   M S B A M L   `   `   `  ����D  @LabSheet4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LabSheet4	LabSheet4  5   	       LabSheet4.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LabSheet4     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $
��198* �6   �� 5      $
��326* �6   �� 5      $	��23* �6   �� 5      $	��47* �6   �� 5      $
��198* �6   .+�5   
   �� -   5         ��Name$ lbxStock��5      $��1��6Q   $��10q�6^   �� 5   
   -   5        $ lbxSuppliers��5       �� DisplayMemberPath$ SupplierName��6(    �� SelectedValuePath$ 
SupplierID��6I   $��1��6�   $��1��6�   $��10q�6�   $��3��6�   �� 5   
   -   5        $ lbxCountries��5      $��4��6Y   $��1��6i   $��10q�6v   �� 5   
   -   5        $ lbxProducts��5      $��5��6'   $��3��6;   $��10q�6H   �� 5   
   $��Stock Level��6   $��0��6&   $��0��63   $��64,13q�6C   �� 5    
   $��	Suppliers��6   $��0��6$   $��1��61   $��168,13,98,13q�6A   �� 5!   
   $��country��6   $��0��6"   $��4��6/   $��74,13q�6?   �� 5"   
   $��Products��6   $��2��6#   $��Center=�60   $��1��6M   $��170,13,100,14q�6]   5#      5$      