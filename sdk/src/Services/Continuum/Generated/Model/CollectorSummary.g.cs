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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// A summary of a Collector returned in list responses.
    /// </summary>
    public partial class CollectorSummary
    {
        /// <summary>
        /// Gets and sets the property CollectorArn. The ARN of the Collector.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string CollectorArn { get; set; }

        /// <summary>
        /// Checks to see if the CollectorArn property is set.
        /// </summary>
        internal bool IsSetCollectorArn() => this.CollectorArn != null;

        /// <summary>
        /// Gets and sets the property CollectorId. The unique identifier of the Collector.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CollectorId { get; set; }

        /// <summary>
        /// Checks to see if the CollectorId property is set.
        /// </summary>
        internal bool IsSetCollectorId() => this.CollectorId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the Collector was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. The current lifecycle status.
        /// </summary>
        [AWSProperty(Required = true)]
        public CollectorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. The source collected by this Collector.
        /// </summary>
        [AWSProperty(Required = true)]
        public CollectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
