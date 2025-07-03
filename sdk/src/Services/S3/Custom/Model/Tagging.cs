using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System.Xml;

namespace Amazon.S3.Model
{
    public partial class Tagging
    {
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                xmlWriter.WriteStartElement("TagSet");
                {
                    if (this._tagSet != null)
                    {
                        foreach (var tag in _tagSet)
                        {
                            tag.Marshall("Tag", xmlWriter);
                        }
                    }
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }
    }
}
