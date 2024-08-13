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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Limits on the number of instances that can be created in OpenSearch Service for a
    /// given instance type.
    /// </summary>
    public partial class InstanceCountLimits
    {
        private int? _maximumInstanceCount;
        private int? _minimumInstanceCount;

        /// <summary>
        /// Gets and sets the property MaximumInstanceCount. 
        /// <para>
        /// The minimum allowed number of instances.
        /// </para>
        /// </summary>
        public int? MaximumInstanceCount
        {
            get { return this._maximumInstanceCount; }
            set { this._maximumInstanceCount = value; }
        }

        // Check to see if MaximumInstanceCount property is set
        internal bool IsSetMaximumInstanceCount()
        {
            return this._maximumInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumInstanceCount. 
        /// <para>
        /// The maximum allowed number of instances.
        /// </para>
        /// </summary>
        public int? MinimumInstanceCount
        {
            get { return this._minimumInstanceCount; }
            set { this._minimumInstanceCount = value; }
        }

        // Check to see if MinimumInstanceCount property is set
        internal bool IsSetMinimumInstanceCount()
        {
            return this._minimumInstanceCount.HasValue; 
        }

    }
}