using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {

        BindingList<CustomResource> CustomResourceCollection = new BindingList<CustomResource>();
        BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();
        public Form1() {
            InitializeComponent();

            InitHelper.InitResources(CustomResourceCollection);
            InitHelper.InitAppointments(CustomEventList, CustomResourceCollection);

            ResourceMappingInfo mappingsResource = this.schedulerDataStorage1.Resources.Mappings;
            mappingsResource.Id = "ResID";
            mappingsResource.Caption = "Name";

            AppointmentMappingInfo mappingsAppointment = this.schedulerDataStorage1.Appointments.Mappings;
            mappingsAppointment.Start = "StartTime";
            mappingsAppointment.End = "EndTime";
            mappingsAppointment.Subject = "Subject";
            mappingsAppointment.AllDay = "AllDay";
            mappingsAppointment.Description = "Description";
            mappingsAppointment.Label = "Label";
            mappingsAppointment.Location = "Location";
            mappingsAppointment.RecurrenceInfo = "RecurrenceInfo";
            mappingsAppointment.ReminderInfo = "ReminderInfo";
            mappingsAppointment.ResourceId = "OwnerId";
            mappingsAppointment.Status = "Status";
            mappingsAppointment.Type = "EventType";

            schedulerDataStorage1.Resources.DataSource = CustomResourceCollection;
            schedulerDataStorage1.Appointments.DataSource = CustomEventList;

            schedulerControl1.AppointmentViewInfoCustomizing += SchedulerControl1_AppointmentViewInfoCustomizing;

           

            schedulerControl1.Start = DateTime.Now;
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            Appointment apt = schedulerControl1.ActiveView.GetAppointments()[0];
            apt.End = apt.End.AddDays(1);
            apt.Description = "Time";
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
            schedulerControl1.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl1.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = false;
        }

        private void SchedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e) {
            switch(e.ViewInfo.Status.Type) {
                case AppointmentStatusType.Busy:
                    e.ViewInfo.Appearance.ForeColor = Color.Black;
                    break;
                case AppointmentStatusType.Free:
                    e.ViewInfo.Appearance.ForeColor = Color.Blue;
                    break;
                case AppointmentStatusType.OutOfOffice:
                    e.ViewInfo.Appearance.ForeColor = Color.Green;
                    break;
            }
            if(e.ViewInfo.Description.Contains("Time"))
                e.ViewInfo.StatusDisplayType = AppointmentStatusDisplayType.Time;
        }
    }
}
