   M S B A M L   `   `   `  ����_  [PRN221PE_FA22_TrialTest_NgoQuangMinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:PRN221PE_FA22_TrialTest_NgoQuangMinh$PRN221PE_FA22_TrialTest_NgoQuangMinh  5   	   ;    5PRN221PE_FA22_TrialTest_NgoQuangMinh.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:PRN221PE_FA22_TrialTest_NgoQuangMinh     5   	   -   5          � Title$  JobPostingWindow��5   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�5	   	   .��5
      � $��	225,0,0,0q�6   .+�5   
   � $��
-108,0,0,0q�6   ��5      �� 5       �� 
StartPoint$
 0, 0&�6&    �� EndPoint$
 1, 1&�68   .��5      �  � Color$ #0099FF��6#    � Offset$ 0Q�63   � 5      $ 	#FF347BDA��6#   $ 0.794Q�65   � 5      $ 	#FF60B1E7��6#   $ 1Q�65   � 5      $ 	#FF596FDD��6#   $ 0.309Q�65   � 5      $ 	#FF472FDE��6#   $ 0.484Q�65   5       � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��30 �6    �� 5      $��10 �6    �� 5      $��30 �6    �� 5      $��10 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      �� 5"       � ColumnDefinitions 5%      �� 5&      $��119.415 �6#   �� 5'      $��30.585 �6#   �� 5(      $	��47* �6#   �� 5)      $
��513* �6#   .+�5,      �� $��JOB MANAGEMENT��6   $
��Left=�6-   $��65��6H   $	��Top=�6T   $	��432��6l   $��Center=�6x   $
��Bold"�6�   $��36(�6�   $��2��6�   $��	34,12,0,0q�6�   $��2��6�   �� 5-      $��	PostingID��6   $
��Left=�6(   $��30��6C   $��31,0,0,0q�6O   $��Center=�6a   $	��146��6|   $��Center=�6�   $��3��6�   $��1��6�   �� 5.      $��JobPostingTitle��6   $
��Left=�6.   $��30��6I   $��	23,21,0,0q�6U   $	��Top=�6h   $	��146��6�   $��Center=�6�   $��3��6�   $��2��6�   $��2��6�   �� 5/      $��Description��6   $
��Left=�6*   $��30��6E   $��
197,73,0,0q�6Q   $	��Top=�6e   $	��146��6}   $��Center=�6�   $��3��6�   $��2��6�   �� 50      $��
PostedDate��6   $��Center=�6)   $��28��6F   $	��Top=�6R   $	��146��6j    J� RenderTransformOrigin$ 0.365,0.189&�6v   $��3��6�   $��0,37,0,0q�6�   $��Center=�6�   $��3��6�   $��2��6�   �� 51      -   5        	 ��Name$	 txtPostingID��51      $
��Left=�6,   $��28��6G   
 �� TextWrapping$

 Wrap=�6S   $�� ��6g   $��Center=�6o   $	��225��6�   $��1��6�   $��1��6�   $��3��6�   $��24,0,0,0q�6�   �� 52      -   5        $	 txtJobPostingTitle��52      $
��Left=�62   $��30��6M   $

 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��225��6�   $��1��6�   $��2��6�   $��3��6�   $��	23,18,0,0q�6�   $��2��6�   �� 53      -   5        $	 txtDescription��53      $
��Left=�6.   $	��115��6I   $

 Wrap=�6V   $�� ��6j   $��Center=�6r   $	��248��6�   $��3��6�   $��2��6�   $��	210,0,0,0q�6�   $��4��6�   (  "System.Windows.Controls.DatePicker  54      -   5          Name$ 
PostedDate��54      $��1��6-   $
��Left=�6=   $��30��6X   $��3��6d   $	��Top=�6q   $	��224��6�   $��3��6�   $��	24,39,0,0q�6�   $��2��6�   &   System.Windows.Controls.DataGrid  55      -   5          Name$ 	cmbPostID��55      $��4��6*   $
��Left=�6>   $	��141��6Y   $��	39,11,0,0q�6f   $��2��6y   $��8��6�   $	��Top=�6�   $	��616��6�   6�   �� 56      -   5         ��Name$ BtnAdd��56      $	��Add��6%   $
��Left=�63   $��33��6N   $��	31,58,0,0q�6Z   $	��Top=�6m   $	��124��6�   ���	#FF58D743$��3��6�   $��9��6�   �� 57      -   5        $ 	BtnUpdate��57      $��Update��6(   $
��Left=�69   $��33��6T   $��3,58,0,0q�6`   $	��Top=�6r   $	��131��6�   ���	#FF00F7FF$��3��6�   $��9��6�   �� 58      -	   5        $ 	BtnDelete��58      $��Delete��6(   $
��Left=�69   $��33��6T   $��
169,58,0,0q�6`   $	��Top=�6t   $	��127��6�   ���	#FFE5C251$��3��6�   $��9��6�   �� 59      -
   5        $ 	Btn_Close��59      $��Close��6(   $
��Left=�68   $��33��6S   $��
318,58,0,0q�6_   $	��Top=�6s   $	��135��6�   ���	#FFCEC30E$��3��6�   $��9��6�   >   8PRN221PE_FA22_TrialTest_NgoQuangMinh.SidebarHeaderWindow  5:      -   5          Name$ headerWindowControl��5?      $
��Left=�5;      $	��Top=�5<      $��
-117,0,0,0q�5=      $	��124��5>      $	��434��5@      $��10��6   5A      5B      5C      