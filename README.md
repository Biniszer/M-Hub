# M-Hub
## Założenia projektu
W planach jest napisanie aplikacji desktopowej która będzie klientem messengera i instagrama. Rozmowy w przyszłości mają być tłumaczone na określony język, a użytkownik będzie się logował za pomocą swojego konta na facebook.
Możliwa funkcjonalność w przyszłości to pobranie próbki głosu i czytanie konwersacji głosem uczestników.

## Część 1 - Logowanie
Podczas logowania będzie pytanie czy użytkownik loguje sięza pomocą swojego konta facebook. W założeniou użytkownik taki powinien posiadać swoje konto deweloperskie i ma możliwośc wygenerowania tokena. Celem tej części jest generowanie tokena potrzebnego do komunikacji.

### Plan części pierwszej
1. Stworzyć front do logowania i poglądową zawartość (na początek równie dobrze może być po prostu napis "Zalogowałeś się :D")
2. Stworzyć logikę odpowiadającą za proces logowania, na ten moment tylko dla  messnegera (sprawdzeni czy działa)
3. Stworzyć stronę na platformie Meta którą mogę autoryzować pobieranie konwersacji. 
4. Przetestować logowanie.
5. Zalogować się na inne konto.
## Problemy
1. Stworzenie aplikacji z tokenem api który posiada odpowiednie uprawnienia
2. Sprawdzić czy potrzeba fanpage żeby wygenerowac token z odpowiednimi uprawnieniami
  a) Sprawdzić czy po zalogowaniu jako fanpage wiadomości wyświetlają się poprawnie
  b) wysłać wiadomość tekstową 
  c) wysłać obraz
  d) wysłać link
  e) wysłać rolkę 


## Część 2 - Zawartość
Po zalogowaniu dostaniemy okno w którym po lewej stronie będziemy mieli listę konwersacji z podziałem na platformę której dotyczy dana rozmowa oraz wewnątrz platformy czy konwersacje są grupowe (oddzielna podzakładka - do przemyślenia).
Po prawej stronie będziemy mieli zawartość zaznaczonej konwersacji, domyślnie brak zaznaczenia. Wewnątrz tej sekcji trzeba umieścić również galerię multimediów (do przemyślenia czy jako oddzielna zakładka czy podzakładka konwersacji) oraz tłumaczenie wiadomości.(do konfiguracji czy chcemy przetłumaczyć wiadomość czy całą załadowaną konwersacje, czy listę konwersacji).
(Na koniec, jeśli starczy czasu)
Możliwość pobierania próbki głosu w celu przeczytania konwersacji przez uczestników (domyślnie zapewne Ivona ale do przemyślenia lub opcja zablokowana do momentu pobrania próbki głosu).

## Plan części drugiej
1. Poglądowo stworzyć Napis "Zalogowałeś się *imię i nazwisko użytkownika*", ewentualnie nazwa strony w późniejszych etapach rozbudowa do zakładek podanych w części.
a) W przypadku zalogowania jako strona wyświetlić odpowiedni komunikat.
b) zaimplementować autoryzację za pomocą OAuth 2.0 dla messengera, Instagrama i whatsapp
c) domyślne logowanie będzie do messengera, każde inne jest opcjonalne, ewentualnie otwieramy okno aplikacji i mamy na każdej liście platformy przycisk logowania i logujemy się dowolnie.
3. tworzenie logiki odpowiadajązej za funkcjonalności aplikacji zawarte w opisie (długi punkt, do rozbudowy)
   a) panel boczny z platformami (facebook, instagram) w formie listy rozwijanej konwersacji
   b) panel głowny z zawartością rozmowy (lub opcjami w przypadku szczegółów rozmowy(zawiera opcje typu tłumaczenie rozmowy))
4. Rozplanować układ konwersacji i ułożenie funkcjonalności.
5. Sprawdzić czy jest oczekiwana zawartość 
6. Do ustalenia (ustalone): Koncepcja 1 pozwala na otworzenie aplikacji i zalogowanie się do każdego z komunikatorów oddzielnie ale trzeba to robić za każdym raz jak włączy się aplikację. 
Koncepcja 2 zakłada posiadanie konta aplikacji która pamięta dane logowania do komunikatorów, pozwoli to zalogiwać się różnym użytkownikom i nie wymusza logowania do komunikatorów za każdym razem.
Preferowana koncepcja 2 ponieważ koncepcja 1 i tak będzie w większości wdrożona.