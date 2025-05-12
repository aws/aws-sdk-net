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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The detail of the partition field transformation.
    /// </summary>
    public partial class DataLakeDatasetPartitionFieldTransform
    {
        private DataLakeDatasetPartitionTransformType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of partitioning transformation for this field. The available options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IDENTITY</b> - Partitions data on a given field by its exact values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>YEAR</b> - Partitions data on a timestamp field using year granularity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MONTH</b> - Partitions data on a timestamp field using month granularity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DAY</b> - Partitions data on a timestamp field using day granularity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HOUR</b> - Partitions data on a timestamp field using hour granularity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataLakeDatasetPartitionTransformType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}