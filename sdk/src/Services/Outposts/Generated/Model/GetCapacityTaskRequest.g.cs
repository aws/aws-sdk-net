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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the GetCapacityTask operation. Gets details of the
    /// specified capacity task.
    /// </summary>
    public partial class GetCapacityTaskRequest : AmazonOutpostsRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityTaskId. 
        /// <para>
        /// ID of the capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string CapacityTaskId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityTaskId property is set.
        /// </summary>
        internal bool IsSetCapacityTaskId() => this.CapacityTaskId != null;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// ID or ARN of the Outpost associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string OutpostIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OutpostIdentifier property is set.
        /// </summary>
        internal bool IsSetOutpostIdentifier() => this.OutpostIdentifier != null;
    }
}
