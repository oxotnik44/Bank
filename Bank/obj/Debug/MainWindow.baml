   M S B A M L   `   `   `  ?????  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BankBank  5   	       Bank.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Bank     5   	     ? Title$  
MainWindow??5   	   $	??650??6   $
??1000??6)   $	??650??66   $
??1000??6F    ? WindowStartupLocation$ CenterScreen=?6W   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??60 ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??54* ?6   ?? 5      $	??60* ?6   ?? 5      $??46.305 ?6   ?? 5      $??38.695 ?6   ?? 5      $??42.232 ?6   ?? 5      $??42.768 ?6   ?? 5      $??41.837 ?6   ?? 5      $??43.163 ?6   ?? 5      $??38.989 ?6   ?? 5       $??46.011 ?6   ?? 5!      $??39.82 ?6   ?? 5"      $??45.18 ?6   ?? 5#      $??38.199 ?6   ?? 5$      $??46.801 ?6   ?? 5%      $??43.935 ?6   ?? 5&      $??41.065 ?6   ?? 5'      $??41.087 ?6   ?? 5(      $??43.913 ?6   ?? 5)      $??37.014 ?6   ?? 5*      $??47.986 ?6   ?? 5+      $	??49* ?6   ?? 5,      $	??64* ?6   .+?5.   
   ?? -   5         ??Name$ 	tbl_money??5.      $??15??6'   $??	0,17,59,0q?68   $
??Wrap=?6K   $/??)Деньги в каждый карман??6_   $	??Top=?6}   $??7??6?   $??Italic$?6?   ???	#FF213452$??22(?6?   $??Right=?6?   $	??259??6?   $??27??6	  $??Arial)?6  ?? 50   
   -   5         ??Name$ 	rect_stab??50      $??2??6'   $??2??67   ???	#FFC2C0C0???	#FFDEEBF7$	??280??6h   $	??Top=?6u   $??	0,10,40,0q?6?   $??5??6?   $??6??6?    J? Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52         Color$ 	#FFDFEBF7??6#      	Direction$	 140Q?65   	   ShadowDepth$	 15Q?6E   
   Opacity$	
 0.9Q?6V      
BlurRadius$ 15Q?6e   54      ?? 55   
   -   5        $ tbl_namedstability??55      $??2??60   $??2??6@   $
??Wrap=?6M   $??Стабильный??6a   $??Normal"?6s    ?? TextAlignment$ Center=?6?   $??	26,23,0,0q?6?   $??24(?6?   $??32??6?   $	??Top=?6?   $??5??6?   $
??Left=?6?   $	??170??6  $??Calibri)?6  ?? 56   
   -   5        $ tbl_stability??56      $??2??6+   $??3??6;   $
??Wrap=?6H   $??Normal"?6\   $ Center=?6p   $??16(?6?   $
??Left=?6?   $	??166??6?   $	??156??6?   $	??Top=?6?   $??	30,10,0,0q?6?   $??3??6?   $??5??6  $??Calibri)?6  ?? 6/  $"?Без пополнения ??63  ?? 6L  ?? 6X  $?Без снятия??6\  ?? 6p  ?? 6|  $'?!Без капитализации??6?  ?? 6?  ?? 6?  ?? 6?  ?? 6?  $%?Минимальный срок??6?  ?? 6?  ?? 6?  $?от 3 месяцев??6?  ?? 6?  ?? 6	  ?? 6  ?? 6  ?? 6!  ?? 6-  ?? 63  ?? 6?  ?? 6E  ?? 6Q  6X  ?? 57   
   -   5        $ tbl_stabilityprocent??57      $??2??62   $
??Left=?6B   $??	42,41,0,0q?6]   $??5??6p   $
??Wrap=?6}   $	??Top=?6?   $	??154??6?   $??56??6?   $??2??6?   $??5??6?   ?? 6?   ???	#FF002060$??35(?6  $?8%??6  $
??Bold"?6  ?? 6/  $? ??63  ?? 6>  ???	#FF002060$??22(?6Y  $?годовых??6g  $
??Bold"?6v  6?  ?? 59   
   -   5        $ rect_opt??59      $??8??6'   $??2??67   ???	#FFC2C0C0???	#FFDEEBF7$	??280??6h   $	??Top=?6u   $??	20,10,0,0q?6?   $??5??6?   $??6??6?   $
??Left=?6?   $	??216??6?    5:        5;      $ 	#FFDFEBF7??6#   $	 140Q?65   $	 15Q?6E   $	
 0.9Q?6V   $ 15Q?6e   5=      ?? 5>   
   -   5        $ tbl_namedoptimali??5>      $??9??6/   $??2??6?   $
??Wrap=?6L   $??Оптимальный??6`   $??Normal"?6s   $ Center=?6?   $??3,23,0,0q?6?   $??24(?6?   $??32??6?   $	??Top=?6?   $??5??6?   $
??Left=?6?   $	??172??6  $??Calibri)?6  ?? 5?   
   -   5        $ tbl_optimal??5?      $??8??6)   $??3??69   $
