
using BiscuitDeMer;
using NUnit.Framework;

namespace TestBiscuitDeMer
{
    public class BiscuitDeMerTest
    {
       /*Test et code pas encore termines
 manque le test et le code pour les nombres compris de 1 a 100*/





        [Test]
        public void doisRetourner1SiLeNombreEst1()
            //on voudrais  que la sortie nous renvoie une chaine de caractere 1
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 1 et on veut que en sortie de notre methode genere on est "1"
            Assert.AreEqual("1", bDeMer.Genere(1,1));
        }


        [Test]
        public void doisRetourner2SiLeNombreEst2()
        //on voudrais  que la sortie nous renvoie une chaine de caractere 2
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 2 et on veut que en sortie de notre methode genere on est "2"
            Assert.AreEqual("2", bDeMer.Genere(2,2));
        }


        [Test]
        public void doisRetourner_Biscuit_SiLeNombreEst3()
        //on voudrais  que la sortie nous renvoie une chaine de caractere Biscuit
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 3 et on veut que en sortie de notre methode genere on est "Biscuit"
            Assert.AreEqual("Biscuit", bDeMer.Genere(3,3));
        }



        [Test]
        public void  doisRetourner_De_SiLeNombreEst6()
        //on voudrais  que la sortie nous renvoie une chaine de caractere DeMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 5 et on veut que en sortie de notre methode genere on est "DeMer"
            Assert.AreEqual("Biscuit", bDeMer.Genere(6,6));
        }

        [Test]
        public void doisRetourner_De_SiLeNombreEst5()
        //on voudrais  que la sortie nous renvoie une chaine de caractere DeMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 5 et on veut que en sortie de notre methode genere on est "DeMer"
            Assert.AreEqual("DeMer", bDeMer.Genere(5,5));
        }

        [Test]
        public void doisRetourner_De_SiLeNombreEst10()
        //on voudrais  que la sortie nous renvoie une chaine de caractere DeMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 10 et on veut que en sortie de notre methode genere on est "DeMer"
            Assert.AreEqual("DeMer", bDeMer.Genere(10,10));
        }


        [Test]
        public void doisRetourner_BiscuitDeMer_SiLeNombreEst15()
        //on voudrais  que la sortie nous renvoie une chaine de caractere BiscuitDeMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 15 et on veut que en sortie de notre methode genere on est "BiscuitDeMer"
            Assert.AreEqual("BiscuitDeMer", bDeMer.Genere(15,15));
        }


        [Test]
        public void doisRetourner_BiscuitDeMer_SiLeNombreEst30()
        //on voudrais  que la sortie nous renvoie une chaine de caractere BiscuitDeMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            //on a 30 et on veut que en sortie de notre methode genere on est "BiscuitDeMer"
            Assert.AreEqual("BiscuitDeMer", bDeMer.Genere(30,30));
        }

        public void doisRetourner_12_SiLesNombres1_2()
        //on On passe deux nombres en parametre et on aimerait
        //quil nous renvoie deux nombres concatenes en sortieMer
        {
            //ARRANGE
            var bDeMer = new BiscuitDemer();

            //ACT+ASSERT
            
            Assert.AreEqual("12", bDeMer.Genere(1,2));
        }

    }
}            

 
                      
                // Tests pas encore termine
               