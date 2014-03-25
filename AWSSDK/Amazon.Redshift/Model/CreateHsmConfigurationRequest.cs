/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHsmConfiguration operation.
    /// <para>Creates an HSM configuration that contains the information required by an Amazon Redshift cluster to store and use database encryption
    /// keys in a Hardware Security Module (HSM). After creating the HSM configuration, you can specify it as a parameter when creating a cluster.
    /// The cluster will then store its encryption keys in the HSM.</para> <para>In addition to creating an HSM configuration, you must also create
    /// an HSM client certificate. For more information, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html"
    /// >Hardware Security Modules</a> in the Amazon Redshift Management Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.CreateHsmConfiguration"/>
    public class CreateHsmConfigurationRequest : AmazonWebServiceRequest
    {
        private string hsmConfigurationIdentifier;
        private string description;
        private string hsmIpAddress;
        private string hsmPartitionName;
        private string hsmPartitionPassword;
        private string hsmServerPublicCertificate;

        /// <summary>
        /// The identifier to be assigned to the new Amazon Redshift HSM configuration.
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
        public CreateHsmConfigurationRequest WithHsmConfigurationIdentifier(string hsmConfigurationIdentifier)
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
        /// A text description of the HSM configuration to be created.
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
        public CreateHsmConfigurationRequest WithDescription(string description)
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
        public CreateHsmConfigurationRequest WithHsmIpAddress(string hsmIpAddress)
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
        public CreateHsmConfigurationRequest WithHsmPartitionName(string hsmPartitionName)
        {
            this.hsmPartitionName = hsmPartitionName;
            return this;
        }
            

        // Check to see if HsmPartitionName property is set
        internal bool IsSetHsmPartitionName()
        {
            return this.hsmPartitionName != null;
        }

        /// <summary>
        /// The password required to access the HSM partition.
        ///  
        /// </summary>
        public string HsmPartitionPassword
        {
            get { return this.hsmPartitionPassword; }
            set { this.hsmPartitionPassword = value; }
        }

        /// <summary>
        /// Sets the HsmPartitionPassword property
        /// </summary>
        /// <param name="hsmPartitionPassword">The value to set for the HsmPartitionPassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHsmConfigurationRequest WithHsmPartitionPassword(string hsmPartitionPassword)
        {
            this.hsmPartitionPassword = hsmPartitionPassword;
            return this;
        }
            

        // Check to see if HsmPartitionPassword property is set
        internal bool IsSetHsmPartitionPassword()
        {
            return this.hsmPartitionPassword != null;
        }

        /// <summary>
        /// The HSMs public certificate file. When using Cloud HSM, the file name is server.pem.
        ///  
        /// </summary>
        public string HsmServerPublicCertificate
        {
            get { return this.hsmServerPublicCertificate; }
            set { this.hsmServerPublicCertificate = value; }
        }

        /// <summary>
        /// Sets the HsmServerPublicCertificate property
        /// </summary>
        /// <param name="hsmServerPublicCertificate">The value to set for the HsmServerPublicCertificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHsmConfigurationRequest WithHsmServerPublicCertificate(string hsmServerPublicCertificate)
        {
            this.hsmServerPublicCertificate = hsmServerPublicCertificate;
            return this;
        }
            

        // Check to see if HsmServerPublicCertificate property is set
        internal bool IsSetHsmServerPublicCertificate()
        {
            return this.hsmServerPublicCertificate != null;
        }
    }
}
    
