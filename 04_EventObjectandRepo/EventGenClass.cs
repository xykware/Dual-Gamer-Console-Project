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
        public int OptionOneGotoEvent { get; set; }
        public string OptionTwoText { get; set; }
        public int[] OptionTwoParams { get; set; }
        public int OptionTwoGotoEvent { get; set; }
        public string OptionThreeText { get; set; }
        public int[] OptionThreeParams { get; set; }
        public int OptionThreeGotoEvent { get; set; }
        public string OptionFourText { get; set; }
        public int[] OptionFourParams { get; set; }
        public int OptionFourGotoEvent { get; set; }
        public string OptionFiveText { get; set; }
        public int[] OptionFiveParams { get; set; }
        public int OptionFiveGotoEvent { get; set; }

        public EventContent() { }

        public EventContent(int eventNumber, string eventText, string optionOneText, int[] optionOneParams, int optionOneGotoEvent, string optionTwoText, int[] optionTwoParams, int optionTwoGotoEvent, string optionThreeText, int[] optionThreeParams, int optionThreeGotoEvent, string optionFourText, int[] optionFourParams, int optionFourGotoEvent, string optionFiveText, int[] optionFiveParams, int optionFiveGotoEvent)
        {
            EventNumber = eventNumber;
            EventText = eventText;
            OptionOneText = optionOneText;
            OptionOneParams = optionOneParams;
            OptionOneGotoEvent = optionOneGotoEvent;
            OptionTwoText = optionTwoText;
            OptionTwoParams = optionTwoParams;
            OptionTwoGotoEvent = optionTwoGotoEvent;
            OptionThreeText = optionThreeText;
            OptionThreeParams = optionThreeParams;
            OptionThreeGotoEvent = optionThreeGotoEvent;
            OptionFourText = optionFourText;
            OptionFourParams = optionFourParams;
            OptionFourGotoEvent = optionFourGotoEvent;
            OptionFiveText = optionFiveText;
            OptionFiveParams = optionFiveParams;
            OptionFiveGotoEvent = optionFiveGotoEvent;
        }


    }
}
