// ClientFactory.cs
// 
// Copyright (C) 2008 Jordi Mart�n Cardona
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;

namespace CIFSClient
{
	
	/// <summary>
	/// Patr� de disseny factory encarregat de tornar un client v�lid per a la plataforma
	/// </summary>
	public  class ClientFactory
	{
		/// <summary>
		//  Obt� un objecte que implementa IClient i es valid a la plataforma que s'est� executant
        //  la biblioteca de classes
		/// </summary>
		/// <returns>
		/// Client CIFS v�lid <see cref="IClient"/>
		/// </returns>
		public static IClient GetClient()
		{
			//obte informaci� de la plataforma
			int p = (int) Environment.OSVersion.Platform;
                if ((p == 4) || (p == 128)) {
                        Console.WriteLine ("Carregant el modul CIFSClient de Unix (Samba)");
				        //compilaci� condicional depenent si es linux o windows
                        #if (LINUX)
				        	return new SambaClient();
				        #else
				        	Console.WriteLine ("EL modul CIFSClient de Unix (no es accesible des de .NET)");
				        	Console.WriteLine ("Carregant el modul CIFSClient de Windows (Win32)");
				        	return new Win32Client();
				        #endif
				        	
                } else {
                        Console.WriteLine ("Carregant el modul CIFSClient de Windows (Win32)");
				        return new Win32Client();
                }
		}
	}
}
