   M S B A M L   `   `   `  ����  Vikatehtävä    WpfSovellus.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Tehtävälista��5   	   $	��350��6   $	��500��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Kuvaus:��6   $��Center=�6'   �� 5      -   5         ��Name$ DescriptionTextBox��5      $	��150��62   $��5q�6>   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��	Tärkeys:��6   $��Center=�6(   �� 5      -   5         ��Name$ PriorityComboBox��5      $	��150��61   $��5q�6=   .@�5      �� $��
Tavallinen��6   �� 5      $��Tärkeä��6   5      5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5        $��Lisää Tehtävä��5      6-   5      �� 5   
   -   5         ��Name$ TaskListBox��5      $��3��6'   $��10q�64   5      5       