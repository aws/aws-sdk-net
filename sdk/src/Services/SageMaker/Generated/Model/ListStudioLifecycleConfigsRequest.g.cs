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
    /// Container for the parameters to the ListStudioLifecycleConfigs operation. Lists the
    /// Amazon SageMaker AI Studio Lifecycle Configurations in your Amazon Web Services Account.
    /// </summary>
    public partial class ListStudioLifecycleConfigsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppTypeEquals. 
        /// <para>
        /// A parameter to search for the App Type to which the Lifecycle Configuration is attached.
        /// </para>
        /// </summary>
        public StudioLifecycleConfigAppType AppTypeEquals { get; set; }

        /// <summary>
        /// Checks to see if the AppTypeEquals property is set.
        /// </summary>
        internal bool IsSetAppTypeEquals() => this.AppTypeEquals != null;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only Lifecycle Configurations created on or after the specified
        /// time.
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
        /// A filter that returns only Lifecycle Configurations created on or before the specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of items to return in the response. If the total number of items
        /// available is more than the value specified, a <c>NextToken</c> is provided in the
        /// response. To resume pagination, provide the <c>NextToken</c> value in the as part
        /// of a subsequent call. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only Lifecycle Configurations modified after the specified time.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimeAfter property is set.
        /// </summary>
        internal bool IsSetModifiedTimeAfter() => this.ModifiedTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only Lifecycle Configurations modified before the specified
        /// time.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimeBefore property is set.
        /// </summary>
        internal bool IsSetModifiedTimeBefore() => this.ModifiedTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string in the Lifecycle Configuration name. This filter returns only Lifecycle Configurations
        /// whose name contains the specified string.
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
        /// If the previous call to ListStudioLifecycleConfigs didn't return the full set of Lifecycle
        /// Configurations, the call returns a token for getting the next set of Lifecycle Configurations.
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
        /// The property used to sort results. The default value is CreationTime.
        /// </para>
        /// </summary>
        public StudioLifecycleConfigSortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order. The default value is Descending.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
