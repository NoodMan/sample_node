using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demotest
{
    public class DateValid
    {
            public bool IsDateValid(string date)
            {
                // Récupère la date d'aujourd'hui
                DateTime today = DateTime.Now;

                // Variable pour stocker la date à valider
                DateTime inputDate;

                // Vérifie si la chaîne de date est null, vide ou ou contient uniquement des espaces blancs
                //  Si le nombre de tirets n'est pas égal à 2, cela signifie que la chaîne de caractères de date n'est pas formatée correctement
                if (string.IsNullOrWhiteSpace(date) || date.Count(c => c == '-') != 2)
                    return false;

                // Sépare la chaîne de date en parties dans un tableau : jour, mois et année
                string[] dateParts = date.Split('-');

                //la méthode "int.TryParse" pour tenter de convertir chaque partie de la date en un entier
                // Vérifie si les parties jour, mois et année sont numériques
                if (!int.TryParse(dateParts[0], out int day) || !int.TryParse(dateParts[1], out int month) || !int.TryParse(dateParts[2], out int year))
                    return false;

                // Vérifie si le mois est compris entre 1 et 12 
                if (month < 1 || month > 12)
                    return false;
                // Vérifie si le jour est compris entre 1 et le nombre de jours maximum pour le mois et l'année donnés
                int maxDays = DateTime.DaysInMonth(year, month);
                if (day < 1 || day > maxDays)
                    return false;

                // Vérifie si l'année est comprise entre 2000 et l'année en cours
                if (year < 2000 || year > today.Year)
                    return false;


                // Si tous les critères sont satisfaits, la date est valide
                return true;
            }
        

    }
}
