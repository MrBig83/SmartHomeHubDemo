# SmartHomeHub – Design Patterns Demo

## How to run
dotnet run

## Patterns used

Observer  
Devices notify Dashboard, Logger and Audit observers when their state changes.

Command  
All actions are encapsulated as command objects like TurnOnCommand and LockDoorCommand.

Strategy  
Different system modes (NormalMode, EcoMode, PartyMode) control system behaviour.

Facade  
SmartHomeFacade exposes a simple API so Program.cs does not interact with subsystems.

Singleton  
Logger is implemented as a Singleton so the same instance is used everywhere.