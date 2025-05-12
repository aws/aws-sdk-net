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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the ListInferenceComponents operation.
    /// Lists the inference components in your account and their properties.
    /// </summary>
    public partial class ListInferenceComponentsRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _endpointNameEquals;
        private DateTime? _lastModifiedTimeAfter;
        private DateTime? _lastModifiedTimeBefore;
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private InferenceComponentSortKey _sortBy;
        private OrderKey _sortOrder;
        private InferenceComponentStatus _statusEquals;
        private string _variantNameEquals;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Filters the results to only those inference components that were created after the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Filters the results to only those inference components that were created before the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointNameEquals. 
        /// <para>
        /// An endpoint name to filter the listed inference components. The response includes
        /// only those inference components that are hosted at the specified endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string EndpointNameEquals
        {
            get { return this._endpointNameEquals; }
            set { this._endpointNameEquals = value; }
        }

        // Check to see if EndpointNameEquals property is set
        internal bool IsSetEndpointNameEquals()
        {
            return this._endpointNameEquals != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// Filters the results to only those inference components that were updated after the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter
        {
            get { return this._lastModifiedTimeAfter; }
            set { this._lastModifiedTimeAfter = value; }
        }

        // Check to see if LastModifiedTimeAfter property is set
        internal bool IsSetLastModifiedTimeAfter()
        {
            return this._lastModifiedTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// Filters the results to only those inference components that were updated before the
        /// specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore
        {
            get { return this._lastModifiedTimeBefore; }
            set { this._lastModifiedTimeBefore = value; }
        }

        // Check to see if LastModifiedTimeBefore property is set
        internal bool IsSetLastModifiedTimeBefore()
        {
            return this._lastModifiedTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of inference components to return in the response. This value defaults
        /// to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Filters the results to only those inference components with a name that contains the
        /// specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that you use to get the next set of results following a truncated response.
        /// If the response to the previous request was truncated, that response provides the
        /// value for this token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field by which to sort the inference components in the response. The default is
        /// <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public InferenceComponentSortKey SortBy
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
        /// The sort order for results. The default is <c>Descending</c>.
        /// </para>
        /// </summary>
        public OrderKey SortOrder
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
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Filters the results to only those inference components with the specified status.
        /// </para>
        /// </summary>
        public InferenceComponentStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

        /// <summary>
        /// Gets and sets the property VariantNameEquals. 
        /// <para>
        /// A production variant name to filter the listed inference components. The response
        /// includes only those inference components that are hosted at the specified variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string VariantNameEquals
        {
            get { return this._variantNameEquals; }
            set { this._variantNameEquals = value; }
        }

        // Check to see if VariantNameEquals property is set
        internal bool IsSetVariantNameEquals()
        {
            return this._variantNameEquals != null;
        }

    }
}