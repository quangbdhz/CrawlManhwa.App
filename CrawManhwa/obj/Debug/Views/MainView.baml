   M S B A M L   `   `   `  ����E  ACrawManhwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CrawManhwa.ViewsCrawManhwa.Views  5   	       CrawManhwa.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CrawManhwa.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	     � Icon$  /Images/Comic_Icon.ico��5	   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 TrueX�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$
 Home��5   	   $	��700��6   $
��1305��6#   .��5      � ���#2d3436 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0,5,0,5q�6"   .+�5      #  MaterialDesignThemes.Wpf.Card  $	��5 0q�6"   .��5      � $	��0 3q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $
��Auto �6+   �� 5       $
��Auto �6+   �� 5!      $
��Auto �6+   .+�5$      �� $��0��6   $��10 0 0 0q�6-   $��0q�6?   $��90��6r   
���   ����#00d8d6
���   �$��Users��6�   ��6K   �� *UserManagerCommand+6�   �� 5&      $��1��6   $��20 0 0 0q�6-   $��0q�6?   $��90��6p   $��	Add Comic��6{   
���   ����#0be881
���   ���6K   �� *AddManhwaCommand+6�   �� 5(      $��2��6   $��20 0 0 0q�6-   $��0q�6?   $��90��6j   $��Right=�6u   ���#ffdd59
���   �
���   �$��
Read Comic��6�   ��6K   �� *
ReadManhwa+6�   �� 5*      $��3��6   $��20 0 0 0q�6-   $��0q�6?   $��90��6�   $��Right=�6�   ���#FDA7DF
���   �
���   �$��Cate/Author��6�   ��6K   �� *$"CategoriesAndAuthorsManagerCommand+6�   5,      5-        5/      $��5 5 5 0q�6"   .��50      � $	��0 3q�6    51      �� 52      $
��Auto �6+   �� 53      $
��Auto �6+   �� 54      $
��Auto �6+   �� 55      $
��Auto �6+   �� 56      $��* �6+   .+�59      �� -   5        $��checkedCrawlUrlChapter��59   �   $��10 0 0 0q�5:   F   $��Crawl Url Chapter��6X   $��0��6t    $   MaterialDesignFilterChipCheckBox#��[  6�   ��59      �� *CheckedCrawlUrlChapterCommand+��6Q   ��  �� ElementName$ checkedCrawlUrlChapter�� d� 	IsChecked 5:      �� *CheckedCrawlUrlChapter+6�   �� 5<      -   5        $��checkedCrawChapter��5<   �   $��20 0 0 0q�5=   C   $��Crawl Chapter��6U   $��1��6m   #��[  6}   ��5<      �� *CheckedCrawlChapterCommand+��6N   �� $ checkedCrawChapter�� 5=      �� *CheckedCrawlChapter+6}   �� 5?      $
��20 0q�6    $��2��6.   $��Center=�6>   $��13(�6Y   $��Italic$�6g   $
��Bold"�6z   $��Url In Line��6�   �� 5A      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ 	Collapsed=�6   $��0q�6^   $��0 0 0 3q�6r   $��13(�6�   $��3��5B      $��0 0 0 5q�6D   $��Bottom=�6U   $��Center=�6p   ��6)   �� *	UrlInLine+6p   �� 5D      $ 	Collapsed=�6   $��0q�6^   $
��Auto��6r   $��14(�6   
�������$��Center=�5E      $��Center=�6@   $��4��5F      $
��10 0q�6.   $��Right=�6=   $
��Bold"�6Y   ���#5758BB$��0 0 30 5q�6�   $��Bottom=�6�   ��6�   �� *ErrorUrlMaxLength+6�   5H      5I        5L      $��5 5 5 0q�6"   .��5M      �� .+�5N      � $	��0 5q�6   y�6(   �� *%#VisibilityControlCrawlChapterManhwa+ 5O      �� 5P      $
��Auto �6/   �� 5Q      $��* �6/   .+�5T      �� $��0��6$   $��Center=�64   $��15(�6O   $
��Bold"�6]   $��10 0 0 0q�6p   $��Url Detail Chapter ��6�   � 5V      $��1��6    5W      �� 5X   "   $
��Auto �60   �� 5Y   "   $
��Auto �60   .+�5\      � $��0��6#    5]   "   �� 5^   &   $
��Auto �67   �� 5_   &   $
��Auto �67   �� 5`   &   $
��Auto �67   �� 5a   &   $
��Auto �67   �� 5b   &   $
��Auto �67   .+�5e   "   �� $��0��6*   $��	20,0,20,0q�6:   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Start Chapter��6N    % !MaterialDesignFloatingHintTextBox#��[ 6}   $��Center=�5f   G   ��6%   �� *StartChapterCraw+6G   �� 5h   "   $��1��6*   $��0,0,20,0q�6:   $	 End Chapter��6L   #��[ 6y   $��Center=�5i   E   ��6%   �� *EndChapterCraw+6E   �� 5k   "   $��2��6*   $	 Start Url Chapter��6;   #��[ 6o   $��0,0,20,0q�5l   k   $��Center=�6}   ��6%   �� *StartUrlWebsite+
 �� UpdateSourceTrigger$
 PropertyChanged=�6}   �� 5n   "   $��3��6*   $	 End Url Chapter��6;   #��[ 6m   $��5,0,20,0q�5o   i   $��Center=�6{   ��6%   �� *EndUrlWebsite+$
 PropertyChanged=�6{   �� 5q   "   $��4��6*   $	 Add Zero��6;   #��[ 6f   $��0,0,3,0q�5r   t   $��Center=�6�   ��6%   �� *AddZeroStartChapterCrawl+$
 PropertyChanged=�6�   5s      � 5u      $��1��6#   $��0 10 0 0q�60    5v   "   �� 5w   &   $
��Auto �67   �� 5x   &   $
��Auto �67   �� 5y   &   $
��Auto �67   �� 5z   &   $
��Auto �67   �� 5{   &   $
��Auto �67   .+�5~   "   �� $��0��6*   $	 Attribute Tag��6;   #��[ 6k   $��	20,0,20,0q�5   h   $��Center=�6|   ��6%   �� *AttributeTag+$
 PropertyChanged=�6|   �� 5�   "   $��2��6*   $	 End Char Attribute��6;   #��[ 6p   $��0,0,20,0q�5�   l   ��6%   �� *EndCharAttribute+$
 PropertyChanged=�6l   �� 5�   "   $��3��6*   $	 Url Duplicate��6:   #��[ 6j   $��Center=�5�   %   $��Center=�6I   ��6k   �� *UrlDuplicate+$
 PropertyChanged=��� 5�   "   $��4��6)   $��	20,2,20,3q�69   $��Submit��6z   ��6L   �� *DeleteUrlDuplicateCommand+6z   5�      5�      5�      � 5�      $��0 5 0 5q�6   y�6,   �� *(&VisibilityControlCrawlUrlChapterManhwa+ 5�      �� 5�      $
��Auto �6/   �� 5�      $��* �6/   �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   .+�5�      �� $��0��6$   $��Center=�64   $��15(�6O   $
��Bold"�6]   $��10 0 0 0q�6p   $��
Url Comic ��6�   � 5�      $��1��6    5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      � $��0��6#    5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� $��20 0 0 0q�6*   $��0��6<   $	 
Url Manhwa��6M   #��[ 6z   $	��250��5�   n    �� TextWrapping$
 Wrap=�6}   ��6%   �� *UrlCrawlFullManhwa+$
 PropertyChanged=�6}   �� 5�   "   $��20 0 0 0q�6*   $��1��6<   $	 IndexOf Url Manhwa��6M   #��[ 6�   $	��250��5�   i   $
 Wrap=�6x   ��6%   �� *NameUrlManhwa+$
 PropertyChanged=�6x   �� 5�   "   $��20 0 0 0q�6*   $��2��6<   $	 Url Web Upload��6M   #��[ 6~   $	��150��5�   m   $
 Wrap=�6|   ��6%   �� *UrlWebUploadImage+$
 PropertyChanged=�6|   �� 5�   "   $��3��6*   $	 Attribute Tag��6;   #��[ 6k   $��Center=�5�   %   $��Center=�6I   $��	20 0 20 0q�6�   ��6k   �� *AttributeTag+$
 PropertyChanged=�6�   �� 5�   "   $��4��6*   $	 End Char Attribute��6;   #��[ 6p   $��Center=�5�   %   $��Center=�6I   $��0 0 20 0q�6�   ��6k   �� *EndCharAttribute+$
 PropertyChanged=�6�   5�      � 5�      $��1��6#   $��0 10 0 0q�60    5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� -   5        $��SortListChapterCrawl��5�   %   $��Bottom=�5�   +   $��0��6F    �� SelectedIndex$ 1��6V   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�6h     MaterialDesignBody   UnderlineBrush# �  6�   $��	20 0 20 0q�5�   A   #���  6T   .@�5�   &   �� $��	Ascending��63   �� 5�   &   $��Decrease��63   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5�   &   +  %Microsoft.Xaml.Behaviors.EventTrigger  5�   *      	EventName$ DropDownClosed��69   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�   .   2	  ,Microsoft.Xaml.Behaviors.InvokeCommandAction	   	  Command 6D   �� *+)SelectedOptionSortListChapterCrawlCommand+ 	  CommandParameter 5�   <   �� $ SortListChapterCrawl��5�   +   5�   #   �� 5�   "   -   5        $��AddProtocolToUrl��5�   %   $��Bottom=�5�   +   $��1��6F   $ 0��6V   $
 Dark=�6h   # �  6�   $��0 0 20 0q�5�   =   #���  6O   .@�5�   &   �� $��Normal��63   �� 5�   &   $��https:��63   �� 5�   &   $��http:��63    5�   &     5�   *   $ DropDownClosed��69   . 5�   .   	   6D   �� *!SelectedAddProtocolToUrlCommand+ 5�   <   �� $ AddProtocolToUrl��5�   +   5�   #   5�      5�      �� 5�      $ Hidden=�6"   $��0q�6_   $��0q�6s   $��Center=�5�      $��2��68   $	 Delete Id Chapter��6I   #��[ 6|   $��Center=�5�      $��Center=�6A   $��0 0 20 0q�6�   ��6c   �� *IdChapterDuplicate+$
 PropertyChanged=�6�   �� 5�      $	��100��6!   $��0q�6-   
���   �
���   ����#C4E538$��0 0 20 0q�5�   O   $��3��6a   $��Delete��6q   ��6   �� *DeleteChapterDuplicateCommand+6q   5�      5�      5�        5�      $��5 5 5 0q�6"   .��5�      � $	��0 3q�6    5�      �� 5�      $
��Auto �6+   �� 5�      .+�5�      �� -   5        $	��130��5�      $��1q�6)   $��0��6=    �� 	IsDefault . $��	10 0 0 0 q�6^   ���#1dd1a1$
��Bold"�6�   
���   �$��Submit Crawl��5�      
���   ���60   �� *SubmitUrlWebsite+6V   � 5�      $��1��6    5�      �� 5�      $
��Auto �6/   �� 5�      $
��Auto �6/   �� 5�      $��* �6/   .+�5�      �� $	��130��6!   $��1q�6-   $��0��6A    . $��20 0 q�6b   ���#ff3838$
��Bold"�6�   
���   �$��Save Comic Crawl��5�      $��0q�6f   
���   ���68   �� *SaveDataToDatabaseCommand+6r   �� 5     -   5        $ ��cbx_ChooseManhwaAddChapter��5  �   $	 
Name Comic��5  #   $��0 0 0 8q�6O   $��0q�5  #    �� 
IsEditable . $��Center=�6I   $��Center=�6m   $��Bottom=�6�   $��50��6�   $��1��6�   $ 	Collapsed=�5  #   $��13(�6c    �� DisplayMemberPath$ 	NameComic��5  H   $��0 0 20 0q�6�   ��6#   �� *LvNameManhwa+ �� SelectedItem 6f   �� *SelectedItemManhwa+$
 PropertyChanged=� 5       5  "   $ DropDownClosed��61   . 5  &   	   6<   �� *ChooseManhwaAddChapterCommand+ 5     �� $  cbx_ChooseManhwaAddChapter��5	  #   5     �� 5     $��Center=�6$   $��13(�6?   
