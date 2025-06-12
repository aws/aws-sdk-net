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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// A summary for sync blockers.
    /// </summary>
    public partial class SyncBlockerSummary
    {
        private List<SyncBlocker> _latestBlockers = AWSConfigs.InitializeCollections ? new List<SyncBlocker>() : null;
        private string _parentResourceName;
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property LatestBlockers. 
        /// <para>
        /// The latest events for a sync blocker summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SyncBlocker> LatestBlockers
        {
            get { return this._latestBlockers; }
            set { this._latestBlockers = value; }
        }

        // Check to see if LatestBlockers property is set
        internal bool IsSetLatestBlockers()
        {
            return this._latestBlockers != null && (this._latestBlockers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentResourceName. 
        /// <para>
        /// The parent resource name for a sync blocker summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ParentResourceName
        {
            get { return this._parentResourceName; }
            set { this._parentResourceName = value; }
        }

        // Check to see if ParentResourceName property is set
        internal bool IsSetParentResourceName()
        {
            return this._parentResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name for sync blocker summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

    }
}