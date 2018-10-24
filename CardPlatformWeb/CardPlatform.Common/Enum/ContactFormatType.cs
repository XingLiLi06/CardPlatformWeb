using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlatform.Common.Enum
{
    /// <summary>
    /// 联系方式格式
    /// </summary>
    public enum ContactFormatType
    {
        /// <summary>
        /// 任意字符
        /// </summary>
        AnyChar = 0,
        /// <summary>
        /// 纯数字
        /// </summary>
        PureDigital = 1,
        /// <summary>
        /// 纯字母
        /// </summary>
        PureLetter,
        /// <summary>
        /// 字母和数字
        /// </summary>
        LetterAndDigital,
        /// <summary>
        /// 手机号
        /// </summary>
        PhoneNo,
    }
}
