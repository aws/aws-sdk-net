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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The free trial period for a Security Hub feature, and whether the trial is currently
    /// active.
    /// </summary>
    public partial class FreeTrialStatus
    {
        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time at which the free trial period ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The feature that the free trial period applies to. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SECURITY_HUB_V2</c> specifies Security Hub.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECURITY_HUB_V2_MULTI_CLOUD_AZURE</c> specifies Security Hub coverage for Microsoft
        /// Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FreeTrialType FeatureType { get; set; }

        /// <summary>
        /// Checks to see if the FeatureType property is set.
        /// </summary>
        internal bool IsSetFeatureType() => this.FeatureType != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time at which the free trial period began.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the free trial period is currently active. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> specifies that the free trial period is ongoing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> specifies that the free trial period has ended, or that it never
        /// started.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine whether a trial has expired, compare <c>ExpiresAt</c> to the current
        /// time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FreeTrialStatusValue Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
