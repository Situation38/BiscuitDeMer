﻿


//Ecrivons un progragmme^qui retourne les entier de 1 a 100 
//Qui pour les multiples de 3 remplace le nombre par "Biscuit"
//Qui pour les multiples de 5 remplace le nombre par "DeMer"
//Qui pour les multiples de 15  remplace le nombre par "BiscuitDeMer"

//ExDeSortie: "12Biscuit4DemerBiscuit78BiscuitDemer.........DeMer"


//on commence des tests  des fonctionnalites les plus basiques
//En creant le minimum de code qui va faire passer le test
//on commence par traiter les cas les plus simples
//puis en terminant part les cas les plus complexes

            //Test et code Termine



using System;

namespace BiscuitDeMer
{
    public class BiscuitDemer
    {
       
        
        public BiscuitDemer()
        {

        }


        /* On commence a faire des tests et a generer du code
         * pour laffichage dun nombre et ses multiples
         
        
        
        public string Genere()
         
            {
         
            return "Null";

            }
           
        
            public string Genere(int nombre)
            {
                if (nombre == 1)
                return "1";
         
            }


            public string Genere(int nombre)
            {
               if (number == 1)
               return "1";
               return "2";
             }

        
         
             public string Genere(int nombre)
                {
                  
                   return "nombre";
                 }


               public string Genere(int nombre)
              {
         
                    return nombre.ToString();
         
                }


                 public string Genere(int nombre)
                {
                    if (nombre == 3|| nombre == 6)
                        return "Biscuit";
                    return nombre.ToString();

                }   

                        //optimisation du code pour cecas

                 public string Genere(int nombre)
                    {
                        if (nombre % 3 == 0)
                            return "Biscuit";
                    
                        return nombre.ToString();

                    }



            public string Genere(int nombre)
            {
                if (nombre % 3 == 0)
                    return "Biscuit";
                else if (nombre == 5 || nombre == 10)
                    return "DeMer";
                return nombre.ToString();

            }


            //on optimise le code pour ce cas

             public string Genere(int nombre)
            {
                if (nombre % 3 == 0)
                    return "Biscuit";
                else if (nombre % 5 == 0)
                    return "DeMer";
                return nombre.ToString();

            }

             

             public string Genere(int nombre)
                {
                    if (nombre == 15 || nombre == 30)
                        return "BiscuitDeMer";
                    if (nombre % 3 == 0)
                        return "Biscuit";
                    if (nombre % 5 == 0)
                        return "DeMer";
                    return nombre.ToString();

                }

       
                //on optimise le code pour ce cas
        
            public string Genere(int nombre)
                {
                    if (nombre % 15 == 0)
                        return "BiscuitDeMer";
                    if (nombre % 3 == 0)
                        return "Biscuit";
                    if (nombre % 5 == 0)
                        return "DeMer";
                    return nombre.ToString();

                }

        


        *On fait des tests et on genere du code 
        * pour le cas deux nombres  pasees en parametre 
        * un min et un max
        *
        *
        
                //ici on traitait un seul nombre

            public string Genere(int minNombre , int Maxnombre)
            {
                if (minNombre % 15 == 0)
                    return "BiscuitDeMer";
                if (minNombre % 3 == 0)
                    return "Biscuit";
                if (minNombre % 5 == 0)
                    return "DeMer";
                return minNombre.ToString();

            }

               
          //Les sorties sont concatanees

        public string Genere(int minNombre , int Maxnombre)
            {
                string affich = "";
                if (minNombre % 15 == 0)
                    return affich += "BiscuitDeMer";
                else if (minNombre % 3 == 0)
                    return affich += "Biscuit";
                else if (minNombre % 5 == 0) 
            
                    affich +=  "DeMer";
                else
                    affich += minNombre.ToString();
             
            }


        
         //ici on traite le premier et le deuxieme nombre 


     public string Genere(int minNombre , int maxNombre)
        {
            string affich = "";
            if (minNombre % 15 == 0)
                affich += "BiscuitDeMer";
            else if (minNombre % 3 == 0)
                affich += "Biscuit";
            else if (minNombre % 5 == 0)
                 affich += "DeMer";
            else
                 affich +=minNombre.ToString();
           
        

            if (minNombre < maxNombre) 
           
                {

                   
                    if (maxNombre % 15 == 0)
                        affich += "BiscuitDeMer";
                    else if (maxNombre % 3 == 0)
                         affich += "Biscuit";
                    else if (maxNombre % 5 == 0)
                         affich += "DeMer";

                else
                     affich += maxNombre.ToString();
            }
        
        return affich;

        }

***********************code Refactoriser**********************

             public string Genere(int minNombre , int maxNombre)
                {
                    string affich = "";
                    affich += EvalionsLeNombre(minNombre);



                    if (minNombre < maxNombre)
                    {

                        affich += EvalionsLeNombre( maxNombre);
                     }

                        return affich;

                }



            public string EvalionsLeNombre (int nombre)
            {
                //Methode permettant de cleaner notre code
                //Elle permet de tester nos conditions pour 
                chaque nombre
       


                if (nombre % 15 == 0)
                    return "BiscuitDeMer";
                if  (nombre % 3 == 0)
                    return "Biscuit";
                 if (nombre % 5 == 0)
                    return "DeMer";

            
                   return nombre.ToString();

            }
        


        ****************code Refactoriser*******************
        *
        *public string Genere(int minNombre , int maxNombre)
        {
            string affich = "";
           



            while (minNombre <= maxNombre)
            {

                affich += EvalionsLeNombre(minNombre++);
            }

                return affich;

        }

        public string EvalionsLeNombre (int nombre)
        {
            //Nous permet juste de refactoriser
            //notre code afin quil soit moins touffu 
            //et plus clean


            if (nombre % 15 == 0)
                return "BiscuitDeMer";
            if  (nombre % 3 == 0)
                return "Biscuit";
             if (nombre % 5 == 0)
                return "DeMer";

            
               return nombre.ToString();

        }
        



         */





        public string Genere(int minNombre , int maxNombre)
        {
            string affich = "";
           



            while (minNombre <= maxNombre)
            {

                affich += EvalionsLeNombre(minNombre++);
            }

                return affich;

        }

        public string EvalionsLeNombre (int nombre)
        {
            //Nous permet juste de refactoriser
            //notre code afin quil soit moins touffu 
            //et plus clean


            if (nombre % 15 == 0)
                return "BiscuitDeMer";
            if  (nombre % 3 == 0)
                return "Biscuit";
             if (nombre % 5 == 0)
                return "DeMer";

            
               return nombre.ToString();

        }
        





        //  Okey termine






        static void Main(string[] args)
        {
           //   
        }
    }
}
