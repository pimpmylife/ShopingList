   M S B A M L   `   `   `  ����M  IShopingListDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ShopingListDesktop.ModelViewShopingListDesktop.ModelView  5   	   )    #ShopingListDesktop.View.ShopingList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ShopingListDesktop.ModelView     5   	     � Title$  ShopingList��5   	   $��469.042��6   $	��300��6.   .��5
      � $��0,0,0,4q�6    � RowDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6�   $��30,60,0,148q�6�   $	��252��6�      CanUserResizeRows .     CanUserDeleteRows .     CanUserAddRows .     
IsReadOnly . ��6%   �� *
Products+ �� SelectedIndex 6F   �� *SelectedProduct+ �� SelectedItem 6p   �� *SelectedItemProduct+6%  �� 5   
   -   5        	 ��Name$	 button��5      $��Dodaj produkt��6@   $
��Left=�6X   $��
26,351,0,0q�6s   $	��Top=�6�   $	��119��6�   $��22��6�   ��6!   �� *
NewProduct+6�   �� 5   
   -   5        $	 button1��5      $��Usuń produkt��6D   $
��Left=�6[   $��
26,391,0,0q�6v   $	��Top=�6�   $	��119��6�   $��22��6�   ��6"   �� *DeleteProduct+6�   �� 5   
   -   5        $	 button2��5      $��Edytuj produkt��6B   $
��Left=�6\   $��166,351,0,0q�6w   $	��Top=�6�   $	��112��6�   $��22��6�   ��6"   �� *EditProduct+6�   �� 5   
   -   5        $	 button3��5      $��
Usun Liste��6A   $
��Left=�6V   $��166,391,0,0q�6q   $	��Top=�6�   $��75��6�   $��22��6�   ��6"   �� *
DeleteList+6�   �� 5   
   -   5        
 ��Name$
 	textBlock��5      $
��Left=�6'   $��	98,10,0,0q�6B   $
��Wrap=�6U   $	��Top=�6   $	��118��6�   $��16��6�   ��6i   �� *Name+6�   5      5      