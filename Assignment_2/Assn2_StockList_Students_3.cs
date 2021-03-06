﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;

            StockNode current;
            current = this.head;
            while (current !=null)
            {
                value = value + (current.StockHolding.Holdings * current.StockHolding.CurrentPrice);

                current = current.Next;
            }

      return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      int similarityIndex = 0;

            StockNode current;
            current = this.head;

            StockNode secondList;
            secondList = listToCompare.head;


            while (current != null)
            {

                while (secondList != null)
                {
                    if (current.StockHolding.Symbol == secondList.StockHolding.Symbol)
                    {
                        similarityIndex++;
                        //break;

                    }
                    secondList = secondList.Next;

                }

                secondList = listToCompare.head;


                current = current.Next;
            }



            return similarityIndex;

        }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {

            StockNode current = head;

            Console.Write("head --> ");

            while (current != null)
            {

                Console.Write(" | " + current.StockHolding.Name + ", " + current.StockHolding.Symbol + ", " + current.StockHolding.Holdings + "|");
                Console.Write(" --> ");
                current = current.Next;
            }

            Console.Write("null ");

            Console.WriteLine();

        }
    }
}
 