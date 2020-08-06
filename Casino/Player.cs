﻿using System;
using System.Collections.Generic;


namespace Casino
{
    public class Player
    {

        public Player(string name) : this (name, 100)
        {
        }
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; } = new List<Card>();

        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public bool Stay { get; set; }

        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enought to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}