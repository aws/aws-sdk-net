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
    /// The detail of the partition field.
    /// </summary>
    public partial class DataLakeDatasetPartitionField
    {
        private string _name;
        private DataLakeDatasetPartitionFieldTransform _transform;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the partition field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Transform. 
        /// <para>
        /// The transformation of the partition field. A transformation specifies how to partition
        /// on a given field. For example, with timestamp you can specify that you'd like to partition
        /// fields by day, e.g. data record with value 2025-01-03T00:00:00Z in partition field
        /// is in 2025-01-03 partition. Also noted that data record without any value in optional
        /// partition field is in NULL partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataLakeDatasetPartitionFieldTransform Transform
        {
            get { return this._transform; }
            set { this._transform = value; }
        }

        // Check to see if Transform property is set
        internal bool IsSetTransform()
        {
            return this._transform != null;
        }

    }
}