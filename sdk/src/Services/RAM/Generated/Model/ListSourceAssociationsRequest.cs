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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the ListSourceAssociations operation.
    /// Lists source associations for resource shares. Source associations control which sources
    /// can be used with service principals in resource shares. This operation provides visibility
    /// into source associations for resource share owners.
    /// 
    ///  
    /// <para>
    /// You can filter the results by resource share Amazon Resource Name (ARN), source ID,
    /// source type, or association status. We recommend using pagination to ensure that the
    /// operation returns quickly and successfully.
    /// </para>
    /// </summary>
    public partial class ListSourceAssociationsRequest : AmazonRAMRequest
    {
        private ResourceShareAssociationStatus _associationStatus;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceShareArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceId;
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The status of the source associations that you want to retrieve.
        /// </para>
        /// </summary>
        public ResourceShareAssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The pagination token that indicates the next set of results to retrieve.
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
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the resource shares for which you want to retrieve
        /// source associations.
        /// </para>
        /// </summary>
        public List<string> ResourceShareArns
        {
            get { return this._resourceShareArns; }
            set { this._resourceShareArns = value; }
        }

        // Check to see if ResourceShareArns property is set
        internal bool IsSetResourceShareArns()
        {
            return this._resourceShareArns != null && (this._resourceShareArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The identifier of the source for which you want to retrieve associations. This can
        /// be an account ID, Amazon Resource Name (ARN), organization ID, or organization path.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source for which you want to retrieve associations.
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}