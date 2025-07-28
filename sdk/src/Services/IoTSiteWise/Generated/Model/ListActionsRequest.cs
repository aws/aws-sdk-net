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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListActions operation.
    /// Retrieves a paginated list of actions for a specific target resource.
    /// </summary>
    public partial class ListActionsRequest : AmazonIoTSiteWiseRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resolveToResourceId;
        private ResolveToResourceType _resolveToResourceType;
        private string _targetResourceId;
        private TargetResourceType _targetResourceType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResolveToResourceId. 
        /// <para>
        /// The ID of the resolved resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ResolveToResourceId
        {
            get { return this._resolveToResourceId; }
            set { this._resolveToResourceId = value; }
        }

        // Check to see if ResolveToResourceId property is set
        internal bool IsSetResolveToResourceId()
        {
            return this._resolveToResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResolveToResourceType. 
        /// <para>
        /// The type of the resolved resource.
        /// </para>
        /// </summary>
        public ResolveToResourceType ResolveToResourceType
        {
            get { return this._resolveToResourceType; }
            set { this._resolveToResourceType = value; }
        }

        // Check to see if ResolveToResourceType property is set
        internal bool IsSetResolveToResourceType()
        {
            return this._resolveToResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The ID of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TargetResourceId
        {
            get { return this._targetResourceId; }
            set { this._targetResourceId = value; }
        }

        // Check to see if TargetResourceId property is set
        internal bool IsSetTargetResourceId()
        {
            return this._targetResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetResourceType TargetResourceType
        {
            get { return this._targetResourceType; }
            set { this._targetResourceType = value; }
        }

        // Check to see if TargetResourceType property is set
        internal bool IsSetTargetResourceType()
        {
            return this._targetResourceType != null;
        }

    }
}