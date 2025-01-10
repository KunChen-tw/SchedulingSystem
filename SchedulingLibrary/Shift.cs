
/// <summary>
/// 表示一個班次。
/// </summary>
public class Shift
{
    /// <summary>
    /// 獲取班次的描述。
    /// </summary>
    public string Description
    {
        get
        {
            return Type switch
            {
                ShiftType.Morning => "早班",
                ShiftType.Afternoon => "午班",
                ShiftType.Night => "晚班",
                ShiftType.Graveyard => "大夜班",
                ShiftType.Off => "休假",
                _ => "未知班次"
            };
        }
    }

    /// <summary>
    /// 獲取或設置班次的員工。
    /// </summary>
    public Employee User { get; set; }

    /// <summary>
    /// 表示班次類型的列舉。
    /// </summary>
    public enum ShiftType
    {
        /// <summary>
        /// 早班。
        /// </summary>
        Morning,
        /// <summary>
        /// 午班。
        /// </summary>
        Afternoon,
        /// <summary>
        /// 晚班。
        /// </summary>
        Night,
        /// <summary>
        /// 大夜班。
        /// </summary>
        Graveyard,
        /// <summary>
        /// 休假。
        /// </summary>
        Off
    }

    /// <summary>
    /// 獲取或設置班次的類型。
    /// </summary>
    public ShiftType Type { get; set; }
}
