/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about whether an Amazon Redshift cluster finished applying any hardware
    /// changes to security module (HSM) settings that were specified in a modify cluster
    /// command.
    /// </summary>
    public partial class AwsRedshiftClusterHsmStatus
    {
        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// The name of the HSM client certificate that the Amazon Redshift cluster uses to retrieve
        /// the data encryption keys that are stored in an HSM.
        /// </para>
        /// </summary>
        public string HsmClientCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmClientCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmClientCertificateIdentifier() => this.HsmClientCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// The name of the HSM configuration that contains the information that the Amazon Redshift
        /// cluster can use to retrieve and store keys in an HSM.
        /// </para>
        /// </summary>
        public string HsmConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmConfigurationIdentifier() => this.HsmConfigurationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether the Amazon Redshift cluster has finished applying any HSM settings
        /// changes specified in a modify cluster command.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>active</c> | <c>applying</c> 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
