   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.WindowEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
WindowEdit��5   	   $	��450��6   $	��400��6)   .��5	      � -   5         �Name$
 grid��5	       � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $/��)Редактирование данных��6   $��Center=�60   $��0��5      $��0��6   $��2��6-   �� 5   
   $��	Ф.И.О.��6   $��1��6!   �� 5   
   -   5         ��Name$ textBoxName��5      $��1��5      $��1��6   ��5   '   ��  �� Path$ FullName�5      �� 5   
   $��Возраст��6   $��2��6"   �� 5   
   -   5        $ 
textBoxAge��5      $��2��5      $��1��6   ��5   &   �� $	 Age�5      �� 5   
   $��Оплачено��6   $��3��6#   �� 5   
   -   5        $ textBoxPayment��5      $��3��5       $��1��6   ��5   *   �� $ Payment�5       �� 5!   
   $��Группа��6   $��4��6!   �� 5"   
   -   5        $ textBoxgroup��5"      $��4��5#      $��1��6   ��5"   (   �� $ GroupId�5#      �� 5$   
   -   5        $��OK��5$      $��5��6   $��0��6+   $��25 15q�6;   6J   �� 5%   
   -   5        $��Cancel��5%      $��5��6"   $��1��6/   $��25 15q�6?   6N   5&      5(      