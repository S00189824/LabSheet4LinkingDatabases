   M S B A M L   `   `   `  ����G  CLabSheet4Ex2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LabSheet4Ex2LabSheet4Ex2  5   	       LabSheet4Ex2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:LabSheet4Ex2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $	��32* �6   �� 5      $
��273* �6   �� 5      $	��91* �6   �� 5      $
��271* �6   �� 5      $
��125* �6   .+�5   
   �� -   5        $��lbxCustomers��5   +   $��1��6   $��10q�6   $��3��6?   6S   �� 5   
   -   5        $��	lbxOrders��5   ;   $��1��6   $��3��6   $��10q�6/   $��2��6L    �� SelectedValuePath$ SalesOrderID��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgOrderDetails��5   4   $��3��6   $��
10,10,0,10q�6    $��5��6J   $
��Left=�6^   $	��772��6y   �� 5    
   $��	Customers��6   $��131,13,72,13q�6$   $��1��6:   �� 5!   
   $��Order Summary��6   $��3��6(   $��148,13,23.412,13q�68   �� 5"   
   $��Order Details��6   $��2��6(   $��2��65   $��2��6I   $��49,13,229.412,14q�6Y   5#      5$      