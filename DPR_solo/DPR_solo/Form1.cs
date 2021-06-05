using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPR_solo
{
    public partial class Form1 : Form
    {
        ConcreteDistributorReceiver d;
        int nameCount;
        bool startDistribution;
        string curentclient;
        FashionPublisherFactoryInvoker lastFashionCreated;
        SportPublisherFactoryInvoker lastSportCreated;
        public Form1()
        {
            InitializeComponent();
            d = new ConcreteDistributorReceiver("Stefan's Distribution Company");
            lblDistributor.Text = d.Name;
            rbtnIndividual.Checked=true;
            nameCount = 0;
            startDistribution = false;
            curentclient = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (rbtnIndividual.Checked)
            {
                if (String.IsNullOrEmpty(txbFN.Text) || String.IsNullOrEmpty(txbLN.Text) || String.IsNullOrEmpty(txbAddress.Text))
                {
                    MessageBox.Show("Please input firstname,lastname and address");
                }
                else
                {
                    try
                    {
                        curentclient = txbAddress.Text;
                        new IndividualObserver(d, txbFN.Text, txbLN.Text, txbAddress.Text);
                        MessageBox.Show("You have subscribed to " + d.Name);
                        txbFN.Clear();
                        txbLN.Clear();
                        txbAddress.Clear();
                        listBox1.Items.Clear();
                        listBox1.Items.Add(curentclient);
                        
                    }
                    catch(Exception) 
                    {
                        MessageBox.Show("This address is already subscribed");
                    }
                }
            }

            if (rbtnOrganization.Checked)
            {
                if (String.IsNullOrEmpty(txbCN.Text) || String.IsNullOrEmpty(txbAddress.Text))
                {
                    MessageBox.Show("Please input the name of your organization and address");
                }
                else
                {
                    try
                    {
                        curentclient = txbAddress.Text;
                        new OrganizationObserver(d, txbCN.Text, txbAddress.Text);
                        MessageBox.Show("You have subscribed to " + d.Name);
                        txbCN.Clear();
                        txbAddress.Clear();
                        listBox1.Items.Clear();
                        listBox1.Items.Add(curentclient);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This address is already subscribed");
                    }
                }
            }
            timer1.Enabled = true;
        }

        private void btnUnsub_Click(object sender, EventArgs e)
        {
            if (rbtnIndividual.Checked)
            {
                if (String.IsNullOrEmpty(txbAddress.Text))
                {
                    MessageBox.Show("Please input your postcode");
                }
                else
                {
                    try
                    {
                        IObserver client = d.GetSubscriber(txbAddress.Text);
                        curentclient = client.Address;
                        d.Detach(client);
                        MessageBox.Show("You have unsubscribed from " + d.Name);
                        txbAddress.Clear();
                        listBox1.Items.Clear();
                        listBox1.Items.Add(curentclient);
                    }
                    catch(Exception) 
                    {
                        MessageBox.Show("There is no subscribtion on this address");
                    }
                }
            }
        }

        private void rbtnIndividual_CheckedChanged(object sender, EventArgs e)
        {
            lblFN.Visible = true;
            lblLN.Visible = true;
            txbFN.Visible = true;
            txbLN.Visible = true;

            lblCN.Visible = false;
            txbCN.Visible = false;
        }

        private void rbtnOrganization_CheckedChanged(object sender, EventArgs e)
        {
            lblFN.Visible = false;
            lblLN.Visible = false;
            txbFN.Visible = false;
            txbLN.Visible = false;

            lblCN.Visible = true;
            txbCN.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FashionPublisherFactoryInvoker fashionPublisher;
            SportPublisherFactoryInvoker sportPublisher;

            if (!startDistribution)
            {
                fashionPublisher = new FashionPublisherFactoryInvoker(" Fashion Publisher: " + ++nameCount);
                
                lastFashionCreated = fashionPublisher;

                fashionPublisher.CreateMagazine();
                fashionPublisher.CreateNewspaper();
                fashionPublisher.ChangeDistributionStatus(new StartDistributionCommand(d));

                if (d.GetSubscriber(curentclient) != null)
                    listBox1.Items.Add(d.PublisherState);

                sportPublisher = new SportPublisherFactoryInvoker(" Sport Publisher: " + nameCount);
                
                lastSportCreated = sportPublisher;
                
                sportPublisher.CreateNewspaper();
                sportPublisher.CreateMagazine();
                sportPublisher.ChangeDistributionStatus(new StartDistributionCommand(d));

                if(d.GetSubscriber(curentclient)!=null)
                    listBox1.Items.Add(d.PublisherState);

                startDistribution = true;
            }
            else
            {
                lastFashionCreated.ChangeDistributionStatus(new StopDistributionCommand(d));

                if (d.GetSubscriber(curentclient) != null)
                    listBox1.Items.Add(d.PublisherState);

                lastSportCreated.ChangeDistributionStatus(new StopDistributionCommand(d));

                if (d.GetSubscriber(curentclient) != null)
                    listBox1.Items.Add(d.PublisherState);

                startDistribution = false;
            }
        }
    }
}
