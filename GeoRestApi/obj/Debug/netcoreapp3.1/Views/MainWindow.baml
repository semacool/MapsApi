   M S B A M L   `   `   `  ����E  AGeoRestApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GeoRestApi
GeoRestApi  5   	       GeoRestApi.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GeoRestApi     5   	     � Title$  	SearchMap��5   	   $	��450��6   $	��800��6(    � 	Resources 5	       �� 
TargetType   TextBoxStyle �� Property �� Value  TextBlockStyle  StackPanelStyle  ButtonStyle��%�  &	        &	 Q     &	 �     &	     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  �@��TextAlignment$ Center=�6.   6?   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   6C   5      �� 5   
   " ��6   .�5      ��  � ��$ 30q�6'   64   �� 5       � ��$ 0q�60   6<   �� 5       � ��$ 15(�6)   66   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5!   
   �� 5"      $��1* �6   �� 5#      $��2* �6   .+�5&   
   �� $��Address��6   $��0��6$   .��5'      �� #��[  6   ��6<   �� *	Address+6W   5(      �� 5*   
   $��	Threshold��6   $��1��6&   .��5+      �� #��[ 6    �� Orientation$ Vertical=�6B   .+�5,      ��  � Maximum$ 1Q�64   	 � SmallChange$	 0.001Q�6@   
 �� TickFrequency$
 0Q�6T    � Value 6   �� *
Polygons+6T   �� 5-      #��[ 6   ��6D   �� *
Polygons+5.      5/      �� 51   
   $��Limit��6   $��2��6"   .��52      �� #��[ 6   $ Vertical=�6B   .+�53      �� $	 1Q�61   $ 50Q�6A    � Minimum$ 1Q�6N    6   �� *Limit+6N   �� 54      #��[ 6   ��6E   �� *Limit+55      56      �� 58   
   #��[ 6   $��3��59      $��Search��5:      ��5;      �� *ClickSearch+�� 5=   
   $��Objects��6   $��3��6$   $��1��65   .��5>      �� ��6   �� *	Answers+��5?      �� 5@      .R�5A      �� ��6$   �� *Title+5B      5D      5E      �� 5G   
   #��[ 6   $��3��5H      $��1��5I      $
��Save��5J      ��5K      �� *	ClickSave+5L      5M      