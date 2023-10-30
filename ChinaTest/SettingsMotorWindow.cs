
namespace ChinaTest
{
    public partial class SettingsMotorWindow : Form
    {
        private readonly string PathX = $"{Environment.CurrentDirectory}\\motorSettingsX.json";
        private readonly string PathY = $"{Environment.CurrentDirectory}\\motorSettingsY.json";
        private readonly string PathZ = $"{Environment.CurrentDirectory}\\motorSettingsZ.json";

        private Controller _controller;
        private FileIOService _fileIOService;

        private string _typeStageX;
        private string _runnigUnitX;
        private double _stepperAngleX;
        private double _subdivisionX;
        private double _screwLeadX;
        private double _transmissionRatioX;
        private double _travelRangeX;

        private string _typeStageY;
        private string _runnigUnitY;
        private double _stepperAngleY;
        private double _subdivisionY;
        private double _screwLeadY;
        private double _transmissionRatioY;
        private double _travelRangeY;

        private string _typeStageZ;
        private string _runnigUnitZ;
        private double _stepperAngleZ;
        private double _subdivisionZ;
        private double _screwLeadZ;
        private double _transmissionRatioZ;
        private double _travelRangeZ;

        public SettingsMotorWindow()
        {
            InitializeComponent();
            LoadThisWindow();
        }

        private void LoadThisWindow()
        {
            comboBox1.SelectedIndexChanged += comboBox1_StageType;
            comboBox2.SelectedIndexChanged += comboBox2_RunnigUnit;
            comboBox13.SelectedIndexChanged += comboBox13_StepperAngle;
            comboBox3.SelectedIndexChanged += comboBox3_Subdivision;
            comboBox4.SelectedIndexChanged += comboBox4_ScrewLead;
            comboBox17.SelectedIndexChanged += comboBox17_TransmoccionRatio;
            comboBox16.SelectedIndexChanged += comboBox16_TravelRange;

            comboBox8.SelectedIndexChanged += comboBox8_StageTypeY;
            comboBox7.SelectedIndexChanged += comboBox7_RunnigUnitY;
            comboBox14.SelectedIndexChanged += comboBox14_StepperAngleY;
            comboBox6.SelectedIndexChanged += comboBox6_SubdivisionY;
            comboBox5.SelectedIndexChanged += comboBox5_ScrewLeadY;
            comboBox18.SelectedIndexChanged += comboBox18_TransmissionRatioY;
            comboBox19.SelectedIndexChanged += comboBox19_TravelRangeY; ;
        }

        private void button1_X(object sender, EventArgs e)
        {
            AxisModel axis = new AxisModel();
            axis.Name = "X";
            SetAxis(axis, PathX, _typeStageX, _runnigUnitX, _stepperAngleX, _subdivisionX, _screwLeadX, _transmissionRatioX, _travelRangeX);
            _controller.SetAxisValue(axis);

        }

        private void button2_Y(object sender, EventArgs e)
        {
            AxisModel axis = new AxisModel();
            axis.Name = "Y";
            SetAxis(axis, PathY, _typeStageY, _runnigUnitY, _stepperAngleY, _subdivisionY, _screwLeadY, _transmissionRatioY, _travelRangeY);
            _controller.SetAxisValue(axis);
        }
        private void button3_Z(object sender, EventArgs e)
        {
            AxisModel axis = new AxisModel();
            axis.Name = "Z";
            SetAxis(axis, PathZ, _typeStageZ, _runnigUnitZ, _stepperAngleZ, _subdivisionZ, _screwLeadZ, _transmissionRatioZ, _travelRangeZ);
            _controller.SetAxisValue(axis);
        }


        //Поля оси Х
        private void comboBox1_StageType(object sender, EventArgs e) //Тип подвижки 
        {
            _typeStageX = comboBox1.Text;
            DisabledButton(_typeStageX, "X");
        }

        private void comboBox2_RunnigUnit(object sender, EventArgs e) //Единица измерения
        {
            _runnigUnitX = comboBox2.Text;
        }

        private void comboBox13_StepperAngle(object sender, EventArgs e) //Шаг угла двигателя
        {
            _stepperAngleX = double.Parse(comboBox13.Text);
        }

        private void comboBox3_Subdivision(object sender, EventArgs e) //Деление шага
        {
            _subdivisionX = double.Parse(comboBox3.Text);
        }

        private void comboBox4_ScrewLead(object sender, EventArgs e) //Шаг винта
        {
            _screwLeadX = double.Parse(comboBox4.Text);
        }
        private void comboBox17_TransmoccionRatio(object sender, EventArgs e) //Передаточное отношение
        {
            _transmissionRatioX = double.Parse(comboBox17.Text);
        }

        private void comboBox16_TravelRange(object sender, EventArgs e) //Длина подвижки
        {
            _travelRangeX = double.Parse(comboBox16.Text);
        }

        //Поля оси Y

        private void comboBox8_StageTypeY(object sender, EventArgs e)
        {
            _typeStageY = comboBox8.Text;
            DisabledButton(_typeStageY, "Y");
        }

        private void comboBox7_RunnigUnitY(object sender, EventArgs e)
        {
            _runnigUnitY = comboBox7.Text;
        }

        private void comboBox14_StepperAngleY(object sender, EventArgs e)
        {
            _stepperAngleY = double.Parse(comboBox14.Text);
        }

        private void comboBox6_SubdivisionY(object sender, EventArgs e)
        {
            _subdivisionY = double.Parse(comboBox6.Text);
        }

        private void comboBox5_ScrewLeadY(object sender, EventArgs e)
        {
            _screwLeadY = double.Parse(comboBox5.Text);
        }

