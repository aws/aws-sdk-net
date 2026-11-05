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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Capacity limits for a collection group. These limits define the minimum and maximum
    /// OpenSearch Compute Units (OCUs) for indexing and search operations that can be used
    /// by collections in the group.
    /// </summary>
    public partial class CollectionGroupCapacityLimits
    {
        /// <summary>
        /// Gets and sets the property MaxIndexingCapacityInOCU. 
        /// <para>
        /// The maximum indexing capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public float? MaxIndexingCapacityInOCU { get; set; }

        /// <summary>
        /// Checks to see if the MaxIndexingCapacityInOCU property is set.
        /// </summary>
        internal bool IsSetMaxIndexingCapacityInOCU() => this.MaxIndexingCapacityInOCU.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSearchCapacityInOCU. 
        /// <para>
        /// The maximum search capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public float? MaxSearchCapacityInOCU { get; set; }

        /// <summary>
        /// Checks to see if the MaxSearchCapacityInOCU property is set.
        /// </summary>
        internal bool IsSetMaxSearchCapacityInOCU() => this.MaxSearchCapacityInOCU.HasValue;

        /// <summary>
        /// Gets and sets the property MinIndexingCapacityInOCU. 
        /// <para>
        /// The minimum indexing capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? MinIndexingCapacityInOCU { get; set; }

        /// <summary>
        /// Checks to see if the MinIndexingCapacityInOCU property is set.
        /// </summary>
        internal bool IsSetMinIndexingCapacityInOCU() => this.MinIndexingCapacityInOCU.HasValue;

        /// <summary>
        /// Gets and sets the property MinSearchCapacityInOCU. 
        /// <para>
        /// The minimum search capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? MinSearchCapacityInOCU { get; set; }

        /// <summary>
        /// Checks to see if the MinSearchCapacityInOCU property is set.
        /// </summary>
        internal bool IsSetMinSearchCapacityInOCU() => this.MinSearchCapacityInOCU.HasValue;
    }
}
