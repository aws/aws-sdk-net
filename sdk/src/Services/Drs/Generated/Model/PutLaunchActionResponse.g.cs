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
    /// This is the response object from the PutLaunchAction operation.
    /// </summary>
    public partial class PutLaunchActionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionCode. 
        /// <para>
        /// Launch action code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Checks to see if the ActionCode property is set.
        /// </summary>
        internal bool IsSetActionCode() => this.ActionCode != null;

        /// <summary>
        /// Gets and sets the property ActionId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ActionVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string ActionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ActionVersion property is set.
        /// </summary>
        internal bool IsSetActionVersion() => this.ActionVersion != null;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Whether the launch action is active.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property Category.
        /// </summary>
        public LaunchActionCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Whether the launch will not be marked as failed if this action fails.
        /// </para>
        /// </summary>
        public bool? Optional { get; set; }

        /// <summary>
        /// Checks to see if the Optional property is set.
        /// </summary>
        internal bool IsSetOptional() => this.Optional.HasValue;

        /// <summary>
        /// Gets and sets the property Order.
        /// </summary>
        [AWSProperty(Min = 2, Max = 10000)]
        public int? Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public Dictionary<string, LaunchActionParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, LaunchActionParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Launch action type.
        /// </para>
        /// </summary>
        public LaunchActionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
