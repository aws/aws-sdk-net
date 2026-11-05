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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ARN.
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// True if the search domain is created. It can take several minutes to initialize a
        /// domain when <a>CreateDomain</a> is called. Newly created search domains are returned
        /// from <a>DescribeDomains</a> with a false value for Created until domain creation is
        /// complete.
        /// </para>
        /// </summary>
        public bool? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// True if the search domain has been deleted. The system must clean up resources dedicated
        /// to the search domain when <a>DeleteDomain</a> is called. Newly deleted search domains
        /// are returned from <a>DescribeDomains</a> with a true value for IsDeleted for several
        /// minutes until resource cleanup is complete.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property DocService. 
        /// <para>
        /// The service endpoint for updating documents in a search domain.
        /// </para>
        /// </summary>
        public ServiceEndpoint DocService { get; set; }

        /// <summary>
        /// Checks to see if the DocService property is set.
        /// </summary>
        internal bool IsSetDocService() => this.DocService != null;

        /// <summary>
        /// Gets and sets the property DomainId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Limits.
        /// </summary>
        public Limits Limits { get; set; }

        /// <summary>
        /// Checks to see if the Limits property is set.
        /// </summary>
        internal bool IsSetLimits() => this.Limits != null;

        /// <summary>
        /// Gets and sets the property Processing. 
        /// <para>
        /// True if processing is being done to activate the current domain configuration.
        /// </para>
        /// </summary>
        public bool? Processing { get; set; }

        /// <summary>
        /// Checks to see if the Processing property is set.
        /// </summary>
        internal bool IsSetProcessing() => this.Processing.HasValue;

        /// <summary>
        /// Gets and sets the property RequiresIndexDocuments. 
        /// <para>
        /// True if <a>IndexDocuments</a> needs to be called to activate the current domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? RequiresIndexDocuments { get; set; }

        /// <summary>
        /// Checks to see if the RequiresIndexDocuments property is set.
        /// </summary>
        internal bool IsSetRequiresIndexDocuments() => this.RequiresIndexDocuments.HasValue;

        /// <summary>
        /// Gets and sets the property SearchInstanceCount. 
        /// <para>
        /// The number of search instances that are available to process search requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? SearchInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the SearchInstanceCount property is set.
        /// </summary>
        internal bool IsSetSearchInstanceCount() => this.SearchInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SearchInstanceType. 
        /// <para>
        /// The instance type that is being used to process search requests.
        /// </para>
        /// </summary>
        public string SearchInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SearchInstanceType property is set.
        /// </summary>
        internal bool IsSetSearchInstanceType() => this.SearchInstanceType != null;

        /// <summary>
        /// Gets and sets the property SearchPartitionCount. 
        /// <para>
        /// The number of partitions across which the search index is spread.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? SearchPartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the SearchPartitionCount property is set.
        /// </summary>
        internal bool IsSetSearchPartitionCount() => this.SearchPartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SearchService. 
        /// <para>
        /// The service endpoint for requesting search results from a search domain.
        /// </para>
        /// </summary>
        public ServiceEndpoint SearchService { get; set; }

        /// <summary>
        /// Checks to see if the SearchService property is set.
        /// </summary>
        internal bool IsSetSearchService() => this.SearchService != null;
    }
}
