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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomPermissions operation. Creates a custom
    /// permissions profile.
    /// </summary>
    public partial class CreateCustomPermissionsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that you want to create the custom permissions
        /// profile in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// A set of actions to include in the custom permissions profile.
        /// </para>
        /// </summary>
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// The name of the custom permissions profile that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CustomPermissionsName { get; set; }

        /// <summary>
        /// Checks to see if the CustomPermissionsName property is set.
        /// </summary>
        internal bool IsSetCustomPermissionsName() => this.CustomPermissionsName != null;

        /// <summary>
        /// Gets and sets the property Governance. 
        /// <para>
        /// The governance configuration for the custom permissions profile. When governance controls
        /// are defined for a category, any capabilities in that category not explicitly set to
        /// <c>ALLOW</c> in <c>Capabilities</c> are denied. Even newly added capabilities in the
        /// category are implicitly disabled when Amazon Quick releases them.
        /// </para>
        /// </summary>
        public Governance Governance { get; set; }

        /// <summary>
        /// Checks to see if the Governance property is set.
        /// </summary>
        internal bool IsSetGovernance() => this.Governance != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the custom permissions profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
