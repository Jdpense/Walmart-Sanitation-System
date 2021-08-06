using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Main container

namespace JP_Capstone_CSIS484
{
    public partial class body : Form
    {
        // Create an instance of the debug window class
        debug_Window debug = new debug_Window();
        // change this button to "1" to enable debug mode
        int debug_mode = 0;

        // Initate arrays of the labels
        String[,] textBoxLabelArr = { /* Main Menu */     { "Total Scanned: ", "", "Total Virus Strains Found: ", "" }, 
                                      /* Scan Progress */ { "Scan Progress: ", "Number of Strains Spotted: ", "Found Strains: ", "Product Name: "}, 
                                      /* Contacts*/       { "Phone: ", "Company: ", "Address: ", ""}, 
                                      /* Product List */  { "Product Name:", "Number of possible Strains:", "", "List of Products: "},
                                      /* Unused */        { "Product Address: ", "Manufacturer: ", "Producer: ", "Copy Right: "},
                                      /* Login */         { "User Name: ", "Password: ", " ", " "},
                                      /* Register */      { "User Name: ", "Password: ", " ", " "} };

String[] menuTitles = { "Main Menu", "Scan Progress", "Contacts", "Product List", "Unused", "Login", "Register"};

        // Initate the arrays and variables for the virus strains and products
        String[] currentScannedStrains = { "None" };
        String[] StrainsPool = { "None", "229E", "NL63", "OC43", "HKU1", "MERS-CoV", "SARS-CoV", "SARS-CoV-2" };
        List<String> ProductList = new List<string>(new string[] { "Deli", "Produce", "Dairy", "Bakery", "Bread", "Beverages", "General Grocery" });
        List <int> VirusList = new List<int>(new int[] { 0, 2, 1, 2, 3, 5, 6 });  // The list of after being scanned
        int virusFound = 0;
        int totalVirusesFound = 0;
        int currentlySelected_Strand = 0;

        // Initate the contact info for the strings 
        String phone_Number = "(479)273-0060";
        String company = "Walmart";
        String address = "Bentonville, AR";

        // Initate misc varibles 
        int totalCasesScanned = 0;
        int menuPage = 5;
        int totalProducts = 7;
        int totalStrands = 7;
        bool txtbeChanged = false;
        String productAddress = "";
        String productManufacturer = "";
        String productProducer = "";
        String productCopyRightDate = "";
        String prev_Productlist_Txt = " ";
        String username = "";
        String password = "";
        bool accMade = false;

        // Initate main class constructor 
        public body()
        {
            InitializeComponent();
        }

        // Initiate and setup the main body
        // along with the menus
        public void Form1_Load(object sender, EventArgs e)
        {
            // Load password and user information 
            // into the string variables 
            if (File.Exists("useraccount.pas"))
            {
                using (StreamReader accLoad = new StreamReader("useraccount.pas"))
                {
                    username = accLoad.ReadLine();
                    password = accLoad.ReadLine();
                }
                    accMade = true;
            }
            // Otherwise leave them blank
            // And claim that there is no account made
            else 
            {
                accMade = false;
            }
            chngPage(menuPage);
            txtbeChanged = true;
            CreateSelectionBoxList();
            updateBigTextBox();

            if (debug_mode == 1)
            {
                debug.Show();
            }
            else 
            {
                debug.Hide();
            }
            // update general info for debug mode
            if (debug_mode == 1)
            {
                debug.updateContactInfo(phone_Number, company, address);
            }

        }

