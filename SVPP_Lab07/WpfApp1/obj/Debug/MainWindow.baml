   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      6!   .+�5   
   �� $��0��6   .+�5      �� -   5        $��50��5      $
��5,10q�6"   .��6I   Просмотр6S   �� 5      -   5        $��50��5      $
��5,10q�6"   .��6K   Вставить6U   �� 5      -   5        $��50��5      $
��5,10q�6"   .��6I   
Найти6P   �� 5      -   5        $��50��5      $
��5,10q�6"   .��6K   Обновить6U   �� 5      -   5        $��50��5      $
��5,10q�6"   .��6K   Удалить6T   5      �� 5   
   -   5         ��Name$ stackpanelPerson��5      $��1��6/   
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��200��6   $
��5,10q�6$   .��62   Имя67   �� 5      -   5         ��Name$ textBoxName��5      $	��200��6/   $
��5,10q�6;   ��6I   ��  �� Path$
 Name�6f   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��200��6   $
��5,10q�6$   .��62   
Сумма69   �� 5      -   5        $ 
textBoxSum��5      $	��200��6.   $
��5,10q�6:   ��6H   �� $	 Sum�6d   5      �� 5      -	   5         ��Name$ listBox��5      $	��400��6'   
���������6K   �� 6e   5      5!      5"      