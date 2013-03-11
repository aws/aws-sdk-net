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
    /// Describe Vpc Attributes Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVpcAttributeResult
    {
        private string vpcIdField;
        private bool? enableDnsSupportField;
        private bool? enableDnsHostnamesField;


        /// <summary>
        /// Id of the target VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }


        /// <summary>
        /// Flag that signals if the EnableDnsSupport attribute is true or false.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableDnsSupport")]
        public bool EnableDnsSupport
        {
            get { return this.enableDnsSupportField.GetValueOrDefault(); }
            set { this.enableDnsSupportField = value; }
        }

        /// <summary>
        /// Checks if EnableDnsSupport property is set
        /// </summary>
        /// <returns>true if EnableDnsSupport property is set</returns>
        public bool IsSetEnableDnsSupport()
        {
            return enableDnsSupportField.HasValue;
        }


        /// <summary>
        /// Flag that signals if the EnableDnsHostnames attribute is true or false.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableDnsHostnames")]
        public bool EnableDnsHostnames
        {
            get { return this.enableDnsHostnamesField.GetValueOrDefault(); }
            set { this.enableDnsHostnamesField = value; }
        }

        /// <summary>
        /// Checks if EnableDnsHostnames property is set
        /// </summary>
        /// <returns>true if EnableDnsHostnames property is set</returns>
        public bool IsSetEnableDnsHostnames()
        {
            return enableDnsHostnamesField.HasValue;
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
