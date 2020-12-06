using Datamvc.Models;
using System.Collections.Generic;

namespace Datamvc.Services
{
    interface IItemService
    {
        void AddItem(Item item);
        void DeleteItem(int id);
        Item GetItem(int id);
        IEnumerable<Item> GetItems();

    }
}
