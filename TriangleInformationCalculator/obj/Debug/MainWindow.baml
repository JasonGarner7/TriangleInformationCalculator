   M S B A M L   `   `   `  ����X  TTriangleInformationCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TriangleInformationCalculatorTriangleInformationCalculator  5   	   .    (TriangleInformationCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TriangleInformationCalculator     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$% Triangle Information Calculator��5	   	   $��539.6��61   $��313.6��6@   .��5
      � .+�5   
   �� $��Courier New)�5      $��30(�5      $��DemiBold"�5      
�����F�$
��Left=�5       �� TextAlignment$ Center=�5      $��65��5      $��	50,13,0,0q�5      $
��Wrap=�5      $��Triangle Information��5      $	��Top=�5      $	��210��6%   �� 5   
   
����İ� �� CornerRadius$ 10��5      $
��Left=�5      $��76��5      $��	10,90,0,0q�5      $	��Top=�5      $	��275��5      ._�5      �� $��Side A length:��5       $��14(�5!      $��9.2,24.2,99.8,20.2q�5"      5#      �� 5$   
   -   5         ��Name$ SideA��5$      $��0q�5&      $
��Left=�5(      $��23��5)      $��135,121,0,0q�5*       �� TextWrapping$
 Wrap=�5+      $�� ��5,      $	��Top=�5-      $	��125��5.      �� 5/   
   
����İ�$ 10��51      $
��Left=�52      $��76��53      $��
10,180,0,0q�54      $	��Top=�55      $	��275��56      ._�57      �� $��Side B length:��58      $��14(�59      $��9.2,24.2,99.8,20.2q�5:       J� RenderTransformOrigin$ 0.502,0.507&�5;      5<      �� 5=   
   -   5        $ SideB��5=      $��0q�5?      $
��Left=�5A      $��23��5B      $��135,210,0,0q�5C      $
 Wrap=�5D      $�� ��5E      $	��Top=�5F      $	��125��5G      �� 5H   
   
����İ�$ 10��5J      $
��Left=�5K      $��76��5L      $��
10,270,0,0q�5M      $	��Top=�5N      $	��275��5O      ._�5P      �� $��Side C length:��5Q      $��14(�5R      $��9.2,25.2,99.8,19.2q�5S      5T      �� 5U   
   -   5        $ SideC��5U      $��0q�5W      $
��Left=�5Y      $��23��5Z      $��135,304,0,0q�5[      $
 Wrap=�5\      $�� ��5]      $	��Top=�5^      $	��125��5_      �� 5`   
   -   5         ��Name$ Result��5`      $��Courier New)�5a      $��13(�5b      $��DemiBold"�5c      $
��Left=�5d      $ Center=�5e      $��
10,360,0,0q�5f      $
��Wrap=�5g      $$��Results will be displayed here��5h      $	��Top=�5i      $��37��5j      $	��275��5k       �� LineStackingStrategy$ BlockLineHeight=�5l      	 �� 
LineHeight$	 20��5m      �� 5n   
   -   5        $ AngleResult��5n      $��Courier New)�5o      $��14(�5p      $��DemiBold"�5q      
�����F�$
��Left=�5s      $ Center=�5t      $��
10,418,0,0q�5u      $
��Wrap=�5v      $�� ��5w      $	��Top=�5x      $��71��5y      $	��275��5z      $ BlockLineHeight=�5{      $	 20��5|      5}      5~      