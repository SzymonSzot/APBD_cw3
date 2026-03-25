klasy urządzeń oraz użytkowników mają osobne pliki i przechowują podstawowe informacje z nimi związane
klasa Service zarządza dodawaniem/usuwaniem obiektów wszystkich klas oraz oferuje metody do uzyskania szybkich sprawozdań

model nie przewiduje możliwości planowania wypożyczenia przedmiotu - nasze wypożyczenie rozpocznie się zawsze w chwili
zaksięgowania, więc nie ma możliwości wypożyczenia czegoś, co jest teraz niedostępne zaczynając nasze zlecenie później.

użytkownicy dziedziczą po abstrakcyjnej klasie User, dzięki czemu w przypadku gdybyśmy chcieli dodać nowy typ użytkownika
wystarczy że będzie on dziedziczył i nie będzie potrzeby np. dodawać nowych pól do enuma i aktualizować funkcji,
która by na ich podstawie przypisywała limity. Limit jest atrybutem abstrakcyjnym User i każdy nowy typ usera musi go nadpisać

kary za spóźnienia z oddania to const wartość w metodzie Penalty w klasie Renting, którą mnożymy przez różnicę w datach
zwrotu (ustawiona na 20.0)

w pliku Program znajdują się przykładow instancje i metody  