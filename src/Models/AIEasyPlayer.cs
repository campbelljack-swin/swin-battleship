/// <summary>
/// ''' This is, currently a clone of Medium AI
/// ''' if it has found a ship
/// ''' </summary>
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

public class AIEasyPlayer : AIPlayer
{
    public AIEasyPlayer(BattleShipsGame controller) : base(controller)
    {
    }

    /// <summary>
    ///     ''' GenerateCoordinates should generate random shooting coordinates
    ///     ''' </summary>
    ///     ''' <param name="row">the generated row</param>
    ///     ''' <param name="column">the generated column</param>
    protected override void GenerateCoords(ref int row, ref int column)
    {
        do
        {
	    SearchCoords(ref row, ref column);
        }
        while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid.Item(row, column) != TileView.Sea)); // while inside the grid and not a sea tile do the search
    }

    /// <summary>
    ///     ''' SearchCoords will randomly generate shots within the grid as long as its not hit that tile already
    ///     ''' </summary>
    ///     ''' <param name="row">the generated row</param>
    ///     ''' <param name="column">the generated column</param>
    private void SearchCoords(ref int row, ref int column)
    {
        row = _Random.Next(0, EnemyGrid.Height);
        column = _Random.Next(0, EnemyGrid.Width);
    }

    /// <summary>
    ///     ''' ProcessShot will be called uppon when a ship is found.
    ///     ''' Should do nothin in Easy AI
    ///     ''' </summary>
    ///     ''' <param name="row">the row it needs to process</param>
    ///     ''' <param name="col">the column it needs to process</param>
    ///     ''' <param name="result">the result og the last shot (should be hit)</param>
    protected override void ProcessShot(int row, int col, AttackResult result)
    {
    }
}
