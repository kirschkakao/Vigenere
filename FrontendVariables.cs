using System;
using System.ComponentModel;
using System.Linq;

namespace Vigenere
{
    public class FrontendVariables : INotifyPropertyChanged

    {
        #region Constructors
        public FrontendVariables() : this("Input", "abc", "Encrypt") { }
        public FrontendVariables(string Inputtext, string Key, string Mode)
        {
            sMode = Mode;
            sKey = Key;
            sInputtext = Inputtext;
        }
        #endregion

        #region EventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        #endregion

        #region Properties
        private string _sInputtext = "", _sOutputtext = "", _sKey = "", _sMode = "", _sPhiVec = "";
        private int _iKeyLen = 0, _iPhiLen = 0;
        private double[] _dPhiVec = new double[] { };

        public string iKeyLen
        {
            get => _iKeyLen.ToString();
            set
            {
                _iKeyLen = Algos.FormatNumber(value);
                NotifyPropertyChanged("iKeyLen");
                UpdateKey();
                sMode = "Decrypt";
            }
        }
        public string iPhiLen
        {
            get => _iPhiLen.ToString();
            set
            {
                _iPhiLen = Algos.FormatNumber(value);
                NotifyPropertyChanged("iPhiLen");
                UpdatePhiVec();
            }
        }
        public string sInputtext
        {
            get => _sInputtext;
            set
            {
                _sInputtext = Algos.FormatText(value);
                NotifyPropertyChanged("sInputtext");
                UpdateOutput();
            }
        }
        public string sOutputtext
        {
            get => _sOutputtext;
            set
            {
                _sOutputtext = value;
                NotifyPropertyChanged("sOutputtext");
            }
        }
        public string sKey
        {
            get => _sKey;
            set
            {
                _sKey = Algos.FormatText(value);
                NotifyPropertyChanged("sKey");
                UpdateOutput();
            }
        }
        public string sMode
        {
            get => _sMode;
            set
            {
                _sMode = value;
                NotifyPropertyChanged("sMode");
                UpdateOutput();
            }
        }
        public string sPhiVec
        {
            get => _sPhiVec;
            set
            {
                _sPhiVec = value;
                NotifyPropertyChanged("sPhiVec");
                UpdateOutput();
            }
        }
        #endregion

        #region Methods
        private void UpdateOutput()
        {
            if (sInputtext.Length > 0 && sKey.Length > 0)
            {
                switch (sMode)
                {
                    case "Encrypt": sOutputtext = Algos.Crypt(sInputtext, sKey, "Encrypt"); break;
                    case "Decrypt": sOutputtext = Algos.Crypt(sInputtext, sKey, "Decrypt"); break;
                }
                if(_iPhiLen>0) sOutputtext = Algos.Crypt(sInputtext, sKey, "Decrypt");
            }
        }

        private void UpdatePhiVec()
        {
            _dPhiVec = Algos.CalcPhiVec(sInputtext, _iPhiLen);
            sPhiVec = Algos.FormatArr(_dPhiVec);
            iKeyLen = _dPhiVec.Length>0?(Array.IndexOf(_dPhiVec, _dPhiVec.Max())+1).ToString():"0";
        }

        private void UpdateKey()
        {
            sKey = _iKeyLen==0?"A":Algos.GenerateKey(sInputtext, _iKeyLen);
        }
        #endregion
    }
}
