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
    /// Modifies attributes of a VPC.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ModifyVpcAttributeRequest
    {
        private string vpcIdField;
        private bool? enableDnsSupportField;
        private bool? enableDnsHostnamesField;

        /// <summary>
        /// VPC ID to modify.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VPC ID to describe.
        /// </summary>
        /// <param name="vpcId">VPC ID to describe.</param>
        /// <returns>this instance</returns>
        public ModifyVpcAttributeRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
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
        /// Whether Dns is supported.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableDnsSupport")]
        public bool EnableDnsSupport
        {
            get { return this.enableDnsSupportField.GetValueOrDefault(); }
            set { this.enableDnsSupportField = value; }
        }

        /// <summary>
        /// Sets whether Dns is supported.
        /// </summary>
        /// <param name="enableDnsSupport">Whether Dns is supported.</param>
        /// <returns>this instance</returns>
        public ModifyVpcAttributeRequest WithEnableDnsSupport(bool enableDnsSupport)
        {
            this.enableDnsSupportField = enableDnsSupport;
            return this;
        }

        /// <summary>
        /// Checks if EnableDnsSupport property is set
        /// </summary>
        /// <returns>true if EnableDnsSupport property is set</returns>
        public bool IsSetEnableDnsSupport()
        {
            return this.enableDnsSupportField.HasValue;
        }


        /// <summary>
        /// Whether Dns hostnames are enabled.
        /// </summary>
        [XmlElementAttribute(ElementName = "EnableDnsHostnames")]
        public bool EnableDnsHostnames
        {
            get { return this.enableDnsHostnamesField.GetValueOrDefault(); }
            set { this.enableDnsHostnamesField = value; }
        }

        /// <summary>
        /// Sets whether Dns hostnames are enabled.
        /// </summary>
        /// <param name="enableDnsHostnames">Whether Dns hostnames are enabled.</param>
        /// <returns>this instance</returns>
        public ModifyVpcAttributeRequest WithEnableDnsHostnames(bool enableDnsHostnames)
        {
            this.enableDnsHostnamesField = enableDnsHostnames;
            return this;
        }

        /// <summary>
        /// Checks if EnableDnsHostnames property is set
        /// </summary>
        /// <returns>true if Egress property is set</returns>
        public bool IsSetEnableDnsHostnames()
        {
            return this.enableDnsHostnamesField.HasValue;
        }

    }
}
