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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNodeRegistrationScript operation. Create
    /// the Register Node script for all the nodes intended for a specific Cluster. You will
    /// then run the script on each hardware unit that is intended for that Cluster. The script
    /// creates a Node in the specified Cluster. It then binds the Node to this hardware unit,
    /// and activates the node hardware for use with MediaLive Anywhere.
    /// </summary>
    public partial class CreateNodeRegistrationScriptRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterId. The ID of the cluster
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Id. If you're generating a re-registration script for an
        /// already existing node, this is where you provide the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. Specify a pattern for MediaLive Anywhere to use to
        /// assign a name to each Node in the Cluster. The pattern can include the variables $hn
        /// (hostname of the node hardware) and $ts for the date and time that the Node is created,
        /// in UTC (for example, 2024-08-20T23:35:12Z).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NodeInterfaceMappings. Documentation update needed
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeInterfaceMapping> NodeInterfaceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeInterfaceMapping>() : null;

        /// <summary>
        /// Checks to see if the NodeInterfaceMappings property is set.
        /// </summary>
        internal bool IsSetNodeInterfaceMappings() => this.NodeInterfaceMappings != null && (this.NodeInterfaceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestId. An ID that you assign to a create request. This
        /// ID ensures idempotency when creating resources.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Role. The initial role of the Node in the Cluster. ACTIVE
        /// means the Node is available for encoding. BACKUP means the Node is a redundant Node
        /// and might get used if an ACTIVE Node fails.
        /// </summary>
        public NodeRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
