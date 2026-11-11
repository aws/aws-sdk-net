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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of changes to HSM settings.
    /// </summary>
    public partial class HsmStatus
    {
        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// Specifies the name of the HSM client certificate the Amazon Redshift cluster uses
        /// to retrieve the data encryption keys stored in an HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmClientCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmClientCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmClientCertificateIdentifier() => this.HsmClientCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// Specifies the name of the HSM configuration that contains the information the Amazon
        /// Redshift cluster can use to retrieve and store keys in an HSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string HsmConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the HsmConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetHsmConfigurationIdentifier() => this.HsmConfigurationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reports whether the Amazon Redshift cluster has finished applying any HSM settings
        /// changes specified in a modify cluster command.
        /// </para>
        ///  
        /// <para>
        /// Values: active, applying
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
