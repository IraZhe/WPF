   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%T   '��       �� 5
   
   " ��6   .�5      ��  � ��$
 5,10q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dGrid��5      $��1��6"      
IsReadOnly .    RowHeaderWidth$ 50Q�5      	   AutoGenerateColumns	 .  ��5   2   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *
FullName+   	CellStyle 5      �� 5      .�5      ��  �@��TextAlignment$ Right=�6H   5      5        5      $ Возраст��6%    66   �� *Age+  5      $ Оплачено��6%    67   �� *	Payment+  5      $ Номер группы��6%    6;   �� *	GroupId+5!      �� 5"   
   -   5         ��Name$ stackButtons��5"      .+�5#      �� -   5         ��Name$ btnAdd��5#      .��6:   Add student5%      �� 5&      -   5        $ 	btnDelete��5&      .��6@   Delete student5(      �� 5)      -   5        $ btnEdit��5)      .��6<   Edit student5+      5,      5-      5/      