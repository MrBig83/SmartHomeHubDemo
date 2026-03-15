# SmartHomeHub – Design Patterns Demo

## Köra programmet:
dotnet run

## Patterns som används:

Observer
När en device ändrar state notifieras flera observers automatiskt (Dashboard, Logger och Audit). Detta implementerar en one-to-many relation där observers registrerar sig hos devices.

Command
Alla actions kapslas som kommandon (TurnOnCommand, LockDoorCommand osv). Detta gör att systemet kan köa och replaya kommandon.

Strategy
Systemets beteende styrs av ett valbart mode (Normal, Eco, Party). Algoritmen för hur hubben beter sig byts dynamiskt via Strategy.

Facade
SmartHomeFacade ger ett förenklat API som används av Program.cs istället för att interagera direkt med alla subsystems.

Singleton
Logger implementeras som en Singleton så att alla delar av systemet använder samma instans.