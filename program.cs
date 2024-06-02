using System;
using System.Xml.Xsl.Runtime;
using Oxide.Plugins;
using Oxide.Libraries.Covalence;

namespace Oxide.Plugins {
    [Info("Roll - random number generator", "Artem Shumilov a.k.a. Herosh1", "0.1")]
    [Description("Плагин добавляющий команду /roll которая выводит в чат случайное число от 1 до 100")]

    public class program : RustPlugin {
        [ChatCommand("roll")]
        private void RollComand(IPlayer player, string command, string[] args){
            var random = new Random();
            int randomNumber = random.Next(1, 100);

            player.ChatMessage($"You rolled a: {randomNumber}")
        }
    }
}
