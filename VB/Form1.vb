Imports DevExpress.XtraScheduler
Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DXApplication1
    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private CustomResourceCollection As BindingList(Of CustomResource) = New BindingList(Of CustomResource)()
        Private CustomEventList As BindingList(Of CustomAppointment) = New BindingList(Of CustomAppointment)()

        Public Sub New()
            InitializeComponent()
            InitHelper.InitResources(CustomResourceCollection)
            InitHelper.InitAppointments(CustomEventList, CustomResourceCollection)
            Dim mappingsResource = schedulerDataStorage1.Resources.Mappings
            mappingsResource.Id = "ResID"
            mappingsResource.Caption = "Name"
            Dim mappingsAppointment = schedulerDataStorage1.Appointments.Mappings
            mappingsAppointment.Start = "StartTime"
            mappingsAppointment.End = "EndTime"
            mappingsAppointment.Subject = "Subject"
            mappingsAppointment.AllDay = "AllDay"
            mappingsAppointment.Description = "Description"
            mappingsAppointment.Label = "Label"
            mappingsAppointment.Location = "Location"
            mappingsAppointment.RecurrenceInfo = "RecurrenceInfo"
            mappingsAppointment.ReminderInfo = "ReminderInfo"
            mappingsAppointment.ResourceId = "OwnerId"
            mappingsAppointment.Status = "Status"
            mappingsAppointment.Type = "EventType"
            schedulerDataStorage1.Resources.DataSource = CustomResourceCollection
            schedulerDataStorage1.Appointments.DataSource = CustomEventList
            AddHandler schedulerControl1.AppointmentViewInfoCustomizing, AddressOf SchedulerControl1_AppointmentViewInfoCustomizing
            schedulerControl1.Start = Date.Now
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            Dim apt As Appointment = schedulerControl1.ActiveView.GetAppointments()(0)
            apt.End = apt.End.AddDays(1)
            apt.Description = "Time"
            schedulerControl1.ActiveViewType = SchedulerViewType.Day
            schedulerControl1.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = AppointmentStatusDisplayType.Bounds
            schedulerControl1.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = False
        End Sub

        Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As AppointmentViewInfoCustomizingEventArgs)
            Select Case e.ViewInfo.Status.Type
                Case AppointmentStatusType.Busy
                    e.ViewInfo.Appearance.ForeColor = Color.Black
                Case AppointmentStatusType.Free
                    e.ViewInfo.Appearance.ForeColor = Color.Blue
                Case AppointmentStatusType.OutOfOffice
                    e.ViewInfo.Appearance.ForeColor = Color.Green
            End Select

            If e.ViewInfo.Description.Contains("Time") Then e.ViewInfo.StatusDisplayType = AppointmentStatusDisplayType.Time
        End Sub
    End Class
End Namespace
