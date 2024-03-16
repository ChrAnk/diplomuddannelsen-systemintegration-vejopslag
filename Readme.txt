***********************************************************
*                  README - VEJREGISTER                   *
***********************************************************
Løsningen består af en C# .NET 8-applikation. Den kan ini-
tieres gennem Visual Studio gennem VejregisterOpslag.sln.
Dette vil åbne API-oversigten i Swagger.

Løsningen har to API'er:
* VejregisterOpslag/FindEgenskaber
* VejregisterOpslag/FindVeje

Forberedelse
-----------------------------------------------------------
Inden applikationen kører skal datafilen placeres på stien:
                    C:\Vejregister.txt
Alternativt kan stien rettes i linke 20 og 301 i filen:
        Controllers/VejregisterOpslagController.cs
-----------------------------------------------------------

FindEgenskaber
-----------------------------------------------------------
Tager Kommunekode og Vejkode som parametre og returnerer
alle registrerede egenskaber. Tilføjer automatisk foran-
stillede nuller.

Returnerer 200 hvis vejen findes og 400 hvis vejen ikke
findes.
-----------------------------------------------------------

FindVeje
-----------------------------------------------------------
Tager en tekststreng som parameter og returnerer alle veje
hvis navne starter med tekststrengen. Der returneres også
Kommunekode og Vejkode for at forhindre tvetydighed. API'en
skelner ikke mellem små og store bogstaver søgestrengen.

Returnerer 200 hvis en eller flere veje blev fundet og 400
hvis ingen veje blev fundet.
-----------------------------------------------------------

Demonstration
-----------------------------------------------------------
En demonstration af brugen af API'erne kan se i denne
video: https://youtu.be/y_TjDKrUZdc
-----------------------------------------------------------