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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the StartInvestigation operation. Detective investigations
    /// lets you investigate IAM users and IAM roles using indicators of compromise. An indicator
    /// of compromise (IOC) is an artifact observed in or on a network, system, or environment
    /// that can (with a high level of confidence) identify malicious activity or a security
    /// incident. <c>StartInvestigation</c> initiates an investigation on an entity in a behavior
    /// graph.
    /// </summary>
    public partial class StartInvestigationRequest : AmazonDetectiveRequest
    {
        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the IAM user and IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the behavior graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphArn { get; set; }

        /// <summary>
        /// Checks to see if the GraphArn property is set.
        /// </summary>
        internal bool IsSetGraphArn() => this.GraphArn != null;

        /// <summary>
        /// Gets and sets the property ScopeEndTime. 
        /// <para>
        /// The data and time when the investigation ended. The value is an UTC ISO8601 formatted
        /// string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ScopeEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ScopeEndTime property is set.
        /// </summary>
        internal bool IsSetScopeEndTime() => this.ScopeEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScopeStartTime. 
        /// <para>
        /// The data and time when the investigation began. The value is an UTC ISO8601 formatted
        /// string. For example, <c>2021-08-18T16:35:56.284Z</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ScopeStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScopeStartTime property is set.
        /// </summary>
        internal bool IsSetScopeStartTime() => this.ScopeStartTime.HasValue;
    }
}
