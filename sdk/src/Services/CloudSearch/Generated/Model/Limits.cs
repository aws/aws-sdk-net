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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Limits
    {
        private int? _maximumPartitionCount;
        private int? _maximumReplicationCount;

        /// <summary>
        /// Gets and sets the property MaximumPartitionCount.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaximumPartitionCount
        {
            get { return this._maximumPartitionCount; }
            set { this._maximumPartitionCount = value; }
        }

        // Check to see if MaximumPartitionCount property is set
        internal bool IsSetMaximumPartitionCount()
        {
            return this._maximumPartitionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumReplicationCount.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaximumReplicationCount
        {
            get { return this._maximumReplicationCount; }
            set { this._maximumReplicationCount = value; }
        }

        // Check to see if MaximumReplicationCount property is set
        internal bool IsSetMaximumReplicationCount()
        {
            return this._maximumReplicationCount.HasValue; 
        }

    }
}