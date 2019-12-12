using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;

        private const int countPlaces = 20;

        private int pictureWidth;

        private int pictureHeight;

        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
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

        public bool SaveData(string filename)
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
                    //Начинаем уровень
                    sw.Write("Level" + Environment.NewLine);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var vehicle = level[i];
                        if (vehicle != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (vehicle.GetType().Name == "Tractor")
                            {
                                sw.Write(i + ":Tractor:");
                            }
                            if (vehicle.GetType().Name == "Bulldozer")
                            {
                                sw.Write(i + ":Bulldozer:");
                            }
                            //Записываемые параметры
                            sw.Write(vehicle + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, StreamWriter stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(text);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
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
                            //начинаем новый уровень
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
                    return true;
                }
                return false;

            }
        }
    }
}
