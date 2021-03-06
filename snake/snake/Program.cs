﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25); //установить размер окна и убрать возможность перемотки

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка змеи
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(37, 7);
                    Console.Write("YOU LOSE");
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable) //нажата ли какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.ReadKey();
        }
    }
}