        // This method changes everything to a certain page 
        // based on the button that was pressed
        // which is completed through a switch statement
        public void chngPage(int pageNumber)
        {

            switch (pageNumber)
            {
                // Scan project page
                case 1:
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = true;
                    productInfo_Button.Visible = true;
                    product_ScanProgress.Visible = true;
                    contacts.Visible = true;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = true;
                    scanProduct.Visible = true;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = false;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = false;
                    infoBox_TopMid.Enabled = false;
                    infoBox_BotMid.Visible = true;
                    infoBox_Bottom.Visible = false;
                    infoBox_Bottom.Enabled = false;
                    infoBox_BotMid.Enabled = false;
                    selectionBox_Menu.Visible = true;
                    arrowLeft.Visible = true;
                    arrowRight.Visible = true;
                    product_TxtBoxList.Visible = false;
                    virusFound = 0;
                    infoBox_TopMid.Text = virusFound.ToString();
                    scan_Progress.Value = 0;
                    currentlySelected_Strand = 0;
                    infoBox_BotMid.Text = currentScannedStrains[0];
                    infoBox_TopMid.UseSystemPasswordChar = false;
                    menuPage = 1;
                    break;
                // Contact info page
                case 2:
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = true;
                    productInfo_Button.Visible = true;
                    product_ScanProgress.Visible = true;
                    contacts.Visible = true;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = false;
                    infoBox_TopMid.Enabled = false;
                    infoBox_BotMid.Visible = true;
                    infoBox_Bottom.Visible = false;
                    infoBox_Bottom.Enabled = false;
                    infoBox_BotMid.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    product_TxtBoxList.Visible = false;
                    infoBox_Top.Text = phone_Number;
                    infoBox_TopMid.Text = company;
                    infoBox_BotMid.Text = address;
                    infoBox_TopMid.UseSystemPasswordChar = false;
                    menuPage = 2;
                    break;
               // Product list page
                case 3:
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = true;
                    productInfo_Button.Visible = true;
                    product_ScanProgress.Visible = true;
                    contacts.Visible = true;
                    add_ProductButton.Visible = true;
                    save_Button.Visible = true;
                    load_Button.Visible = true;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = true;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = true;
                    infoBox_TopMid.Enabled = true;
                    infoBox_BotMid.Visible = false;
                    infoBox_Bottom.Visible = false;
                    infoBox_BotMid.Enabled = false;
                    infoBox_Bottom.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    product_TxtBoxList.Visible = true;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    infoBox_Top.Text = "";
                    infoBox_TopMid.Text = "";
                    infoBox_TopMid.UseSystemPasswordChar = false;
                    menuPage = 3;
                    break;
                // Unused
                case 4:
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = true;
                    productInfo_Button.Visible = true;
                    product_ScanProgress.Visible = true;
                    contacts.Visible = true;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = false;
                    infoBox_TopMid.Enabled = false;
                    infoBox_BotMid.Visible = true;
                    infoBox_Bottom.Visible = true;
                    infoBox_BotMid.Enabled = false;
                    infoBox_Bottom.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    product_TxtBoxList.Visible = false;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    infoBox_Top.Text = productAddress;
                    infoBox_TopMid.Text = productManufacturer;
                    infoBox_BotMid.Text = productProducer;
                    infoBox_Bottom.Text = productCopyRightDate;
                    infoBox_TopMid.UseSystemPasswordChar = false;
                    menuPage = 4;
                    break;
                // Login
                case 5:
                    infoBox_Top.Text = "";
                    infoBox_TopMid.Text = "";
                    login_button.Visible = true;
                    register_button.Visible = true;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = false;
                    productInfo_Button.Visible = false;
                    product_ScanProgress.Visible = false;
                    contacts.Visible = false;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = true;
                    infoBox_TopMid.Enabled = true;
                    infoBox_BotMid.Visible = false;
                    infoBox_Bottom.Visible = false;
                    infoBox_BotMid.Enabled = false;
                    infoBox_Bottom.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    product_TxtBoxList.Visible = false;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    infoBox_TopMid.UseSystemPasswordChar = true;
                    menuPage = 5;
                    break;
                // Register
                case 6:
                    infoBox_Top.Text = "";
                    infoBox_TopMid.Text = "";
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = true;
                    createAcc_button.Visible = true;
                    main_Menu.Visible = false;
                    productInfo_Button.Visible = false;
                    product_ScanProgress.Visible = false;
                    contacts.Visible = false;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = true;
                    infoBox_Top.Enabled = true;
                    infoBox_TopMid.Enabled = true;
                    infoBox_BotMid.Visible = false;
                    infoBox_Bottom.Visible = false;
                    infoBox_BotMid.Enabled = true;
                    infoBox_Bottom.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    product_TxtBoxList.Visible = false;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    infoBox_TopMid.UseSystemPasswordChar = true;
                    menuPage = 6;
                    break;
                // Main menu page
                default:
                    login_button.Visible = false;
                    register_button.Visible = false;
                    log_button2.Visible = false;
                    createAcc_button.Visible = false;
                    main_Menu.Visible = true;
                    productInfo_Button.Visible = true;
                    product_ScanProgress.Visible = true;
                    contacts.Visible = true;
                    add_ProductButton.Visible = false;
                    save_Button.Visible = false;
                    load_Button.Visible = false;
                    scan_Progress.Visible = false;
                    scanProduct.Visible = false;
                    updateContact_Info.Visible = false;
                    delete_button.Visible = false;
                    infoBox_Top.Visible = true;
                    infoBox_TopMid.Visible = false;
                    infoBox_Top.Enabled = false;
                    infoBox_TopMid.Enabled = false;
                    infoBox_BotMid.Visible = true;
                    infoBox_Bottom.Visible = false;
                    infoBox_BotMid.Enabled = false;
                    infoBox_Bottom.Enabled = false;
                    selectionBox_Menu.Visible = false;
                    product_TxtBoxList.Visible = false;
                    arrowLeft.Visible = false;
                    arrowRight.Visible = false;
                    infoBox_Top.Text = totalCasesScanned.ToString();
                    infoBox_BotMid.Text = totalVirusesFound.ToString();
                    currentlySelected_Strand = 0;
                    infoBox_TopMid.UseSystemPasswordChar = false;
                    menuPage = 0;
                    break;
                    
            }
            // Swap labels and text box info
            chngLabelText(pageNumber);
            // update page number for menu
            if (debug_mode == 1)
            {
                debug.updatepageNum(menuPage);
            }
        }

