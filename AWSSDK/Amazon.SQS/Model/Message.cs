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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// An individual message.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class Message
    {    
        private string messageIdField;
        private string receiptHandleField;
        private string MD5OfBodyField;
        private string bodyField;
        private List<Attribute> attributeField;

        /// <summary>
        /// Unique ID associated with the message.
        /// </summary>
        [XmlElementAttribute(ElementName = "MessageId")]
        public string MessageId
        {
            get { return this.messageIdField; }
            set { this.messageIdField = value; }
        }

        /// <summary>
        /// Sets the unique ID associated with the message.
        /// </summary>
        /// <param name="messageId">Unique ID associated with the message.</param>
        /// <returns>this instance</returns>
        public Message WithMessageId(string messageId)
        {
            this.messageIdField = messageId;
            return this;
        }

        /// <summary>
        /// Checks if MessageId property is set
        /// </summary>
        /// <returns>true if MessageId property is set</returns>
        public bool IsSetMessageId()
        {
            return this.messageIdField != null;
        }

        /// <summary>
        /// A string associated with a specific instance of receiving the message.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReceiptHandle")]
        public string ReceiptHandle
        {
            get { return this.receiptHandleField; }
            set { this.receiptHandleField = value; }
        }

        /// <summary>
        /// Sets the string associated with a specific instance of receiving the message.
        /// </summary>
        /// <param name="receiptHandle">A string associated with a specific instance of receiving the message.</param>
        /// <returns>this instance</returns>
        public Message WithReceiptHandle(string receiptHandle)
        {
            this.receiptHandleField = receiptHandle;
            return this;
        }

        /// <summary>
        /// Checks if ReceiptHandle property is set
        /// </summary>
        /// <returns>true if ReceiptHandle property is set</returns>
        public bool IsSetReceiptHandle()
        {
            return this.receiptHandleField != null;
        }

        /// <summary>
        /// An MD5 digest of the non-URL-encoded message body string.
        /// </summary>
        [XmlElementAttribute(ElementName = "MD5OfBody")]
        public string MD5OfBody
        {
            get { return this.MD5OfBodyField; }
            set { this.MD5OfBodyField = value; }
        }

        /// <summary>
        /// Sets the MD5 digest of the non-URL-encoded message body string.
        /// </summary>
        /// <param name="MD5OfBody">An MD5 digest of the non-URL-encoded message body string.</param>
        /// <returns>this instance</returns>
        public Message WithMD5OfBody(string MD5OfBody)
        {
            this.MD5OfBodyField = MD5OfBody;
            return this;
        }

        /// <summary>
        /// Checks if MD5OfBody property is set
        /// </summary>
        /// <returns>true if MD5OfBody property is set</returns>
        public bool IsSetMD5OfBody()
        {
            return this.MD5OfBodyField != null;
        }

        /// <summary>
        /// The message's contents (not URL encoded).
        /// </summary>
        [XmlElementAttribute(ElementName = "Body")]
        public string Body
        {
            get { return this.bodyField; }
            set { this.bodyField = value; }
        }

        /// <summary>
        /// Sets the message's contents (not URL encoded).
        /// </summary>
        /// <param name="body">The message's contents (not URL encoded).</param>
        /// <returns>this instance</returns>
        public Message WithBody(string body)
        {
            this.bodyField = body;
            return this;
        }

        /// <summary>
        /// Checks if Body property is set
        /// </summary>
        /// <returns>true if Body property is set</returns>
        public bool IsSetBody()
        {
            return this.bodyField != null;
        }

        /// <summary>
        /// Name and value pair of an attribute associated with the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<Attribute> Attribute
        {
            get
            {
                if (this.attributeField == null)
                {
                    this.attributeField = new List<Attribute>();
                }
                return this.attributeField;
            }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the name and value pair of an attribute associated with the queue.
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public Message WithAttribute(params Attribute[] list)
        {
            foreach (Attribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
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
