using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      StockList resultList = new StockList();
      resultList = this;
      StockNode startOfList = listToMerge.head;
      
      // traverse the list till the end
      StockNode current = resultList.head;
      while (current.Next != null)
          current = current.Next;

      // point the last node of the first list to the new node of the other list
      current.Next = startOfList;

      return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = null;

      // write your implementation here

      return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

      // write your implementation here

      return length;
    }
  }
}