        private void comboBox18_TransmissionRatioY(object sender, EventArgs e)
        {
            _transmissionRatioY = double.Parse(comboBox18.Text);
        }

        private void comboBox19_TravelRangeY(object sender, EventArgs e)
        {
            _travelRangeY = double.Parse(comboBox19.Text);
        }

        //Поля оси Z

        private void comboBox12_StageTypeZ(object sender, EventArgs e)
        {
            _typeStageZ = comboBox12.Text;
            DisabledButton(_typeStageZ, "Z");
        }

        private void comboBox11_RuningUnitZ(object sender, EventArgs e)
        {
            _runnigUnitZ = comboBox11.Text;
        }

        private void comboBox15_StepperAngleZ(object sender, EventArgs e)
        {
            _stepperAngleZ = double.Parse(comboBox15.Text);
        }

        private void comboBox10_SubdivisionZ(object sender, EventArgs e)
        {
            _subdivisionZ = double.Parse(comboBox10.Text);
        }

        private void comboBox9_ScrewLeadZ(object sender, EventArgs e)
        {
            _screwLeadZ = double.Parse(comboBox9.Text);
        }

        private void comboBox20_TransmissionRatioZ(object sender, EventArgs e)
        {
            _transmissionRatioZ = double.Parse(comboBox20.Text);
        }

        private void comboBox21_TravelRangeZ(object sender, EventArgs e)
        {
            _travelRangeZ = double.Parse(comboBox21.Text);
        }

        public void GetController(object controller)
        {
            _controller = (Controller)controller;
            SetValuesInComboBox();
        }

        public void GetService(object service)
        {
            _fileIOService = (FileIOService)service;
        }

        private void SetAxis(AxisModel axis, string path, string typeStage, string runningUnit, double stepperAngle,
                             double subdivision, double screwLead, double transmissionRatio, double traveRange)
        {
            axis.StageType = typeStage;
            axis.RuningUnit = runningUnit;
            axis.StepperAngle = stepperAngle;
            axis.Subdivision = subdivision;
            axis.ScrewLead = screwLead;
            axis.TransmissonRatio = transmissionRatio;
            axis.TravelRange = traveRange;

            _fileIOService.SaveData(axis, path);
        }

        private void SetValuesInComboBox()
        {
            try
            {
                comboBox1.Text = _controller.AxisModelX.StageType;
                comboBox2.Text += _controller.AxisModelX.RuningUnit;
                comboBox13.Text += _controller.AxisModelX.StepperAngle;
                comboBox3.Text += _controller.AxisModelX.Subdivision;
                comboBox4.Text += _controller.AxisModelX.ScrewLead;
                comboBox17.Text += _controller.AxisModelX.TransmissonRatio;
                comboBox16.Text += _controller.AxisModelX.TravelRange;

                comboBox8.Text += _controller.AxisModelY.StageType;
                comboBox7.Text += _controller.AxisModelY.RuningUnit;
                comboBox14.Text += _controller.AxisModelY.StepperAngle;
                comboBox6.Text += _controller.AxisModelY.Subdivision;
                comboBox5.Text += _controller.AxisModelY.ScrewLead;
                comboBox18.Text += _controller.AxisModelY.TransmissonRatio;
                comboBox19.Text += _controller.AxisModelY.TravelRange;

                comboBox12.Text += _controller.AxisModelZ.StageType;
                comboBox11.Text += _controller.AxisModelZ.RuningUnit;
                comboBox15.Text += _controller.AxisModelZ.StepperAngle;
                comboBox10.Text += _controller.AxisModelZ.Subdivision;
                comboBox9.Text += _controller.AxisModelZ.ScrewLead;
                comboBox20.Text += _controller.AxisModelZ.TransmissonRatio;
                comboBox21.Text += _controller.AxisModelZ.TravelRange;
            }
            catch { }
        }

        private void DisabledButton(string name, string axis)
        {
            if (name == "TranslationStage")
            {
                if (axis == "X")
                {
                    comboBox16.Enabled = true;
                    comboBox17.Enabled = false;
                    comboBox4.Enabled = true;
                }
                else if (axis == "Y")
                {
                    comboBox5.Enabled = true;
                    comboBox18.Enabled = false;
                    comboBox19.Enabled = true;
                }
                else if (axis == "Z")
                {
                    comboBox9.Enabled = true;
                    comboBox20.Enabled = false;
                    comboBox21.Enabled = true;
                }

            }
            else if (name == "RotaryStage")
            {
                if (axis == "X")
                {
                    comboBox4.Enabled = false;
                    comboBox16.Enabled = false;
                    comboBox17.Enabled = true;
                }
                else if (axis == "Y")
                {
                    comboBox5.Enabled = false;
                    comboBox18.Enabled = true;
                    comboBox19.Enabled = false;
                }
                else if (axis == "Z")
                {
                    comboBox9.Enabled = false;
                    comboBox20.Enabled = true;
                    comboBox21.Enabled = false;
                }
            }
            else if (name == "GoniometrStage")
            {
                if (axis == "X")
                {
                    comboBox4.Enabled = false;
                    comboBox16.Enabled = true;
                    comboBox17.Enabled = true;
                }
                else if (axis == "Y")
                {
                    comboBox5.Enabled = false;
                    comboBox18.Enabled = true;
                    comboBox19.Enabled = true;
                }
                else if (axis == "Z")
                {
                    comboBox9.Enabled = false;
                    comboBox20.Enabled = true;
                    comboBox21.Enabled = true;
                }
            }
        }
    }
}
