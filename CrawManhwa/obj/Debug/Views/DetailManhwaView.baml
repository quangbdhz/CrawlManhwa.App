   M S B A M L   `   `   `  ����E  ACrawManhwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CrawManhwa.ViewsCrawManhwa.Views  5   	   '    !CrawManhwa.Views.DetailManhwaView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CrawManhwa.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	     � Icon$  /Images/Comic_Icon.ico��5	   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 TrueX�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ DetailManhwaView��5   	   $	��850��6"   $	��810��6/   .��5      � ���#222f3e � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��ScrollLvReadManhwa��5   ,   ���#222f3e$��0 0 0 0q�6F   $
��Auto=�6�   $��1��6�   .��5      �� -   5        $��Lv_ReadManhwa��5   5   $��Center=�6   $��
10 0 10 10q�6J   ��5      �� *LvUrlImageOfOneChapter+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 67   �� 5       � �� 5       �� 5!   "   	 �� 
TargetType"	 ��62   .R�5"   &   �� 
������ $��0q�5$      #��z��5%      ._�5&   *   �� $��Stretch=�6?   #��z��6]   $
��Auto��6�   $��0q�6�   
 �� Content#
 z��6�   5'   '   5(   #   5*      5+       �� View 5-      �� 5.      .P�5/      ��  �� CellTemplate 50      �� 51   "   .R�52   &   �� $	��750��6,   $
��Auto��6c   ��6;   �� *UrlImageChapterComic+6c   53   #   55      56      58      59      #  MaterialDesignThemes.Wpf.Card  5;   
   $��0��6   $��Center=�6,   $	��0 5q�6I   .��5<      � $
��20 4q�6    � ColumnDefinitions 5=      �� 5>      $
��Auto �6'   �� 5?      $
��Auto �6'   �� 5@      $
��Auto �6'   .+�5C      �� -   5        $��cbx_ChooseChapterManhwa��5D      $��Bottom=�5C      $	��100��6�   $
��30 0q�6�   $��1��6�    �� DisplayMemberPath$ NameChapter��5D   ^    �� SelectedItem 5C   6   �� *SelectedItemChapter+ �� SelectedIndex 6c   �� * IndexCurrentChapterInLvChapter+��5D   6   �� *LvChapterManhwa+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5E      +  %Microsoft.Xaml.Behaviors.EventTrigger  5F         	EventName$ DropDownClosed��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5G      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   �� *ChooseChapterManhwaRead+   CommandParameter 5H      ��  �� ElementName$ cbx_ChooseChapterManhwa�� �� Path$ SelectedItem�5I      5K      �� 5M      -   5        $	��100��5M   X   
���   ����#3ae374$	��0 0q�6�   $��0��6�   $��Previous��6�   ��6.   �� *PreviousChapterManhwa+6�   �� 5O      -   5        $	��100��5O   T   
���   ����#EA2027 �� 	IsDefault . $	��0 0q�6�   $��2��6�   $
��Next��6�   ��6.   �� *NextChapterManhwa+6�   5P      5Q      5R      5S      