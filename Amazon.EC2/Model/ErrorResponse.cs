/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Error Response
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class ErrorResponse
    {
        private List<Error> errorField;
        private string requestIdField;
        /// <summary>
        /// Gets and sets the Error property.
        /// Error
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
        /// Sets the Error property
        /// </summary>
        /// <param name="list">Error</param>
        /// <returns>this instance</returns>
        public ErrorResponse WithError(params Error[] list)
        {
            foreach (Error item in list)
            {
                Error.Add(item);
            }
            return this;
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
        /// Gets and sets the RequestId property.
        /// Request Id
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this.requestIdField ; }
            set { this.requestIdField= value; }
        }

        /// <summary>
        /// Sets the RequestId property
        /// </summary>
        /// <param name="requestId">Request Id</param>
        /// <returns>this instance</returns>
        public ErrorResponse WithRequestId(string requestId)
        {
            this.requestIdField = requestId;
            return this;
        }

        /// <summary>
        /// Checks if RequestId property is set
        /// </summary>
        /// <returns>true if RequestId property is set</returns>
        public bool IsSetRequestId()
        {
            return  this.requestIdField != null;
        }

        /// <summary>
        /// XML Representation for this object
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
    }
}
