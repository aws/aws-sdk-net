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
    /// Contains the aggregated resource count values for a specific point in the resources
    /// trend timeline.
    /// </summary>
    public partial class ResourcesTrendsValues
    {
        private ResourcesCount _resourcesCount;

        /// <summary>
        /// Gets and sets the property ResourcesCount. 
        /// <para>
        /// The resource count statistics for this data point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourcesCount ResourcesCount
        {
            get { return this._resourcesCount; }
            set { this._resourcesCount = value; }
        }

        // Check to see if ResourcesCount property is set
        internal bool IsSetResourcesCount()
        {
            return this._resourcesCount != null;
        }

    }
}