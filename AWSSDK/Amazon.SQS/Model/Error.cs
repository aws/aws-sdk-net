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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Error
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class Error
    {    
        private string typeField;
        private string codeField;
        private string messageField;
        private Object detailField;

        /// <summary>
        /// The error type.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the error type.
        /// </summary>
        /// <param name="type">The error type.</param>
        /// <returns>this instance</returns>
        public Error WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// The specific error code.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the specific error code.
        /// </summary>
        /// <param name="code">The specific error code.</param>
        /// <returns>this instance</returns>
        public Error WithCode(string code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }

        /// <summary>
        /// Summary of the error.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets the summary of the error.
        /// </summary>
        /// <param name="message">A summary of the error.</param>
        /// <returns>this instance</returns>
        public Error WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }

        /// <summary>
        /// Details associated with the error.
        /// </summary>
        [XmlElementAttribute(ElementName = "Detail")]
        public Object Detail
        {
            get { return this.detailField; }
            set { this.detailField = value; }
        }

        /// <summary>
        /// Sets the details associated with the error.
        /// </summary>
        /// <param name="detail">Details associated with the error.</param>
        /// <returns>this instance</returns>
        public Error WithDetail(Object detail)
        {
            this.detailField = detail;
            return this;
        }

        /// <summary>
        /// Checks if Detail property is set
        /// </summary>
        /// <returns>true if Detail property is set</returns>
        public bool IsSetDetail()
        {
            return this.detailField != null;
        }

    }
}
