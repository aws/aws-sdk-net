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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a cross-account destination that receives subscription log events.
    /// </summary>
    public partial class Destination
    {
        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// An IAM policy document that governs which Amazon Web Services accounts can create
        /// subscription filters against this destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string AccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicy property is set.
        /// </summary>
        internal bool IsSetAccessPolicy() => this.AccessPolicy != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this destination.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the destination, expressed as the number of milliseconds after
        /// Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A role for impersonation, used when delivering log events to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the physical target where the log events are delivered
        /// (for example, a Kinesis stream).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
