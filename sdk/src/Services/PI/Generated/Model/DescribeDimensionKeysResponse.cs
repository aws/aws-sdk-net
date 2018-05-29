/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the DescribeDimensionKeys operation.
    /// </summary>
    public partial class DescribeDimensionKeysResponse : AmazonWebServiceResponse
    {
        private DateTime? _alignedEndTime;
        private DateTime? _alignedStartTime;
        private List<DimensionKeyDescription> _keys = new List<DimensionKeyDescription>();
        private string _nextToken;
        private List<ResponsePartitionKey> _partitionKeys = new List<ResponsePartitionKey>();

        /// <summary>
        /// Gets and sets the property AlignedEndTime. 
        /// <para>
        /// The end time for the returned dimension keys, after alignment to a granular boundary
        /// (as specified by <code>PeriodInSeconds</code>). <code>AlignedEndTime</code> will be
        /// greater than or equal to the value of the user-specified <code>Endtime</code>.
        /// </para>
        /// </summary>
        public DateTime AlignedEndTime
        {
            get { return this._alignedEndTime.GetValueOrDefault(); }
            set { this._alignedEndTime = value; }
        }

        // Check to see if AlignedEndTime property is set
        internal bool IsSetAlignedEndTime()
        {
            return this._alignedEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlignedStartTime. 
        /// <para>
        /// The start time for the returned dimension keys, after alignment to a granular boundary
        /// (as specified by <code>PeriodInSeconds</code>). <code>AlignedStartTime</code> will
        /// be less than or equal to the value of the user-specified <code>StartTime</code>.
        /// </para>
        /// </summary>
        public DateTime AlignedStartTime
        {
            get { return this._alignedStartTime.GetValueOrDefault(); }
            set { this._alignedStartTime = value; }
        }

        // Check to see if AlignedStartTime property is set
        internal bool IsSetAlignedStartTime()
        {
            return this._alignedStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The dimension keys that were requested.
        /// </para>
        /// </summary>
        public List<DimensionKeyDescription> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// If <code>PartitionBy</code> was present in the request, <code>PartitionKeys</code>
        /// contains the breakdown of dimension keys by the specified partitions.
        /// </para>
        /// </summary>
        public List<ResponsePartitionKey> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && this._partitionKeys.Count > 0; 
        }

    }
}