        // This method changes the text of the labels whenever the page is change in the application
        public void chngLabelText(int arrtext)
        {
            label_Top.Text = textBoxLabelArr[arrtext, 0];
            label_TopMid.Text = textBoxLabelArr[arrtext, 1];
            label_BotMid.Text = textBoxLabelArr[arrtext, 2];
            label_Bottom.Text = textBoxLabelArr[arrtext, 3];
            // update title of menu based on the page user is on
            menu_Title.Text = menuTitles[arrtext];
        }

        // This method updates the virus strand box through pressing the arrows
        public void strandtextBox(String[] vstrandarr, int total, String sign)
        {
            if (sign == "right")
            {
                if (currentlySelected_Strand < total)
                {
                    currentlySelected_Strand += 1;
                    infoBox_BotMid.Text = vstrandarr[currentlySelected_Strand];
                }
            }

            else
            {
                if (currentlySelected_Strand > 1)
                {
                    currentlySelected_Strand -= 1;
                    infoBox_BotMid.Text = vstrandarr[currentlySelected_Strand];
                }
            }

        }


        // This method creates key pairs for the selection menu box
        // via "for loop"
        public void CreateSelectionBoxList() 
        {
            for (int i = 0; i < totalProducts; i++) 
            {
                addToProductList(i);
            }
        }

        // This method updates the product list by adding items to the list
        public void addToProductList(int index) 
        {
            selectionBox_Menu.Items.Add(new KeyValuePair<string, int>(ProductList[index], index));
            product_TxtBoxList.AppendText(String.Format("{0,-1} , {1,0}", ProductList[index], VirusList[index] + "\r\n"));
        }

        // These methods make the buttons that complete change each element on the page
        private void main_Menu_Click(object sender, EventArgs e)
        {
            chngPage(0);
        }

        private void product_ScanProgress_Click(object sender, EventArgs e)
        {
            chngPage(1);
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            chngPage(2);
        }

        private void productInfo_Button_Click(object sender, EventArgs e)
        {
            chngPage(3);
        }

