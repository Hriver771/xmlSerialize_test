   M S B A M L   `   `   `  ����H  DDataManage_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataManage_v1DataManage_v1  5   	       DataManage_v1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DataManage_v1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $
��Auto��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$
 read��5      $��0��6"   $	��het��6/   �� 5   
   -   5         ��Name$
 list��5      $��1��6!    �� View 5      �� 5       �� AllowsColumnReorder . .P�5      �� $��	ShapeType��6%    �� DisplayMemberBinding 68   ��  �� Path$ 	ShapeType��� 5      $
��Type��6%    63   �� $
 Type��� 5      $��	Transform��6%    �� CellTemplate 5      �� 5      .R�5   "   �� 	 �� Orientation$	 
Horizontal=�6-   $��0q�6F   .+�5   &   �� $��0q�6V   $��0q�6b   ��6,   �� $ Transform.Height�6p   �� 5   &   $��0q�6U   $��0q�6a   ��6,   �� $ Transform.Width�6o   �� 5   &   $��0q�6X   $��0q�6d   ��6,   �� $ Transform.ShowRoof�6r   �� 5   &   $��0q�6]   $��0q�6i   ��6,   �� $ Transform.ExtendedPoint�6v   5   #   5      5       5@      5B      5C      5D      