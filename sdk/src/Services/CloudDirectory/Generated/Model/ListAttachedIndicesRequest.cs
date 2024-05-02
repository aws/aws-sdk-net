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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the ListAttachedIndices operation.
    /// Lists indices attached to the specified object.
    /// </summary>
    public partial class ListAttachedIndicesRequest : AmazonCloudDirectoryRequest
    {
        private ConsistencyLevel _consistencyLevel;
        private string _directoryArn;
        private int? _maxResults;
        private string _nextToken;
        private ObjectReference _targetReference;

        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level to use for this operation.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel
        {
            get { return this._consistencyLevel; }
            set { this._consistencyLevel = value; }
        }

        // Check to see if ConsistencyLevel property is set
        internal bool IsSetConsistencyLevel()
        {
            return this._consistencyLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The pagination token.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetReference. 
        /// <para>
        /// A reference to the object that has indices attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference TargetReference
        {
            get { return this._targetReference; }
            set { this._targetReference = value; }
        }

        // Check to see if TargetReference property is set
        internal bool IsSetTargetReference()
        {
            return this._targetReference != null;
        }

    }
}