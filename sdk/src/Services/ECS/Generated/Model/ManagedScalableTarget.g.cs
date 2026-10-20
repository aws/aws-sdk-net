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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Represents a scalable target.
    /// </summary>
    public partial class ManagedScalableTarget
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the scalable target.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum value to scale to in response to a scale-out activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum value to scale to in response to a scale-in activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinCapacity property is set.
        /// </summary>
        internal bool IsSetMinCapacity() => this.MinCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the scalable target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagedResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the scalable target is in the current status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for when the target was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
