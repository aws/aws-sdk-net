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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLimit operation. Updates the properties
    /// of the specified limit.
    /// </summary>
    public partial class UpdateLimitRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new display name of the limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The unique identifier of the farm that contains
        /// the limit.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property LimitId. The unique identifier of the limit to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string LimitId { get; set; }

        /// <summary>
        /// Checks to see if the LimitId property is set.
        /// </summary>
        internal bool IsSetLimitId() => this.LimitId != null;

        /// <summary>
        /// Gets and sets the property MaxCount. The maximum number of resources constrained by
        /// this limit. When all of the resources are in use, steps that require the limit won't
        /// be scheduled until the resource is available. If more than the new maximum number
        /// is currently in use, running jobs finish but no new jobs are started until the number
        /// of resources in use is below the new maximum number. The <c>maxCount</c> must not
        /// be 0. If the value is -1, there is no restriction on the number of resources that
        /// can be acquired for this limit.
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount.HasValue;
    }
}
