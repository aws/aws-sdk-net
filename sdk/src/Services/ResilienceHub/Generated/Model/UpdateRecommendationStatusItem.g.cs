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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the operational recommendation item that needs a status update.
    /// </summary>
    public partial class UpdateRecommendationStatusItem
    {
        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Resource identifier of the operational recommendation item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// Identifier of the target Amazon Web Services account.
        /// </para>
        /// </summary>
        public string TargetAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccountId property is set.
        /// </summary>
        internal bool IsSetTargetAccountId() => this.TargetAccountId != null;

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// Identifier of the target Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string TargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the TargetRegion property is set.
        /// </summary>
        internal bool IsSetTargetRegion() => this.TargetRegion != null;
    }
}
