using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;

        private const int countPlaces = 20;

        private int pictureWidth;

        private int pictureHeight;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                sw.Write("CountLevels:" + parkingStages.Count + Environment.NewLine);
                foreach (var level in parkingStages)
                {
                    sw.Write("Level" + Environment.NewLine);
                    foreach (ITransport vehicle in level)
                    {
                        if (vehicle.GetType().Name == "Tractor")
                        {
                            sw.Write((level.GetKey) + ":Tractor:");
                        }
                        if (vehicle.GetType().Name == "Bulldozer")
                        {
                            sw.Write((level.GetKey) + ":Bulldozer:");
                        }
                        sw.Write(vehicle + Environment.NewLine);
                    }
                }
            }
        }

        private void WriteToFile(string text, StreamWriter stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(text);
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int counter = -1;
            ITransport vehicle = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                line = sr.ReadLine();
                if ((line != null) && (line.Contains("CountLevels")))
                {
                    int count = Convert.ToInt32(line.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "Level")
                        {
                            counter++;
                            parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                            continue;
                        }
                        if (line.Split(':')[1] == "Tractor")
                        {
                            vehicle = new Tractor(line.Split(':')[2]);
                        }
                        else if (line.Split(':')[1] == "Bulldozer")
                        {
                            vehicle = new Bulldozer(line.Split(':')[2]);
                        }
                        if (vehicle != null)
                        {
                            parkingStages[counter][Convert.ToInt32(line.Split(':')[0])] = vehicle;
                        }
                    }
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
            }
        }

        public void Sort()
        {
            parkingStages.Sort();
        }

    }
}
