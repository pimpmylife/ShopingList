   M S B A M L   `   `   `  ����M  IShopingListDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ShopingListDesktop.ModelViewShopingListDesktop.ModelView  5   	   #    ShopingListDesktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ShopingListDesktop.ModelView     5   	     � Title$  Listy zakupowe��5	   	   $��368.617��6    $	��525��61    � DataContext 5
      1  +ShopingListDesktop.ModelView.MainWindowView  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6c   $��0,31,0,0q�6~   $	��Top=�6�   $	��232��6�   $	��507��6�      CanUserResizeRows .     CanUserDeleteRows .     CanUserAddRows .     
IsReadOnly . ��6%   �� *Add+ �� SelectedItem 6A   �� *
ShowList+6  �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��36,9,0,0q�6B   $
��Wrap=�6T   $��Listy zakupowe��6h   $	��Top=�6~   �� 5   
   -   5        	 ��Name$	 button��5      $��Stwórz Nową Listę!��6=   $
��Left=�6Z   $��194,287,0,0q�6u   $	��Top=�6�   $	��120��6�   
 J� RenderTransformOrigin$
 0.056,0.101&�6�   ��6!   �� *	AddList+6�   5      5      