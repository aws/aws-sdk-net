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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides a group of results for a query that retrieved aggregated statistical data
    /// about findings.
    /// </summary>
    public partial class GroupCount
    {
        private long? _count;
        private string _groupKey;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of findings in the group of query results.
        /// </para>
        /// </summary>
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupKey. 
        /// <para>
        /// The name of the property that defines the group in the query results, as specified
        /// by the groupBy property in the query request.
        /// </para>
        /// </summary>
        public string GroupKey
        {
            get { return this._groupKey; }
            set { this._groupKey = value; }
        }

        // Check to see if GroupKey property is set
        internal bool IsSetGroupKey()
        {
            return this._groupKey != null;
        }

    }
}