using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace LiteNinja.CameraService
{
    public class CameraRegistry : ICameraRegistry
    {
        private static readonly Dictionary<string, Camera> _cameras = new();

        public void RegisterCamera(string id, Camera camera)
        {
            _cameras[id] = camera;
            OnCameraChanged?.Invoke(id);
        }

        public Camera GetCamera(string id)
        {
            return _cameras.GetValueOrDefault(id);
        }

        public void UnregisterCamera(string id)
        {
            if (!_cameras.ContainsKey(id)) return;
            _cameras.Remove(id);
            OnCameraChanged?.Invoke(id);
        }

        public string[] CameraIds => _cameras.Keys.ToArray();
        public UnityEvent<string> OnCameraChanged { get; } = new();
    }
}