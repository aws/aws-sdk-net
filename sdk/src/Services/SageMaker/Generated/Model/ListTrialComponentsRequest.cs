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
    /// Container for the parameters to the ListTrialComponents operation.
    /// Lists the trial components in your account. You can sort the list by trial component
    /// name or creation time. You can filter the list to show only components that were created
    /// in a specific time range. You can also filter on one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>ExperimentName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SourceArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TrialName</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListTrialComponentsRequest : AmazonSageMakerRequest
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _experimentName;
        private int? _maxResults;
        private string _nextToken;
        private SortTrialComponentsBy _sortBy;
        private SortOrder _sortOrder;
        private string _sourceArn;
        private string _trialName;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// A filter that returns only components created after the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// A filter that returns only components created before the specified time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// A filter that returns only components that are part of the specified experiment. If
        /// you specify <c>ExperimentName</c>, you can't filter by <c>SourceArn</c> or <c>TrialName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string ExperimentName
        {
            get { return this._experimentName; }
            set { this._experimentName = value; }
        }

        // Check to see if ExperimentName property is set
        internal bool IsSetExperimentName()
        {
            return this._experimentName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of components to return in the response. The default value is 10.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous call to <c>ListTrialComponents</c> didn't return the full set of components,
        /// the call returns a token for getting the next set of components.
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
        /// The property used to sort results. The default value is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SortTrialComponentsBy SortBy
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
        /// The sort order. The default value is <c>Descending</c>.
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
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// A filter that returns only components that have the specified source Amazon Resource
        /// Name (ARN). If you specify <c>SourceArn</c>, you can't filter by <c>ExperimentName</c>
        /// or <c>TrialName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// A filter that returns only components that are part of the specified trial. If you
        /// specify <c>TrialName</c>, you can't filter by <c>ExperimentName</c> or <c>SourceArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string TrialName
        {
            get { return this._trialName; }
            set { this._trialName = value; }
        }

        // Check to see if TrialName property is set
        internal bool IsSetTrialName()
        {
            return this._trialName != null;
        }

    }
}