���  ��$��2��6�   ��6M   �� *SelectedItemManhwa.NameComic+6�   5     5     5     5     � 5  
   $��1��6    5     �� 5     $��* �6    �� 5     $
��Auto �6    .+�5     � $��0��6    5     �� 5     $��* �6'   �� 5     $
��Auto �6'   .+�5       $��0��6&   $��5 0 0 5 q�66   .��5      �� -   5        $$��ScrollLvFullUrlImageOneChapter��5   $   $
��Auto=�6}   $
��Auto=�6�   .��5!     �� -   5        $��Lv_FullUrlImageOneChapter��5!  #   ��6D   �� *LvFullUrlImageOneChapter+ �� View 5"     �� 5#  "   .P�5$  &   �� $��Serial��65    �� DisplayMemberBinding 6E   �� *Id+�� 5%  &   $��Length��65    �� CellTemplate 5&  *   �� 5'  .   .R�5(  2   �� ��6<   �� *Length+��6T   �� *Length+  errorMaxLenghtUrlConverter �� 	Converter# [ 5)  /   5+  '   �� 5,  &   $	��Url��65    6B   �� *FullUrlImage+5-  #   5/     50     51       53     $	��280��6&   $��1��62   $��5 0 5 5q�6B   .��54     �  55     �� 56     $
��Auto �6,   �� 57     $��* �6,   .+�5:     � $��0��6   $	��0 2q�6,    5;     �� 5<  "   $��* �63   �� 5=  "   $
��Auto �63   .+�5@     �� $	��5 0q�6&   $��0 8 0 0q�63   $��0��5A  &   $	 Replace Name Chapter��6Z   ��66   �� *ReplaceNameChapter+6Z   �� 5C     $
��10 0q�6%   $	��100��63   
���   ����#ED4C67
���   �$��1��5D  S   $��Replace��6c   ��6%   �� *ReplaceNameChapterCommand+6c   5E     �� 5G     -	   5        $��ScrollListChapter��5G  4   $��1��6'   $
��Auto=�6�   $
��Auto=�6�   .��5H     �� -
   5        $��
Lv_Chapter��5H  '   ��69   �� *LvChapterCrawl+ 5I  "   �� 5J  &   .P�5K  *   �� $
��Name��69    6G   �� *NameChapter+�� 5L  *   $��Serial��69    6I   �� *	ComicId+5M  '   5O     5P     5Q     5R     5S     5T     5U     5V     