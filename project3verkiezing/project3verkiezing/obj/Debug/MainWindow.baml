   M S B A M L   `   `   `  ����M  Iproject3verkiezing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:project3verkiezingproject3verkiezing  5   	   #    project3verkiezing.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:project3verkiezing     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,   �� 5      $��1* �6   6*   �� 5      $
��10px �6   6,    � ColumnDefinitions 5   
   �� 5      $
��10px �6   6.   �� 5      $��3* �6   6,   �� 5      $��1* �6   6,   �� 5      $��4* �6   6,   �� 5       $��1* �6   6,   �� 5!      $
��10px �6   6.   .+�5#   
   (� $��1��6   $��1��6"   .��5$   
   �� Selecteer om in te zien6-   5%      �� 5'   
   -   5         ��Name$ 	BtnPartij��5'   T   $��1��6   $��3��6!   
���   �
�������.��6   Partij6�   �� 5(   
   -   5        $ BtnThema��5(   T   $��1��6   $��5��6!   
���   �
�������.��6}   Thema6�   �� 5)   
   -   5        $ BtnStandpunt��5)   T   $��1��6   $��7��6!   
���   �
�������.��6�   	Standpunt6�   �� 5*   
   -   5        $ BtnVerkiezingssoort��5*   T   $��1��6   $��9��6!   
���   �
�������.��6�   Verkiezingssoort6�   �� 5+   
   -   5        $ BtnVerkiezingen��5+   U   $��1��6   $��11��6!   
���   �
�������.��6�   Verkiezingen6�   �� 5,   
   -   5        $ BtnVerkiezingsPartijen��5,   U   $��1��6   $��13��6!   
���   �
�������.��6�   VerkiezingsPartijen6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ DGShow��5.      $��1��6#   $��13��60   $��2��6B   $��3��6V   $y�Hidden=�6f      Columns 5/      4  .System.Windows.Controls.DataGridTemplateColumn  50         CellTemplate 51      �� 52      .R�53      �� $��Wijzig��6%   54      56        57       58      �� 59      .R�5:      �� -   5        $��	Verwijder��5:   %   69   5;      5=      5@      �� 5A   
   -	   5         ��Name$ Todelete��5A      $y�Hidden=�6&   6<   5E      5F      