   M S B A M L   `   `   `  ����E  ACrawManhwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CrawManhwa.ViewsCrawManhwa.Views  5   	   &     CrawManhwa.Views.UserManagerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CrawManhwa.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	     � Icon$  /Images/Comic_Icon.ico��5	   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 TrueX�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ User Manager��5   	   $	��700��6   $
��1305��6+   .��5      � ���#2d3436 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��5 5 5 0q�6.   
���   �.��5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$
 Dark=�6'      CornerRadius$ 2��63   
����� � K� ZIndex$ 1��6W   $��0q�6h   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6s   .��5      � 	 � ColumnDefinitions	 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5       $
��Auto �6+   .+�5#      �� {�. $��0��6.      MaterialDesignToolButton#���   6>   .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  
�������
   Kind$
 Magnify=�6E    J� Opacity$	 .99Q�6T   5%      �� 5'      -   5        $��tb_user��5*      $��1��5(      $��8 0 0 0q�6.   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search the user��6?   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5)      $��0q�5*   -   $	��200��6A   $��Center=�6P   ��5'      �� *DisplayNameSearchUser+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5*   P   � 5,      $��2��6   .+�5-      �� -   5        $��OptionSearch��5-   Z    �� SelectedIndex$ 0��6#   $��8 4 5 0q�65   $��0q�6F   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Inverted=�5.   #   $ Hidden=�6S     MaterialDesignPaper   UnderlineBrush# �  5/   #   #���  50   #   .@�51      �� .��6+   	User Name66   �� 52      .��6+   Email62   �� 53      .��6+   Active User68   �� 54      .��6+   Confirm Mail69   55      56      57      58      59        5;   
   $��1��6   $��5q�6+   .��5<      �� -   5        $$��ScrollLvFullUrlImageOneChapter��5<      $
��Auto=�6u   $
��Auto=�6�   .��5=      �� -   5        $��Lv_AppUsers��5=      ��6.   �� *
LvAppUsers+��5>      �� 5?       �� 
TargetType" ��6    .�5@      ��  �� Property � �� �� Value$ Center=�6B   5A       �� View 5C      �� 5D      ! �� ColumnHeaderContainerStyle 5E      �� 5F   "   " ��6(   .�5G   &   ��  � �� 5H   *   �� 5I   .    �� 
TargetType" ��6>   .R�5J   2   �� $��0,0,0,0q�69   
���   �
������ ._�5K   6   ��  ��Name$ ContentHeader��6@   #��z��6W    �� Padding$ 5,5,5,0q�6x   #��z��6�    �� TextAlignment$ Center=�6�   5L   3   5M   /   5O   '   �� 5P   &    �@�OverridesDefaultStyle . 6N   �� 5Q   &    � ��
 �   �6C   �� 5R   &    � ��$ DemiBold"�6C   �� 5S   &    � ��$ Segoe UI)�6C   �� 5T   &    � ��$ 14(�6A   5U   #   .P�5Y      �� $��UserName��6-    �� DisplayMemberBinding 6?   �� *
UserName+�� 5Z      $��	FirstName��6-    6@   �� *	FirstName+�� 5[      $��LastName��6-    6?   �� *
LastName+�� 5\      $��Email��6-    6<   �� *Email+�� 5]      $��PhoneNumber��6-    6B   �� *PhoneNumber+�� 5^      $	��Dob��6-    6:   �� *Dob+ �� StringFormat$ 
dd/MM/yyyy���� 5`      $��Confirm Mail��6-    �� CellTemplate 5a   "   �� 5b   &   .R�5c   *   �� $��Center=�64   ��5d   -   �� *EmailConfirmed+ ' #foregroundEmailConfirmUserConverter �� 	Converter# [ ��5e   -   �� *EmailConfirmed+  emailConfirmedUserConverter# [ 5f   '   5h      �� 5j      $��Active��6-    5k   "   �� 5l   &   .R�5m   *   �� $
��20 0q�61   
����� �$��0q�6�   #���   6�   ��6?   ��   �� ElementName$  Lv_AppUsers��! �� Path$)! #DataContext.LockOrUnlockUserComamnd���6�   �� .��5n   .     $��20��6F   $��20��6Q   $	 .99Q�5o   �   ��5n   ]   �� *
IsActive+ # foregroundIsActiveUserConverter# [ 
 5o   F   �� *
IsActive+  isActiveUserConverter# [ 6�   5p   +   5q   '   5s      �� 5u      $��Photo��6-    5v   "   �� 5w   &   .R�5x   *   �� " �� BitmapScalingMode$
" Fant=�60   $	��100��6X   $	��100��6d   ��6q   �� $! UrlImageUser�5y   '   5{      5}      5      5�      5�      5�      5�      