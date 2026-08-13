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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Specifies the minimum number of distinct identities for an individual output column.
    /// This value overrides the table-wide <c>minimumIdentityCount</c> that you set in <c>AggregationThreshold</c>.
    /// </summary>
    public partial class OutputColumnThreshold
    {
        private int? _minimumIdentityCount;
        private string _outputColumnName;

        /// <summary>
        /// Gets and sets the property MinimumIdentityCount. 
        /// <para>
        /// The minimum number of distinct identities that each query output group must represent
        /// for this column. Specify 0 to exempt the column from the threshold, or a value of
        /// 2 or greater to enforce a threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100000)]
        public int? MinimumIdentityCount
        {
            get { return this._minimumIdentityCount; }
            set { this._minimumIdentityCount = value; }
        }

        // Check to see if MinimumIdentityCount property is set
        internal bool IsSetMinimumIdentityCount()
        {
            return this._minimumIdentityCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputColumnName. 
        /// <para>
        /// The name of the output column that the override applies to. You can specify each column
        /// only once.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string OutputColumnName
        {
            get { return this._outputColumnName; }
            set { this._outputColumnName = value; }
        }

        // Check to see if OutputColumnName property is set
        internal bool IsSetOutputColumnName()
        {
            return this._outputColumnName != null;
        }

    }
}