using System;
using UnityEngine;
using UnityEngine.Events;

namespace LiteNinja.CameraService
{
    /// <summary>
    /// Interface for a registry that manages cameras.
    /// </summary>
    public interface ICameraRegistry
    {
        /// <summary>
        /// Registers a camera with the given id.
        /// </summary>
        /// <param name="id">The id to register the camera under.</param>
        /// <param name="camera">The camera to register.</param>
        void RegisterCamera(string id, Camera camera);

        /// <summary>
        /// Retrieves the camera registered under the given id.
        /// </summary>
        /// <param name="id">The id of the camera to retrieve.</param>
        /// <returns>The camera registered under the given id.</returns>
        Camera GetCamera(string id);

        /// <summary>
        /// Unregisters the camera under the given id.
        /// </summary>
        /// <param name="id">The id of the camera to unregister.</param>
        void UnregisterCamera(string id);

        /// <summary>
        /// Gets the ids of all registered cameras.
        /// </summary>
        string[] CameraIds { get; }

        /// <summary>
        /// Event that is invoked when a camera is changed.
        /// </summary>
        UnityEvent<string> OnCameraChanged { get; }
    }
}