/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class MessageAttributeValue
    {
        private List<MemoryStream> binaryListValueField;
        private MemoryStream binaryValueField;
        private string dataTypeField;
        private List<string> stringListValueField;
        private string stringValueField;

        [XmlElementAttribute(ElementName = "BinaryListValue")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public string[] BinaryListValueRaw
        {
            get
            {
                List<string> values = new List<string>();
                foreach (var item in this.BinaryListValue)
                {
                    var s = item == null ? null : StringUtils.FromMemoryStream(item);
                    values.Add(s);
                }
                return values.ToArray();
            }
            set
            {
                this.BinaryListValue.Clear();
                if (value == null) return;

                foreach (var s in value)
                {
                    var ms = (s == null ? null : StringUtils.ToMemoryStream(s));
                    this.BinaryListValue.Add(ms);
                }
            }
        }

        /// <summary>
        /// Gets and sets the property BinaryListValues.
        /// </summary>
        [XmlIgnore]
        public List<MemoryStream> BinaryListValue
        {
            get
            {
                if (this.binaryListValueField == null)
                {
                    this.binaryListValueField = new List<MemoryStream>();
                }
                return this.binaryListValueField;
            }
            set { this.binaryListValueField = value; }
        }

        /// <summary>
        /// Sets the MemoryStreams of a message attribute.
        /// </summary>
        /// <param name="list">MemoryStreams of a message attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public MessageAttributeValue WithBinaryListValue(params MemoryStream[] list)
        {
            foreach (MemoryStream item in list)
            {
                BinaryListValue.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BinaryListValue property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetBinaryListValue()
        {
            return (BinaryListValue.Count > 0);
        }


        [XmlElementAttribute(ElementName = "BinaryValue")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public string BinaryValueRaw
        {
            get { return this.BinaryValue == null ? null : StringUtils.FromMemoryStream(this.BinaryValue); }
            set { this.BinaryValue = (value == null ? null : StringUtils.ToMemoryStream(value)); }
        }

        /// <summary>
        /// The MemoryStream of a message attribute.
        /// </summary>
        [XmlIgnore]
        public MemoryStream BinaryValue
        {
            get { return this.binaryValueField; }
            set { this.binaryValueField = value; }
        }

        /// <summary>
        /// Sets the MemoryStream of a message attribute.
        /// </summary>
        /// <param name="binaryValue">MemoryStream of a message attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public MessageAttributeValue WithBinaryValue(MemoryStream binaryValue)
        {
            this.binaryValueField = binaryValue;
            return this;
        }

        /// <summary>
        /// Checks if BinaryValue property is set
        /// </summary>
        /// <returns>true if BinaryValue property is set</returns>
        public bool IsSetBinaryValue()
        {
            return this.binaryValueField != null;
        }




        /// <summary>
        /// The DataType of this attribute value.
        /// </summary>
        [XmlElementAttribute(ElementName = "DataType")]
        public string DataType
        {
            get { return this.dataTypeField; }
            set { this.dataTypeField = value; }
        }

        /// <summary>
        /// Sets the DataType of this attribute value.
        /// </summary>
        /// <param name="dataType">A DataType of this attribute value.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public MessageAttributeValue WithDataType(string dataType)
        {
            this.dataTypeField = dataType;
            return this;
        }

        /// <summary>
        /// Checks if DataType property is set
        /// </summary>
        /// <returns>true if DataType property is set</returns>
        public bool IsSetDataType()
        {
            return this.dataTypeField != null;
        }





        /// <summary>
        /// Gets and sets the property StringListValue.
        /// </summary>
        [XmlElementAttribute(ElementName = "StringListValue")]
        public List<string> StringListValue
        {
            get
            {
                if (this.stringListValueField == null)
                {
                    this.stringListValueField = new List<string>();
                }
                return this.stringListValueField;
            }
            set { this.stringListValueField = value; }
        }

        /// <summary>
        /// Sets the MemoryStreams of a message attribute.
        /// </summary>
        /// <param name="list">MemoryStreams of a message attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public MessageAttributeValue WithStringListValue(params string[] list)
        {
            foreach (string item in list)
            {
                StringListValue.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if StringListValue property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetStringListValue()
        {
            return (StringListValue.Count > 0);
        }




        /// <summary>
        /// The string of a message attribute.
        /// </summary>
        [XmlElementAttribute(ElementName = "StringValue")]
        public string StringValue
        {
            get { return this.stringValueField; }
            set { this.stringValueField = value; }
        }

        /// <summary>
        /// Sets the string of a message attribute.
        /// </summary>
        /// <param name="stringValue">String of a message attribute.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public MessageAttributeValue WithStringValue(string stringValue)
        {
            this.stringValueField = stringValue;
            return this;
        }

        /// <summary>
        /// Checks if StringValue property is set
        /// </summary>
        /// <returns>true if StringValue property is set</returns>
        public bool IsSetStringValue()
        {
            return this.stringValueField != null;
        }


        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
