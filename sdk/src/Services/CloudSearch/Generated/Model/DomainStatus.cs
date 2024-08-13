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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The current status of the search domain.
    /// </summary>
    public partial class DomainStatus
    {
        private string _arn;
        private bool? _created;
        private bool? _deleted;
        private ServiceEndpoint _docService;
        private string _domainId;
        private string _domainName;
        private Limits _limits;
        private bool? _processing;
        private bool? _requiresIndexDocuments;
        private int? _searchInstanceCount;
        private string _searchInstanceType;
        private int? _searchPartitionCount;
        private ServiceEndpoint _searchService;

        /// <summary>
        /// Gets and sets the property ARN.
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// True if the search domain is created. It can take several minutes to initialize a
        /// domain when <a>CreateDomain</a> is called. Newly created search domains are returned
        /// from <a>DescribeDomains</a> with a false value for Created until domain creation is
        /// complete.
        /// </para>
        /// </summary>
        public bool? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// True if the search domain has been deleted. The system must clean up resources dedicated
        /// to the search domain when <a>DeleteDomain</a> is called. Newly deleted search domains
        /// are returned from <a>DescribeDomains</a> with a true value for IsDeleted for several
        /// minutes until resource cleanup is complete.
        /// </para>
        /// </summary>
        public bool? Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocService. 
        /// <para>
        /// The service endpoint for updating documents in a search domain.
        /// </para>
        /// </summary>
        public ServiceEndpoint DocService
        {
            get { return this._docService; }
            set { this._docService = value; }
        }

        // Check to see if DocService property is set
        internal bool IsSetDocService()
        {
            return this._docService != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Limits.
        /// </summary>
        public Limits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// True if processing is being done to activate the current domain configuration.
        /// </para>
        /// </summary>
        public bool? Processing
        {
            get { return this._processing; }
            set { this._processing = value; }
        }

        // Check to see if Processing property is set
        internal bool IsSetProcessing()
        {
            return this._processing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiresIndexDocuments. 
        /// <para>
        /// True if <a>IndexDocuments</a> needs to be called to activate the current domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RequiresIndexDocuments
        {
            get { return this._requiresIndexDocuments; }
            set { this._requiresIndexDocuments = value; }
        }

        // Check to see if RequiresIndexDocuments property is set
        internal bool IsSetRequiresIndexDocuments()
        {
            return this._requiresIndexDocuments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchInstanceCount. 
        /// <para>
        /// The number of search instances that are available to process search requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? SearchInstanceCount
        {
            get { return this._searchInstanceCount; }
            set { this._searchInstanceCount = value; }
        }

        // Check to see if SearchInstanceCount property is set
        internal bool IsSetSearchInstanceCount()
        {
            return this._searchInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchInstanceType. 
        /// <para>
        /// The instance type that is being used to process search requests.
        /// </para>
        /// </summary>
        public string SearchInstanceType
        {
            get { return this._searchInstanceType; }
            set { this._searchInstanceType = value; }
        }

        // Check to see if SearchInstanceType property is set
        internal bool IsSetSearchInstanceType()
        {
            return this._searchInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property SearchPartitionCount. 
        /// <para>
        /// The number of partitions across which the search index is spread.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? SearchPartitionCount
        {
            get { return this._searchPartitionCount; }
            set { this._searchPartitionCount = value; }
        }

        // Check to see if SearchPartitionCount property is set
        internal bool IsSetSearchPartitionCount()
        {
            return this._searchPartitionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SearchService. 
        /// <para>
        /// The service endpoint for requesting search results from a search domain.
        /// </para>
        /// </summary>
        public ServiceEndpoint SearchService
        {
            get { return this._searchService; }
            set { this._searchService = value; }
        }

        // Check to see if SearchService property is set
        internal bool IsSetSearchService()
        {
            return this._searchService != null;
        }

    }
}