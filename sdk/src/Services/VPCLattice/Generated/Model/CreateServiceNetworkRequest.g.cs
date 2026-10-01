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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceNetwork operation. Creates a service
    /// network. A service network is a logical boundary for a collection of services. You
    /// can associate services and VPCs with a service network. <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-networks.html">Service
    /// networks</a> in the <i>Amazon VPC Lattice User Guide</i>. </para>
    /// </summary>
    public partial class CreateServiceNetworkRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of IAM policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: The resource does not use an IAM policy. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM</c>: The resource uses an IAM policy. When this type is used, auth is
        /// enabled and an auth policy is required.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service network. The name must be unique to the account. The valid
        /// characters are a-z, 0-9, and hyphens (-). You can't use a hyphen as the first or last
        /// character, or immediately after another hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SharingConfig. 
        /// <para>
        /// Specify if the service network should be enabled for sharing.
        /// </para>
        /// </summary>
        public SharingConfig SharingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SharingConfig property is set.
        /// </summary>
        internal bool IsSetSharingConfig() => this.SharingConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the service network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
