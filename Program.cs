using SmartHomeHub.Devices;
using SmartHomeHub.Command;
using SmartHomeHub.Observer;
using SmartHomeHub.Strategy;
using SmartHomeHub.Facade;


var hub = new SmartHomeFacade();

// Lampor
var kitchenLamp = new Lamp("Kitchen lamp");
var livingLamp = new Lamp("Living room lamp");
var bedroomLamp = new Lamp("Bedroom lamp");

// Lås
var frontDoor = new DoorLock("Front door");
var backDoor = new DoorLock("Back door");

// Termostat
var thermostat = new Thermostat("Hall thermostat");

// Registrera devices i hubben
hub.AddDevice(kitchenLamp);
hub.AddDevice(livingLamp);
hub.AddDevice(bedroomLamp);

hub.AddDevice(frontDoor);
hub.AddDevice(backDoor);

hub.AddDevice(thermostat);

// Observers
hub.AddObserver(new DashboardObserver());
hub.AddObserver(new LoggerObserver());
hub.AddObserver(new AuditObserver());

// Mode
hub.SetMode(new NormalMode());

// Kör några kommandon
hub.RunCommand(new TurnOnCommand(kitchenLamp));
hub.RunCommand(new TurnOnCommand(livingLamp));
hub.RunCommand(new TurnOnCommand(bedroomLamp));

hub.RunCommand(new LockDoorCommand(frontDoor));
hub.RunCommand(new LockDoorCommand(backDoor));

hub.RunCommand(new SetTemperatureCommand(thermostat, 22));

Console.WriteLine("\nReplaying last commands...");
hub.ReplayLast(5);

// var hub = new SmartHomeFacade();

// var lamp = new Lamp("Living room lamp");
// var door = new DoorLock("Front door");
// var thermostat = new Thermostat("Hall thermostat");

// hub.AddDevice(lamp);
// hub.AddDevice(door);
// hub.AddDevice(thermostat);

// hub.AddObserver(new DashboardObserver());
// hub.AddObserver(new LoggerObserver());
// hub.AddObserver(new AuditObserver());

// hub.SetMode(new NormalMode());

// hub.RunCommand(new TurnOnCommand(lamp));
// hub.RunCommand(new LockDoorCommand(door));
// hub.RunCommand(new SetTemperatureCommand(thermostat, 22));

// Console.WriteLine("\nReplaying last commands...");
// hub.ReplayLast(3);

Console.ReadLine();