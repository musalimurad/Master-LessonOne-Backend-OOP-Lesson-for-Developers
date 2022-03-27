

int numOne = 10;
int numTwo = 20;
numOne = numTwo;
numTwo = 40;

//Console.WriteLine(numOne);? cavabi nedir?
//Console.WriteLine(numTwo);? cavbi nedir?

int[] numArrOne = new[] { 50, 60, 70 };
int[] numArrTwo = new[] { 80, 90, 100 };

numArrOne = numArrTwo;
numArrTwo[0] = 110;

//Console.WriteLine(numArrOne[0]); Cavabi nedir?


//Data Types = int, decimal, double, bigInt, bool, enum , short, byte, long, struct, char, float 

// Reference Types = class, interface, array, string, object, pointer, delegate

//Iki cur yaddas var "Ramda olan mentiqi quruluslardir" Stack ve Heap yaddas


// Data types ancaq Stack yaddasda saxlanilir

//Reference types 
/*
 * Stack ile Heap arasinda baglanti yaranir. Data-lar Heap-de saxlanilir. yeni hem Stack-den hem de Heap-den istifade etmis olunur  
 */

//Test Branch

/*
 * Stack ile Heap arasindaki ferq:
 Heap-de melumatlar qarisiq bir sekilde saxlanilir . basqa bir ferqi ise Heap-de melumatlar Garbage Collector alqoritmine bagli sekilde isleyir yeni lazimsiz melumatlari veya deyisilmis bir melumati garbage collector gelir silir.

 Stack-de ise ardicil sekilde saxlanilir (melumatlar boyukden kiciye dogru siralanaraq isleyir). Stack-da ise aninda silinir

Stack yaddasdan melumat getirmek Heap yaddasdan daha suretlidir. cunki Heap yaddas dinamik Ram strukturunu istifade edir. Yeni Heap yaddas RunTime-dir yeni ancaq isleme zamani aninda istifade olunur. Stack yaddasa baglanti qurmaq Heap yaddasa
baglanti qurmaqdan daha suretli olur. buna gore de Heap yaddas daha yavas isleyir Stack yaddasa baxanda 

ehtiyyaciniz olacag yaddas hecmini deqiq bilirsinizse Stack yaddasi istifade etmek daha yaxsidi eger ne qeder yaddasin lazim olacagini deqiq bilmirsizse Heap yaddasi istifade etmek daha dogru olar
 */

