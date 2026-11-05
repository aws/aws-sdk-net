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
    /// Container for the parameters to the ModifyAquaConfiguration operation. This operation
    /// is retired. Calling this operation does not change AQUA configuration. Amazon Redshift
    /// automatically determines whether to use AQUA (Advanced Query Accelerator).
    /// </summary>
    public partial class ModifyAquaConfigurationRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property AquaConfigurationStatus. 
        /// <para>
        /// This parameter is retired. Amazon Redshift automatically determines whether to use
        /// AQUA (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfigurationStatus AquaConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AquaConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetAquaConfigurationStatus() => this.AquaConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;
    }
}
