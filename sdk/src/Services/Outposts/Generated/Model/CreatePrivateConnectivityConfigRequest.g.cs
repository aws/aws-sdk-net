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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePrivateConnectivityConfig operation. Creates
    /// the private connectivity configuration for the specified Outpost. Private connectivity
    /// establishes a service link VPN connection between the Outpost and its home Amazon
    /// Web Services Region using a VPC and subnet that you specify, which allows the service
    /// link traffic to flow through your VPC and minimizes public internet exposure.
    /// </summary>
    public partial class CreatePrivateConnectivityConfigRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID or ARN of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property VpcInformationList. 
        /// <para>
        /// Information about the VPC used for private connectivity, including the VPC, its subnets,
        /// and an associated VPC endpoint. You can specify at most one entry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<VpcInformation> VpcInformationList { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcInformation>() : null;

        /// <summary>
        /// Checks to see if the VpcInformationList property is set.
        /// </summary>
        internal bool IsSetVpcInformationList() => this.VpcInformationList != null && (this.VpcInformationList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
