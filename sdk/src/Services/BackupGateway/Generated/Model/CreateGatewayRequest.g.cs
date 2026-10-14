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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGateway operation. Creates a backup gateway.
    /// After you create a gateway, you can associate it with a server using the <c>AssociateGatewayToServer</c>
    /// operation.
    /// </summary>
    public partial class CreateGatewayRequest : AmazonBackupGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// The activation key of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string ActivationKey { get; set; }

        /// <summary>
        /// Checks to see if the ActivationKey property is set.
        /// </summary>
        internal bool IsSetActivationKey() => this.ActivationKey != null;

        /// <summary>
        /// Gets and sets the property GatewayDisplayName. 
        /// <para>
        /// The display name of the created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string GatewayDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the GatewayDisplayName property is set.
        /// </summary>
        internal bool IsSetGatewayDisplayName() => this.GatewayDisplayName != null;

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of created gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayType GatewayType { get; set; }

        /// <summary>
        /// Checks to see if the GatewayType property is set.
        /// </summary>
        internal bool IsSetGatewayType() => this.GatewayType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags to assign to the gateway. Each tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
