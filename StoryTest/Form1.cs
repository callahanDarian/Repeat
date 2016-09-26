using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int progressStory;
        int p;
        int s = 10;

        string story;
        string strName;

        private void button1_Click(object sender, EventArgs e)
        {
            progressStory++;
            Name = txtBoxName.Text;

            if (progressStory == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Hello again, welcome back to the beginning.";
            }
            else if (progressStory == 2)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Do you remember anything?";
            }
            else if (progressStory == 3)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "The events that happened before, the tragedies that will repeat themselves?";
            }
            else if (progressStory == 4)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "... Oh, I...";
            }
            else if (progressStory == 5)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "... I couldn't bring back your memories... just like last time...";
            }
            else if (progressStory == 6)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Don't worry! My memories are kind of shattered, too.";
            }
            else if (progressStory == 7)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Things will be fine this time around though, I'm sure.";
            }
            else if (progressStory == 8)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Just be yourself, and you'll do fine.";
            }
            else if (progressStory == 9)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "...";
            }
            else if (progressStory == 10)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Well, it's time for us to depart.";
            }
            else if (progressStory == 11)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "But before we go... Can I tell you something?";
            }
            else if (progressStory == 12)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I've already said this alot before, but I want to say it again.";
            }
            else if (progressStory == 13)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I...";
            }
            else if (progressStory == 14)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "... I'm sorry I couldn't save you.";
            }
            else if (progressStory == 15)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "...";
            }
            else if (progressStory == 16)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "... Again.";
            }
            else if (progressStory == 17)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Day 1 : Begin Again";
            }
            else if (progressStory == 18)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Me";
                story = "So this is it, huh?";
            }
            else if (progressStory == 19)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "The city noise echoes around me as I arrived to my destination.";
            }
            else if (progressStory == 20)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I've never been to this side of town before, but it looks like I'll have to get used to living here.";
            }
            else if (progressStory == 21)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "This is Gerania Academy, a fancy school with a month-long summer program for gifted students.";
            }
            else if (progressStory == 22)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I'm going to be spending the next four weeks here, unfortunately.";
            }
            else if (progressStory == 23)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Ha, sounds like the opposite of a good time.";
            }
            else if (progressStory == 24)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I'd rather be back home sleeping my summer away if I'm being honest." + Environment.NewLine + "But my parents wanted me out of the house.";
            }
            else if (progressStory == 25)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Geez, what a drag...";
            }
            else if (progressStory == 26)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "The weather's certainly agreeing with me." + Environment.NewLine + "It looks as though it might rain any minute.";
            }
            else if (progressStory == 27)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I better hurry up and get inside." + Environment.NewLine + "I doubt strolling in late would leave a good first impression.";
            }
            else if (progressStory == 28)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "As I approach the front doors, the air suddenly turns frigid.";
            }
            else if (progressStory == 29)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "???";
            }
            else if (progressStory == 30)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "What?";
            }
            else if (progressStory == 31)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "... not that way...";
            }
            else if (progressStory == 32)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "A cold shiver slips down my spine. What the hell was that just now?";
            }
            else if (progressStory == 33)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Wait, what?";
            }
            else if (progressStory == 34)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Fuck, the door's locked!" + Environment.NewLine + "What am I going to do? The teachers are going to rip me a new one if I'm actually late.";
            }
            else if (progressStory == 35)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I try slamming the doors to get someone's attention, but nobody's there to hear me." + Environment.NewLine + "Damn! This day can't get any worse.";
            }
            else if (progressStory == 36)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "...";
            }
            else if (progressStory == 37)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "... Well shit.";
            }
            else if (progressStory == 38)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I'm getting soaked!";
            }
            else if (progressStory == 39)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I try banging on the glass again.";
            }
            else if (progressStory == 40)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Me";
                story = "Hello? Is anybody there?! Open the door!";
            }
            else if (progressStory == 41)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "Um, hey there. Is everything ok?";
            }
            else if (progressStory == 42)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Suddenly, a shadow passed over my head and the rain stopped pelting me.";
            }
            else if (progressStory == 43)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "A boy came up behind me nervously gripping an umbrella.";
            }
            else if (progressStory == 44)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "He looked around my age, and very short. Another student maybe?";
            }
            else if (progressStory == 45)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Me";
                story = "Uh, yeah I'm fine." + Environment.NewLine + "But the door's locked and nobody's around. I think I'm missing the introduction orientation, too.";
            }
            else if (progressStory == 46)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "What a coincidence, I got locked out from the side entrance, too!";
            }
            else if (progressStory == 47)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 10);
                strName = "???";
                story = "W-well actually I kinda broke the door handle...";
            }
            else if (progressStory == 48)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "I think we'll have a better chance getting inside if we tried the back entrance instead.";
            }
            else if (progressStory == 49)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "Wanna go together?";
            }
            else if (progressStory == 50)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Me";
                story = "Sounds better than standing around clueless.";
            }
            else if (progressStory == 51)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Me";
                story = "Thanks man, you're a real lifesaver.";
            }
            else if (progressStory == 52)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "I'm happy to help!" + Environment.NewLine + "The name's Phillip by the way, what's yours?";
            }
            else if (progressStory == 53)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "What's your name?";
                txtBoxName.Visible = true;
            }
            else if (progressStory == 54)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "'" + Name + "' huh? Weird name. You sound like a protagonist to a visual novel.";
                txtBoxName.Visible = false;
            }
            else if (progressStory == 55)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "A-anywho, don't take this the wrong way, but I'm glad we're late together.";
            }
            else if (progressStory == 56)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Much better than going alone haha~";
            }
            else if (progressStory == 57)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Well, let's get going!";
            }
            else if (progressStory == 58)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "As we make our way around the building, I stick close under Phillip's umbrella." + Environment.NewLine + "I'm glad he's around, otherwise I would have been soaked.";
            }
            else if (progressStory == 59)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Awkward silence hung between us as we walked closely around the building.";
            }
            else if (progressStory == 60)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Phillip was fumbling with his umbrella, glancing at me periodically.";
            }
            else if (progressStory == 61)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "...Uh, by the way " + Name + ", what subject are you studying here?";
            }
            else if (progressStory == 62)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "" + Name;
                story = "What do you mean?";
            }
            else if (progressStory == 63)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "You mean you forgot? Did you do all of that paperwork while half-asleep or something?";
            }
            else if (progressStory == 64)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "" + Name;
                story = "Uh well...";
            }
            else if (progressStory == 65)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Hey, no worries! You're not the only one. I pulled an all-nighter myself and finished it last minute eheh...";
            }
            else if (progressStory == 66)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "It sounds to me like he's only bringing this up because he couldn't think of anything else to talk about.";
            }
            else if (progressStory == 67)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "It's a bit weird that we can only choose one subject to study here.";
            }
            else if (progressStory == 68)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Maybe they go really in-depth?";
            }
            else if (progressStory == 69)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "It'd be pretty interesting if you actually got into a subject you care about.";
            }
            else if (progressStory == 70)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "" + Name;
                story = "Oh, I remember something like this. I think I signed up for Photography or something...?";
            }
            else if (progressStory == 71)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Wow, I really did finish that paperwork half asleep.";
            }
            else if (progressStory == 72)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Way to go " + Name + ", procrastination hero for future generations.";
            }
            else if (progressStory == 73)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Oh wow! Photography? That's a pretty brave choice. I'm sort of jealous.";
            }
            else if (progressStory == 74)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Why? Is it a big deal?";
            }
            else if (progressStory == 75)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Erm, not really. But I haven't declared a subject yet.";
            }
            else if (progressStory == 76)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "I want to take something art related too, but it's a risky career choice to go into...";
            }
            else if (progressStory == 77)
            {
                labelName.Visible = false;
                labelStory.Visible = false;
                labelStoryy.Visible = false;
                button1.Visible = false;

                btnChoice1.Text = "Just do what makes you feel happy.";
                btnChoice1.Visible = true;
                btnChoice2.Text = "Yeah, you're right.";
                btnChoice2.Visible = true;
            }
            else if (progressStory == 78)
            {
                labelName.Visible = true;
                labelStory.Visible = true;
                btnChoice1.Visible = false;
                btnChoice2.Visible = false;
                labelStoryy.Text = "";
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Just do what makes you feel happy.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Yeah, you're right." + Environment.NewLine + "Better safe than sorry, after all.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 79)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "That's all that really matters in the end, isn't it?";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Yeah..." + Environment.NewLine + "I'd probably end up like one of those starving artists haha...";
                }
                else
                { story = "BUG"; }
            }
            else if (progressStory == 80)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Mm... I guess you're right.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "I should probably study something that'll actually pur food on the table";
                }
                else
                { story = "BUG"; }
            }
            else if (progressStory == 81)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Does photography make you happy?";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "Phillip stares off into space again, his ears drooping in the rain as we continue walking.";
                }
            }
            else if (progressStory == 82)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Eeeh, if I'm being honest, I only picked it because it sounded like the easiest class.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "He sure worries a lot for a little guy...";
                    progressStory = 94;
                }
            }
            else if (progressStory == 83 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Oh " + Name + ", you're a riot.";
            }
            else if (progressStory == 84 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Maybe you'll 'develop' and interest later on?";
                s = 592;
            }
            else if (progressStory == 85 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Oh no.";
            }
            else if (progressStory == 86 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "You mean you can't 'picture' yourself as a photographer?";
            }
            else if (progressStory == 87 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                story = "Geez, I 'shudder' to think of your future.";
            }
            else if (progressStory == 88 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Nope nope nope I'm leaving you behind.";
            }
            else if (progressStory == 89 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Good luck making it through this rain!";
            }
            else if (progressStory == 90 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "I'm the umbrella overlord around here.";
            }
            else if (progressStory == 91 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Alright fine, I'll stick with you. Just stop with all your puns!";
            }
            else if (progressStory == 92 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "They're awful!";
            }
            else if (progressStory == 93 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "You want me to stop punning? You're no fun.";
            }
            else if (progressStory == 94 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Well, I guess I could give it a 'shot'!";
            }
            else if (progressStory == 95 && p == 1)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                strName = Name;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 40);
                story = "I'M PUSHING YOU INTO THE STREET!";
            }
            else if (progressStory == 96)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Oh look, I think there's someone already here.";
            }
            else if (progressStory == 97)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I glance out from under Phillip's umbrella.";
            }
            else if (progressStory == 98)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "There was some weird guy struggling to climb up the side of the building's walls.";
            }
            else if (progressStory == 99)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "A burglar?";
            }
            else if (progressStory == 100)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "No, I think it's a student.";
            }
            else if (progressStory == 101)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "As we approached, the weird guy spotted us and grinned before taking a great, acrobatic leap and landed in front of us.";
            }
            else if (progressStory == 102)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Ah-!";
            }
            else if (progressStory == 103)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "And then promptly slipped and toppled onto Phillip.";
            }
            else if (progressStory == 104)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "Whoops, sorry there, kiddo! You alright?";
            }
            else if (progressStory == 105)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "I'm still in one piece, I think.";
            }
            else if (progressStory == 106)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "That's a relief! Were you cuties locked out. too?";
            }
            else if (progressStory == 107)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "'Cuties'?";
            }
            else if (progressStory == 108)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Amasing." + Environment.NewLine + "He's flirting horribly and he hasn't even introduced himself yet.";
            }
            else if (progressStory == 109)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "???";
                story = "H-hey! I was just trying to make you two feel welcome!";
            }
            else if (progressStory == 110)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Anyway, my name is Owen." + Environment.NewLine + "Owen Lorelei.";
            }
            else if (progressStory == 111)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "I'm a student at Gerania, just like you guys.";
            }
            else if (progressStory == 112)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Pleased to meet you. It's always nice to meet a bunch of cute boys.";
            }
            else if (progressStory == 113)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Lorelei?" + Environment.NewLine + "Like that rich family of CEOs that practically owns the school?";
            }
            else if (progressStory == 114)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Y-yeah, that one.";
            }
            else if (progressStory == 115)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen mumbles under his breath. He looks a bit uncomfortable.";
            }
            else if (progressStory == 116)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Hm..." + Environment.NewLine + "Anyway, it's nice to meet you. My name's Phillip Tan.";
            }
            else if (progressStory == 117)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "'Phillip Tan'? Hey! We're roommates!";
            }
            else if (progressStory == 118)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "W-what? How do you know?";
            }
            else if (progressStory == 119)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "I've lived at this academy for like, five years." + Environment.NewLine + "'Course I'd have some insider information hehe~";
            }
            else if (progressStory == 120)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Lookin' forward to it, kiddo!";
            }
            else if (progressStory == 121)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "R-right, likewise.";
            }
            else if (progressStory == 122)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen turned to me with a wide grin. This guy seems a bit too excited.";
            }
            else if (progressStory == 123)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "And what's your name, handsome?";
            }
            else if (progressStory == 124)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Er, I'm " + Name + ".";
            }
            else if (progressStory == 125)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Why the hell were you trying to climb the building?";
            }
            else if (progressStory == 126)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Ouch, right to the point, huh?";
            }
            else if (progressStory == 127)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Well, the door was locked; so I tried to reach the window and climb inside from there!";
            }
            else if (progressStory == 128)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Uh...";
            }
            else if (progressStory == 129)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Or maybe we could just wait until someone passes by to open the door for us?";
            }
            else if (progressStory == 130)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "You know, like normal people.";
            }
            else if (progressStory == 131)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "I already waited, like, forever though! It'll take an eternity!";
            }
            else if (progressStory == 132)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Waiting sounds a whole lot safer than climbing through windows.";
            }
            else if (progressStory == 133)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "It's not that hard, really! I used to do it all the time!";
            }
            else if (progressStory == 134)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "There's a little ledge over there that we can use and it'll be super quick.";
            }
            else if (progressStory == 135)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Eh, you'll probably break the window and be in a world of 'pane'.";
            }
            else if (progressStory == 136)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Look here buddy, I'm too suave and handsome to break anything but expectations in bed.";
            }
            else if (progressStory == 137)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "In the bad way?";
            }
            else if (progressStory == 138)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Probably.";
            }
            else if (progressStory == 139)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Only ever in the good way!" + Environment.NewLine + "Wanna find out first-hand?";
            }
            else if (progressStory == 140)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen leans in close to me and gives me a wink.";
            }
            else if (progressStory == 141)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I can feel myself growing a bit warm under the collar.";
            }
            else if (progressStory == 142)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Uhm...";
            }
            else if (progressStory == 143)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Suddenly, Phillip coughs awkwardly behind us";
            }
            else if (progressStory == 144)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Um, lets find a way inside the building before you two start making out in the rain.";
            }
            else if (progressStory == 145)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "W-we weren't!";
            }
            else if (progressStory == 146)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Heh, good idea.";
            }
            else if (progressStory == 147)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen hovers close to my ear and whispers huskily.";
            }
            else if (progressStory == 148)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 16);
                strName = "Owen";
                story = "That's a promise for later";
            }
            else if (progressStory == 149)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "He then gave me a small, quick wink.";
            }
            else if (progressStory == 150)
            {
                s = 5;
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Anyway, " + Name + ", what do you think we should do?";
            }
            else if (progressStory == 151)
            {
                labelName.Visible = false;
                labelStory.Visible = false;
                labelStoryy.Visible = false;
                button1.Visible = false;

                btnChoice1.Text = "Climb the window.";
                btnChoice1.Visible = true;
                btnChoice2.Text = "Wait outside.";
                btnChoice2.Visible = true;
            }
            else if (progressStory == 152)
            {
                labelName.Visible = true;
                labelStory.Visible = true;
                btnChoice1.Visible = false;
                btnChoice2.Visible = false;
                labelStoryy.Text = "";

                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Well, waiting here will take forever." + Environment.NewLine + "This is the back entrance after all.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Eh, I'm not sure I want to try climbing a building when it's rainging out.";
                }
            }
            else if (progressStory == 153)
            {

                if (p == 1)
                {

                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Climbing the window doesn't look too difficult, either-";
                }
                else
                {

                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "We'd probably slip and end up hugging the ground.";
                }
            }
            else if (progressStory == 154)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Window climbing it is!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Aw, you're a bunch of killjoys" + Environment.NewLine + "Opportunities to climb windows don't come every day, you know.";
                }
            }
            else if (progressStory == 155)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "I knew you would be reasonable, " + Name + "!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Hey, better safe than sorry after all.";
                }
            }
            else if (progressStory == 156)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Hey Phillip, are you coming along, too?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "I guess you could say we're missing a 'window of opportunity'";
                }
            }
            else if (progressStory == 157)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "I guess so...";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "I groaned and buried my face into my hands.";
                }
            }
            else if (progressStory == 158)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Enough dilly-dallying, we're all late as it is. Let's get going!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Geez, and you think my flirting was bad";
                }
            }
            else if (progressStory == 159)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "The three of us hobbled onto the ledge that Owen was climbing earlier and inched our way towards the window.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "I'd take your flirting over this any day.";
                }
            }
            else if (progressStory == 160)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "Now that I'm up here, it doesn't seem too bad.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Don't be mean, that was a good one!";
                }
            }
            else if (progressStory == 161)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "Phillip, on the other hand, was gripping my arm like no tomorrow." + Environment.NewLine + "He looks a little pale.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "If you say so.";
                }
            }
            else if (progressStory == 162)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Hey Phillip, you ok?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Keep dreamin' kiddo. You're losing this war.";
                }
            }
            else if (progressStory == 163)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Y-yeah, no worries!" + Environment.NewLine + "I'm just a little uncomfortable with heights.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "And all of our respect.";
                }
            }
            else if (progressStory == 164)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Just keep moving, I'll be fine!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "For making us wait outside for all eternity.";
                }
            }
            else if (progressStory == 165)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "If you say so...";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Oh geez, you're all so high maintenance";
                }
            }
            else if (progressStory == 166)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "There was a sudden click as Owen swung open the window with a wide grin.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "WelL~, I suppose I could make this easier and just pick the lock.";
                }
            }
            else if (progressStory == 167)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "See? Way easier than waiting outside for eternity." + Environment.NewLine + "Let's go-!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Woah, you know how to pick locks? That's sick!";
                }
            }
            else if (progressStory == 168)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "Owen lept into the window headfirst.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Strict parents make sneaky children I guess.";
                }
            }
            else if (progressStory == 169)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = story + Environment.NewLine + "His leap was followed by a CRACK and a resounding 'Ow!'";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Hehe, I'd love to make children with you, kiddo.";
                }
            }
            else if (progressStory == 170)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Are you still alive in there?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Uh, we're both guys.";
                }
            }
            else if (progressStory == 171)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Yeah!  Perfectly fine, nothing went wrong!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Doesn't mean we can't try.";
                }
            }
            else if (progressStory == 172)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Except that he broke the window lock. This thing isn't closing anytime soon.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Yo lovebirds, let's get ourselves inside before we freeze to death";
                }
            }
            else if (progressStory == 173)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Well, at least now we can get out of this rain.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Good plan.";
                }
            }
            else if (progressStory == 174)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "The three of us shook the rain from our hair, and I glanced around the lobby";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "Phillip crouches down in front of the door and pulls out some hairpins and tweezers.";
                }
            }
            else if (progressStory == 175)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "This school is fancier than I expected. I wonder where to go from here?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "From the way hes picking at it, you would think that he's done this before";
                }
            }
            else if (progressStory == 176)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Mm, the orientation is probably over by now. I think we should probably find a teacher-";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Heh, nice view back here.";
                }
            }
            else if (progressStory == 177)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 40);
                    strName = "???";
                    story = "HEY YOU BRATS!";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "???";
                    story = "Phillip just rolled his eyes and continued picking the lock.";
                }
            }
            else if (progressStory == 178)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "A large ugly rat hobbles towards us, his face scrunched up in hostility." + Environment.NewLine + "He looked like the type of guy that constantly started bar fights.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Are you always this... flirty?";
                }
            }
            else if (progressStory == 179)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "???";
                    story = "What do you miscreants think you're doing, entering the building like a bunch of criminals?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Oh, are you jealous? Don't worry dude, your type turns me on too-";
                }
            }
            else if (progressStory == 180)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Oh, hello there Dorcas.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 36);
                    strName = "";
                    story = "SNAP";
                }
            }
            else if (progressStory == 181)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Mr. Dolores";
                    story = "That's 'Mr.Dolores' to you, brat.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Whoops~";
                }
            }
            else if (progressStory == 182)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "If you say so.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "Well, the good news is that I unlocked it." + Environment.NewLine + "Bad news is that I kinda broke the lock.";
                }
            }
            else if (progressStory == 183)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "The man ( I think he's a teacher? ) turned toward Phillip and I with and upturned nose.";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Red;
                    labelName.ForeColor = System.Drawing.Color.Red;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Phillip";
                    story = "This thing ain't staying closed anytime soon.";
                }
            }
            else if (progressStory == 184)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Mr. Dolores";
                    story = "Ah, and you're " + Name + " and Phillip, I take it?" + Environment.NewLine + "The two that missed the orientation?";
                }
                else
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "At least now we can get inside and out of this rain.";
                    progressStory = 174;
                    p = 1;
                }
            }
            else if (progressStory == 185)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Y-yes?" + Environment.NewLine + "Owen was with us too-";
            }
            else if (progressStory == 186)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Mr. Dolores";
                story = "Who would have thought that Gerania Academy's new students would be snooping in here this way?" + Environment.NewLine + "Guess I shouldn't be surprised-";
            }
            else if (progressStory == 187)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Actually, all the entrances were locked and we were stuck in the rain." + Environment.NewLine + "A system glitch, I guess?";
            }
            else if (progressStory == 188)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "It'd be great if you'd stop yelling at them for something they couldn't help.";
            }
            else if (progressStory == 189)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Mr. Dolores huffed and shook his head.";
            }
            else if (progressStory == 190)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Mr. Dolores";
                story = "Whatever. At least you folks weren't like that other kid that didn't even show up.";
            }
            else if (progressStory == 191)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Mr. Dolores";
                story = "Here, take your student ID cards and unpack at your dorms." + Environment.NewLine + "And Owen, make yourself useful and be a tour guide or something.";
            }
            else if (progressStory == 192)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Mr. Dolores tossed the ID cards at us and stomped away.";
            }
            else if (progressStory == 193)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Wow... That guy was...";
            }
            else if (progressStory == 194)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "A douche?";
            }
            else if (progressStory == 195)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Eheh, sorry about the first impressions, guys." + Environment.NewLine + "This is a good school, really.";
            }
            else if (progressStory == 196)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Dolores is just a jackass";
            }
            else if (progressStory == 197)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I heaved a tired sigh. It hasn't even been an hour and this school's already been a crazy experience.";
            }
            else if (progressStory == 198)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Shaking my head, I glanced at my ID card";
            }
            else if (progressStory == 199)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Ugh, I probably shouldn't have sent in a selfie as my ID photo. What was I thinking?";
            }
            else if (progressStory == 200)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "By the way, Owen. Could you show us where our dorms are?";
            }
            else if (progressStory == 201)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Of course!" + "And Phillip and I can get some 'roommate bonding' time too~";
            }
            else if (progressStory == 202)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "What?";
            }
            else if (progressStory == 203)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "C'mon buddy, it'll be a good chance to get to know each other!";
            }
            else if (progressStory == 204)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen goes to put a friendly arm around Phillip, but the little guy instantly stiffens";
            }
            else if (progressStory == 205)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "Oh! I just remembered!" + Environment.NewLine + "I have to go to the office for something!";
            }
            else if (progressStory == 206)
            {
                labelStory.ForeColor = System.Drawing.Color.Red;
                labelName.ForeColor = System.Drawing.Color.Red;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Phillip";
                story = "I'll see you guys around!";
            }
            else if (progressStory == 207)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "As Phillip strolls away, Owen stares at his retreating back, deep in thought.";
            }
            else if (progressStory == 208)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Suddenly, I yelp as Owen elbows me playfully.";
            }
            else if (progressStory == 209)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Heh, what a cute guy. Is he single?";
            }
            else if (progressStory == 210)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "Dude, we just met. I don't know anything about him.";
            }
            else if (progressStory == 211)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Oh bummer. Whatever, I'm sure we'll get to know each other real well after a while.";
            }
            else if (progressStory == 212)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Well anyway, I better show you the way to your dorm.";
            }
            else if (progressStory == 213)
            {
                labelStory.ForeColor = System.Drawing.Color.Blue;
                labelName.ForeColor = System.Drawing.Color.Blue;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = Name;
                story = "By the way, why are you the one showing us around? You don't exactly look like a tour guide.";
            }
            else if (progressStory == 214)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "Mmmm...";
            }
            else if (progressStory == 215)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "Owen starts walking down the hall briskly.";
            }
            else if (progressStory == 216)
            {
                labelStory.ForeColor = System.Drawing.Color.Black;
                labelName.ForeColor = System.Drawing.Color.Black;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "";
                story = "I struggled to keep up with his strides.";
            }
            else if (progressStory == 217)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "My dad's this rich dude that contributes a lot to this academy.";
            }
            else if (progressStory == 218)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "I've been here taking private classes for a long time, so I've pretty much turned into the teachers' errand boy.";
            }
            else if (progressStory == 219)
            {
                labelStory.ForeColor = System.Drawing.Color.Orange;
                labelName.ForeColor = System.Drawing.Color.Orange;
                labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                strName = "Owen";
                story = "It's kinda annoying, actually.";
            }
            else if (progressStory == 220)
            {
                btnChoice1.Text = "Wow sounds awful. A rich life full of errands.";
                btnChoice2.Text = "Thanks for the help, though.";
                btnChoice3.Text = "Sorry for the trouble";

                btnChoice1.Visible = true;
                btnChoice2.Visible = true;
                btnChoice3.Visible = true;
            }
            else if (progressStory == 221)
            {
                labelName.Visible = true;
                labelStory.Visible = true;
                btnChoice1.Visible = false;
                btnChoice2.Visible = false;
                labelStoryy.Text = "";
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Wow sounds awful. A rich life full of errands.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "It's probably not the best job, but I'm glad you're here guiding me.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Sorry, I didn't mean to be annoying.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 222)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Oh yes,";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Makes my first day a little less painful. So thanks.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "No no,";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 223)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Oh yes," + Environment.NewLine + "because being rich instantly wipes away any problems life could throw at you.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Haha, meeting people like you make things worth it.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "No no," + Environment.NewLine + "I didn't mean it that way.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 224)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Geez, I didn't mean it like-";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "It's hard to make friends here when everyone thinks I'm a snotty rich kid.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Gah, sorry, I probably sounded like an asshole, didn't I?";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 225)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Yeah yeah, whatever. I don't even care anymore.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "I think you're pretty likeable.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "I don't mind guiding you around at all! It's just that I wish all the teachers would stop treating me so differently.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 226)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Anyway, let's head off to the dorms. Introduction classes are going to start soon.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Maybe most people are just intimidated";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "It's hard to make friends when you're the tour guide all the time, you know?";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 227)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Let's go then.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "Maybe most people are just intimidated." + Environment.NewLine + "because it looks like you're a step above them.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "You make an excellent tour guide, though.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 228)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Just try to keep up. The dorm building is right...";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "I'm not though, not really.";
                }
                else if (p == 3)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Thanks, friendly folks like you make the job more bearable.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 229)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "... right here!";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "The teachers are just afraid to piss me off because my dad sends their paychecks";
                }
                else if (p == 3)
                {
                    p = 1;
                    progressStory = 225;
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 230)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "There's an odd number of students this year, so you get a room all to yourself! Lucky guy you are.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Eh, I really shouldn't be talking about this on your first day.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 231)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "My own room? Sweet.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Thanks for listening though, " + Name + ".";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 232)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Well, you better get unpacked quickly, classes start in about 10 minutes.";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "Really, it means alot.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 233)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Orange;
                    labelName.ForeColor = System.Drawing.Color.Orange;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "Owen";
                    story = "I've got to go myself, so see ya' around kiddo!";
                }
                else if (p == 2)
                {
                    labelStory.ForeColor = System.Drawing.Color.Blue;
                    labelName.ForeColor = System.Drawing.Color.Blue;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = Name;
                    story = "No problem.";
                }
                else { story = "BUG"; }
            }
            else if (progressStory == 234)
            {
                if (p == 1)
                {
                    labelStory.ForeColor = System.Drawing.Color.Black;
                    labelName.ForeColor = System.Drawing.Color.Black;
                    labelStory.Font = new Font(labelStory.Font.FontFamily, 20);
                    strName = "";
                    story = "I down my bags and sink into the bed, sighing at the comfort.";
                }
                else if (p == 2)
                {
                    p = 1;
                    progressStory = 225;
                }
                else { story = "BUG"; }
            }

            else { }
            labelStory.Text = "" + story;
            labelName.Text = "" + strName;

        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            p = 1;

            labelStoryy.Visible = true;
            button1.Visible = true;

            labelStoryy.Text = "Select choice 1 : '" + btnChoice1.Text + "' ?";
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            p = 2;

            labelStoryy.Visible = true;
            button1.Visible = true;

            labelStoryy.Text = "Select choice 2 : '" + btnChoice2.Text + "' ?";
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            p = 3;


            labelStoryy.Visible = true;
            button1.Visible = true;

            labelStoryy.Text = "Select choice 3 : '" + btnChoice3.Text + "' ?";
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            p = 4;


            labelStoryy.Visible = true;
            button1.Visible = true;

            labelStoryy.Text = "Select choice 4 : '" + btnChoice4.Text + "' ?";
        }

        private void btnChoice5_Click(object sender, EventArgs e)
        {
            p = 5;


            labelStoryy.Visible = true;
            button1.Visible = true;

            labelStoryy.Text = "Select choice 5 : '" + btnChoice5.Text + "' ?";
        }

        private void labelStoryy_Click(object sender, EventArgs e)
        {

        }
    }
}
