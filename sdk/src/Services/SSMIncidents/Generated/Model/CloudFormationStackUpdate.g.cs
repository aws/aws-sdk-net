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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Information about an CloudFormation stack creation or update that occurred around
    /// the time of an incident and could be a potential cause of the incident.
    /// </summary>
    public partial class CloudFormationStackUpdate
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp for when the CloudFormation stack creation or update ended. Not reported
        /// for deployments that are still in progress.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StackArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudFormation stack involved in the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string StackArn { get; set; }

        /// <summary>
        /// Checks to see if the StackArn property is set.
        /// </summary>
        internal bool IsSetStackArn() => this.StackArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp for when the CloudFormation stack creation or update began.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
