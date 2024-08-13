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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// A count of noncompliant resources.
    /// </summary>
    public partial class Summary
    {
        private string _lastUpdated;
        private long? _nonCompliantResources;
        private string _region;
        private string _resourceType;
        private string _targetId;
        private TargetIdType _targetIdType;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The timestamp that shows when this summary was generated in this Region. 
        /// </para>
        /// </summary>
        public string LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property NonCompliantResources. 
        /// <para>
        /// The count of noncompliant resources.
        /// </para>
        /// </summary>
        public long? NonCompliantResources
        {
            get { return this._nonCompliantResources; }
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
        /// The Amazon Web Services Region that the summary applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The Amazon Web Services resource type.
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
        /// the root ID, you can call the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_ListRoots.html">ListRoots</a>
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

        /// <summary>
        /// Gets and sets the property TargetIdType. 
        /// <para>
        /// Whether the target is an account, an OU, or the organization root.
        /// </para>
        /// </summary>
        public TargetIdType TargetIdType
        {
            get { return this._targetIdType; }
            set { this._targetIdType = value; }
        }

        // Check to see if TargetIdType property is set
        internal bool IsSetTargetIdType()
        {
            return this._targetIdType != null;
        }

    }
}