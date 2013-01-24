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
    /// A list of errors associated with a request returned by Amazon SQS.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class ErrorResponse
    {    
        private List<Error> errorField;
        private string requestIdField;

        /// <summary>
        /// List of errors.
        /// </summary>
        [XmlElementAttribute(ElementName = "Error")]
        public List<Error> Error
        {
            get
            {
                if (this.errorField == null)
                {
                    this.errorField = new List<Error>();
                }
                return this.errorField;
            }
            set { this.errorField = value; }
        }

        /// <summary>
        /// Checks if Error property is set
        /// </summary>
        /// <returns>true if Error property is set</returns>
        public bool IsSetError()
        {
            return (Error.Count > 0);
        }

        /// <summary>
        /// A unique ID for tracking the request.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this.requestIdField; }
            set { this.requestIdField = value; }
        }

        /// <summary>
        /// Checks if RequestId property is set
        /// </summary>
        /// <returns>true if RequestId property is set</returns>
        public bool IsSetRequestId()
        {
            return this.requestIdField != null;
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
