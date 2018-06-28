using SudokuSharp;

namespace GameMechanics
{
    public class LevelGenerator
    {
        public static Board GenerateBoard(int seed, int level)
        {
            var cuts = (int)((((level * 0.0017) + 0.37) * 81));            

            if (level < 50)
                return Factory.Puzzle(seed + level, 0, 0, cuts);
            else if (level < 150)
                return Factory.Puzzle(seed + level, 0, (cuts / 3), (cuts / 3) * 2);
            return Factory.Puzzle(seed + level, 0, cuts, 0);
        }
    }
}
