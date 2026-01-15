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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
        private float? _maxIndexingCapacityInOCU;
        private float? _maxSearchCapacityInOCU;
        private float? _minIndexingCapacityInOCU;
        private float? _minSearchCapacityInOCU;

        /// <summary>
        /// Gets and sets the property MaxIndexingCapacityInOCU. 
        /// <para>
        /// The maximum indexing capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public float MaxIndexingCapacityInOCU
        {
            get { return this._maxIndexingCapacityInOCU.GetValueOrDefault(); }
            set { this._maxIndexingCapacityInOCU = value; }
        }

        // Check to see if MaxIndexingCapacityInOCU property is set
        internal bool IsSetMaxIndexingCapacityInOCU()
        {
            return this._maxIndexingCapacityInOCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSearchCapacityInOCU. 
        /// <para>
        /// The maximum search capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public float MaxSearchCapacityInOCU
        {
            get { return this._maxSearchCapacityInOCU.GetValueOrDefault(); }
            set { this._maxSearchCapacityInOCU = value; }
        }

        // Check to see if MaxSearchCapacityInOCU property is set
        internal bool IsSetMaxSearchCapacityInOCU()
        {
            return this._maxSearchCapacityInOCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIndexingCapacityInOCU. 
        /// <para>
        /// The minimum indexing capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public float MinIndexingCapacityInOCU
        {
            get { return this._minIndexingCapacityInOCU.GetValueOrDefault(); }
            set { this._minIndexingCapacityInOCU = value; }
        }

        // Check to see if MinIndexingCapacityInOCU property is set
        internal bool IsSetMinIndexingCapacityInOCU()
        {
            return this._minIndexingCapacityInOCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSearchCapacityInOCU. 
        /// <para>
        /// The minimum search capacity for collections in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public float MinSearchCapacityInOCU
        {
            get { return this._minSearchCapacityInOCU.GetValueOrDefault(); }
            set { this._minSearchCapacityInOCU = value; }
        }

        // Check to see if MinSearchCapacityInOCU property is set
        internal bool IsSetMinSearchCapacityInOCU()
        {
            return this._minSearchCapacityInOCU.HasValue; 
        }

    }
}