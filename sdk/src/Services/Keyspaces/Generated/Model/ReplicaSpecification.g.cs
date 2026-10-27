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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The Amazon Web Services Region specific settings of a multi-Region table.
    /// 
    ///  
    /// <para>
    /// For a multi-Region table, you can configure the table's read capacity differently
    /// per Amazon Web Services Region. You can do this by configuring the following parameters.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>region</c>: The Region where these settings are applied. (Required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>readCapacityUnits</c>: The provisioned read capacity units. (Optional)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>readCapacityAutoScaling</c>: The read capacity auto scaling settings for the table.
    /// (Optional)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ReplicaSpecification
    {
        /// <summary>
        /// Gets and sets the property ReadCapacityAutoScaling. 
        /// <para>
        /// The read capacity auto scaling settings for the multi-Region table in the specified
        /// Amazon Web Services Region.
        /// </para>
        /// </summary>
        public AutoScalingSettings ReadCapacityAutoScaling { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityAutoScaling property is set.
        /// </summary>
        internal bool IsSetReadCapacityAutoScaling() => this.ReadCapacityAutoScaling != null;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The provisioned read capacity units for the multi-Region table in the specified Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 25)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
