   M S B A M L   `   `   `  ����   Vigenere    Vigenere.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Vigenere��$	��485��$	��500�����	#FF001E4B � 	Resources  
  LabelW �� Property �� Value��%�   &	        �� .���  � ��$ 0,0,0,0q���  � ��$ 0����  � ��$ 12(���  � ��
 �������  � ��$ Center=�.���� ���	#FF001E4B��Z�   �� 
TargetType �� 
TargetType ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName��%.  '��       �� " ��.���  � �� �� " ��.R�� $��Panel��.+��� $ ContentSite��$��Center=�$��Center=�$��Header��$
��10,2q� P�  �@��
IsSelected	 . . ��� $
 Panel�� � �� �	#FF60626CP�  �@��
IsSelected	 .  . ��� $
 Panel�� � �� �	#FF001E4B.@��� $��
De/Encrypt��
���������Z� .���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0�����	#FF60626C$��10���� $��1��.+��� $��10,0,0,0q�$��Input��#��[  �� -   $��TextBox_TextInput��$
��10,0q�$	��150��$��12(� �� TextWrapping$
 Wrap=�� $��2�� � ColumnDefinitions �� �� $��2* �.+��� $��0��.+��� $
��Mode��#��[  $��10,0,0,0q��� -   $��ComboBox_KryptDirection�� �� 
IsEditable .  �� 
IsReadOnly .  �� SelectedIndex$ 0��$��	10,0,10,0q�$��12(�$��Center=�.@��� $��Encrypt���� $��Decrypt���� $��1��.+��� $	��Key��#��[  $��10,0,0,0q��� -   $��TextBox_Key��$��	10,0,10,0q�$��14(�$��Center=��� $��3��.+��� $��10,0,0,0q�$��Output��#��[  �� -   $��TextBox_TextOutput��$
��10,0q�$	��150��$��12(�$
 Wrap=��� $��Krypt Analyzer��
���������Z� .���  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0�����	#FF60626C$��10���� $��1��$��
Phi-Vector��#��[  $��10,0,0,0q�$
��Bold"��� $��2�����	#FF8F8F8F$��1��$��	10,0,10,0q�� $��3�� �� �� $��4* �.+��� $��0��.+��� $��Length��#��[  $��10,0,0,0q��� -   $��TextBox_Phi_Length��$��	10,0,10,0q�$��14(�$��Center=��� $��1��.+��� $��Output��#��[  $��10,0,0,0q��� -   $��TextBox_Phi_Vector��$��	10,0,10,0q�$��14(�$��Center=��� $��4�����	#FF8F8F8F$��1��$��
10,10,10,0q��� $��5��$	��Key��#��[  $��	10,10,0,0q�$
��Bold"��� $��6�����	#FF8F8F8F$��1��$��	10,0,10,0q�� $��7�� �� �� $��4* �.+��� $��0��.+��� $��Length��#��[  $��10,0,0,0q��� -   $��TextBox_Key_Length��$��	10,0,10,0q�$��14(�$��Center=��� $��1��.+��� $��Output��#��[  $��10,0,0,0q��� -   $��TextBox_Key_Derived��$��	10,0,10,0q�$��14(�$��Center=��� $��8�����	#FF8F8F8F$��1��$��
10,10,10,0q��� $��9��$��Bottom=�.+��� $��	10,15,0,0q�$��Decrypted Text��#��[  �� -	   $��TextBox_TextDecrypt��$
��10,0q�$	��170��$��12(�$
 Wrap=