using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Collections;

namespace Quiz
{
    class Result
    {
        private string file;
        private string result = "";
        private string quesid;

        public string getResult(string option, int id, string category)
        {

            try
            {
                quesid = id.ToString();
                file = category + ".xml";
                XElement root = XElement.Load(file);
                IEnumerable<XElement> address =
                from el in root.Elements("question")
                where (string)el.Attribute("id") == quesid
                select el;
                foreach (XElement el in address)
                    foreach (XElement el1 in el.Elements())
                    {
                        if (el1.Name == "correct")
                        {
                            if (el1.Value == option)
                            {
                                result = "CORRECT";
                            }
                            else
                            {
                                result = "WRONG";
                            }
                        }
                    }
                return result;
            }
            catch (XmlException)
            {
                return "XML Exception has occured! Please contact administrator.";

            }
            catch (FileLoadException)
            {
                return "Not able to load data from backend! Please contact administrator.";
            }
            catch (FileNotFoundException)
            {
                return "Data file not found in backend! Please contact administrator.";
            }
            catch
            {
                return "Unknown error! Please contact administrator.";
            }

        }

    }
}
