namespace AlgorithmsForFun.CS;

public partial class Algorithms {
   public static string TournamentWinner(string[][] competitions, int[] results) {
      var winningTeam = string.Empty;
      var scores = new Dictionary<string, int> { { winningTeam, 0 } };

      for (var i = 0; i < competitions.Length; i++) {
         var winner = results[i] == 0 ? competitions[i][1] : competitions[i][0];
         
         if (!scores.TryAdd(winner, 3)) {
            scores[winner] += 3;
         }
         if (scores[winner] > scores[winningTeam]) {
            winningTeam = winner;
         }
      }

      return winningTeam;
   }
}