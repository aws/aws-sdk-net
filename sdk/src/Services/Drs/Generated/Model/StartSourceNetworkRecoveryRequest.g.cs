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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the StartSourceNetworkRecovery operation. Deploy VPC
    /// for the specified Source Network and modify launch templates to use this network.
    /// The VPC will be deployed using a dedicated CloudFormation stack.
    /// </summary>
    public partial class StartSourceNetworkRecoveryRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property DeployAsNew. 
        /// <para>
        /// Don't update existing CloudFormation Stack, recover the network using a new stack.
        /// </para>
        /// </summary>
        public bool? DeployAsNew { get; set; }

        /// <summary>
        /// Checks to see if the DeployAsNew property is set.
        /// </summary>
        internal bool IsSetDeployAsNew() => this.DeployAsNew.HasValue;

        /// <summary>
        /// Gets and sets the property SourceNetworks. 
        /// <para>
        /// The Source Networks that we want to start a Recovery Job for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<StartSourceNetworkRecoveryRequestNetworkEntry> SourceNetworks { get; set; } = AWSConfigs.InitializeCollections ? new List<StartSourceNetworkRecoveryRequestNetworkEntry>() : null;

        /// <summary>
        /// Checks to see if the SourceNetworks property is set.
        /// </summary>
        internal bool IsSetSourceNetworks() => this.SourceNetworks != null && (this.SourceNetworks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the Source Network recovery Job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
