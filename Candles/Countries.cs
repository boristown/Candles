using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles
{
    class Countries
    {
        public static Dictionary<string, HashSet<string>> continents = new Dictionary<string, HashSet<string>>()
        {
            { "Popular", new HashSet<string>(){
                "united-states", "france", "japan",
                "united-kingdom",  "germany", "australia",
            }},
            { "Americas", new HashSet<string>(){
                "argentina", "brazil", "canada",
                "chile",  "colombia", "costa",
                "rica", "jamaica", "mexico",
                "peru", "united-states", "venezuela"
            }},
            { "Europe", new HashSet<string>(){
                "austria", "belgium", "bosnia",
                "bulgaria", "croatia", "cyprus",
                "czech-republic", "denmark", "estonia",
                "finland", "france", "germany",
                "greece","hungary","iceland",
                "ireland","italy","latvia",
                "lithuania","malta","montenegro",
                "netherlands","norway","poland",
                "portugal","romania","russia",
                "serbia","slovakia","slovenia",
                "spain","sweden","switzerland",
                "turkey","ukraine","united-kingdom",
            }},
            { "Asia/Pacific", new HashSet<string>(){
                "australia","bangladesh","china",
                "hong-kong","india","indonesia",
                "japan","kazakhstan","malaysia",
                "mongolia","new-zealand","pakistan",
                "philippines","singapore","south-korea",
                "sri-lanka","taiwan","thailand",
                "vietnam",
            }},
            { "Middle East", new HashSet<string>(){
                "bahrain","egypt","iraq",
                "israel","jordan","kuwait",
                "lebanon","oman","palestinian-territory",
                "qatar","saudi-arabia","dubai",
            }},
            { "Africa", new HashSet<string>(){
                "botswana","ivory-coast","kenya",
                "malawi","mauritius","morocco",
                "namibia","nigeria","rwanda",
                "south-africa","tanzania","tunisia",
                "uganda","zambia","zimbabwe",
            }},
        };
        
    }
}
