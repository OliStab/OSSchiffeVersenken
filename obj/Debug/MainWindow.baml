   M S B A M L   `   `   `  ����K  GSchiffeVersenken, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SchiffeVersenkenSchiffeVersenken  5   	   !    SchiffeVersenken.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SchiffeVersenken     5   	     � Title$  Schiffe versenken��5   	   $	��330��6#   $	��530��60   .��5	      � .+�5
   
   �� -   5        $��BTNPvC��5
      $��Player vs CPU��6   $��50��67   $��
0,110,10,0q�6C   $	��Top=�6W   $��Right=�6o   $	��150��6�   6�   �� 5   
   -   5        $��BTNCvC��5      $��
CPU vs CPU��6   $��50��64   $��
0,170,10,0q�6@   $	��Top=�6T   $��Right=�6l   $	��150��6�   6�   �� 5   
   -   5        $��TXTFieldSize��5      $
��Left=�6'   $��25��6B   $��	80,50,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��TXTCarrierSize��5      $
��Left=�6(   $��25��6C   $��
80,115,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $��TXTCarrierCount��5      $
��Left=�6)   $��25��6D   $��210,115,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��TXTBattleshipSize��5      $
��Left=�6+   $��25��6F   $��
80,150,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $��TXTBattleshipCount��5      $
��Left=�6,   $��25��6G   $��210,150,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $��TXTCruiserSize��5      $
��Left=�6(   $��25��6C   $��
80,185,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -	   5        $��TXTCruiserCount��5      $
��Left=�6)   $��25��6D   $��210,185,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -
   5        $��TXTSubmarineSize��5      $
��Left=�6*   $��25��6E   $��
80,220,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��TXTSubmarineCount��5      $
��Left=�6+   $��25��6F   $��210,220,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��TXTDestroyerSize��5      $
��Left=�6*   $��25��6E   $��
80,255,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��TXTDestroyerCount��5      $
��Left=�6+   $��25��6F   $��210,255,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��LBLFieldSize��5      $��
Field Size��6$   $
��Left=�69   $��	80,20,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $��LBLShipSize��5      $��	Ship Size��6#   $
��Left=�67   $��	80,85,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $��LBLShipCount��5      $��
Ship Count��6$   $
��Left=�69   $��
210,85,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $��
LBLCarrier��5      $��Carrier��6"   $
��Left=�64   $��
10,115,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $��LBLBattleship��5      $��
Battleship��6%   $
��Left=�6:   $��
10,150,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $��
LBLCruiser��5      $��Cruiser��6"   $
��Left=�64   $��
10,185,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $��LBLSubmarine��5      $��	Submarine��6$   $
��Left=�68   $��
10,220,0,0q�6S   $	��Top=�6g   �� 5   
   -   5        $��LBLDestroyer��5      $��	Destroyer��6$   $
��Left=�68   $��
10,255,0,0q�6S   $	��Top=�6g   5      5       