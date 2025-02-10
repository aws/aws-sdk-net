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
    /// Container for the parameters to the ListConnections operation.
    /// Lists connections. In Amazon DataZone, a connection enables you to connect your resources
    /// (domains, projects, and environments) to external resources and services.
    /// </summary>
    public partial class ListConnectionsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _environmentIdentifier;
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private string _projectIdentifier;
        private SortFieldConnection _sortBy;
        private SortOrder _sortOrder;
        private ConnectionType _type;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to list connections.
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
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment where you want to list connections.
        /// </para>
        /// </summary>
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of connections to return in a single call to ListConnections. When
        /// the number of connections to be listed is greater than the value of MaxResults, the
        /// response contains a NextToken value that you can use in a subsequent call to ListConnections
        /// to list the next set of connections.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of connections is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of connections, the response includes a pagination token named NextToken. You
        /// can specify this NextToken value in a subsequent call to ListConnections to list the
        /// next set of connections.
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
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The ID of the project where you want to list connections.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectIdentifier
        {
            get { return this._projectIdentifier; }
            set { this._projectIdentifier = value; }
        }

        // Check to see if ProjectIdentifier property is set
        internal bool IsSetProjectIdentifier()
        {
            return this._projectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies how you want to sort the listed connections.
        /// </para>
        /// </summary>
        public SortFieldConnection SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sort order for the listed connections.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of connection.
        /// </para>
        /// </summary>
        public ConnectionType Type
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