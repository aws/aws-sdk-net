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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that displays information about one destination that CloudWatch RUM sends
    /// extended metrics to.
    /// </summary>
    public partial class MetricDestinationSummary
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Specifies whether the destination is <c>CloudWatch</c> or <c>Evidently</c>.
        /// </para>
        /// </summary>
        public MetricDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// If the destination is <c>Evidently</c>, this specifies the ARN of the Evidently experiment
        /// that receives the metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// This field appears only when the destination is <c>Evidently</c>. It specifies the
        /// ARN of the IAM role that is used to write to the Evidently experiment that receives
        /// the metrics.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;
    }
}
