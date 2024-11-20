using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MultiShop.Message.DAL.Context
{
    public class MessageContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {

        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
