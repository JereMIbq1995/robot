using System;

namespace Robot {
    class Robot {
        
        // Attributes/Member variables
        private string name;
        private int numAmmos;

        // Constructor
        public Robot(string name) {
            this.name = name;
            this.numAmmos = 1000;
        }

        // Move
        public void Move(string direction) {
            Console.WriteLine($"{this.name}: Moving to the {direction}");
        }

        // Speak
        public void Speak(string sentence) {
            Console.WriteLine($"{this.name}: {sentence}");
        }
        // Fire
        public void Fire(int numBullets) {
            Console.WriteLine($"{this.name}: Firing {numBullets} bullets");
        }
        // SelfDestruct
        public void SelfDestruct(string sentence) {
            Console.WriteLine($"{this.name}: {sentence}");
        }
        // Scan
        public void Scan() {
            Console.WriteLine($"{this.name}: Scanning...");
        }

        // Pray
        public void Pray(string prayer) {
            Console.WriteLine($"{this.name}: Praying... {prayer}");
        }

    }
}