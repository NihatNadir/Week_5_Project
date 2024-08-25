# Week_5_Project TR || ENG

## Program akışı:
 - Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soruyoruz. Üretmek istiyorsa e, istemiyorsa h harfi ile yanıt veriyor. Büyük - Küçük harf duyarlılığını ortadan kaldırdım. Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltiyor.
 - Kullanıcının cevabı hayır programı sonlandırılıyor, evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcı giriyor.
 - Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanıyor.
 - Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve kullanıcıyı yeniden o satıra yönlendiriyor.
 - Oluşturulan araba nesnesini arabalar isimli bir listeye aktarıyoruz.
 - Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise yeni bir araba üretip listeye ekleniyor. Cevap hayır ise arabalar listesinin bütün elemanlarının bilgileri yazdırılıyor.

### Kullanılan yöntem,blok ve metotlar 
- List<Car>: Car nesnelerinin saklandığı dinamik bir listedir. Bu listeye program boyunca birden fazla Car nesnesi eklenebilir.
- string.ToLower(): Girilen metni küçük harflere dönüştürerek büyük-küçük harf duyarlılığını ortadan kaldırır.
- try-catch Bloğu: Potansiyel bir hatayı (exception) yakalamak ve yönetmek için kullanılır. Burada, kapı sayısı için sayısal bir değer girilmezse, hata yakalanır ve kullanıcı tekrar giriş yapmaya yönlendirilir.
- goto: Programın belirli bir noktasına gitmek için kullanılır. Bu kodda, kullanıcı hatalı giriş yaptığında belirli bir noktaya geri döndürmek için kullanılmıştır.
- foreach: Koleksiyonlar veya diziler üzerinde yineleme yapmak için kullanılır. Burada, cars listesi içinde bulunan her Car nesnesinin bilgilerini ekrana yazdırmak için kullanılmıştır.
- isValid: Programın ana döngüsünün çalışmaya devam edip etmeyeceğini kontrol eden bir bayrak (flag) değişkenidir. true olduğu sürece döngü devam eder, false olduğunda döngü sonlanır ve program çıkar.
- null-coalescing Operatörü (??): Bir değer null ise, belirli bir varsayılan değeri döndürmek için kullanılır. Örneğin, Console.ReadLine() ?? "" ifadesi, Console.ReadLine() null döndürürse boş bir string döndürür.
- car.InfoCar Yöntemi : Car sınıfı içinde tanımlanmış olmalıdır ve bir Car nesnesinin tüm özelliklerini (üretim tarihi, seri numarası, marka, model, renk, kapı sayısı) ekrana yazdırır.
- break Deyimi : Döngüden çıkmak için kullanılır. Kullanıcı 'h' tuşuna bastığında foreach döngüsü tamamlandıktan sonra break ile programdan çıkılır.

   ---

## Program Flow:
- We ask the user via the console if they want to produce a car. If they want to, they respond with 'e', if they don't, they respond with 'h'. I've removed case sensitivity. If an invalid answer is given, it informs the user that the answer is invalid and asks the same question again.
- If the user's answer is 'no', the program terminates; if 'yes', a car object is created, and the user enters its properties via the console.
- The Production Date value is automatically set to the current time when the car is created.
- If a non-numeric value is assigned to the Door Count, the program prevents an exception from being thrown, displays a warning message, and redirects the user back to that input line.
- The created car object is added to a list named cars.
- The program asks the user if they want to create another car; if 'yes', a new car is created and added to the list. If the answer is 'no', the information of all elements in the cars list is printed.

### Methods, Blocks, and Constructs Used
- List<Car>: A dynamic list that stores Car objects. Multiple Car objects can be added to this list throughout the program.
- string.ToLower(): Converts the input text to lowercase, eliminating case sensitivity.
- try-catch Block: Used to catch and handle potential errors (exceptions). Here, it is used to catch an error if a non-numeric value is entered for the door count, prompting the user to re-enter the value.
- goto: Directs the program flow to a specific point. In this code, it is used to return to a specific point if the user makes an incorrect input.
- foreach: Used to iterate over collections or arrays. In this case, it is used to print the information of each Car object in the cars list to the console.
- isValid: A flag variable that controls whether the main loop of the program continues to run. The loop continues as long as it is true, and the program exits when it is false.
- null-coalescing Operator (??): Returns a default value if the input is null. For example, Console.ReadLine() ?? "" returns an empty string if Console.ReadLine() returns null.
- car.InfoCar Method: Should be defined within the Car class and is responsible for printing all the properties of a Car object (production date, serial number, brand, model, color, door count) to the console.
- break Statement: Used to exit a loop. When the user presses 'h', the program exits after the foreach loop completes by using break.



