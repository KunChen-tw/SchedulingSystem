
/// <summary>
/// ��ܤ@�ӯZ���C
/// </summary>
public class Shift
{
    /// <summary>
    /// ����Z�����y�z�C
    /// </summary>
    public string Description
    {
        get
        {
            return Type switch
            {
                ShiftType.Morning => "���Z",
                ShiftType.Afternoon => "�ȯZ",
                ShiftType.Night => "�߯Z",
                ShiftType.Graveyard => "�j�]�Z",
                ShiftType.Off => "��",
                _ => "�����Z��"
            };
        }
    }

    /// <summary>
    /// ����γ]�m�Z�������u�C
    /// </summary>
    public Employee User { get; set; }

    /// <summary>
    /// ��ܯZ���������C�|�C
    /// </summary>
    public enum ShiftType
    {
        /// <summary>
        /// ���Z�C
        /// </summary>
        Morning,
        /// <summary>
        /// �ȯZ�C
        /// </summary>
        Afternoon,
        /// <summary>
        /// �߯Z�C
        /// </summary>
        Night,
        /// <summary>
        /// �j�]�Z�C
        /// </summary>
        Graveyard,
        /// <summary>
        /// �𰲡C
        /// </summary>
        Off
    }

    /// <summary>
    /// ����γ]�m�Z���������C
    /// </summary>
    public ShiftType Type { get; set; }
}
