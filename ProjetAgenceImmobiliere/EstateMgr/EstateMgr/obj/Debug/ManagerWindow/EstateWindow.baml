   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      H DEstateMgrCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR9clr-namespace:EstateMgrCore.Models;assembly=EstateMgrCoreEstateMgrCore.Models 5      D @EstateMgr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EstateMgr.ConvertersEstateMgr.Converters 5         EstateMgr.EstateWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      Kmodel9clr-namespace:EstateMgrCore.Models;assembly=EstateMgrCore     5      4local"clr-namespace:EstateMgr.Converters     5        N� Title$  EstateWindow��5       � 	Resources 5      =  7EstateMgr.Converters.Base64StringToBitmapImageConverter &  "Base64StringToBitmapImageConverter 	 Titre �� 
TargetType �� Property �� Value  Description  
typeEstate S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName��%p  &	        &	      &	     &	 �      5   
   63   �� 5   
   " ��6   .�5      ��  � ��$
 None=�6-   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0,0,5,0q�6'   �� 5       �@��TextAlignment$ Right=�6.   �� 5       � ��
 �����6+   5      �� 5   
   " ��6$   .�5      ��  � ��$
 None=�6-   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0,0,5,0q�6'   �� 5       � �� �	#FF004CFF6+   5      S� 5   
   $ 	GetValues��5      "  5        5!      M� 5"      $ model:Estate+typeEstate��6   5$      5%      .��5'      � 	 � RowDefinitions	 5(   
   �� 5)      $��85 �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   
 � ColumnDefinitions
 5.   
   �� 5/      $	��220 �6   �� 50      $��* �6   .+�53   
   �� $��0��6   $��4��6   ��60   �� *	Estates+ �� SelectedItem 6P   �� *SelectedEstate+��54      �� 55      .R�56      ��  �� Orientation$ Vertical=�6!   .+�57      �� $��
itemBorder��6G   
���   �
�������$	��275��6Y   ._�58      �� $ 
Horizontal=�6)   .+�5:   "   �� $��Type :��6,   #��[ 6:   �� 5;   "   
���������6,   �� *Type+6B   5=      5>      5?      5@      5B      �� 5D   
   $��1��6   $��0��6#   $��10,23,716,32.8q�60    5E      �� *
TypeEstate+��5F      ��  �� Source# [ �� 5G   
   $��1��6   $��0��6#   $��182,23,544,32.8q�60   �� 5H   
   $��1��6   $��0��6#   $��353,23,373,32.8q�60   �� 5I   
   $��1��6   $��0��6#   $��526,23,200,32.8q�60   �� 5J   
   $��1��6   $��0��6#   $��698,23,28,32.8q�60   � 5L   
   $��1��6   $��1��6   $��3��6,   	 5M      �� 5N      $��* �6    �� 5O      $��* �6    �� 5P      $��* �6    �� 5Q      $��* �6    
 5S      �� 5T      $��* �6#   �� 5U      $��* �6#   .+�5X      �� $��2��6   ��6%   �� *CurrentPicture.Base64+ �� 	Converter# [  �� 5Z      $��1��6   $��1��6)   $ Vertical=�66   $��36,0.4,0,0.2q�6M   .+�5[      �� $��Commentaire :��6   #��[ 61   �� 5\      $
��Bold"�6L   ��6   �� * CurrentTransaction.Description+6L   5]      �� 5_      $��1��6   $ 
Horizontal=�6)   $��36,0,0,133.2q�6B   $��2��6X   .+�5`      �� $��Surface (m²) : ��6   #��[ 63   �� 5a      $
��Bold"�6D   ��6   �� *SelectedEstate.Surface+6D   5b      �� 5d      $��1��6   $��1��6)   $ 
Horizontal=�66   $��36,133.4,0,133.2q�6O   $��3��6i   .+�5e      �� $��Nombre de pièces : ��6   #��[ 67   �� 5f      $
��Bold"�6G   ��6   �� *SelectedEstate.RoomsCount+6G   5g      �� 5i      $��1��6   $��3��6)   $ 
Horizontal=�66   $��36,0.4,0,0.2q�6O   .+�5j      �� $��Nombre d'étages : ��6   #��[ 66   �� 5k      $
��Bold"�6H   ��6   �� *SelectedEstate.FloorsCount+6H   5l      5n      5o      5p      