        // This button looks for information on the product and the strains of virus that it can carry
        private void scanProduct_Click(object sender, EventArgs e)
        {
            // Read and update info from Selection Box
            if (selectionBox_Menu.Text != "")
            {
                scan_Progress.Value = 100;
                virusFound = VirusList[selectionBox_Menu.SelectedIndex];
                infoBox_TopMid.Text = virusFound.ToString();
                // Add to the total cases scanned  
                totalCasesScanned += 1;
                currentScannedStrains = StrainsPool;
                // Check for any found strains of virus otherwise display none
                if (virusFound != 0)
                {
                    currentlySelected_Strand = 1;
                    infoBox_BotMid.Text = currentScannedStrains[currentlySelected_Strand];
                }

                else
                {
                    currentlySelected_Strand = 0;
                    infoBox_BotMid.Text = currentScannedStrains[currentlySelected_Strand];
                }
                    
                // Add up to the total of viruses found
                    totalVirusesFound += virusFound;
                // update total info for debug mode
                if (debug_mode == 1)
                {
                    debug.updateTotalInfo(totalCasesScanned, totalVirusesFound);
                }
             
            }
            



        }
        // This button updates the contact info
        private void updateContact_Info_Click(object sender, EventArgs e)
        {

        }

        // These buttons scroll the virus strand arrays
        private void arrowRight_Click(object sender, EventArgs e)
        {
            chkMenuPageforStrandArr("right");
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
            chkMenuPageforStrandArr("left");
        }
        // This method checks whether to use the total strand array or the currently scanned one
        public void chkMenuPageforStrandArr(String sign)
        { 
                strandtextBox(currentScannedStrains, virusFound, sign);
        }
        // This method resets the stores values to zero when selection is changed
        private void selectionBox_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            virusFound = 0;
            currentlySelected_Strand = 0;
            infoBox_TopMid.Text = virusFound.ToString();
            infoBox_BotMid.Text = currentScannedStrains[0];
            scan_Progress.Value = 0;
        }

        private void scan_Progress_Click(object sender, EventArgs e)
        {

        }
        // Prevent the list from being modified
        private void product_TxtBoxList_TextChanged(object sender, EventArgs e)
        {
            if (txtbeChanged == false) 
            { 
                product_TxtBoxList.Text = prev_Productlist_Txt;
            }
                
        }
        // This button adds the product and virus to the list
        // as long as the text fields have vaild infomation 
        private void add_ProductButton_Click(object sender, EventArgs e)
        {
            // Create a new form class to represent the error message
            ErrorMsg_Body msg = new ErrorMsg_Body();
            // Check for any blanks in either text boxes
            if (String.IsNullOrWhiteSpace(infoBox_Top.Text))
            {
                msg.SetMsgText("You must enter a valid product name!");
                msg.Show();
            }

            else if (convertStringtoInt(infoBox_TopMid.Text) > totalStrands)
            {
                msg.SetMsgText("Number of virus strands exceed the possible number of 7!");
                msg.Show();
            }

            else
            {
                txtbeChanged = true;
                // add another element to the arrays to avoid
                // an out of bounds exception
                ProductList.Add(infoBox_Top.Text);
                VirusList.Add(convertStringtoInt(infoBox_TopMid.Text)); 
                addToProductList(totalProducts);
                // increase total number of products stored
                totalProducts += 1;
                updateBigTextBox();
            }
        }

        // This method updates updates the big textbox
        public void updateBigTextBox() 
        {
            // Store the product list in a var for future reasons 
            prev_Productlist_Txt = product_TxtBoxList.Text;
            txtbeChanged = false;
        }

        // Checks for any blank textboxes or invaild chars and assumes that they are a zero
        public int convertStringtoInt(String textnum)
        {
            int num = 0;
            bool vaildInt = int.TryParse(textnum, out num);
            if (vaildInt == true)
            {
                num = Int32.Parse(textnum);
            }

            return num;
        }

