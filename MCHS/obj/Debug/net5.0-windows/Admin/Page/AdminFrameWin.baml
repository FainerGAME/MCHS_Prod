   M S B A M L   `   `   `  ����?  ;MCHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MCHS.Admin.PageMCHS.Admin.Page  5   	   #    MCHS.Admin.Page.AdminFrameWin   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /localclr-namespace:MCHS.Admin.Page     5   	      MaterialDesignBody#���   5	   	     � WindowStyle$
  None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AdminFrameWin��5   	   $	��510��6   $	��800��6,   .��5      � .+�5      �  � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��* �6   6)   �� 5      $��50 �6   6*   .+�5   
   � $��0��6   $��Right=�6!   .+�5      �� $��Админ панель��6   $��14(�6*   $
��Bold"�68   5       � 5   
   -   5          �Name$ MyFrame��5      $��1��5        � NavigationUIVisibility$ Hidden=�5        � Source$ ProfileAdminPage.xaml?�5      5      #  MaterialDesignThemes.Wpf.Card  5   
   $��2��6   $��3 0 5 3q�6+   
��� ���$��Center=�6P      UniformCornerRadius$ 15Q�6m   .��5       � .+�5!      �� $��
10 0 10 0 q�6   .+�5"      �� -   5         ��Name$ Profile_Btn��5#      
������ $��0q�5&      
�������.��5)      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Account=�6.   $��24��5*   .   $��24��5+   .   $��Center=�5,   .   5-      �� 5.      $
��Bold"�5/      
�������$��Center=�51      $��Пофиль��52      53      �� 54      $��
10 0 10 0 q�6   .+�55      �� -   5        $ JobTitle_Btn��56      
������ $��0q�59      .��5;        $	 	Briefcase=�6.   $��24��5<   .   
�������$��24��5>   .   $��Center=�5?   .   5@      �� 5A      $
��Bold"�5B      
�������$��Center=�5D      $��Должность��5E      5F      �� 5G      $��
10 0 10 0 q�6   .+�5H      �� -   5        $ Rank_Btn��5I      
������ $��0q�5L      .��5N        $	 ChevronTripleUp=�6.   $��24��5O   .   
�������$��24��5Q   .   $��Center=�5R   .   5S      �� 5T      $
��Bold"�5U      
�������$��Center=�5W      $��Звание��5X      5Y      �� 5Z      $��
10 0 10 0 q�6   .+�5[      �� -   5        $ 	Close_btn��5\      
������ $��0q�5_      .��5a        $	 	ExitToApp=�6.   $��24��5b   .   
�������$��24��5d   .   $��Center=�5e   .   5f      �� 5g      $
��Bold"�5h      
�������$��Center=�5j      $��
Выход��5k      5l      5m      5n      5o      5p      5q      