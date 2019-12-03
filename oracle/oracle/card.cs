using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaUtils;
using System.Windows.Forms;
namespace oracle
{
    public class Card 
    {
        private GroupBox cardHolder;
        public PictureBox cardImage;       
        private AlphaUtils.AlphaRichTextBox cardHealth;
        private AlphaRichTextBox cardAttack;
        private AlphaRichTextBox cardDef;
        private AlphaRichTextBox cardPrice;
        private AlphaRichTextBox cardText;
        public string imageLink { get; set; }
        public int defense { get; set; }
        public string name { get; set; }
        public int ID { get; set; }
        public int price { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        public int specID { get; set; }
        public string god { get; set; }
        public int type { get; set; }
        public int prod { get; set; }
        public Card(string[] args) {

            cardHolder = new GroupBox();
            cardImage = new PictureBox();

            cardHealth = new AlphaRichTextBox();
            cardAttack = new AlphaRichTextBox();
            cardDef = new AlphaRichTextBox();
            cardPrice = new AlphaRichTextBox();
            cardText = new AlphaRichTextBox();

            cardHolder.Controls.Add(cardImage);
            cardHolder.Controls.Add(cardHealth);
            loadStats(health, attack, defense);
        }
        public string imagePath { get { return imagePath; } set => cardImage.ImageLocation = value; }
        public void loadStats(int health, int attack, int def)
        {
            cardHealth.Text = health.ToString();
            cardDef.Text = defense.ToString();
            cardAttack.Text = attack.ToString();
        }
        
    }
}
