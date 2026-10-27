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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// An object that represents a resource that is under DDoS protection.
    /// </summary>
    public partial class Protection
    {
        /// <summary>
        /// Gets and sets the property ApplicationLayerAutomaticResponseConfiguration. 
        /// <para>
        /// The automatic application layer DDoS mitigation settings for the protection. This
        /// configuration determines whether Shield Advanced automatically manages rules in the
        /// web ACL in order to respond to application layer events that Shield Advanced determines
        /// to be DDoS attacks. 
        /// </para>
        /// </summary>
        public ApplicationLayerAutomaticResponseConfiguration ApplicationLayerAutomaticResponseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationLayerAutomaticResponseConfiguration property is set.
        /// </summary>
        internal bool IsSetApplicationLayerAutomaticResponseConfiguration() => this.ApplicationLayerAutomaticResponseConfiguration != null;

        /// <summary>
        /// Gets and sets the property HealthCheckIds. 
        /// <para>
        /// The unique identifier (ID) for the Route 53 health check that's associated with the
        /// protection. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HealthCheckIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HealthCheckIds property is set.
        /// </summary>
        internal bool IsSetHealthCheckIds() => this.HealthCheckIds != null && (this.HealthCheckIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of the protection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the protection. For example, <c>My CloudFront distributions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProtectionArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the protection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProtectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ProtectionArn property is set.
        /// </summary>
        internal bool IsSetProtectionArn() => this.ProtectionArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the Amazon Web Services resource that is protected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
