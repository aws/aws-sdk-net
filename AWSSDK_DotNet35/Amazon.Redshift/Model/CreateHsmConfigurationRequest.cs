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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHsmConfiguration operation.
    /// <para>Creates an HSM configuration that contains the information required by an Amazon Redshift cluster to store and retrieve database
    /// encryption keys in a Hardware Storeage Module (HSM). After creating the HSM configuration, you can specify it as a parameter when creating a
    /// cluster. The cluster will then store its encryption keys in the HSM.</para> <para>Before creating an HSM configuration, you must have first
    /// created an HSM client certificate. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management Guide.</para>
    /// </summary>
    public partial class CreateHsmConfigurationRequest : AmazonRedshiftRequest
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

        // Check to see if HsmPartitionPassword property is set
        internal bool IsSetHsmPartitionPassword()
        {
            return this.hsmPartitionPassword != null;
        }

        /// <summary>
        /// The public key used to access the HSM client certificate, which was created by calling the Amazon Redshift create HSM certificate command.
        ///  
        /// </summary>
        public string HsmServerPublicCertificate
        {
            get { return this.hsmServerPublicCertificate; }
            set { this.hsmServerPublicCertificate = value; }
        }

        // Check to see if HsmServerPublicCertificate property is set
        internal bool IsSetHsmServerPublicCertificate()
        {
            return this.hsmServerPublicCertificate != null;
        }

    }
}
    
