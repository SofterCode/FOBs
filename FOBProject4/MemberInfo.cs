using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOBProject4
{
    class MemberInfo
    {
        private string sFirstName;
        private string sLastName;
        private string sJobPosition;
        private int iYearsAtEstab;
       

        public string MemberInfoAdd(string sFirstName, string sLastName, string sJobPosition, int iYearsAtEstab)
        {
            this.sFirstName = sFirstName;
            this.sLastName = sLastName;
            this.sJobPosition = sJobPosition;
            this.iYearsAtEstab = iYearsAtEstab;
            string sRet = "Your information is as follows: Your name is " + sFirstName + sLastName + ". Your position is " + sJobPosition + ". You have been at your establishment " + iYearsAtEstab + " years.";
            return sRet;

        }

        public string sNotVentFirst()
        {
            string sFail = "If you release the ball first, that first beer your pour will be nothing but foam, all over you, and your customer.";
            return sFail;
        }

        public string sVentFirst()
        {
            string sExcellent = "Yes, exactly, you need to vent the foam out of the FOB before moving on.";
            return sExcellent;
        }

        public string sNotVentAgain()
        {
            string sAnotherFail = "If you reset the pin, the ball will float on the foam, allowing it to travel into your lines..";
            return sAnotherFail;
        }
        public string sSecondStepNotCorrect()
        {
            string noway = "If you reset the pin now, the ball will block the main line and no beer will flow.";
            return noway;
        }
        public string sSecondStepCorrect()
        {
            string sYes2 = "Exactly, you have to release the ball or it will block the main line and no beer will flow.";
            return sYes2;
        }

        public string sThirdStepCorrect()
        {
            string sYes3 = "Yep, you nailed it. The steps are first you vent, then you release the ball and finally you reset the pin";
            return sYes3;
        }

        public string sThirdStepNotCorrect()
        {
            string nope3 = "Remeber at the begining when you vented it. That was the only venting it needed.";
            return nope3;
        }

        
    }
}
