   M S B A M L   `   `   `  ����M  IShopingListDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ShopingListDesktop.ModelViewShopingListDesktop.ModelView  5   	   %    ShopingListDesktop.View.ListAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:ShopingListDesktop.ModelView     5   	     � Title$  ListAdd��5   	   $	��300��6   $	��300��6&    � DataContext 5	      .   (ShopingListDesktop.ModelView.ListAddView  5
   
   .��5      � .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��	98,35,0,0q�6B   $
��Wrap=�6U   $��Nazwa nowej listy:��6i   $	��Top=�6�   $	��124��6�   �� 5   
   -   5         ��Name$ nameList��5      $
��Left=�6K   $��23��6f   $��	98,85,0,0q�6r    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6$   �� *
NameList+ �� Mode$ TwoWay=�6�   �� 5   
   -   5         ��Name$ button��5      $��Dodaj!��6B   $
��Left=�6S   $��116,150,0,0q�6n   $	��Top=�6�   $��75��6�   ��6!   �� *CloseCommand+6�   5      5      