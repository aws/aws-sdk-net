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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a batch update partition error.
    /// </summary>
    public partial class BatchUpdatePartitionFailureEntry
    {
        private ErrorDetail _errorDetail;
        private List<string> _partitionValueList = new List<string>();

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// The details about the batch update partition error.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail
        {
            get { return this._errorDetail; }
            set { this._errorDetail = value; }
        }

        // Check to see if ErrorDetail property is set
        internal bool IsSetErrorDetail()
        {
            return this._errorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionValueList. 
        /// <para>
        /// A list of values defining the partitions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> PartitionValueList
        {
            get { return this._partitionValueList; }
            set { this._partitionValueList = value; }
        }

        // Check to see if PartitionValueList property is set
        internal bool IsSetPartitionValueList()
        {
            return this._partitionValueList != null && this._partitionValueList.Count > 0; 
        }

    }
}