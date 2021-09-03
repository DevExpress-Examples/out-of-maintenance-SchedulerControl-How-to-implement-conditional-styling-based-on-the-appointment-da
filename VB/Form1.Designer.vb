Imports System

Namespace DXApplication1
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim timeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler5 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler6 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(components)
            CType(schedulerControl1, ComponentModel.ISupportInitialize).BeginInit()
            CType(schedulerDataStorage1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            schedulerControl1.DataStorage = schedulerDataStorage1
            schedulerControl1.Dock = Windows.Forms.DockStyle.Fill
            schedulerControl1.Location = New Drawing.Point(0, 0)
            schedulerControl1.Name = "schedulerControl1"
            schedulerControl1.Size = New Drawing.Size(632, 278)
            schedulerControl1.Start = New DateTime(2021, 7, 21, 0, 0, 0, 0)
            schedulerControl1.TabIndex = 0
            schedulerControl1.Text = "schedulerControl1"
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4)
            schedulerControl1.Views.FullWeekView.Enabled = True
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5)
            schedulerControl1.Views.WeekView.Enabled = False
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6)
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = False
            ' 
            ' 
            ' 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", Drawing.SystemColors.Window)
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", Drawing.Color.FromArgb(255, 194, 190))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", Drawing.Color.FromArgb(168, 213, 255))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", Drawing.Color.FromArgb(193, 244, 156))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", Drawing.Color.FromArgb(243, 228, 199))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", Drawing.Color.FromArgb(244, 206, 147))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", Drawing.Color.FromArgb(199, 244, 255))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", Drawing.Color.FromArgb(207, 219, 152))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", Drawing.Color.FromArgb(224, 207, 233))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", Drawing.Color.FromArgb(141, 233, 223))
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", Drawing.Color.FromArgb(255, 247, 165))
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(632, 278)
            Controls.Add(schedulerControl1)
            Name = "Form1"
            Text = "Form1"
            WindowState = Windows.Forms.FormWindowState.Maximized
            CType(schedulerControl1, ComponentModel.ISupportInitialize).EndInit()
            CType(schedulerDataStorage1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    End Class
End Namespace
