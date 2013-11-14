/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Returns information about an HSM configuration, which is an object that describes to Amazon Redshift clusters the information they
    /// require to connect to an HSM where they can store database encryption keys.</para>
    /// </summary>
    public partial class HsmConfiguration
    {
        
        private string hsmConfigurationIdentifier;
        private string description;
        private string hsmIpAddress;
        private string hsmPartitionName;

        /// <summary>
        /// The name of the Amazon Redshift HSM configuration.
        ///  
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this.hsmConfigurationIdentifier; }
            set { this.hsmConfigurationIdentifier = value; }
        }

        /// <summary>
        /// Sets the HsmConfigurationIdentifier property
        /// </summary>
        /// <param name="hsmConfigurationIdentifier">The value to set for the HsmConfigurationIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmConfiguration WithHsmConfigurationIdentifier(string hsmConfigurationIdentifier)
        {
            this.hsmConfigurationIdentifier = hsmConfigurationIdentifier;
            return this;
        }
            

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this.hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// A text description of the HSM configuration.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmConfiguration WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The IP address that the Amazon Redshift cluster must use to access the HSM.
        ///  
        /// </summary>
        public string HsmIpAddress
        {
            get { return this.hsmIpAddress; }
            set { this.hsmIpAddress = value; }
        }

        /// <summary>
        /// Sets the HsmIpAddress property
        /// </summary>
        /// <param name="hsmIpAddress">The value to set for the HsmIpAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmConfiguration WithHsmIpAddress(string hsmIpAddress)
        {
            this.hsmIpAddress = hsmIpAddress;
            return this;
        }
            

        // Check to see if HsmIpAddress property is set
        internal bool IsSetHsmIpAddress()
        {
            return this.hsmIpAddress != null;
        }

        /// <summary>
        /// The name of the partition in the HSM where the Amazon Redshift clusters will store their database encryption keys.
        ///  
        /// </summary>
        public string HsmPartitionName
        {
            get { return this.hsmPartitionName; }
            set { this.hsmPartitionName = value; }
        }

        /// <summary>
        /// Sets the HsmPartitionName property
        /// </summary>
        /// <param name="hsmPartitionName">The value to set for the HsmPartitionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmConfiguration WithHsmPartitionName(string hsmPartitionName)
        {
            this.hsmPartitionName = hsmPartitionName;
            return this;
        }
            

        // Check to see if HsmPartitionName property is set
        internal bool IsSetHsmPartitionName()
        {
            return this.hsmPartitionName != null;
        }
    }
}
