   M S B A M L   `   `   `  ����  ExplorerCalculator#    ExplorerCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	      WindowBrush#���   5   	     � Title$  Elite Explorer Calculator��5   	   $	��350��6+   $	��525��68    � Icon$9 3D:\Users\jay0\Pictures\avatar\explorer_AXa_icon.ico��6D    � 
ResizeMode$ NoResize=�6    � 	Resources 5       �� Color��%-   &	        �� 5   
   $ 	LightGray��6.   5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��108* �6   �� 5      $
��211* �6   .+�5   
   �� -   5         ��Name$ 
CentralImg��5      $
��Left=�6$   $	��100��6?   $��	197,0,0,0q�6L   $	��Top=�6_   $	��100��6w   $9��3D:\Users\jay0\Pictures\avatar\explorer_AXa_icon.ico��6�   6�   �� 5   
   $2��,My jump range is             lightyears (ly)��6   $
��Left=�6G   $��Center=�6b   $��1��6�   $	��Top=�6�   $��24(�6�   $��42��6�   $	��519��6�   �� 5   
   -   5         ��Name$ JumpRangeBox��5      $
��Left=�6(   $��30��6C   $��245,12,0,170q�6O   $��1��6e    �� TextWrapping$
 Wrap=�6r   	 �� TextAlignment$	 Center=�6�   $��30��6�   $��Center=�6�   $��Center=�6�   $��74��6�   $��20(�6�   
 �� 	MaxLength$
 6��6:  �� 5   
   -   5        $ DistanceBox��5      $
��Left=�6'   $��32��6B   $��180,54,0,126q�6N   $��1��6d   $
 Wrap=�6q   $	 Center=�6�   $��25��6�   $��Center=�6�   $��Center=�6�   $��36��6�   $��20(�6�   $
 2��6:  �� 5   
   $��Center=�6   $��I am currently��64   $
��Left=�6M   $��	20,45,0,0q�6h   $��1��6{   $	��Top=�6�   $��24(�6�   $��42��6�   $	��160��6�   �� 5   
   $��from Sagittarius A*.��6   $
��Left=�6/   $��Center=�6J   $��	39,78,0,0q�6n   $��1��6�   $	��Top=�6�   $��24(�6�   $��42��6�   $	��430��6�   �� 5   
   $$��Your optimal plotting range is��6   $
��Left=�69   $��Center=�6T   $��	0,120,0,0q�6x   $��1��6�   $	��Top=�6�   $��20(�6�   $��38��6�   $	��519��6�   �� 5   
   $
��Left=�6   $	��100��62   $	��Top=�6?   $��5��6W   �� 5   
   $
��Left=�6   $��53��6/   $��0,92,0,0q�6;   $	��Top=�6M   $	��519��6e   $��1��6q   �� 5   
   $
��Left=�6   $	��100��6,   $��814,111,-395,0q�69   $��1��6Q   $	��Top=�6^   $	��100��6v   �� 5   
   -   5         ��Name$ PlotRangeLabel��5      $��0.00 ly��6(   $
��Left=�6:   $��Center=�6U   $��	0,145,0,0q�6y   $��1��6�   $	��Top=�6�   $��36(�6�   $��66��6�   $	��519��6�   6�   �� 5   
   $��Center=�6   $��thousand lightyears away��64   $
��Left=�6W   $��
216,45,0,0q�6r   $��1��6�   $	��Top=�6�   $��24(�6�   $��42��6�   $	��281��6�   5      5      