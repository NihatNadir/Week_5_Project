# Week_5_Project TR || ENG

## Program akışı:
 - Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soruyoruz. Üretmek istiyorsa e, istemiyorsa h harfi ile yanıt veriyor. Büyük - Küçük harf duyarlılığını ortadan kaldırdım. Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltiyor.
 - Kullanıcının cevabı hayır programı sonlandırılıyor, evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcı giriyor.
 - Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanıyor.
 - Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve kullanıcıyı yeniden o satıra yönlendiriyor.
 - Oluşturulan araba nesnesini arabalar isimli bir listeye aktarıyoruz.
 - Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise yeni bir araba üretip listeye ekleniyor. Cevap hayır ise arabalar listesinin bütün elemanlarının bilgileri yazdırılıyor.

   ---

## Program Flow:
- We ask the user via the console if they want to produce a car. If they want to, they respond with 'e', if they don't, they respond with 'h'. I've removed case sensitivity. If an invalid answer is given, it informs the user that the answer is invalid and asks the same question again.
- If the user's answer is 'no', the program terminates; if 'yes', a car object is created, and the user enters its properties via the console.
- The Production Date value is automatically set to the current time when the car is created.
- If a non-numeric value is assigned to the Door Count, the program prevents an exception from being thrown, displays a warning message, and redirects the user back to that input line.
- The created car object is added to a list named cars.
- The program asks the user if they want to create another car; if 'yes', a new car is created and added to the list. If the answer is 'no', the information of all elements in the cars list is printed.
