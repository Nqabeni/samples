﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class Form1: Form
{
 protected TextBox textBox1;
// <Snippet1>
private void CreateTextDataObject() {
    // Creates a new data object using a string.
    string myString = "My text string";
    DataObject myDataObject = new DataObject(myString);
 
    // Prints the string in a text box.
    textBox1.Text = myDataObject.GetData(DataFormats.Text).ToString();
 }
 
// </Snippet1>
}
