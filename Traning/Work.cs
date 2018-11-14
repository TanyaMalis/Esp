using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traning
{
    class Work
    {
        List<string> ruWords = new List<string>(); // список русских слов
        List<string> esWords = new List<string>(); // список испанских слов
        List<string> transformEsWords = new List<string>(); // преобразованный список испанских слов
        List<string> transformRuWords = new List<string>(); // преобразованный список русских слов

        /// <summary>
        /// свойство для преобразованного списка испанских слов
        /// </summary>
        public List<string> TransformEsWords
        {
            get
            {
                return transformEsWords;
            }

            set
            {
                transformEsWords = value;
            }
        }
        /// <summary>
        /// свойство для преобразованного списка русских слов
        /// </summary>
        public List<string> TransformRuWords
        {
            get
            {
                return transformRuWords;
            }

            set
            {
                transformRuWords = value;
            }
        }

        /// <summary>
        /// метод выбора темы слов
        /// </summary>
        /// <param название темы="tema"></param>
        public void ChoiceTema(string tema)
        {
            switch (tema) // по указанной теме переходим на заполнение списка слов
            {
                case "gente": Gente(); break;
                case "pais": Pais(); break;
                case "animal": Animal(); break;
                default: break;
            }
        }

        /// <summary>
        /// метод преобразования списка слов
        /// </summary>
        public void RandomWords()
        {
            while (esWords.Count > 0) // пока список не пуст
            {
                Random rnd = new Random(); // случайным образов выбираем число
                int index = rnd.Next(0, esWords.Count - 1); // от 0 до количества слов в списке
                TransformEsWords.Add(esWords[index]); // добавляем слово по этому индексу в преобразованный список испанских слов
                TransformRuWords.Add(ruWords[index]); // и русских, чтобы перевод соответсвовал выбранному слову
                esWords.RemoveAt(index); // удаляем эти слова
                ruWords.RemoveAt(index); // из обоих списков
            }
        }

        /// <summary>
        /// метод добавления слов для темы gente
        /// </summary>
        public void Gente()
        {
            esWords.Add("gente");
            esWords.Add("persona");
            esWords.Add("hombre");
            esWords.Add("marido");
            esWords.Add("mujer");
            esWords.Add("niño");
            esWords.Add("muchacho");
            esWords.Add("muchacha");
            esWords.Add("amigo");
            esWords.Add("invitado");
            ruWords.Add("люди");
            ruWords.Add("человек");
            ruWords.Add("мужчина");
            ruWords.Add("муж");
            ruWords.Add("женщина");
            ruWords.Add("ребенок");
            ruWords.Add("мальчик");
            ruWords.Add("девушка");
            ruWords.Add("друг");
            ruWords.Add("гость");
        }

        public void Pais()
        {
            esWords.Add("país");
            esWords.Add("Rusia");
            esWords.Add("España");
            ruWords.Add("страна");
            ruWords.Add("Россия");
            ruWords.Add("Испания");
        }

        public void Animal()
        {
            esWords.Add("animal");
            esWords.Add("gato");
            esWords.Add("perro");
            esWords.Add("pájaro");
            ruWords.Add("животное");
            ruWords.Add("кошка");
            ruWords.Add("собака");
            ruWords.Add("птица");
        }
    }
}
