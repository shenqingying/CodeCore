using System;
using System.Globalization;
using System.Linq;
using CoreDemo.Domain;
using CoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreDemo.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new CoreContext();

            var test = context.Players
                .Where(x => x.Id > 0)
                .Include(x => x.GamePlayers)
                  .ThenInclude(x => x.Game)
                .ToList();

        }
    }
}
