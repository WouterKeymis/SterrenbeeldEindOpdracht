using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SterrenbeeldService.Repositories
{
    public class SterrenbeeldRepository : ISterrenbeeldRepository
    {
        public string getSterrenbeeld(int dag, int maand)
        {
            string sterrenbeeld; 

            switch (maand)
            {
                case 1:
                    if (dag <= 19)
                        sterrenbeeld = "Steenbok";
                    else
                        sterrenbeeld = "Waterman";
                    break;
                case 2:
                    if (dag <= 19)
                        sterrenbeeld = "Waterman";
                    else
                        sterrenbeeld = "Vissen";
                    break;
                case 3:
                    if (dag <= 20)
                        sterrenbeeld = "Vissen";
                    else
                        sterrenbeeld = "Ram";
                    break;
                case 4:
                    if (dag <= 20)
                        sterrenbeeld = "Ram";
                    else
                        sterrenbeeld = "Stier";
                    break;
                case 5:
                    if (dag <= 20)
                        sterrenbeeld = "Stier";
                    else
                        sterrenbeeld = "Tweeling";
                    break;
                case 6:
                    if (dag <= 21)
                        sterrenbeeld = "Tweeling";
                    else
                        sterrenbeeld = "Kreeft";
                    break;
                case 7:
                    if (dag <= 22)
                        sterrenbeeld = "Kreeft";
                    else
                        sterrenbeeld = "Leeuw";
                    break;
                case 8:
                    if (dag <= 23)
                        sterrenbeeld = "Leeuw";
                    else
                        sterrenbeeld = "Maagd";
                    break;
                case 9:
                    if (dag <= 23)
                        sterrenbeeld = "Maagd";
                    else
                        sterrenbeeld = "Weegschaal";
                    break;
                case 10:
                    if (dag <= 23)
                        sterrenbeeld = "Weegschaal";
                    else
                        sterrenbeeld = "Schorpioen";
                    break;
                case 11:
                    if (dag <= 22)
                        sterrenbeeld = "Schorpioen";
                    else
                        sterrenbeeld = "Booschutter";
                    break;
                case 12:
                    if (dag <= 21)
                        sterrenbeeld = "Boogschutter";
                    else
                        sterrenbeeld = "Steenbok";
                    break;
                default:
                    sterrenbeeld = "Error, niet gevonden";
                    break;
            }

            return sterrenbeeld;
        }
    }
}
