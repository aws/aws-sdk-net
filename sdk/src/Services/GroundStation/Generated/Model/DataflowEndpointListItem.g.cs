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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Item in a list of <c>DataflowEndpoint</c> groups.
    /// </summary>
    public partial class DataflowEndpointListItem
    {
        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupArn. 
        /// <para>
        /// ARN of a dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 97, Max = 146)]
        public string DataflowEndpointGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DataflowEndpointGroupArn property is set.
        /// </summary>
        internal bool IsSetDataflowEndpointGroupArn() => this.DataflowEndpointGroupArn != null;

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupId. 
        /// <para>
        /// UUID of a dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DataflowEndpointGroupId { get; set; }

        /// <summary>
        /// Checks to see if the DataflowEndpointGroupId property is set.
        /// </summary>
        internal bool IsSetDataflowEndpointGroupId() => this.DataflowEndpointGroupId != null;
    }
}
