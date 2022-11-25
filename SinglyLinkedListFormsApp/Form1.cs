using System;
using System.Windows.Forms;

namespace SinglyLinkedListFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Node
        {
            public String name;
            public String surname;
            public int no;
            public Node next;
        }
        Node first = null;

        private void Add(object sender, EventArgs e)
        {

            Node newNode = new Node();
            newNode.name = nameTextBar.Text;
            newNode.surname = surNameTextBar.Text;
            newNode.no = Convert.ToInt32(noTextBar.Text);
            if (first == null) // if List is empty
            {
                newNode.next = null;
                first = newNode;
            }
            else if (first.no > newNode.no)
            {
                newNode.next = first;
                first = newNode;
            }
            else
            {
                Node find = first;
                while (find.next != null)
                {
                    if (find.next.no > newNode.no)
                    {
                        break;
                    }
                    find = find.next;
                }
                newNode.next = find.next;
                find.next = newNode;
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            Node delete = first;
            Node deleteprev = delete;
            if (first == null)
            {
                MessageBox.Show("List is empty.There is nothing to delete!");
            }
            else if (first.no == Convert.ToInt32(noTextBar.Text))
            {
                first = first.next;

            }
            else 
            {
                while (delete != null)
                {
                    if (delete.no == Convert.ToInt32(noTextBar.Text))
                    {
                        deleteprev.next = delete.next;
                        delete.next = null;
                        break;
                    }
                    deleteprev = delete;
                    delete = delete.next;
                }
            }
        }

        private void Show(object sender, EventArgs e)
        {
            List.Text = null;
            Node show = first;
            if (show == null)
            {
                MessageBox.Show("List is empty.There is nothing to show!");
            }
            else
            {
                while (show != null)
                {
                    List.Text += show.name + ":" + show.surname + ":" + show.no + "-->";
                    show = show.next;
                }
            }

        }
    }
}