        // Converts the numbers back to a String for the textbox object's format
        public String convertInttoString(int num)
        {
            string newText = num.ToString();
            return newText;
        }
        // These functions save and load product data
        private void save_Button_Click(object sender, EventArgs e)
        {
            // Initate file dialogue
            // Along with the title and filter list
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Product List";
            save.Filter = "Product List Files (*.vpl)|*.vpl";
            // Check to see if the "OK" button was pressed 
            // Execute the Saving sequence 
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Save product data into file
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(product_TxtBoxList.Text);
                // Delete the save class to prevent errors
                write.Dispose();
            }
        }

        private void load_Button_Click(object sender, EventArgs e)
        {
            // Initate file dialogue
            // Along with the title and filter list
            OpenFileDialog load = new OpenFileDialog();
            load.Title = "Open Product List";
            load.Filter = "Product List Files (*.vpl)|*.vpl";

            // Check to see if the "OK" button was pressed 
            // Execute the loading sequence 
            if (load.ShowDialog() == DialogResult.OK) {

                // Extract product data from file
                // Place loaded data in a class
                StreamReader read = new StreamReader(File.OpenRead(load.FileName));

                // Convert and input the data into the strings and arrays 
                // Replacing the old data
                txtbeChanged = true;
                ProductList.Clear();
                VirusList.Clear();
                selectionBox_Menu.Items.Clear();
                product_TxtBoxList.Clear();
                selectionBox_Menu.Text = "";
                totalProducts = 0;
                String text = "";
                int number = 0;
                int totalProducts_Debug = 0;
                // Iniate the new lines array 
                // To extract data from the file
                String line;
                List<String> line_List = new List<string>(new string[] { });

                // Loop through the saved file
                // To retrieve all the important data
                // Place each line to a list as it's own element
                while ((line = read.ReadLine()) != null)
                    {
                    line_List.Add(line);
                    totalProducts_Debug += 1;
                    }

               if (debug_mode == 1)
                   {
                    // Display the list in the debugger
                     debug.updateProductNumList(totalProducts_Debug, line_List);
                    }

                // Extra from the loaded data list to the main list
                // Using embedded for loops
                foreach (String s in line_List)
                {                    
                    text = "";
                    bool wordComplete = false;
                    for (int counter = 0; counter < s.Length; counter++)
                    {
                        // If the product name was completely spelled out
                        // Then skip the check
                        if (wordComplete == false)
                        {
                            if (s[counter] != ' ' | s[counter+1] != ',')
                            {
                                text += s[counter].ToString();
                            }

                            else
                            {
                                wordComplete = true;
                            }
                        }

                        else
                        {
                            // Break from this embedded loop once the number has been found
                            if (char.IsNumber(s[counter]) == true)
                            {
                                number = convertStringtoInt(s[counter].ToString());
                                VirusList.Add(number);
                                ProductList.Add(text);
                                addToProductList(totalProducts);
                                totalProducts += 1;
                                break;
                            }
                        }
                    }
                }

                updateBigTextBox();
                // Delete the loaded class to prevent errors
                read.Dispose();
            }
        }

        // This is for the register and login pages
        private void login_button_Click(object sender, EventArgs e)
        {
            // Create a new form class to represent the error message
            ErrorMsg_Body msg = new ErrorMsg_Body();

            // Check for the created account
            if (accMade == false)
            {
                msg.SetMsgText("No account made! Please make one!");
                msg.Show();
            }

            // Check for the correct username
            else if (infoBox_Top.Text != username) 
            {
                msg.SetMsgText("Incorrect username!");
                msg.Show();
            }

            // Check for the correct password
            else if (infoBox_TopMid.Text != password) 
            {
                msg.SetMsgText("Incorrect password!");
                msg.Show();
            }

            // Otherwise load page
            else
            {
                chngPage(0);
            }
           
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            chngPage(6);
        }

        private void createAcc_button_Click(object sender, EventArgs e)
        {
            // Create a new form class to represent the error message
            ErrorMsg_Body msg = new ErrorMsg_Body();
            // Check for any blanks in either text boxes
            if (String.IsNullOrWhiteSpace(infoBox_Top.Text))
            {
                msg.SetMsgText("You must enter a username!");
                msg.Show();
            }

            else if (String.IsNullOrWhiteSpace(infoBox_TopMid.Text)) 
            {
                msg.SetMsgText("You must enter a password!");
                msg.Show();
            }

            else
            {
                // Save useraccount and password to an embbeded file
                using (StreamWriter accSave = new StreamWriter("useraccount.pas"))
                {
                    accSave.WriteLine(infoBox_Top.Text);
                    accSave.WriteLine(infoBox_TopMid.Text);
                }
                // Bring users to the main page
                chngPage(0);
            }
        }

        private void log_button2_Click(object sender, EventArgs e)
        {
            chngPage(5);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // Clear List
            txtbeChanged = true;
            ProductList.Clear();
            VirusList.Clear();
            selectionBox_Menu.Items.Clear();
            product_TxtBoxList.Clear();
            selectionBox_Menu.Text = "";
            totalProducts = 0;
            updateBigTextBox();
        }
    }
}
