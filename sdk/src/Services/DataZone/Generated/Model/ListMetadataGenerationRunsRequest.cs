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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetadataGenerationRuns operation.
    /// Lists all metadata generation runs.
    /// 
    ///  
    /// <para>
    /// Metadata generation runs represent automated processes that leverage AI/ML capabilities
    /// to create or enhance asset metadata at scale. This feature helps organizations maintain
    /// comprehensive and consistent metadata across large numbers of assets without manual
    /// intervention. It can automatically generate business descriptions, tags, and other
    /// metadata elements, significantly reducing the time and effort required for metadata
    /// management while improving consistency and completeness.
    /// </para>
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Valid domain identifier. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User must have access to metadata generation runs in the domain.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListMetadataGenerationRunsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private MetadataGenerationRunStatus _status;
        private MetadataGenerationRunType _type;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain where you want to list metadata generation runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of metadata generation runs to return in a single call to ListMetadataGenerationRuns.
        /// When the number of metadata generation runs to be listed is greater than the value
        /// of MaxResults, the response contains a NextToken value that you can use in a subsequent
        /// call to ListMetadataGenerationRuns to list the next set of revisions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// When the number of metadata generation runs is greater than the default value for
        /// the MaxResults parameter, or if you explicitly specify a value for MaxResults that
        /// is less than the number of metadata generation runs, the response includes a pagination
        /// token named NextToken. You can specify this NextToken value in a subsequent call to
        /// ListMetadataGenerationRuns to list the next set of revisions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the metadata generation runs.
        /// </para>
        /// </summary>
        public MetadataGenerationRunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metadata generation runs.
        /// </para>
        /// </summary>
        public MetadataGenerationRunType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}