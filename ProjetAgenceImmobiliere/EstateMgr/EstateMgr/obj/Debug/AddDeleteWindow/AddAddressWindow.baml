   M S B A M L   `   `   `  ����D  @EstateMgr, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EstateMgr	EstateMgr  5   	        EstateMgr.AddAddressWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:EstateMgr     5   	     � Title$  AddAddressWindow��5   	   $	��500��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6    $��
Adresse : ��6-   $��25(�6B   6R   �� 5   
   $��1��6   $��0��6"   $��25(�6/   ��6=   �� *CurrentAddress.Adrress+6g   �� 5   
   $��0��6   $��1��6    $��Ville : ��6-   $��25(�6@   6P   �� 5   
   $��1��6   $��1��6"   $��25(�6/   ��6=   �� *CurrentAddress.City+6d   �� 5   
   $��0��6   $��2��6    $��Latitude : ��6-   $��25(�6C   6S   �� 5    
   $��1��6   $��2��6"   $��25(�6/   ��6=   �� *CurrentAddress.Latitude+6h   �� 5"   
   $��0��6   $��3��6    $��Longitude : ��6-   $��25(�6D   6T   �� 5#   
   $��1��6   $��3��6"   $��25(�6/   ��6=   �� *CurrentAddress.Longitude+6i   �� 5%   
   $��0��6   $��4��6    $��Code postal : ��6-   $��25(�6F   6V   �� 5&   
   $��1��6   $��4��6"   $��25(�6/   ��6=   �� *CurrentAddress.ZipCode+6g   �� 5(   
   $��0��6   $��6��6!   $��Valider��6.   $��25(�6@   $��2��6N   ��6b   �� *	OKCommand+��6�   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ WindowL�6�   5)      5*      