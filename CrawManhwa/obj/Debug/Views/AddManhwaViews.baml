   M S B A M L   `   `   `  ����E  ACrawManhwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CrawManhwa.ViewsCrawManhwa.Views  5   	   %    CrawManhwa.Views.AddManhwaViews   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CrawManhwa.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   -   5        $��addManhwaViews��5   	     � Icon$  /Images/Comic_Icon.ico��5	   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel$
 TrueX�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddManhwaViews��5   	   $	��550��6    $	��800��6-   .��5      �� $��
20 10 20 0q�6   .+�5   
   �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Name Comic��6    %  !MaterialDesignFloatingHintTextBox#��[  6?   $��0 10 0 0q�5   [   ��6   �� *
NameManhwa+ �� UpdateSourceTrigger$ PropertyChanged=�6[   �� 5   
   $ Different Name Comic��6   #��[  6I   $��0 10 0 0q�5   c   ��6   �� *DifferentNameComic+$ PropertyChanged=�6c   �� 5   
   $ Url Image Comic��6   #��[  6D   $��0 10 0 0q�5   _   ��6   �� *UrlImageManhwa+$ PropertyChanged=�6_   �� 5   
   $ Description��6   #��[  6@   $��0 10 0 0q�5    \   ��6   �� *Description+$ PropertyChanged=�6\   �� 5"   
   $ Seo Description��6   #��[  6D   $��0 10 0 0q�5#   _   ��6   �� *SeoDescription+$ PropertyChanged=�6_   �� 5%   
   $ 	Seo Title��6   #��[  6>   $��0 10 0 0q�5&   Y   ��6   �� *
SeoTitle+$ PropertyChanged=�6Y   �� 5(   
   $ 	Seo Alias��6   #��[  6>   $��0 10 0 0q�5)   Y   ��6   �� *
SeoAlias+$ PropertyChanged=�6Y   �� 5+   
    �� DisplayMemberPath$ 
NameAuthor��6   $ Author Comic��5,   9    �� 
IsEditable . $��0 10 0 0q�5-   %    & "MaterialDesignFloatingHintComboBox#��[ 67   ��5+   2   �� *	LvAuthors+ �� SelectedItem 6T   �� *SelectedAuthor+	 �� Mode$	 TwoWay=�$ PropertyChanged=�5-   7   �� 5/   
   $ NameCategory��6   $ Category��50   9    . $��0 10 0 0q�51   %   #��[ 67   ��5/   4   �� *LvCategories+ 6Y   �� *SelectedCategory+$	 TwoWay=�$ PropertyChanged=�51   7   �� 53   
   $��Submit��6   $��0 30 0 0q�6�   ��6"   �� *SubmitAddManhwaCommand+��6M   �� 
 �� ElementName$
 addManhwaViews��6�   55      56      