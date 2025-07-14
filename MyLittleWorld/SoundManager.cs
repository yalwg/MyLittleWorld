using System;
using System.Collections.Generic;
using System.Media;

namespace MyLittleWorld
{
    public class SoundManager
    {
        private Dictionary<Type, SoundPlayer> soundPlayers = new Dictionary<Type, SoundPlayer>();

        public void LoadSound(Type objectType, string soundFile)
        {
            try
            {
                soundPlayers[objectType] = new SoundPlayer(soundFile);
                soundPlayers[objectType].LoadAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading sound for {objectType.Name}: {ex.Message}");
            }
        }

        public void PlaySound(Type objectType)
        {
            if (soundPlayers.TryGetValue(objectType, out SoundPlayer player))
            {
                try
                {
                    player.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing sound: {ex.Message}");
                }
            }
        }
    }
}