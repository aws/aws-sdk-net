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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListInferenceComponents operation. Lists the inference
    /// components in your account and their properties.
    /// </summary>
    public partial class ListInferenceComponentsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Filters the results to only those inference components that were created after the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Filters the results to only those inference components that were created before the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointNameEquals. 
        /// <para>
        /// An endpoint name to filter the listed inference components. The response includes
        /// only those inference components that are hosted at the specified endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointNameEquals { get; set; }

        /// <summary>
        /// Checks to see if the EndpointNameEquals property is set.
        /// </summary>
        internal bool IsSetEndpointNameEquals() => this.EndpointNameEquals != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// Filters the results to only those inference components that were updated after the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeAfter() => this.LastModifiedTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// Filters the results to only those inference components that were updated before the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeBefore() => this.LastModifiedTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of inference components to return in the response. This value defaults
        /// to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Filters the results to only those inference components with a name that contains the
        /// specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that you use to get the next set of results following a truncated response.
        /// If the response to the previous request was truncated, that response provides the
        /// value for this token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field by which to sort the inference components in the response. The default is
        /// <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public InferenceComponentSortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for results. The default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public OrderKey SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filters the results to only those inference components with the specified status.
        /// </para>
        /// </summary>
        public InferenceComponentStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;

        /// <summary>
        /// Gets and sets the property VariantNameEquals. 
        /// <para>
        /// A production variant name to filter the listed inference components. The response
        /// includes only those inference components that are hosted at the specified variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VariantNameEquals { get; set; }

        /// <summary>
        /// Checks to see if the VariantNameEquals property is set.
        /// </summary>
        internal bool IsSetVariantNameEquals() => this.VariantNameEquals != null;
    }
}