??Wrap=?6F   $??Normal"?6Z   $ Center=?6n   $??16(?6?   $
??Left=?6?   $	??198??6?   $	??156??6?   $	??Top=?6?   $??	38,10,0,0q?6?   $??3??6?   $??6??6  $??Calibri)?6  ?? 6-  $?Пополняемый??61  ?? 6F  ?? 6R  $2?,Есть возможность снятия??6V  ?? 6w  ?? 6?  $%?С капитализацией??6?  ?? 6?  ?? 6?  ?? 6?  ?? 6?  $%?Минимальный срок??6?  ?? 6?  ?? 6?  $?от 6 месяцев??6?  ?? 6  ?? 6  ?? 6  ?? 6!  ?? 6'  ?? 63  ?? 69  ?? 6E  ?? 6K  ?? 6W  6^  ?? 5@   
   -	   5        $ tbl_optimalprocent??5@      $??9??60   $
??Left=?6@   $??7,41,0,0q?6[   $??5??6m   $
??Wrap=?6z   $	??Top=?6?   $	??154??6?   $??56??6?   $??2??6?   $??4??6?   ?? 6?   ???	#FF002060$??35(?6   $?5%??6  $
??Bold"?6  ?? 6,  $? ??60  ?? 6;  ???	#FF002060$??22(?6V  $?годовых??6d  $
??Bold"?6s  6?  ?? 5C   
   -
   5        $ rect_standart??5C      $??14??6+   $??2??6<   ???	#FFC2C0C0???	#FFDEEBF7$	??280??6m   $	??Top=?6z   $??	40,10,0,0q?6?   $??5??6?   $??6??6?    5D        5E      $ 	#FFDFEBF7??6#   $	 140Q?65   $	 15Q?6E   $	
 0.9Q?6V   $ 15Q?6e   5G      ?? 5H   
   -   5        $ tbl_namedstandart??5H      $??15??6/   $??2??6@   $
??Wrap=?6M   $??Стандарт??6a   $??Normal"?6q   $ Center=?6?   $??
18,28,24,0q?6?   $??24(?6?   $??32??6?   $	??Top=?6?   $??5??6?   $??Calibri)?6?    J? RenderTransformOrigin$ 0.703,0.541&?6  ?? 5I   
   -   5        $ tbl_standart1??5I      $??15??6+   $??3??6<   $
??Wrap=?6I   $??Normal"?6]   $ Center=?6q   $??16(?6?   $
??Left=?6?   $	??166??6?   $	??156??6?   $	??Top=?6?   $??	18,10,0,0q?6?   $??3??6?   $??5??6  $??Calibri)?6  ?? 60  $?Пополняемый??64  ?? 6I  ?? 6U  $?Без снятия??6Y  ?? 6m  ?? 6y  $'?!Без капитализации??6}  ?? 6?  ?? 6?  ?? 6?  ?? 6?  $%?Минимальный срок??6?  ?? 6?  ?? 6?  $?от 3 месяцев??6?  ?? 6?  ?? 6  ?? 6  ?? 6  ?? 6  ?? 6*  ?? 60  ?? 6<  ?? 6B  ?? 6N  6U  ?? 5J   
   -   5        $ tbl_standartprocent??5J      $??15??61   $
??Left=?6B   $??	18,41,0,0q?6]   $??5??6p   $
??Wrap=?6}   $	??Top=?6?   $	??154??6?   $??56??6?   $??2??6?   $??5??6?   ?? 6?   ???	#FF002060$??35(?6  $?6%??6  $
??Bold"?6  ?? 6/  $? ??63  ?? 6>  ???	#FF002060$??22(?6Y  $?годовых??6g  $
??Bold"?6v  6?  ?? 5L   
   -   5         ??Name$ bt_dohodcalculation??5L      $??7??6.   $%??Рассчитать доход??6>   $??
23,21,29,0q?6Y   $??7??6m   $	??Top=?6z   ???	#FF2C7DE0
???????$??8??6?   $??39??6?   $??20(?6?   ??6?   Z?  5M        5N      $ 	#FFDEEBF7??6#   5P      5R      5S      