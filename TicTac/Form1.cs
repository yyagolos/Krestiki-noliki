using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            x, o
        }
        Player CurrentPlayer;
        Random random = new Random();
        int PlayerWinCount = 0;
        int CPUwinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CompMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                CurrentPlayer = Player.o;
                buttons[index].Text = CurrentPlayer.ToString();
                buttons[index].BackColor = Color.DarkGoldenrod;
                buttons.RemoveAt(index);
                CheckGame();
                Timer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            CurrentPlayer = Player.x;
            button.Text = CurrentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Azure;
            buttons.Remove(button);
            CheckGame();
            Timer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button.Text == "o" && button1.Text == "o" && button2.Text == "o" ||
                button3.Text == "o" && button4.Text == "o" && button5.Text == "o" ||
                button6.Text == "o" && button7.Text == "o" && button8.Text == "o" ||
                button.Text == "o" && button3.Text == "o" && button6.Text == "o" ||
                button1.Text == "o" && button4.Text == "o" && button7.Text == "o" ||
                button2.Text == "o" && button5.Text == "o" && button8.Text == "o" ||
                button.Text == "o" && button4.Text == "o" && button8.Text == "o" ||
                button2.Text == "o" && button4.Text == "o" && button6.Text == "o")
            {
                Timer.Stop();
                MessageBox.Show("Компьютер победил!");
                CPUwinCount++;
                label2.Text = "Комп победил: " + CPUwinCount;
                RestartGame();
            }



            else if (button.Text == "x" && button1.Text == "x" && button2.Text == "x" ||
                         button3.Text == "x" && button4.Text == "x" && button5.Text == "x" ||
                         button6.Text == "x" && button7.Text == "x" && button8.Text == "x" ||
                         button.Text == "x" && button3.Text == "x" && button6.Text == "x" ||
                         button1.Text == "x" && button4.Text == "x" && button7.Text == "x" ||
                         button2.Text == "x" && button5.Text == "x" && button8.Text == "x" ||
                         button.Text == "x" && button4.Text == "x" && button8.Text == "x" ||
                         button2.Text == "x" && button4.Text == "x" && button6.Text == "x")

            {
                Timer.Stop();
                MessageBox.Show("Игрок победил!");
                PlayerWinCount++;
                label1.Text = "Игрок победил: " + PlayerWinCount;
                RestartGame();
            };
        }

            private void RestartGame()
            {
                buttons = new List<Button>
                {
                    button, button1, button2, button3, button4, button5, button6,
                    button7, button8
                };
                foreach (Button x in buttons)
                {
                    x.Enabled = true;
                    x.Text = "?";
                    x.BackColor = DefaultBackColor;
                };

            }


        }
    };


                
            
                
            
        
           
    

