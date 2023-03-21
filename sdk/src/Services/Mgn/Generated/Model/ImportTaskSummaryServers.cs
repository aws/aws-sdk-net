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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import task summary servers.
    /// </summary>
    public partial class ImportTaskSummaryServers
    {
        private long? _createdCount;
        private long? _modifiedCount;

        /// <summary>
        /// Gets and sets the property CreatedCount. 
        /// <para>
        /// Import task summary servers created count.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CreatedCount
        {
            get { return this._createdCount.GetValueOrDefault(); }
            set { this._createdCount = value; }
        }

        // Check to see if CreatedCount property is set
        internal bool IsSetCreatedCount()
        {
            return this._createdCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedCount. 
        /// <para>
        /// Import task summary servers modified count.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ModifiedCount
        {
            get { return this._modifiedCount.GetValueOrDefault(); }
            set { this._modifiedCount = value; }
        }

        // Check to see if ModifiedCount property is set
        internal bool IsSetModifiedCount()
        {
            return this._modifiedCount.HasValue; 
        }

    }
}