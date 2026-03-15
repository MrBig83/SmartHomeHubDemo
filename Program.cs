using SmartHomeHub.Devices;
using SmartHomeHub.Command;
using SmartHomeHub.Observer;
using SmartHomeHub.Strategy;
using SmartHomeHub.Facade;


var hub = new SmartHomeFacade();

var lamp = new Lamp("Living room lamp");
var door = new DoorLock("Front door");
var thermostat = new Thermostat("Hall thermostat");

hub.AddDevice(lamp);
hub.AddDevice(door);
hub.AddDevice(thermostat);

hub.AddObserver(new DashboardObserver());
hub.AddObserver(new LoggerObserver());
hub.AddObserver(new AuditObserver());

hub.SetMode(new NormalMode());

hub.RunCommand(new TurnOnCommand(lamp));
hub.RunCommand(new LockDoorCommand(door));
hub.RunCommand(new SetTemperatureCommand(thermostat, 22));

Console.WriteLine("\nReplaying last commands...");
hub.ReplayLast(3);

Console.ReadLine();