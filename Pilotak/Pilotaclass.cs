﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    class Pilotaclass
    {
        string nev;
        string szuletesidatum;
        string nemzetiseg;
        int rajtszam;

        public Pilotaclass(string nev, string szuletesidatum, string nemzetiseg)
        {
            this.nev = nev;
            this.szuletesidatum = szuletesidatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = int.MaxValue;
        }

        public Pilotaclass(string nev, string szuletesidatum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesidatum = szuletesidatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev;}
        public string Szuletesidatum { get => szuletesidatum;}
        public string Nemzetiseg { get => nemzetiseg;}
        public int Rajtszam { get => rajtszam;}
    }
}
