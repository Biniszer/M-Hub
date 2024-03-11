# M-Hub
## Założenia projektu
W planach jest napisanie aplikacji desktopowej która będzie klientem messengera i instagrama. Rozmowy w przyszłości mają być tłumaczone na określony język, a użytkownik będzie się logował za pomocą swojego konta na facebook.

## Część 1 - Logowanie
Podczas logowania będzie pytanie czy użytkownik loguje sięza pomocą swojego konta facebook. W założeniou użytkownik taki powinien posiadać swoje konto deweloperskie i ma możliwośc wygenerowania tokena. Celem tej części jest generowanie tokena potrzebnego do komunikacji.

### Plan części pierwszej
1. Stworzyć front do logowania i poglądową zawartość (na początek równie dobrze może być po prostu napis "Zalogowałeś się :D")
2. Stworzyć logikę odpowiadającą za proces logowania, na ten moment tylko dla  messnegera (sprawdzeni czy działa)
3. Stworzyć stronę na platformie Meta którą mogę autoryzować pobieranie konwersacji. 
### Problemy
1. Stworzenie aplikacji z tokenem api który posiada odpowiednie uprawnienia
2. Dzisiejsze problemy z platformą Meta (05.03.2024)


## Część 2 - Zawartość
Po zalogowaniu dostaniemy okno w którym po lewej stronie będziemy mieli listę konwersacji z podziałem na platformę której dotyczy dana rozmowa oraz wewnątrz platformy czy konwersacje są grupowe (oddzielna podzakładka - do przemyślenia).
Po prawej stronie będziemy mieli zawartość zaznaczonej konwersacji, domyślnie brak zaznaczenia. Wewnątrz tej sekcji trzeba umieścić również galerię multimediów (do przemyślenia czy jako oddzielna zakładka czy podzakładka konwersacji) oraz tłumaczenie wiadomości.(do konfiguracji czy chcemy przetłumaczyć wiadomość czy całą załadowaną konwersacje, czy listę konwersacji)
(Na koniec, jeśli starczy czasu)
Możliwość pobierania próbki głosu w celu przeczytania konwersacji przez uczestników (domyślnie zapewne Ivona ale do przemyślenia)

## Plan części drugiej
1. Poglądowo stworzyć Napis "Zalogowałeś się *imię i nazwisko użytkownika*", ewentualnie nazwa strony w późniejszych etapach rozbudowa do zakładek podanych w części.
1.1 W przypadku zalogowania jako strona wyświetlić odpowiedni komunikat.
2. tworzenie logiki odpowiadajązej za funkcjonalności aplikacji zawarte w opisie (długi punkt, do rozbudowy)
3. Rozplanować układ konwersacji i ułożenie funkcjonalności 
