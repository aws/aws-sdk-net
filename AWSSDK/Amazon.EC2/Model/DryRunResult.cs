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
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// DryRun result
    /// 
    /// If the dry-run was successful, the IsSuccessful field will be set to true;
    /// otherwise, false.
    /// More information may be available on the Message and Error fields.
    /// </summary>
    public class DryRunResult
    {
        private bool? isSuccessfulField;
        private string messageField;
        private Exception errorField;

        /// <summary>
        /// Flag that signals if you have the required permissions to execute the request.
        /// </summary>
        public bool IsSuccessful
        {
            get { return this.isSuccessfulField.GetValueOrDefault(); }
            set { this.isSuccessfulField = value; }
        }

        /// <summary>
        /// Checks if IsSuccessful property is set
        /// </summary>
        /// <returns>true if IsSuccessful property is set</returns>
        public bool IsSetIsSuccessful()
        {
            return isSuccessfulField.HasValue;
        }


        /// <summary>
        /// Message associated with the response.
        /// </summary>
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
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
        /// Exception associated with the response, if there was one.
        /// </summary>
        public Exception Error
        {
            get { return this.errorField; }
            set { this.errorField = value; }
        }

        /// <summary>
        /// Checks if Error property is set
        /// </summary>
        /// <returns>true if Error property is set</returns>
        public bool IsSetError()
        {
            return this.errorField != null;
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
