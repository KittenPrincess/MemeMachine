using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public int numTEMP;
    public int numSRC;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DropDownList1.Items.Add("Select A Source");
            DropDownList1.Items.Add("Spongebob Window");
            DropDownList1.Items.Add("Pepsi Dog");
            DropDownList1.Items.Add("Garfield");
            DropDownList1.Items.Add("Sneaky");
            DropDownList1.Items.Add("Jensen");
            DropDownList1.Items.Add("Dino George");
            DropDownList1.Items.Add("Bold & Brash");
            DropDownList1.Items.Add("Cool Dude");
            DropDownList1.Items.Add("Imaqtpie");
            DropDownList1.Items.Add("Dabbing Pikachu");
            DropDownList1.Items.Add("Sweater Patrick");
            DropDownList1.Items.Add("George Costanza");
            DropDownList1.Items.Add("Knife Dog");
            DropDownList1.Items.Add("Falling Spongebob");
            DropDownList1.Items.Add("Fast Boy");
            DropDownList1.Items.Add("Spongebob Lips");
            DropDownList1.Items.Add("Bubba");
            DropDownList1.Items.Add("Clothed Dog");
            DropDownList1.Items.Add("Lawbringer");
            DropDownList1.Items.Add("Daniel");
            DropDownList1.Items.Add("Jazz Cat");
            DropDownList1.Items.Add("Squidward");
            DropDownList1.Items.Add("Homicidal Grandma");
            DropDownList1.Items.Add("Pizza Boy");
            DropDownList1.Items.Add("Singing Iguana");
            DropDownList1.Items.Add("Donkey Kong");

            DropDownList2.Items.Add("Select A Template");
            DropDownList2.Items.Add("Follow You Are Dreams");
            DropDownList2.Items.Add("Home Alone");
            DropDownList2.Items.Add("Hiroshima");
            DropDownList2.Items.Add("Time Magazine");
            DropDownList2.Items.Add("The Real Enemy");
            DropDownList2.Items.Add("Nothing's Perfect");
            DropDownList2.Items.Add("Amazon");
            DropDownList2.Items.Add("Hitler");
            DropDownList2.Items.Add("3 Drinks Later");
            DropDownList2.Items.Add("Drake");
            DropDownList2.Items.Add("Woke");
            DropDownList2.Items.Add("Pope");
            DropDownList2.Items.Add("Tattoo");
            DropDownList2.Items.Add("Meme Jake");
            DropDownList2.Items.Add("3:00 AM");
            DropDownList2.Items.Add("Meet Her");
            DropDownList2.Items.Add("President");
            DropDownList2.Items.Add("420");
            DropDownList2.Items.Add("Obama Is Gay");
            DropDownList2.Items.Add("Squidward's TV");
            DropDownList2.Items.Add("I Love You Too");
            DropDownList2.Items.Add("Constitution");



        }
    }

        protected void DropDownList1_Change(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedIndex != 0)
            srcImg.ImageUrl = "~/Images/src" + (DropDownList1.SelectedIndex - 1) + ".png";
    }

    protected void DropDownList2_Change(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex != 0)
        {
            tempImg.ImageUrl = "~/Images/temp" + (DropDownList2.SelectedIndex - 1) + ".png";
            numTEMP = (DropDownList2.SelectedIndex - 1);
            tempSwitch();
            
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        Random random1 = new Random();
        numTEMP = random1.Next(0, 21);
        numSRC = random1.Next(0, 26);

        tempImg.ImageUrl = "~/Images/temp" + numTEMP.ToString() + ".png";
        srcImg.ImageUrl = "~/Images/src" + numSRC.ToString() + ".png";



        tempSwitch();



    }

    protected void boilerPlate()
    {
        srcImg.Style.Add("position", "absolute");
        srcImg.Style.Add("TOP", "0px");
        srcImg.Style.Add("LEFT", "0px");
        srcImg.Style.Add("WIDTH", "0px");
        srcImg.Style.Add("HEIGHT", "0px");
        srcImg.Style.Add("z-index", "+1");

        tempImg.Style.Add("position", "absolute");
        tempImg.Style.Add("WIDTH", "0px");
        tempImg.Style.Add("HEIGHT", "0px");
        tempImg.Style.Add("TOP", "0px");
        tempImg.Style.Add("LEFT", "0px");
    }


    protected void tempSwitch()
    {
        switch (numTEMP)
        {
            case 0:
                boilerPlate();
                srcImg.Style.Add("TOP", "200px");
                srcImg.Style.Add("LEFT", "575px");
                srcImg.Style.Add("WIDTH", "500px");
                srcImg.Style.Add("HEIGHT", "420px");
                srcImg.Style.Add("z-index", "-1");

                tempImg.Style.Add("WIDTH", "300px");
                tempImg.Style.Add("HEIGHT", "50px");
                tempImg.Style.Add("TOP", "550px");
                tempImg.Style.Add("LEFT", "775px");
                break;

            case 1:
                whenYouMeme();
                break;

            case 2:
                whenYouMeme();
                srcImg.Style.Add("TOP", "310px");
                break;

            case 3:
                boilerPlate();
                srcImg.Style.Add("TOP", "330px");
                srcImg.Style.Add("LEFT", "690px");
                srcImg.Style.Add("WIDTH", "320px");
                srcImg.Style.Add("HEIGHT", "340px");

                tempImg.Style.Add("WIDTH", "380px");
                tempImg.Style.Add("HEIGHT", "508px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "653px");

                break;

            case 4:
                boilerPlate();
                srcImg.Style.Add("TOP", "465px");
                srcImg.Style.Add("LEFT", "683px");
                srcImg.Style.Add("WIDTH", "200px");
                srcImg.Style.Add("HEIGHT", "180px");

                tempImg.Style.Add("WIDTH", "380px");
                tempImg.Style.Add("HEIGHT", "475px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "653px");

                break;

            case 5:
                boilerPlate();
                srcImg.Style.Add("TOP", "240px");
                srcImg.Style.Add("LEFT", "853px");
                srcImg.Style.Add("WIDTH", "200px");
                srcImg.Style.Add("HEIGHT", "220px");

                tempImg.Style.Add("WIDTH", "480px");
                tempImg.Style.Add("HEIGHT", "424px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "600px");

                break;

            case 6:
                boilerPlate();
                srcImg.Style.Add("TOP", "345px");
                srcImg.Style.Add("LEFT", "700px");
                srcImg.Style.Add("WIDTH", "240px");
                srcImg.Style.Add("HEIGHT", "215px");

                tempImg.Style.Add("WIDTH", "550px");
                tempImg.Style.Add("HEIGHT", "400px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "560px");

                break;

            case 7:
                boilerPlate();
                srcImg.Style.Add("TOP", "450px");
                srcImg.Style.Add("LEFT", "36%");
                srcImg.Style.Add("WIDTH", "248px");
                srcImg.Style.Add("HEIGHT", "230px");

                tempImg.Style.Add("WIDTH", "480px");
                tempImg.Style.Add("HEIGHT", "482px");
                tempImg.Style.Add("TOP", "200px");
                tempImg.Style.Add("LEFT", "36%");

                break;

            case 8:
                whenYouMeme();
                srcImg.Style.Add("TOP", "360px");
                srcImg.Style.Add("LEFT", "655px");
                srcImg.Style.Add("WIDTH", "350px");
                srcImg.Style.Add("HEIGHT", "310px");

                break;


            case 9:
                boilerPlate();
                srcImg.Style.Add("TOP", "345px");
                srcImg.Style.Add("LEFT", "800px");
                srcImg.Style.Add("WIDTH", "200px");
                srcImg.Style.Add("HEIGHT", "175px");

                tempImg.Style.Add("WIDTH", "550px");
                tempImg.Style.Add("HEIGHT", "400px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "560px");

                break;

            case 10:
                boilerPlate();
                srcImg.Style.Add("TOP", "450px");
                srcImg.Style.Add("LEFT", "36%");
                srcImg.Style.Add("WIDTH", "248px");
                srcImg.Style.Add("HEIGHT", "230px");

                tempImg.Style.Add("WIDTH", "480px");
                tempImg.Style.Add("HEIGHT", "482px");
                tempImg.Style.Add("TOP", "200px");
                tempImg.Style.Add("LEFT", "36%");

                break;

            case 11:
                boilerPlate();
                srcImg.Style.Add("TOP", "240px");
                srcImg.Style.Add("LEFT", "675px");
                srcImg.Style.Add("WIDTH", "100px");
                srcImg.Style.Add("HEIGHT", "85px");

                tempImg.Style.Add("WIDTH", "580px");
                tempImg.Style.Add("HEIGHT", "420px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "540px");

                break;

            case 12:
                boilerPlate();
                srcImg.Style.Add("TOP", "425px");
                srcImg.Style.Add("LEFT", "968px");
                srcImg.Style.Add("WIDTH", "165px");
                srcImg.Style.Add("HEIGHT", "150px");

                tempImg.Style.Add("WIDTH", "600px");
                tempImg.Style.Add("HEIGHT", "430px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "535px");

                break;

            case 13:
                boilerPlate();
                srcImg.Style.Add("TOP", "340px");
                srcImg.Style.Add("LEFT", "793.5px");
                srcImg.Style.Add("WIDTH", "100px");
                srcImg.Style.Add("HEIGHT", "100px");

                tempImg.Style.Add("WIDTH", "550px");
                tempImg.Style.Add("HEIGHT", "400px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "560px");

                break;

            case 14:
                whenYouMeme();
                srcImg.Style.Add("TOP", "290px");

                break;

            case 15:
                whenYouMeme();
                srcImg.Style.Add("TOP", "195px");
                srcImg.Style.Add("LEFT", "635px");
                srcImg.Style.Add("WIDTH", "385px");
                srcImg.Style.Add("HEIGHT", "330px");

                break;

            case 16:
                whenYouMeme();
                srcImg.Style.Add("WIDTH", "415px");
                srcImg.Style.Add("HEIGHT", "345px");
                srcImg.Style.Add("TOP", "320px");
                srcImg.Style.Add("LEFT", "615px");
                break;

            case 17:
                boilerPlate();
                srcImg.Style.Add("TOP", "200px");
                srcImg.Style.Add("LEFT", "575px");
                srcImg.Style.Add("WIDTH", "500px");
                srcImg.Style.Add("HEIGHT", "420px");
                srcImg.Style.Add("z-index", "-1");

                tempImg.Style.Add("WIDTH", "500px");
                tempImg.Style.Add("HEIGHT", "100px");
                tempImg.Style.Add("TOP", "615px");
                tempImg.Style.Add("LEFT", "575px");
                break;


            case 18:
                boilerPlate();
                srcImg.Style.Add("TOP", "538px");
                srcImg.Style.Add("LEFT", "654px");
                srcImg.Style.Add("WIDTH", "65px");
                srcImg.Style.Add("HEIGHT", "110px");

                tempImg.Style.Add("WIDTH", "380px");
                tempImg.Style.Add("HEIGHT", "475px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "653px");

                break;

            case 19:
                boilerPlate();
                srcImg.Style.Add("TOP", "325px");
                srcImg.Style.Add("LEFT", "840px");
                srcImg.Style.Add("WIDTH", "120px");
                srcImg.Style.Add("HEIGHT", "140px");

                tempImg.Style.Add("WIDTH", "480px");
                tempImg.Style.Add("HEIGHT", "424px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "600px");

                break;

            case 20:
                boilerPlate();
                srcImg.Style.Add("TOP", "260px");
                srcImg.Style.Add("LEFT", "665px");
                srcImg.Style.Add("WIDTH", "320px");
                srcImg.Style.Add("HEIGHT", "340px");

                tempImg.Style.Add("WIDTH", "400px");
                tempImg.Style.Add("HEIGHT", "508px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "653px");

                break;

            case 21:
                boilerPlate();
                srcImg.Style.Add("TOP", "240px");
                srcImg.Style.Add("LEFT", "690px");
                srcImg.Style.Add("WIDTH", "100px");
                srcImg.Style.Add("HEIGHT", "100px");

                tempImg.Style.Add("WIDTH", "550px");
                tempImg.Style.Add("HEIGHT", "400px");
                tempImg.Style.Add("TOP", "180px");
                tempImg.Style.Add("LEFT", "560px");

                break;

        }
    }


    protected void whenYouMeme() {
        boilerPlate();
        srcImg.Style.Add("TOP", "300px");
        srcImg.Style.Add("LEFT", "615px");
        srcImg.Style.Add("WIDTH", "430px");
        srcImg.Style.Add("HEIGHT", "365px");
        
        tempImg.Style.Add("WIDTH", "500px");
        tempImg.Style.Add("HEIGHT", "500px");
        tempImg.Style.Add("TOP", "180px");
        tempImg.Style.Add("LEFT", "580px");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Change Source Only
        Random random1 = new Random();
        numSRC = random1.Next(0, 26);
        
        srcImg.ImageUrl = "~/Images/src" + numSRC.ToString() + ".png";

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Change Template Only

        Random random1 = new Random();
        numTEMP = random1.Next(0, 21);

        tempImg.ImageUrl = "~/Images/temp" + numTEMP.ToString() + ".png";

        tempSwitch();
    }
}