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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// A count of noncompliant resources.
    /// </summary>
    public partial class Summary
    {
        private DateTime? _lastUpdated;
        private long? _nonCompliantResources;
        private string _region;
        private string _resourceType;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The timestamp that shows when this summary was generated in this Region. 
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantResources. 
        /// <para>
        /// The count of noncompliant resources.
        /// </para>
        /// </summary>
        public long NonCompliantResources
        {
            get { return this._nonCompliantResources.GetValueOrDefault(); }
            set { this._nonCompliantResources = value; }
        }

        // Check to see if NonCompliantResources property is set
        internal bool IsSetNonCompliantResources()
        {
            return this._nonCompliantResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region that the summary applies to.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The account identifier or the root identifier of the organization. If you don't know
        /// the root ID, you can call the AWS Organizations <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_ListRoots.html">ListRoots</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=68)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}