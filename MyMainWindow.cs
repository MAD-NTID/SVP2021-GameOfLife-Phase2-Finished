using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls; // 3.3
using GameOfLifeDesktop.UILibrary; // 2.3

namespace GameOfLifeDesktop
{
    class MyMainWindow : GameOfLifeMainWindow // 2.3
    {
        protected override void OnStartSimulation() // 3.1
        { // 3.1
            ToggleInputEnabled(false); // 3.2
            Game.Rows = int.Parse(numOfRowsTextBox.Text); // 3.2
            Game.Columns = int.Parse(numOfColTextBox.Text); // 3.2
            Game.CycleTime = 1000 * double.Parse(cycleTimeTextBox.Text); // 3.2

            cycleGrid = new Grid(); // 3.3 
            SetCycleGridRowsAndColumns(); // 3.3

            for (int row = 0; row < Game.Rows; row++) // 3.4
            { // 3.4
                for (int column = 0; column < Game.Columns; column++) // 3.5
                { // 3.5
                    Image cell = new Image(); // 3.6
                    cell.SetCellRowAndColumn(row, column); // 3.6
                    cell.Source = SelectedInstructorImage; // 3.6
                    cycleGrid.Children.Add(cell); // 3.6
                } // 3.5
            } // 3.4

            mainGrid.Children.Add(cycleGrid); // 3.7
            Game.Start(); // 3.7
        } // 3.1        
    }
}
