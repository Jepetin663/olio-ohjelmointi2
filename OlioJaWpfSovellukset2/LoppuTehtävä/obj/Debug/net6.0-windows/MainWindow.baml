   M S B A M L   `   `   `  ����  LoppuTehtävä    LoppuTehtävä.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Yhteystietosovellus��5   	   $	��350��6%   $	��500��62   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Nimi:��6   $��Center=�6%   �� 5      -   5         ��Name$ NimiTextBox��5      $	��150��6+   $��5q�67   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Ikä:��6   $��Center=�6$   �� 5      -   5        $ 
IkaTextBox��5      $��50��6*   $��5q�65   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Opiskelijanumero:��6   $��Center=�61   �� 5      -   5        $ OpiskelijaNumeroTextBox��5      $	��150��67   $��5q�6C   5      �� 5   
   $��3��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5        $��Lisää henkilö��5      6-   �� 5      -   5        $��Tallenna tiedosto��5      $��10,0,0,0q�6V   5       �� 5"   
   -   5         ��Name$ HenkiloListBox��5"      $��4��6*   $��10q�67   5#      5$      