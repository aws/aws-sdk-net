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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains counts of resources for trend analysis.
    /// </summary>
    public partial class ResourcesCount
    {
        private long? _allResources;

        /// <summary>
        /// Gets and sets the property AllResources. 
        /// <para>
        /// The total count of all resources for the given time interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? AllResources
        {
            get { return this._allResources; }
            set { this._allResources = value; }
        }

        // Check to see if AllResources property is set
        internal bool IsSetAllResources()
        {
            return this._allResources.HasValue; 
        }

    }
}