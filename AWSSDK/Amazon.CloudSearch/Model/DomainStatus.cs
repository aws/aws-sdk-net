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
        private int? numSearchableDocs;
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

        /// <summary>
        /// Sets the DomainId property
        /// </summary>
        /// <param name="domainId">The value to set for the DomainId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithDomainId(string domainId)
        {
            this.domainId = domainId;
            return this;
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

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithDomainName(string domainName)
        {
            this.domainName = domainName;
            return this;
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

        /// <summary>
        /// Sets the Created property
        /// </summary>
        /// <param name="created">The value to set for the Created property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithCreated(bool created)
        {
            this.created = created;
            return this;
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

        /// <summary>
        /// Sets the Deleted property
        /// </summary>
        /// <param name="deleted">The value to set for the Deleted property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithDeleted(bool deleted)
        {
            this.deleted = deleted;
            return this;
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
        public int NumSearchableDocs
        {
            get { return this.numSearchableDocs ?? default(int); }
            set { this.numSearchableDocs = value; }
        }

        /// <summary>
        /// Sets the NumSearchableDocs property
        /// </summary>
        /// <param name="numSearchableDocs">The value to set for the NumSearchableDocs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithNumSearchableDocs(int numSearchableDocs)
        {
            this.numSearchableDocs = numSearchableDocs;
            return this;
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

        /// <summary>
        /// Sets the DocService property
        /// </summary>
        /// <param name="docService">The value to set for the DocService property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithDocService(ServiceEndpoint docService)
        {
            this.docService = docService;
            return this;
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

        /// <summary>
        /// Sets the SearchService property
        /// </summary>
        /// <param name="searchService">The value to set for the SearchService property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithSearchService(ServiceEndpoint searchService)
        {
            this.searchService = searchService;
            return this;
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

        /// <summary>
        /// Sets the RequiresIndexDocuments property
        /// </summary>
        /// <param name="requiresIndexDocuments">The value to set for the RequiresIndexDocuments property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithRequiresIndexDocuments(bool requiresIndexDocuments)
        {
            this.requiresIndexDocuments = requiresIndexDocuments;
            return this;
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

        /// <summary>
        /// Sets the Processing property
        /// </summary>
        /// <param name="processing">The value to set for the Processing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithProcessing(bool processing)
        {
            this.processing = processing;
            return this;
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

        /// <summary>
        /// Sets the SearchInstanceType property
        /// </summary>
        /// <param name="searchInstanceType">The value to set for the SearchInstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithSearchInstanceType(string searchInstanceType)
        {
            this.searchInstanceType = searchInstanceType;
            return this;
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

        /// <summary>
        /// Sets the SearchPartitionCount property
        /// </summary>
        /// <param name="searchPartitionCount">The value to set for the SearchPartitionCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithSearchPartitionCount(int searchPartitionCount)
        {
            this.searchPartitionCount = searchPartitionCount;
            return this;
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

        /// <summary>
        /// Sets the SearchInstanceCount property
        /// </summary>
        /// <param name="searchInstanceCount">The value to set for the SearchInstanceCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainStatus WithSearchInstanceCount(int searchInstanceCount)
        {
            this.searchInstanceCount = searchInstanceCount;
            return this;
        }
            

        // Check to see if SearchInstanceCount property is set
        internal bool IsSetSearchInstanceCount()
        {
            return this.searchInstanceCount.HasValue;
        }
    }
}
