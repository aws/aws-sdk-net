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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// The status of Change History for the hosted zone.
    /// </summary>
    public partial class ChangeHistoryFeature
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether Change History is turned on for the hosted zone. Valid values are
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Change History is turned on for the hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Change History is turned off for the hosted zone.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Route 53 turns Change History on or off when the hosted zone moves to or from a tier
        /// that includes it.
        /// </para>
        /// </summary>
        public FeatureEnablement Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property RetentionStartsAt. 
        /// <para>
        /// The earliest date and time from which you can read the change history of the hosted
        /// zone. Route 53 returns this value only when <c>Status</c> is <c>ENABLED</c>.
        /// </para>
        /// </summary>
        public DateTime? RetentionStartsAt { get; set; }

        /// <summary>
        /// Checks to see if the RetentionStartsAt property is set.
        /// </summary>
        internal bool IsSetRetentionStartsAt() => this.RetentionStartsAt.HasValue;
    }
}
