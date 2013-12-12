/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The current status of the search domain.</para>
    /// </summary>
    public class DomainStatus
    {
        
        private string domainId;
        private string domainName;
        private bool? created;
        private bool? deleted;
        private long? numSearchableDocs;
        private ServiceEndpoint docService;
        private ServiceEndpoint searchService;
        private bool? requiresIndexDocuments;
        private bool? processing;
        private string searchInstanceType;
        private int? searchPartitionCount;
        private int? searchInstanceCount;


        /// <summary>
        /// An internally generated unique identifier for a domain.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this.domainId; }
            set { this.domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this.domainId != null;
        }

        /// <summary>
        /// A string that represents the name of a domain. Domain names must be unique across the domains owned by an account within an AWS region.
        /// Domain names must start with a letter or number and can contain the following characters: a-z (lowercase), 0-9, and - (hyphen). Uppercase
        /// letters and underscores are not allowed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// True if the search domain is created. It can take several minutes to initialize a domain when <a>CreateDomain</a> is called. Newly created
        /// search domains are returned from <a>DescribeDomains</a> with a false value for Created until domain creation is complete.
        ///  
        /// </summary>
        public bool Created
        {
            get { return this.created ?? default(bool); }
            set { this.created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this.created.HasValue;
        }

        /// <summary>
        /// True if the search domain has been deleted. The system must clean up resources dedicated to the search domain when <a>DeleteDomain</a> is
        /// called. Newly deleted search domains are returned from <a>DescribeDomains</a> with a true value for IsDeleted for several minutes until
        /// resource cleanup is complete.
        ///  
        /// </summary>
        public bool Deleted
        {
            get { return this.deleted ?? default(bool); }
            set { this.deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this.deleted.HasValue;
        }

        /// <summary>
        /// The number of documents that have been submitted to the domain and indexed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long NumSearchableDocs
        {
            get { return this.numSearchableDocs ?? default(long); }
            set { this.numSearchableDocs = value; }
        }

        // Check to see if NumSearchableDocs property is set
        internal bool IsSetNumSearchableDocs()
        {
            return this.numSearchableDocs.HasValue;
        }

        /// <summary>
        /// The service endpoint for updating documents in a search domain.
        ///  
        /// </summary>
        public ServiceEndpoint DocService
        {
            get { return this.docService; }
            set { this.docService = value; }
        }

        // Check to see if DocService property is set
        internal bool IsSetDocService()
        {
            return this.docService != null;
        }

        /// <summary>
        /// The service endpoint for requesting search results from a search domain.
        ///  
        /// </summary>
        public ServiceEndpoint SearchService
        {
            get { return this.searchService; }
            set { this.searchService = value; }
        }

        // Check to see if SearchService property is set
        internal bool IsSetSearchService()
        {
            return this.searchService != null;
        }

        /// <summary>
        /// True if <a>IndexDocuments</a> needs to be called to activate the current domain configuration.
        ///  
        /// </summary>
        public bool RequiresIndexDocuments
        {
            get { return this.requiresIndexDocuments ?? default(bool); }
            set { this.requiresIndexDocuments = value; }
        }

        // Check to see if RequiresIndexDocuments property is set
        internal bool IsSetRequiresIndexDocuments()
        {
            return this.requiresIndexDocuments.HasValue;
        }

        /// <summary>
        /// True if processing is being done to activate the current domain configuration.
        ///  
        /// </summary>
        public bool Processing
        {
            get { return this.processing ?? default(bool); }
            set { this.processing = value; }
        }

        // Check to see if Processing property is set
        internal bool IsSetProcessing()
        {
            return this.processing.HasValue;
        }

        /// <summary>
        /// The instance type (such as search.m1.small) that is being used to process search requests.
        ///  
        /// </summary>
        public string SearchInstanceType
        {
            get { return this.searchInstanceType; }
            set { this.searchInstanceType = value; }
        }

        // Check to see if SearchInstanceType property is set
        internal bool IsSetSearchInstanceType()
        {
            return this.searchInstanceType != null;
        }

        /// <summary>
        /// The number of partitions across which the search index is spread.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int SearchPartitionCount
        {
            get { return this.searchPartitionCount ?? default(int); }
            set { this.searchPartitionCount = value; }
        }

        // Check to see if SearchPartitionCount property is set
        internal bool IsSetSearchPartitionCount()
        {
            return this.searchPartitionCount.HasValue;
        }

        /// <summary>
        /// The number of search instances that are available to process search requests.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int SearchInstanceCount
        {
            get { return this.searchInstanceCount ?? default(int); }
            set { this.searchInstanceCount = value; }
        }

        // Check to see if SearchInstanceCount property is set
        internal bool IsSetSearchInstanceCount()
        {
            return this.searchInstanceCount.HasValue;
        }
    }
}
