   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.WindowPerson   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  WindowPerson��5   	   $	��400��6   $	��450��6+   $��18(�67   .��5	      � -   5         �Name$
 grid��5	      
���z��� � ColumnDefinitions 5
   
   �� 5      �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��ID��6   $��15q�6   �� 5   
   $
��Name��6   $��15q�6   $��1��6+   �� 5   
   $	��Age��6   $��15q�6   $��2��6*   �� 5   
   $��Company��6   $��15q�6"   $��3��6.   �� 5   
   $��Salary��6   $��15q�6!   $��4��6-   �� 5   
   -   5         ��Name$ 	textBoxID��5      $��15q�6%   $��0��61   $��1��6>   ��6N   ��  �� Path$ ID��� 5   
   -   5        $ textBoxName��5      $��15q�6'   $��1��63   $��1��6@   ��6P   �� $
 Name��� 5   
   -   5        $ 
textBoxAge��5      $��15q�6&   $��2��62   $��1��6?   ��6O   �� $	 Age��� 5   
   -   5        $ textBoxCompany��5      $��15q�6*   $��3��66   $��1��6C   ��6S   �� $ Company��� 5   
   -   5        $ textBoxSalary��5      $��15q�6)   $��4��65   $��1��6B   ��6R   �� $ Salary��� 5    
   -   5         ��Name$ buttonCancel��5       $��Cancel��6'   $��15q�68   $��5��6D   6Q   �� 5!   
   -   5        $ buttonOk��5!      $��OK��6#   $��15q�60   $��5��6<   $��1��6I   6Y   5#      5$      