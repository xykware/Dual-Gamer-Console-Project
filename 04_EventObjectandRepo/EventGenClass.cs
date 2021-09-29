using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EventObjectandRepo
{
    public class EventContent
    {
        public int EventNumber { get; set; }
        public string EventText { get; set; }
        public string OptionOneText { get; set; }
        public int[] OptionOneParams { get; set; }
        public string OptionTwoText { get; set; }
        public int[] OptionTwoParams { get; set; }
        public string OptionThreeText { get; set; }
        public int[] OptionThreeParams { get; set; }
        public string OptionFourText { get; set; }
        public int[] OptionFourParams { get; set; }
        public string OptionFiveText { get; set; }
        public int[] OptionFiveParams { get; set; }

        public EventContent() { }

        public EventContent(int eventNumber, string eventText, string optionOneText, int[] optionOneParams, string optionTwoText, int[] optionTwoParams, string optionThreeText, int[] optionThreeParams, string optionFourText, int[] optionFourParams, string optionFiveText, int[] optionFiveParams)
        {
            EventNumber = eventNumber;
            EventText = eventText;
            OptionOneText = optionOneText;
            OptionOneParams = optionOneParams;
            OptionTwoText = optionTwoText;
            OptionTwoParams = optionTwoParams;
            OptionThreeText = optionThreeText;
            OptionThreeParams = optionThreeParams;
            OptionFourText = optionFourText;
            OptionFourParams = optionFourParams;
            OptionFiveText = optionFiveText;
            OptionFiveParams = optionFiveParams;
        }


    }
}
