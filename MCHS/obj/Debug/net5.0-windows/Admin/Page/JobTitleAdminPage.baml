   M S B A M L   `   `   `  ����?  ;MCHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MCHS.Admin.PageMCHS.Admin.Page  5      '    !MCHS.Admin.Page.JobTitleAdminPage   5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MCHS.Admin.Page     5        N� Title$  JobTitleAdminPage��5
      $	��450��6!   $	��800��6.   .��5      �  � RowDefinitions 5   
   �� 5      $	��280 �6   �� 5      $
��170* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��
20 10 20 0q�6   $��0��62   $	��400��6?   .��5      (  "HandyControl.Controls.ScrollViewer  $
��Auto=�6   $
��Auto=�6C      IsInertiaEnabled$
 True��6f   .��5      �� -   5         ��Name$ 
LVJobtitle��5      ��5      ��  �� RelativeSource ��  �� AncestorType Page �� Path$ JobTitle� �� View 5      �� 5      .P�5      ��  �� Width$	 200��5   !   $��ID��5   !   	 �� DisplayMemberBinding	 5   !   �� *ID+5   !   �� 5      $��Имя��5   !   	 5   !   �� *Name+5   !   5      5       5!      5"      �� 5#   
   $��1��6   .��5$   
     $��
20 0 20 20q�6   $��Center=�63   $��80��6P   .��5%      � .+�5&      �� .+�5'      �� -   5        
 ��Name$
 TB_ID��5*      ${�False��5(      $��	10 5 10 0q�5+      $��60��5,      $	��100��5-      $��18(�5.      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID��5/      $��2q�50         MaterialDesignDivider#���   51       ! MaterialDesignOutlinedTextBox#��[ 52      ��5)      ��  �� ElementName$ 
LVJobtitle��$ SelectedItem.ID�52      54      �� 55      .+�56      �� -   5        $
 TB_Name��58      $��0 5 10 0q�59      $��60��5:      $	��180��5;      $��18(�5<      $ Должность��5=      $��2q�5>      #���   5?      #��[ 5@      ��57      �� $ 
LVJobtitle��$ SelectedItem.Name�5@      5B      � 5C      $��0 10 0 0q�6   .+�5D      �� -   5         ! MaterialDesignFlatMidBgButton#��[ 5F      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5G      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5H      
������� � ToolTip$+ %Сохранить должность��5J      .��5L      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�62   5M      �� 5N      -   5        $�� 3 0 0 0q�5P      #��[ 5Q      $ Depth0=�5R      $ 10��5S      
�������$) #Обновить должность��5U      .��5W        $ Update=�62   5X      �� 5Y      -   5        $�� 3 0 0 0q�5[      #��[ 5\      
���<��$ Depth0=�5^      $ 10��5_      
�������$' !Удалить должность��5a      .��5c        $ Delete=�62   5d      5e      5f      5g      5h      5i      5j      