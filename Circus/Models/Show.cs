using System;
using Circus.Enums;

namespace Circus.Models
{
	public class Show
	{
		private List<Dresseur> _dresseurs;

		private List<Spectateur> _spectateurs;

		public Show()
		{
            _dresseurs = new List<Dresseur> { new Dresseur("Henry", "Singe 1"), new Dresseur("Philipe", "Singe 2") };
			_spectateurs = new List<Spectateur> { new Spectateur("Spectateur 1") };
        }

		public void Launch(Tour tour)
		{
			_dresseurs.ForEach(dresseur => dresseur.ExecuteTour(tour));
			switch (tour)
			{
				case Tour.Acrobatie:
					_spectateurs.ForEach(spectateur => spectateur.Bravo());
					break;
				case Tour.Musique:
                    _spectateurs.ForEach(spectateur => spectateur.Siffle());
                    break;
            }
		}
	}
}

