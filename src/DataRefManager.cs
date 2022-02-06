using System.Collections.Generic;
using XPlaneConnector;

namespace nvan.FdsFfA320McduConnector
{
    public class DataRefManager
    {
        private Dictionary<int, DataRefElement>[] xPlaneDataRefs =
            new Dictionary<int, DataRefElement>[2];

        private Dictionary<int, string> dataRefs = new Dictionary<int, string>()
        {
            [1] = "NumDot",
            [2] = "Num0",
            [3] = "NumPlusMinus",
            [4] = "KeyZ",
            [5] = "KeySlash",
            [6] = "KeySP",
            [7] = "KeyOVFY",
            [8] = "KeyCLR",
            [9] = "Num7",
            [10] = "Num8",
            [11] = "Num9",
            [12] = "KeyU",
            [13] = "KeyV",
            [14] = "KeyW",
            [15] = "KeyX",
            [16] = "KeyY",
            [17] = "Num4",
            [18] = "Num5",
            [19] = "Num6",
            [20] = "KeyP",
            [21] = "KeyQ",
            [22] = "KeyR",
            [23] = "KeyS",
            [24] = "KeyT",
            [25] = "Num1",
            [26] = "Num2",
            [27] = "Num3",
            [28] = "KeyK",
            [29] = "KeyL",
            [30] = "KeyM",
            [31] = "KeyN",
            [32] = "KeyO",
            [33] = "LEFT",
            [34] = "UP",
            [35] = "Line1L",
            [36] = "KeyF",
            [37] = "KeyG",
            [38] = "KeyH",
            [39] = "KeyI",
            [40] = "KeyJ",
            [41] = "AIRPORT",
            [42] = null, // Left Blank key on purpose
            [43] = "Line2L",
            [44] = "KeyA",
            [45] = "KeyB",
            [46] = "KeyC",
            [47] = "KeyD",
            [48] = "KeyE",
            [49] = "FPLAN",
            [50] = "RADNAV",
            [51] = "Line3L",
            [52] = "FUELPRED",
            [53] = "SECFPLAN",
            [54] = "ATCCOMM",
            [55] = "MCDUMENU",
            [56] = "Line5L",
            [57] = "DIR",
            [58] = "PROG",
            [59] = "Line4L",
            [60] = "PERF",
            [61] = "INIT",
            [62] = "DATA",
            [63] = "DIM",
            [64] = "BRT",
            [65] = "Line1R",
            [66] = "Line2R",
            [67] = "Line3R",
            [68] = "Line4R",
            [69] = "Line5R",
            [70] = "Line6R",
            [71] = "Line6L",
            [72] = null, // Right Blank key on purpose
            [73] = "RIGHT",
            [74] = "DOWN"
        };

        public ref Dictionary<int, DataRefElement> getXPlaneDataRefs(int mcduNumber)
        {
            if (xPlaneDataRefs[mcduNumber - 1] == null)
            {
                xPlaneDataRefs[mcduNumber - 1] = new Dictionary<int, DataRefElement>();
                foreach (KeyValuePair<int, string> dataRef in dataRefs)
                {
                    xPlaneDataRefs[mcduNumber - 1].Add(dataRef.Key, new DataRefElement()
                        {
                            DataRef = "NVAN MCDU FDS Connector/MCDU " + mcduNumber + "/" + dataRef.Value
                        }
                    );
                }
            }

            return ref xPlaneDataRefs[mcduNumber - 1];
        }

        private Dictionary<int, DataRefElement>[] ledXPlaneDataRefs =
            new Dictionary<int, DataRefElement>[2];

        private Dictionary<int, string> ledDataRefs = new Dictionary<int, string>()
        {
            [8] = "RDY",
            [2] = "FAIL",
            [4] = "FMGC",
            [3] = "MENU", // Duplicated entry on purspose, as MCDU has two sepparated bulbs for MCDU MENU
            [5] = "MENU",
            [6] = "SYS1",
            [10] = "SYS2",
            [7] = "IND"
        };

        public int getLedsQuantity()
        {
            return ledDataRefs.Count;
        }

        public ref Dictionary<int, DataRefElement> getLedXPlaneDataRefs(int mcduNumber)
        {
            if (ledXPlaneDataRefs[mcduNumber - 1] == null)
            {
                ledXPlaneDataRefs[mcduNumber - 1] = new Dictionary<int, DataRefElement>();
                foreach (KeyValuePair<int, string> dataRef in ledDataRefs)
                {
                    ledXPlaneDataRefs[mcduNumber - 1].Add(dataRef.Key, new DataRefElement()
                    {
                        DataRef = "NVAN MCDU FDS Connector/MCDU " + mcduNumber + "/LED_" + dataRef.Value
                    });
                }
            }

            return ref ledXPlaneDataRefs[mcduNumber - 1];
        }
    }
}
