# LiteNinja Camera Services

LiteNinja Camera Services is a collection of Camera-related services for Unity projects. 

## Camera Registry Service
A service that allows registering and retrieving cameras.

### ICameraRegistry

`ICameraRegistry` is an interface that defines the contract for a camera registry service. It provides methods for registering, retrieving, and unregistering cameras.

Here are the key methods of the `ICameraRegistry`:

- `RegisterCamera(string id, Camera camera)`: This method allows you to register a camera with a unique string identifier. If a camera with the same identifier is already registered, it will be replaced.

- `GetCamera(string id)`: This method allows you to retrieve a camera using its unique string identifier. If no camera is registered with the given identifier, it returns null.

- `UnregisterCamera(string id)`: This method allows you to unregister a camera using its unique string identifier. If no camera is registered with the given identifier, the method does nothing.

- `CameraIds`: This property returns an array of all registered camera identifiers.

- `OnCameraChanged`: This event is invoked when a camera is registered or unregistered. The event handler receives the identifier of the changed camera.

### CameraRegistry

`CameraRegistry` is a class that implements the `ICameraRegistry` interface. It uses a dictionary to store cameras, identified by a unique string ID.

Here's a basic usage example:

```csharp
// Create a new CameraRegistry instance
ICameraRegistry cameraRegistry = new CameraRegistry();

// Register a camera
Camera mainCamera = Camera.main;
cameraRegistry.RegisterCamera("Main", mainCamera);

// Retrieve a camera
Camera retrievedCamera = cameraRegistry.GetCamera("Main");

// Unregister a camera
cameraRegistry.UnregisterCamera("Main");
```

Remember to add a listener to the `OnCameraChanged` event if you want to be notified when a camera is registered or unregistered:

```csharp
cameraRegistry.OnCameraChanged.AddListener((string id) => {
    Debug.Log($"Camera changed: {id}");
});
```