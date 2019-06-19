using BiscuitBattle;
using BiscuitBattle.Game;
using BiscuitBattle.Players;
using BiscuitBattle.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using BiscuitBattle.Store;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginGame();
        }

        static void BeginGame()
        {
            var locator = new ServiceLocator();
            var controller = locator.GetService<IGameController>();
            var cardFactory = locator.GetService<BaseBiscuitFactory>();

            //1. Get the decks for both players

            var humanDeck = new List<IBiscuitCard>();
            var aiDeck = new List<IBiscuitCard>();

            for (int i = 0; i <= 4; i++)
            {
                humanDeck.Add(cardFactory.GetCard());
                aiDeck.Add(cardFactory.GetCard());
            }

            //2. Set decks in game controller
            controller.PlayerOneDeck = humanDeck;
            controller.PlayerTwoDeck = aiDeck;

            controller.PlayerOne = new Human();
            int choice = Menu();
            switch (choice) {
                case 1:
                    controller.PlayerTwo = new EasyAI();
                    break;
                case 2:
                    controller.PlayerTwo = new BasicAI();
                    break;
                case 3:
                    controller.PlayerTwo = new CrazyAI();
                    break;
            }

            //3. Start the game
            controller.Begin();
        }
        //added this here so you can choose the ai level
        static int Menu() {
            Console.WriteLine("Choose your AI Opponent");
            Console.WriteLine("Easy(1), Hard(2) or Crazy(3)?");
            Char choice = Console.ReadKey().KeyChar;
            int i = int.Parse(choice.ToString());
            return i;
        }
    }
}