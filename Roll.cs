using System;
using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins {
    [Info("Roll - random number generator", "Artem Shumilov a.k.a. Herosh1", "0.1")]
    [Description("Plugin adds the command /roll which outputs a random number from 1 to 100 in chat.")]

    public class program : RustPlugin {
        [ChatCommand("roll")]
        private void RollComand(IPlayer player, string command, string[] args){
            var random = new Random();
            int randomNumber = random.Next(1, 100);

            player.Message($"You rolled a: {randomNumber}");
        }
    }
}
