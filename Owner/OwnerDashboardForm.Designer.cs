namespace CarRentalManagementSystem.Owner
{
    partial class OwnerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label lblProfileIcon;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerRole;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyCars;
        private System.Windows.Forms.Button btnOwnerBookings;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSidebarQuote;

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel heroPanel;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblHeroCarIcon;

        private System.Windows.Forms.Panel totalCarsCard;
        private System.Windows.Forms.Label lblTotalCarsIcon;
        private System.Windows.Forms.Label lblTotalCarsTitle;
        private System.Windows.Forms.Label lblTotalCars;
        private System.Windows.Forms.Label lblTotalCarsDescription;

        private System.Windows.Forms.Panel availableCarsCard;
        private System.Windows.Forms.Label lblAvailableCarsIcon;
        private System.Windows.Forms.Label lblAvailableCarsTitle;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.Label lblAvailableCarsDescription;

        private System.Windows.Forms.Panel rentedCarsCard;
        private System.Windows.Forms.Label lblRentedCarsIcon;
        private System.Windows.Forms.Label lblRentedCarsTitle;
        private System.Windows.Forms.Label lblRentedCars;
        private System.Windows.Forms.Label lblRentedCarsDescription;

        private System.Windows.Forms.Panel earningsCard;
        private System.Windows.Forms.Label lblEarningsIcon;
        private System.Windows.Forms.Label lblEarningsTitle;
        private System.Windows.Forms.Label lblTotalEarnings;
        private System.Windows.Forms.Label lblEarningsDescription;

        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Label lblPendingIcon;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingBookings;
        private System.Windows.Forms.Label lblPendingDescription;

        private System.Windows.Forms.Panel vehicleStatusPanel;
        private System.Windows.Forms.Label lblVehicleStatusTitle;
        private System.Windows.Forms.Label lblVehicleStatusSubtitle;
        private System.Windows.Forms.Panel vehicleChartPanel;
        private System.Windows.Forms.Label lblAvailableLegend;
        private System.Windows.Forms.Label lblAvailableLegendValue;
        private System.Windows.Forms.Label lblRentedLegend;
        private System.Windows.Forms.Label lblRentedLegendValue;
        private System.Windows.Forms.Label lblInactiveLegend;
        private System.Windows.Forms.Label lblInactiveLegendValue;

        private System.Windows.Forms.Panel earningsOverviewPanel;
        private System.Windows.Forms.Label lblEarningsOverviewTitle;
        private System.Windows.Forms.Label lblEarningsOverviewSubtitle;
        private System.Windows.Forms.ComboBox cmbEarningsPeriod;
        private System.Windows.Forms.Panel earningsChartPanel;

        private System.Windows.Forms.Panel quickActionsPanel;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnViewEarnings;

        private System.Windows.Forms.Panel recentBookingsPanel;
        private System.Windows.Forms.Label lblRecentBookingsTitle;
        private System.Windows.Forms.Label lblRecentBookingsSubtitle;
        private System.Windows.Forms.Button btnViewAllBookings;
        private System.Windows.Forms.DataGridView dgvRecentBookings;

        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Button btnViewAllActivity;
        private System.Windows.Forms.Panel activityItem1;
        private System.Windows.Forms.Panel activityItem2;
        private System.Windows.Forms.Panel activityItem3;
        private System.Windows.Forms.Panel activityItem4;
        private System.Windows.Forms.Label lblActivityIcon1;
        private System.Windows.Forms.Label lblActivityIcon2;
        private System.Windows.Forms.Label lblActivityIcon3;
        private System.Windows.Forms.Label lblActivityIcon4;
        private System.Windows.Forms.Label lblActivityText1;
        private System.Windows.Forms.Label lblActivityText2;
        private System.Windows.Forms.Label lblActivityText3;
        private System.Windows.Forms.Label lblActivityText4;
        private System.Windows.Forms.Label lblActivityTime1;
        private System.Windows.Forms.Label lblActivityTime2;
        private System.Windows.Forms.Label lblActivityTime3;
        private System.Windows.Forms.Label lblActivityTime4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.lblBrandIcon = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.lblProfileIcon = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerRole = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMyCars = new System.Windows.Forms.Button();
            this.btnOwnerBookings = new System.Windows.Forms.Button();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSidebarQuote = new System.Windows.Forms.Label();

            this.contentPanel = new System.Windows.Forms.Panel();
            this.heroPanel = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblHeroCarIcon = new System.Windows.Forms.Label();

            this.totalCarsCard = new System.Windows.Forms.Panel();
            this.lblTotalCarsIcon = new System.Windows.Forms.Label();
            this.lblTotalCarsTitle = new System.Windows.Forms.Label();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.lblTotalCarsDescription = new System.Windows.Forms.Label();

            this.availableCarsCard = new System.Windows.Forms.Panel();
            this.lblAvailableCarsIcon = new System.Windows.Forms.Label();
            this.lblAvailableCarsTitle = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.lblAvailableCarsDescription = new System.Windows.Forms.Label();

            this.rentedCarsCard = new System.Windows.Forms.Panel();
            this.lblRentedCarsIcon = new System.Windows.Forms.Label();
            this.lblRentedCarsTitle = new System.Windows.Forms.Label();
            this.lblRentedCars = new System.Windows.Forms.Label();
            this.lblRentedCarsDescription = new System.Windows.Forms.Label();

            this.earningsCard = new System.Windows.Forms.Panel();
            this.lblEarningsIcon = new System.Windows.Forms.Label();
            this.lblEarningsTitle = new System.Windows.Forms.Label();
            this.lblTotalEarnings = new System.Windows.Forms.Label();
            this.lblEarningsDescription = new System.Windows.Forms.Label();

            this.pendingCard = new System.Windows.Forms.Panel();
            this.lblPendingIcon = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingBookings = new System.Windows.Forms.Label();
            this.lblPendingDescription = new System.Windows.Forms.Label();

            this.vehicleStatusPanel = new System.Windows.Forms.Panel();
            this.lblVehicleStatusTitle = new System.Windows.Forms.Label();
            this.lblVehicleStatusSubtitle = new System.Windows.Forms.Label();
            this.vehicleChartPanel = new System.Windows.Forms.Panel();
            this.lblAvailableLegend = new System.Windows.Forms.Label();
            this.lblAvailableLegendValue = new System.Windows.Forms.Label();
            this.lblRentedLegend = new System.Windows.Forms.Label();
            this.lblRentedLegendValue = new System.Windows.Forms.Label();
            this.lblInactiveLegend = new System.Windows.Forms.Label();
            this.lblInactiveLegendValue = new System.Windows.Forms.Label();

            this.earningsOverviewPanel = new System.Windows.Forms.Panel();
            this.lblEarningsOverviewTitle = new System.Windows.Forms.Label();
            this.lblEarningsOverviewSubtitle = new System.Windows.Forms.Label();
            this.cmbEarningsPeriod = new System.Windows.Forms.ComboBox();
            this.earningsChartPanel = new System.Windows.Forms.Panel();

            this.quickActionsPanel = new System.Windows.Forms.Panel();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnViewEarnings = new System.Windows.Forms.Button();

            this.recentBookingsPanel = new System.Windows.Forms.Panel();
            this.lblRecentBookingsTitle = new System.Windows.Forms.Label();
            this.lblRecentBookingsSubtitle = new System.Windows.Forms.Label();
            this.btnViewAllBookings = new System.Windows.Forms.Button();
            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();

            this.activityPanel = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.btnViewAllActivity = new System.Windows.Forms.Button();
            this.activityItem1 = new System.Windows.Forms.Panel();
            this.activityItem2 = new System.Windows.Forms.Panel();
            this.activityItem3 = new System.Windows.Forms.Panel();
            this.activityItem4 = new System.Windows.Forms.Panel();
            this.lblActivityIcon1 = new System.Windows.Forms.Label();
            this.lblActivityIcon2 = new System.Windows.Forms.Label();
            this.lblActivityIcon3 = new System.Windows.Forms.Label();
            this.lblActivityIcon4 = new System.Windows.Forms.Label();
            this.lblActivityText1 = new System.Windows.Forms.Label();
            this.lblActivityText2 = new System.Windows.Forms.Label();
            this.lblActivityText3 = new System.Windows.Forms.Label();
            this.lblActivityText4 = new System.Windows.Forms.Label();
            this.lblActivityTime1 = new System.Windows.Forms.Label();
            this.lblActivityTime2 = new System.Windows.Forms.Label();
            this.lblActivityTime3 = new System.Windows.Forms.Label();
            this.lblActivityTime4 = new System.Windows.Forms.Label();

            this.sidebarPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.heroPanel.SuspendLayout();
            this.totalCarsCard.SuspendLayout();
            this.availableCarsCard.SuspendLayout();
            this.rentedCarsCard.SuspendLayout();
            this.earningsCard.SuspendLayout();
            this.pendingCard.SuspendLayout();
            this.vehicleStatusPanel.SuspendLayout();
            this.earningsOverviewPanel.SuspendLayout();
            this.quickActionsPanel.SuspendLayout();
            this.recentBookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            this.activityPanel.SuspendLayout();
            this.activityItem1.SuspendLayout();
            this.activityItem2.SuspendLayout();
            this.activityItem3.SuspendLayout();
            this.activityItem4.SuspendLayout();
            this.SuspendLayout();

            // SIDEBAR
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(19, 45, 76);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(243, 987);
            this.sidebarPanel.TabIndex = 0;

            this.lblBrandIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 34F);
            this.lblBrandIcon.ForeColor = System.Drawing.Color.FromArgb(0, 140, 255);
            this.lblBrandIcon.Location = new System.Drawing.Point(76, 18);
            this.lblBrandIcon.Name = "lblBrandIcon";
            this.lblBrandIcon.Size = new System.Drawing.Size(91, 60);
            this.lblBrandIcon.Text = "🚗";
            this.lblBrandIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(20, 78);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(203, 35);
            this.lblBrand.Text = "CAR RENTAL";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(190, 210, 232);
            this.lblBrandSubtitle.Location = new System.Drawing.Point(20, 112);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(203, 28);
            this.lblBrandSubtitle.Text = "Owner Panel";
            this.lblBrandSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.profilePanel.BackColor = System.Drawing.Color.Transparent;
            this.profilePanel.Location = new System.Drawing.Point(20, 145);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(203, 105);
            this.profilePanel.TabIndex = 0;

            this.lblProfileIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 34F);
            this.lblProfileIcon.ForeColor = System.Drawing.Color.White;
            this.lblProfileIcon.Location = new System.Drawing.Point(4, 13);
            this.lblProfileIcon.Name = "lblProfileIcon";
            this.lblProfileIcon.Size = new System.Drawing.Size(65, 65);
            this.lblProfileIcon.Text = "👤";
            this.lblProfileIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblOwnerName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblOwnerName.ForeColor = System.Drawing.Color.White;
            this.lblOwnerName.Location = new System.Drawing.Point(72, 21);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(125, 28);
            this.lblOwnerName.Text = "Owner Name";

            this.lblOwnerRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOwnerRole.ForeColor = System.Drawing.Color.FromArgb(190, 210, 232);
            this.lblOwnerRole.Location = new System.Drawing.Point(72, 50);
            this.lblOwnerRole.Name = "lblOwnerRole";
            this.lblOwnerRole.Size = new System.Drawing.Size(125, 25);
            this.lblOwnerRole.Text = "Car Owner";

            this.profilePanel.Controls.Add(this.lblProfileIcon);
            this.profilePanel.Controls.Add(this.lblOwnerName);
            this.profilePanel.Controls.Add(this.lblOwnerRole);

            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(21, 108, 190);
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 125, 205);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(10, 270);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(223, 50);
            this.btnDashboard.Text = "⌂    Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            this.btnMyCars.BackColor = System.Drawing.Color.Transparent;
            this.btnMyCars.FlatAppearance.BorderSize = 0;
            this.btnMyCars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 108, 175);
            this.btnMyCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCars.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyCars.ForeColor = System.Drawing.Color.White;
            this.btnMyCars.Location = new System.Drawing.Point(10, 330);
            this.btnMyCars.Name = "btnMyCars";
            this.btnMyCars.Size = new System.Drawing.Size(223, 50);
            this.btnMyCars.Text = "🚗   Manage My Cars";
            this.btnMyCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyCars.UseVisualStyleBackColor = false;
            this.btnMyCars.Click += new System.EventHandler(this.btnMyCars_Click);

            this.btnOwnerBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnOwnerBookings.FlatAppearance.BorderSize = 0;
            this.btnOwnerBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 108, 175);
            this.btnOwnerBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerBookings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOwnerBookings.ForeColor = System.Drawing.Color.White;
            this.btnOwnerBookings.Location = new System.Drawing.Point(10, 390);
            this.btnOwnerBookings.Name = "btnOwnerBookings";
            this.btnOwnerBookings.Size = new System.Drawing.Size(223, 50);
            this.btnOwnerBookings.Text = "▣    View Bookings";
            this.btnOwnerBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOwnerBookings.UseVisualStyleBackColor = false;
            this.btnOwnerBookings.Click += new System.EventHandler(this.btnOwnerBookings_Click);

            this.btnEarnings.BackColor = System.Drawing.Color.Transparent;
            this.btnEarnings.FlatAppearance.BorderSize = 0;
            this.btnEarnings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 108, 175);
            this.btnEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarnings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEarnings.ForeColor = System.Drawing.Color.White;
            this.btnEarnings.Location = new System.Drawing.Point(10, 450);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(223, 50);
            this.btnEarnings.Text = "▥    Earnings";
            this.btnEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEarnings.UseVisualStyleBackColor = false;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);

            this.btnOffers.BackColor = System.Drawing.Color.Transparent;
            this.btnOffers.FlatAppearance.BorderSize = 0;
            this.btnOffers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 108, 175);
            this.btnOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOffers.ForeColor = System.Drawing.Color.White;
            this.btnOffers.Location = new System.Drawing.Point(10, 510);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(223, 50);
            this.btnOffers.Text = "◆    My Offers";
            this.btnOffers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);

            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 108, 175);
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(10, 600);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(223, 50);
            this.btnSettings.Text = "⚙    Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(175, 45, 55);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 660);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 50);
            this.btnLogout.Text = "◉    Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.lblSidebarQuote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSidebarQuote.ForeColor = System.Drawing.Color.FromArgb(110, 165, 210);
            this.lblSidebarQuote.Location = new System.Drawing.Point(25, 875);
            this.lblSidebarQuote.Name = "lblSidebarQuote";
            this.lblSidebarQuote.Size = new System.Drawing.Size(193, 55);
            this.lblSidebarQuote.Text = "Drive Together\r\nfor a Better Tomorrow";
            this.lblSidebarQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.sidebarPanel.Controls.Add(this.lblBrandIcon);
            this.sidebarPanel.Controls.Add(this.lblBrand);
            this.sidebarPanel.Controls.Add(this.lblBrandSubtitle);
            this.sidebarPanel.Controls.Add(this.profilePanel);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnMyCars);
            this.sidebarPanel.Controls.Add(this.btnOwnerBookings);
            this.sidebarPanel.Controls.Add(this.btnEarnings);
            this.sidebarPanel.Controls.Add(this.btnOffers);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.lblSidebarQuote);

            // CONTENT
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(244, 248, 252);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(243, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1293, 987);
            this.contentPanel.TabIndex = 1;

            // HERO
            this.heroPanel.BackColor = System.Drawing.Color.FromArgb(239, 247, 255);
            this.heroPanel.Location = new System.Drawing.Point(0, 0);
            this.heroPanel.Name = "heroPanel";
            this.heroPanel.Size = new System.Drawing.Size(1293, 170);
            this.heroPanel.TabIndex = 0;

            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblPageTitle.Location = new System.Drawing.Point(30, 35);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(850, 55);
            this.lblPageTitle.Text = "Welcome back, Owner! 👋";

            this.lblWelcome.Visible = false;

            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(47, 73, 115);
            this.lblSubtitle.Location = new System.Drawing.Point(31, 91);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(700, 30);
            this.lblSubtitle.Text = "Manage your cars, track bookings and grow your business.";

            this.lblHeroCarIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 66F);
            this.lblHeroCarIcon.ForeColor = System.Drawing.Color.FromArgb(20, 80, 130);
            this.lblHeroCarIcon.Location = new System.Drawing.Point(1010, 27);
            this.lblHeroCarIcon.Name = "lblHeroCarIcon";
            this.lblHeroCarIcon.Size = new System.Drawing.Size(230, 110);
            this.lblHeroCarIcon.Text = "🚗";
            this.lblHeroCarIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.heroPanel.Controls.Add(this.lblPageTitle);
            this.heroPanel.Controls.Add(this.lblWelcome);
            this.heroPanel.Controls.Add(this.lblSubtitle);
            this.heroPanel.Controls.Add(this.lblHeroCarIcon);

            // STAT CARD 1
            this.totalCarsCard.BackColor = System.Drawing.Color.FromArgb(225, 241, 255);
            this.totalCarsCard.Location = new System.Drawing.Point(25, 185);
            this.totalCarsCard.Name = "totalCarsCard";
            this.totalCarsCard.Size = new System.Drawing.Size(220, 145);
            this.totalCarsCard.TabIndex = 1;

            this.lblTotalCarsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 23F);
            this.lblTotalCarsIcon.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.lblTotalCarsIcon.Location = new System.Drawing.Point(16, 15);
            this.lblTotalCarsIcon.Name = "lblTotalCarsIcon";
            this.lblTotalCarsIcon.Size = new System.Drawing.Size(55, 48);
            this.lblTotalCarsIcon.Text = "🚗";
            this.lblTotalCarsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTotalCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCarsTitle.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.lblTotalCarsTitle.Location = new System.Drawing.Point(78, 20);
            this.lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            this.lblTotalCarsTitle.Size = new System.Drawing.Size(130, 25);
            this.lblTotalCarsTitle.Text = "Total Cars";

            this.lblTotalCars.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTotalCars.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblTotalCars.Location = new System.Drawing.Point(78, 48);
            this.lblTotalCars.Name = "lblTotalCars";
            this.lblTotalCars.Size = new System.Drawing.Size(125, 50);
            this.lblTotalCars.Text = "0";

            this.lblTotalCarsDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalCarsDescription.ForeColor = System.Drawing.Color.FromArgb(42, 70, 110);
            this.lblTotalCarsDescription.Location = new System.Drawing.Point(16, 111);
            this.lblTotalCarsDescription.Name = "lblTotalCarsDescription";
            this.lblTotalCarsDescription.Size = new System.Drawing.Size(190, 25);
            this.lblTotalCarsDescription.Text = "All registered vehicles";

            this.totalCarsCard.Controls.Add(this.lblTotalCarsIcon);
            this.totalCarsCard.Controls.Add(this.lblTotalCarsTitle);
            this.totalCarsCard.Controls.Add(this.lblTotalCars);
            this.totalCarsCard.Controls.Add(this.lblTotalCarsDescription);

            // STAT CARD 2
            this.availableCarsCard.BackColor = System.Drawing.Color.FromArgb(225, 250, 240);
            this.availableCarsCard.Location = new System.Drawing.Point(267, 185);
            this.availableCarsCard.Name = "availableCarsCard";
            this.availableCarsCard.Size = new System.Drawing.Size(220, 145);
            this.availableCarsCard.TabIndex = 2;

            this.lblAvailableCarsIcon.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCarsIcon.ForeColor = System.Drawing.Color.FromArgb(0, 150, 75);
            this.lblAvailableCarsIcon.Location = new System.Drawing.Point(16, 14);
            this.lblAvailableCarsIcon.Name = "lblAvailableCarsIcon";
            this.lblAvailableCarsIcon.Size = new System.Drawing.Size(55, 50);
            this.lblAvailableCarsIcon.Text = "✓";
            this.lblAvailableCarsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblAvailableCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCarsTitle.ForeColor = System.Drawing.Color.FromArgb(0, 150, 75);
            this.lblAvailableCarsTitle.Location = new System.Drawing.Point(78, 20);
            this.lblAvailableCarsTitle.Name = "lblAvailableCarsTitle";
            this.lblAvailableCarsTitle.Size = new System.Drawing.Size(130, 25);
            this.lblAvailableCarsTitle.Text = "Available Cars";

            this.lblAvailableCars.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCars.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblAvailableCars.Location = new System.Drawing.Point(78, 48);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(125, 50);
            this.lblAvailableCars.Text = "0";

            this.lblAvailableCarsDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAvailableCarsDescription.ForeColor = System.Drawing.Color.FromArgb(42, 70, 110);
            this.lblAvailableCarsDescription.Location = new System.Drawing.Point(16, 111);
            this.lblAvailableCarsDescription.Name = "lblAvailableCarsDescription";
            this.lblAvailableCarsDescription.Size = new System.Drawing.Size(190, 25);
            this.lblAvailableCarsDescription.Text = "Ready for rent";

            this.availableCarsCard.Controls.Add(this.lblAvailableCarsIcon);
            this.availableCarsCard.Controls.Add(this.lblAvailableCarsTitle);
            this.availableCarsCard.Controls.Add(this.lblAvailableCars);
            this.availableCarsCard.Controls.Add(this.lblAvailableCarsDescription);

            // STAT CARD 3
            this.rentedCarsCard.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.rentedCarsCard.Location = new System.Drawing.Point(509, 185);
            this.rentedCarsCard.Name = "rentedCarsCard";
            this.rentedCarsCard.Size = new System.Drawing.Size(220, 145);
            this.rentedCarsCard.TabIndex = 3;

            this.lblRentedCarsIcon.Font = new System.Drawing.Font("Segoe UI", 27F);
            this.lblRentedCarsIcon.ForeColor = System.Drawing.Color.FromArgb(245, 105, 0);
            this.lblRentedCarsIcon.Location = new System.Drawing.Point(16, 14);
            this.lblRentedCarsIcon.Name = "lblRentedCarsIcon";
            this.lblRentedCarsIcon.Size = new System.Drawing.Size(55, 50);
            this.lblRentedCarsIcon.Text = "◷";
            this.lblRentedCarsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblRentedCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRentedCarsTitle.ForeColor = System.Drawing.Color.FromArgb(245, 105, 0);
            this.lblRentedCarsTitle.Location = new System.Drawing.Point(78, 20);
            this.lblRentedCarsTitle.Name = "lblRentedCarsTitle";
            this.lblRentedCarsTitle.Size = new System.Drawing.Size(130, 25);
            this.lblRentedCarsTitle.Text = "Currently Rented";

            this.lblRentedCars.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblRentedCars.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblRentedCars.Location = new System.Drawing.Point(78, 48);
            this.lblRentedCars.Name = "lblRentedCars";
            this.lblRentedCars.Size = new System.Drawing.Size(125, 50);
            this.lblRentedCars.Text = "0";

            this.lblRentedCarsDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRentedCarsDescription.ForeColor = System.Drawing.Color.FromArgb(42, 70, 110);
            this.lblRentedCarsDescription.Location = new System.Drawing.Point(16, 111);
            this.lblRentedCarsDescription.Name = "lblRentedCarsDescription";
            this.lblRentedCarsDescription.Size = new System.Drawing.Size(190, 25);
            this.lblRentedCarsDescription.Text = "In active bookings";

            this.rentedCarsCard.Controls.Add(this.lblRentedCarsIcon);
            this.rentedCarsCard.Controls.Add(this.lblRentedCarsTitle);
            this.rentedCarsCard.Controls.Add(this.lblRentedCars);
            this.rentedCarsCard.Controls.Add(this.lblRentedCarsDescription);

            // STAT CARD 4
            this.earningsCard.BackColor = System.Drawing.Color.FromArgb(239, 232, 255);
            this.earningsCard.Location = new System.Drawing.Point(751, 185);
            this.earningsCard.Name = "earningsCard";
            this.earningsCard.Size = new System.Drawing.Size(220, 145);
            this.earningsCard.TabIndex = 4;

            this.lblEarningsIcon.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblEarningsIcon.ForeColor = System.Drawing.Color.FromArgb(105, 55, 220);
            this.lblEarningsIcon.Location = new System.Drawing.Point(16, 14);
            this.lblEarningsIcon.Name = "lblEarningsIcon";
            this.lblEarningsIcon.Size = new System.Drawing.Size(55, 50);
            this.lblEarningsIcon.Text = "৳";
            this.lblEarningsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblEarningsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEarningsTitle.ForeColor = System.Drawing.Color.FromArgb(105, 55, 220);
            this.lblEarningsTitle.Location = new System.Drawing.Point(78, 20);
            this.lblEarningsTitle.Name = "lblEarningsTitle";
            this.lblEarningsTitle.Size = new System.Drawing.Size(130, 25);
            this.lblEarningsTitle.Text = "Total Earnings";

            this.lblTotalEarnings.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalEarnings.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblTotalEarnings.Location = new System.Drawing.Point(78, 49);
            this.lblTotalEarnings.Name = "lblTotalEarnings";
            this.lblTotalEarnings.Size = new System.Drawing.Size(135, 48);
            this.lblTotalEarnings.Text = "৳0";

            this.lblEarningsDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEarningsDescription.ForeColor = System.Drawing.Color.FromArgb(42, 70, 110);
            this.lblEarningsDescription.Location = new System.Drawing.Point(16, 111);
            this.lblEarningsDescription.Name = "lblEarningsDescription";
            this.lblEarningsDescription.Size = new System.Drawing.Size(190, 25);
            this.lblEarningsDescription.Text = "From completed bookings";

            this.earningsCard.Controls.Add(this.lblEarningsIcon);
            this.earningsCard.Controls.Add(this.lblEarningsTitle);
            this.earningsCard.Controls.Add(this.lblTotalEarnings);
            this.earningsCard.Controls.Add(this.lblEarningsDescription);

            // STAT CARD 5
            this.pendingCard.BackColor = System.Drawing.Color.FromArgb(255, 231, 236);
            this.pendingCard.Location = new System.Drawing.Point(993, 185);
            this.pendingCard.Name = "pendingCard";
            this.pendingCard.Size = new System.Drawing.Size(220, 145);
            this.pendingCard.TabIndex = 5;

            this.lblPendingIcon.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblPendingIcon.ForeColor = System.Drawing.Color.FromArgb(220, 45, 85);
            this.lblPendingIcon.Location = new System.Drawing.Point(16, 14);
            this.lblPendingIcon.Name = "lblPendingIcon";
            this.lblPendingIcon.Size = new System.Drawing.Size(55, 50);
            this.lblPendingIcon.Text = "▤";
            this.lblPendingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(220, 45, 85);
            this.lblPendingTitle.Location = new System.Drawing.Point(78, 20);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(130, 25);
            this.lblPendingTitle.Text = "Pending Amount";

            this.lblPendingBookings.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblPendingBookings.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblPendingBookings.Location = new System.Drawing.Point(78, 48);
            this.lblPendingBookings.Name = "lblPendingBookings";
            this.lblPendingBookings.Size = new System.Drawing.Size(125, 50);
            this.lblPendingBookings.Text = "0";

            this.lblPendingDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPendingDescription.ForeColor = System.Drawing.Color.FromArgb(42, 70, 110);
            this.lblPendingDescription.Location = new System.Drawing.Point(16, 111);
            this.lblPendingDescription.Name = "lblPendingDescription";
            this.lblPendingDescription.Size = new System.Drawing.Size(190, 25);
            this.lblPendingDescription.Text = "Awaiting payment";

            this.pendingCard.Controls.Add(this.lblPendingIcon);
            this.pendingCard.Controls.Add(this.lblPendingTitle);
            this.pendingCard.Controls.Add(this.lblPendingBookings);
            this.pendingCard.Controls.Add(this.lblPendingDescription);

            // VEHICLE STATUS
            this.vehicleStatusPanel.BackColor = System.Drawing.Color.White;
            this.vehicleStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleStatusPanel.Location = new System.Drawing.Point(25, 350);
            this.vehicleStatusPanel.Name = "vehicleStatusPanel";
            this.vehicleStatusPanel.Size = new System.Drawing.Size(445, 285);
            this.vehicleStatusPanel.TabIndex = 6;

            this.lblVehicleStatusTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblVehicleStatusTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblVehicleStatusTitle.Location = new System.Drawing.Point(18, 14);
            this.lblVehicleStatusTitle.Name = "lblVehicleStatusTitle";
            this.lblVehicleStatusTitle.Size = new System.Drawing.Size(390, 32);
            this.lblVehicleStatusTitle.Text = "Vehicle Status Overview";

            this.lblVehicleStatusSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleStatusSubtitle.ForeColor = System.Drawing.Color.FromArgb(86, 112, 150);
            this.lblVehicleStatusSubtitle.Location = new System.Drawing.Point(19, 45);
            this.lblVehicleStatusSubtitle.Name = "lblVehicleStatusSubtitle";
            this.lblVehicleStatusSubtitle.Size = new System.Drawing.Size(390, 25);
            this.lblVehicleStatusSubtitle.Text = "A quick look at your fleet status";

            this.vehicleChartPanel.Location = new System.Drawing.Point(12, 75);
            this.vehicleChartPanel.Name = "vehicleChartPanel";
            this.vehicleChartPanel.Size = new System.Drawing.Size(220, 190);
            this.vehicleChartPanel.TabIndex = 0;
            this.vehicleChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.vehicleChartPanel_Paint);

            this.lblAvailableLegend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailableLegend.ForeColor = System.Drawing.Color.FromArgb(25, 50, 100);
            this.lblAvailableLegend.Location = new System.Drawing.Point(245, 104);
            this.lblAvailableLegend.Name = "lblAvailableLegend";
            this.lblAvailableLegend.Size = new System.Drawing.Size(100, 25);
            this.lblAvailableLegend.Text = "●  Available";

            this.lblAvailableLegendValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailableLegendValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblAvailableLegendValue.Location = new System.Drawing.Point(345, 104);
            this.lblAvailableLegendValue.Name = "lblAvailableLegendValue";
            this.lblAvailableLegendValue.Size = new System.Drawing.Size(85, 25);
            this.lblAvailableLegendValue.Text = "0 (0%)";

            this.lblRentedLegend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRentedLegend.ForeColor = System.Drawing.Color.FromArgb(25, 50, 100);
            this.lblRentedLegend.Location = new System.Drawing.Point(245, 145);
            this.lblRentedLegend.Name = "lblRentedLegend";
            this.lblRentedLegend.Size = new System.Drawing.Size(100, 25);
            this.lblRentedLegend.Text = "●  Rented";

            this.lblRentedLegendValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentedLegendValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblRentedLegendValue.Location = new System.Drawing.Point(345, 145);
            this.lblRentedLegendValue.Name = "lblRentedLegendValue";
            this.lblRentedLegendValue.Size = new System.Drawing.Size(85, 25);
            this.lblRentedLegendValue.Text = "0 (0%)";

            this.lblInactiveLegend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInactiveLegend.ForeColor = System.Drawing.Color.FromArgb(25, 50, 100);
            this.lblInactiveLegend.Location = new System.Drawing.Point(245, 186);
            this.lblInactiveLegend.Name = "lblInactiveLegend";
            this.lblInactiveLegend.Size = new System.Drawing.Size(100, 25);
            this.lblInactiveLegend.Text = "●  Inactive";

            this.lblInactiveLegendValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInactiveLegendValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblInactiveLegendValue.Location = new System.Drawing.Point(345, 186);
            this.lblInactiveLegendValue.Name = "lblInactiveLegendValue";
            this.lblInactiveLegendValue.Size = new System.Drawing.Size(85, 25);
            this.lblInactiveLegendValue.Text = "0 (0%)";

            this.vehicleStatusPanel.Controls.Add(this.lblVehicleStatusTitle);
            this.vehicleStatusPanel.Controls.Add(this.lblVehicleStatusSubtitle);
            this.vehicleStatusPanel.Controls.Add(this.vehicleChartPanel);
            this.vehicleStatusPanel.Controls.Add(this.lblAvailableLegend);
            this.vehicleStatusPanel.Controls.Add(this.lblAvailableLegendValue);
            this.vehicleStatusPanel.Controls.Add(this.lblRentedLegend);
            this.vehicleStatusPanel.Controls.Add(this.lblRentedLegendValue);
            this.vehicleStatusPanel.Controls.Add(this.lblInactiveLegend);
            this.vehicleStatusPanel.Controls.Add(this.lblInactiveLegendValue);

            // EARNINGS OVERVIEW
            this.earningsOverviewPanel.BackColor = System.Drawing.Color.White;
            this.earningsOverviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.earningsOverviewPanel.Location = new System.Drawing.Point(485, 350);
            this.earningsOverviewPanel.Name = "earningsOverviewPanel";
            this.earningsOverviewPanel.Size = new System.Drawing.Size(410, 285);
            this.earningsOverviewPanel.TabIndex = 7;

            this.lblEarningsOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblEarningsOverviewTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblEarningsOverviewTitle.Location = new System.Drawing.Point(18, 14);
            this.lblEarningsOverviewTitle.Name = "lblEarningsOverviewTitle";
            this.lblEarningsOverviewTitle.Size = new System.Drawing.Size(230, 32);
            this.lblEarningsOverviewTitle.Text = "Earnings Overview";

            this.lblEarningsOverviewSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEarningsOverviewSubtitle.ForeColor = System.Drawing.Color.FromArgb(86, 112, 150);
            this.lblEarningsOverviewSubtitle.Location = new System.Drawing.Point(19, 45);
            this.lblEarningsOverviewSubtitle.Name = "lblEarningsOverviewSubtitle";
            this.lblEarningsOverviewSubtitle.Size = new System.Drawing.Size(300, 25);
            this.lblEarningsOverviewSubtitle.Text = "Your earnings from completed bookings";

            this.cmbEarningsPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEarningsPeriod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEarningsPeriod.FormattingEnabled = true;
            this.cmbEarningsPeriod.Items.AddRange(new object[] { "This Month", "Last Month", "This Year" });
            this.cmbEarningsPeriod.Location = new System.Drawing.Point(260, 14);
            this.cmbEarningsPeriod.Name = "cmbEarningsPeriod";
            this.cmbEarningsPeriod.Size = new System.Drawing.Size(125, 28);
            this.cmbEarningsPeriod.TabIndex = 0;
            this.cmbEarningsPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbEarningsPeriod_SelectedIndexChanged);

            this.earningsChartPanel.BackColor = System.Drawing.Color.White;
            this.earningsChartPanel.Location = new System.Drawing.Point(18, 78);
            this.earningsChartPanel.Name = "earningsChartPanel";
            this.earningsChartPanel.Size = new System.Drawing.Size(375, 190);
            this.earningsChartPanel.TabIndex = 1;
            this.earningsChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.earningsChartPanel_Paint);

            this.earningsOverviewPanel.Controls.Add(this.lblEarningsOverviewTitle);
            this.earningsOverviewPanel.Controls.Add(this.lblEarningsOverviewSubtitle);
            this.earningsOverviewPanel.Controls.Add(this.cmbEarningsPeriod);
            this.earningsOverviewPanel.Controls.Add(this.earningsChartPanel);

            // QUICK ACTIONS
            this.quickActionsPanel.BackColor = System.Drawing.Color.White;
            this.quickActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickActionsPanel.Location = new System.Drawing.Point(910, 350);
            this.quickActionsPanel.Name = "quickActionsPanel";
            this.quickActionsPanel.Size = new System.Drawing.Size(358, 285);
            this.quickActionsPanel.TabIndex = 8;

            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(18, 14);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(300, 32);
            this.lblQuickActionsTitle.Text = "Quick Actions";

            this.btnAddNewCar.BackColor = System.Drawing.Color.FromArgb(30, 140, 245);
            this.btnAddNewCar.FlatAppearance.BorderSize = 0;
            this.btnAddNewCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCar.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCar.Location = new System.Drawing.Point(14, 53);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(158, 95);
            this.btnAddNewCar.Text = "⊕\r\nAdd New Car\r\nList a new vehicle";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);

            this.btnManageCars.BackColor = System.Drawing.Color.FromArgb(10, 180, 105);
            this.btnManageCars.FlatAppearance.BorderSize = 0;
            this.btnManageCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCars.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnManageCars.ForeColor = System.Drawing.Color.White;
            this.btnManageCars.Location = new System.Drawing.Point(184, 53);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(158, 95);
            this.btnManageCars.Text = "🚗\r\nManage My Cars\r\nView & edit vehicles";
            this.btnManageCars.UseVisualStyleBackColor = false;
            this.btnManageCars.Click += new System.EventHandler(this.btnMyCars_Click);

            this.btnViewBookings.BackColor = System.Drawing.Color.FromArgb(120, 65, 235);
            this.btnViewBookings.FlatAppearance.BorderSize = 0;
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewBookings.ForeColor = System.Drawing.Color.White;
            this.btnViewBookings.Location = new System.Drawing.Point(14, 160);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(158, 95);
            this.btnViewBookings.Text = "▣\r\nView Bookings\r\nCheck rental bookings";
            this.btnViewBookings.UseVisualStyleBackColor = false;
            this.btnViewBookings.Click += new System.EventHandler(this.btnOwnerBookings_Click);

            this.btnViewEarnings.BackColor = System.Drawing.Color.FromArgb(255, 110, 35);
            this.btnViewEarnings.FlatAppearance.BorderSize = 0;
            this.btnViewEarnings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEarnings.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewEarnings.ForeColor = System.Drawing.Color.White;
            this.btnViewEarnings.Location = new System.Drawing.Point(184, 160);
            this.btnViewEarnings.Name = "btnViewEarnings";
            this.btnViewEarnings.Size = new System.Drawing.Size(158, 95);
            this.btnViewEarnings.Text = "▥\r\nView Earnings\r\nSee detailed report";
            this.btnViewEarnings.UseVisualStyleBackColor = false;
            this.btnViewEarnings.Click += new System.EventHandler(this.btnEarnings_Click);

            this.quickActionsPanel.Controls.Add(this.lblQuickActionsTitle);
            this.quickActionsPanel.Controls.Add(this.btnAddNewCar);
            this.quickActionsPanel.Controls.Add(this.btnManageCars);
            this.quickActionsPanel.Controls.Add(this.btnViewBookings);
            this.quickActionsPanel.Controls.Add(this.btnViewEarnings);

            // RECENT BOOKINGS
            this.recentBookingsPanel.BackColor = System.Drawing.Color.White;
            this.recentBookingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recentBookingsPanel.Location = new System.Drawing.Point(25, 655);
            this.recentBookingsPanel.Name = "recentBookingsPanel";
            this.recentBookingsPanel.Size = new System.Drawing.Size(870, 310);
            this.recentBookingsPanel.TabIndex = 9;

            this.lblRecentBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRecentBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblRecentBookingsTitle.Location = new System.Drawing.Point(18, 14);
            this.lblRecentBookingsTitle.Name = "lblRecentBookingsTitle";
            this.lblRecentBookingsTitle.Size = new System.Drawing.Size(250, 32);
            this.lblRecentBookingsTitle.Text = "Recent Bookings";

            this.lblRecentBookingsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecentBookingsSubtitle.ForeColor = System.Drawing.Color.FromArgb(86, 112, 150);
            this.lblRecentBookingsSubtitle.Location = new System.Drawing.Point(19, 45);
            this.lblRecentBookingsSubtitle.Name = "lblRecentBookingsSubtitle";
            this.lblRecentBookingsSubtitle.Size = new System.Drawing.Size(400, 25);
            this.lblRecentBookingsSubtitle.Text = "Latest rental bookings for your vehicles";

            this.btnViewAllBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllBookings.FlatAppearance.BorderSize = 0;
            this.btnViewAllBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewAllBookings.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.btnViewAllBookings.Location = new System.Drawing.Point(695, 15);
            this.btnViewAllBookings.Name = "btnViewAllBookings";
            this.btnViewAllBookings.Size = new System.Drawing.Size(155, 35);
            this.btnViewAllBookings.Text = "View All Bookings →";
            this.btnViewAllBookings.UseVisualStyleBackColor = false;
            this.btnViewAllBookings.Click += new System.EventHandler(this.btnOwnerBookings_Click);

            this.dgvRecentBookings.AllowUserToAddRows = false;
            this.dgvRecentBookings.AllowUserToDeleteRows = false;
            this.dgvRecentBookings.AllowUserToResizeRows = false;
            this.dgvRecentBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = System.Drawing.Color.FromArgb(236, 242, 249),
                Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(11, 30, 70),
                SelectionBackColor = System.Drawing.Color.FromArgb(236, 242, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(11, 30, 70)
            };
            this.dgvRecentBookings.ColumnHeadersHeight = 40;
            this.dgvRecentBookings.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 8.5F),
                ForeColor = System.Drawing.Color.FromArgb(25, 50, 90),
                SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 250),
                SelectionForeColor = System.Drawing.Color.FromArgb(11, 30, 70)
            };
            this.dgvRecentBookings.EnableHeadersVisualStyles = false;
            this.dgvRecentBookings.GridColor = System.Drawing.Color.FromArgb(224, 232, 240);
            this.dgvRecentBookings.Location = new System.Drawing.Point(18, 75);
            this.dgvRecentBookings.MultiSelect = false;
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersVisible = false;
            this.dgvRecentBookings.RowTemplate.Height = 38;
            this.dgvRecentBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentBookings.Size = new System.Drawing.Size(834, 215);
            this.dgvRecentBookings.TabIndex = 2;
            this.dgvRecentBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentBookings_CellContentClick);

            this.recentBookingsPanel.Controls.Add(this.lblRecentBookingsTitle);
            this.recentBookingsPanel.Controls.Add(this.lblRecentBookingsSubtitle);
            this.recentBookingsPanel.Controls.Add(this.btnViewAllBookings);
            this.recentBookingsPanel.Controls.Add(this.dgvRecentBookings);

            // ACTIVITY
            this.activityPanel.BackColor = System.Drawing.Color.White;
            this.activityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityPanel.Location = new System.Drawing.Point(910, 655);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(358, 310);
            this.activityPanel.TabIndex = 10;

            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblActivityTitle.Location = new System.Drawing.Point(18, 14);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(220, 32);
            this.lblActivityTitle.Text = "Recent Activity";

            this.btnViewAllActivity.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllActivity.FlatAppearance.BorderSize = 0;
            this.btnViewAllActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllActivity.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnViewAllActivity.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.btnViewAllActivity.Location = new System.Drawing.Point(275, 15);
            this.btnViewAllActivity.Name = "btnViewAllActivity";
            this.btnViewAllActivity.Size = new System.Drawing.Size(65, 30);
            this.btnViewAllActivity.Text = "View All";
            this.btnViewAllActivity.UseVisualStyleBackColor = false;

            // ACTIVITY ITEM 1
            this.activityItem1.BackColor = System.Drawing.Color.White;
            this.activityItem1.Location = new System.Drawing.Point(10, 55);
            this.activityItem1.Name = "activityItem1";
            this.activityItem1.Size = new System.Drawing.Size(330, 52);

            this.lblActivityIcon1.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblActivityIcon1.ForeColor = System.Drawing.Color.FromArgb(0, 120, 230);
            this.lblActivityIcon1.Location = new System.Drawing.Point(5, 4);
            this.lblActivityIcon1.Name = "lblActivityIcon1";
            this.lblActivityIcon1.Size = new System.Drawing.Size(42, 42);
            this.lblActivityIcon1.Text = "🚗";
            this.lblActivityIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblActivityText1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityText1.ForeColor = System.Drawing.Color.FromArgb(20, 45, 80);
            this.lblActivityText1.Location = new System.Drawing.Point(52, 5);
            this.lblActivityText1.Name = "lblActivityText1";
            this.lblActivityText1.Size = new System.Drawing.Size(190, 38);
            this.lblActivityText1.Text = "New booking received";

            this.lblActivityTime1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblActivityTime1.ForeColor = System.Drawing.Color.FromArgb(80, 105, 140);
            this.lblActivityTime1.Location = new System.Drawing.Point(242, 13);
            this.lblActivityTime1.Name = "lblActivityTime1";
            this.lblActivityTime1.Size = new System.Drawing.Size(75, 25);
            this.lblActivityTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblActivityTime1.Text = "Recent";

            this.activityItem1.Controls.Add(this.lblActivityIcon1);
            this.activityItem1.Controls.Add(this.lblActivityText1);
            this.activityItem1.Controls.Add(this.lblActivityTime1);

            // ACTIVITY ITEM 2
            this.activityItem2.BackColor = System.Drawing.Color.White;
            this.activityItem2.Location = new System.Drawing.Point(10, 112);
            this.activityItem2.Name = "activityItem2";
            this.activityItem2.Size = new System.Drawing.Size(330, 52);

            this.lblActivityIcon2.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblActivityIcon2.ForeColor = System.Drawing.Color.FromArgb(105, 55, 220);
            this.lblActivityIcon2.Location = new System.Drawing.Point(5, 4);
            this.lblActivityIcon2.Name = "lblActivityIcon2";
            this.lblActivityIcon2.Size = new System.Drawing.Size(42, 42);
            this.lblActivityIcon2.Text = "৳";
            this.lblActivityIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblActivityText2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityText2.ForeColor = System.Drawing.Color.FromArgb(20, 45, 80);
            this.lblActivityText2.Location = new System.Drawing.Point(52, 5);
            this.lblActivityText2.Name = "lblActivityText2";
            this.lblActivityText2.Size = new System.Drawing.Size(190, 38);

            this.lblActivityTime2.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblActivityTime2.ForeColor = System.Drawing.Color.FromArgb(80, 105, 140);
            this.lblActivityTime2.Location = new System.Drawing.Point(242, 13);
            this.lblActivityTime2.Name = "lblActivityTime2";
            this.lblActivityTime2.Size = new System.Drawing.Size(75, 25);
            this.lblActivityTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.activityItem2.Controls.Add(this.lblActivityIcon2);
            this.activityItem2.Controls.Add(this.lblActivityText2);
            this.activityItem2.Controls.Add(this.lblActivityTime2);

            // ACTIVITY ITEM 3
            this.activityItem3.BackColor = System.Drawing.Color.White;
            this.activityItem3.Location = new System.Drawing.Point(10, 169);
            this.activityItem3.Name = "activityItem3";
            this.activityItem3.Size = new System.Drawing.Size(330, 52);

            this.lblActivityIcon3.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblActivityIcon3.ForeColor = System.Drawing.Color.FromArgb(0, 120, 230);
            this.lblActivityIcon3.Location = new System.Drawing.Point(5, 4);
            this.lblActivityIcon3.Name = "lblActivityIcon3";
            this.lblActivityIcon3.Size = new System.Drawing.Size(42, 42);
            this.lblActivityIcon3.Text = "🚗";
            this.lblActivityIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblActivityText3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityText3.ForeColor = System.Drawing.Color.FromArgb(20, 45, 80);
            this.lblActivityText3.Location = new System.Drawing.Point(52, 5);
            this.lblActivityText3.Name = "lblActivityText3";
            this.lblActivityText3.Size = new System.Drawing.Size(190, 38);

            this.lblActivityTime3.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblActivityTime3.ForeColor = System.Drawing.Color.FromArgb(80, 105, 140);
            this.lblActivityTime3.Location = new System.Drawing.Point(242, 13);
            this.lblActivityTime3.Name = "lblActivityTime3";
            this.lblActivityTime3.Size = new System.Drawing.Size(75, 25);
            this.lblActivityTime3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.activityItem3.Controls.Add(this.lblActivityIcon3);
            this.activityItem3.Controls.Add(this.lblActivityText3);
            this.activityItem3.Controls.Add(this.lblActivityTime3);

            // ACTIVITY ITEM 4
            this.activityItem4.BackColor = System.Drawing.Color.White;
            this.activityItem4.Location = new System.Drawing.Point(10, 226);
            this.activityItem4.Name = "activityItem4";
            this.activityItem4.Size = new System.Drawing.Size(330, 52);

            this.lblActivityIcon4.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblActivityIcon4.ForeColor = System.Drawing.Color.FromArgb(245, 150, 30);
            this.lblActivityIcon4.Location = new System.Drawing.Point(5, 4);
            this.lblActivityIcon4.Name = "lblActivityIcon4";
            this.lblActivityIcon4.Size = new System.Drawing.Size(42, 42);
            this.lblActivityIcon4.Text = "◆";
            this.lblActivityIcon4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblActivityText4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityText4.ForeColor = System.Drawing.Color.FromArgb(20, 45, 80);
            this.lblActivityText4.Location = new System.Drawing.Point(52, 5);
            this.lblActivityText4.Name = "lblActivityText4";
            this.lblActivityText4.Size = new System.Drawing.Size(190, 38);

            this.lblActivityTime4.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblActivityTime4.ForeColor = System.Drawing.Color.FromArgb(80, 105, 140);
            this.lblActivityTime4.Location = new System.Drawing.Point(242, 13);
            this.lblActivityTime4.Name = "lblActivityTime4";
            this.lblActivityTime4.Size = new System.Drawing.Size(75, 25);
            this.lblActivityTime4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.activityItem4.Controls.Add(this.lblActivityIcon4);
            this.activityItem4.Controls.Add(this.lblActivityText4);
            this.activityItem4.Controls.Add(this.lblActivityTime4);

            this.activityPanel.Controls.Add(this.lblActivityTitle);
            this.activityPanel.Controls.Add(this.btnViewAllActivity);
            this.activityPanel.Controls.Add(this.activityItem1);
            this.activityPanel.Controls.Add(this.activityItem2);
            this.activityPanel.Controls.Add(this.activityItem3);
            this.activityPanel.Controls.Add(this.activityItem4);

            // CONTENT ADD
            this.contentPanel.Controls.Add(this.heroPanel);
            this.contentPanel.Controls.Add(this.totalCarsCard);
            this.contentPanel.Controls.Add(this.availableCarsCard);
            this.contentPanel.Controls.Add(this.rentedCarsCard);
            this.contentPanel.Controls.Add(this.earningsCard);
            this.contentPanel.Controls.Add(this.pendingCard);
            this.contentPanel.Controls.Add(this.vehicleStatusPanel);
            this.contentPanel.Controls.Add(this.earningsOverviewPanel);
            this.contentPanel.Controls.Add(this.quickActionsPanel);
            this.contentPanel.Controls.Add(this.recentBookingsPanel);
            this.contentPanel.Controls.Add(this.activityPanel);

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 248, 252);
            this.ClientSize = new System.Drawing.Size(1536, 987);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OwnerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental Management System";
            this.Load += new System.EventHandler(this.OwnerDashboardForm_Load);

            this.sidebarPanel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.heroPanel.ResumeLayout(false);
            this.totalCarsCard.ResumeLayout(false);
            this.availableCarsCard.ResumeLayout(false);
            this.rentedCarsCard.ResumeLayout(false);
            this.earningsCard.ResumeLayout(false);
            this.pendingCard.ResumeLayout(false);
            this.vehicleStatusPanel.ResumeLayout(false);
            this.earningsOverviewPanel.ResumeLayout(false);
            this.quickActionsPanel.ResumeLayout(false);
            this.recentBookingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            this.activityPanel.ResumeLayout(false);
            this.activityItem1.ResumeLayout(false);
            this.activityItem2.ResumeLayout(false);
            this.activityItem3.ResumeLayout(false);
            this.activityItem4.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
