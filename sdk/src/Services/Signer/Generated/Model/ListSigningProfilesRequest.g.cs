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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningProfiles operation. Lists all available
    /// signing profiles in your AWS account. Returns only profiles with an <c>ACTIVE</c>
    /// status unless the <c>includeCanceled</c> request field is set to <c>true</c>. If additional
    /// jobs remain to be listed, AWS Signer returns a <c>nextToken</c> value. Use this value
    /// in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining values. You can
    /// continue calling <c>ListSigningJobs</c> with your <c>maxResults</c> parameter and
    /// with new values that Signer returns in the <c>nextToken</c> parameter until all of
    /// your signing jobs have been returned.
    /// </summary>
    public partial class ListSigningProfilesRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeCanceled. 
        /// <para>
        /// Designates whether to include profiles with the status of <c>CANCELED</c>.
        /// </para>
        /// </summary>
        public bool? IncludeCanceled { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCanceled property is set.
        /// </summary>
        internal bool IsSetIncludeCanceled() => this.IncludeCanceled.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of profiles to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Value for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <c>nextToken</c> from the response that you just received.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// Filters results to return only signing jobs initiated for a specified signing platform.
        /// </para>
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Filters results to return only signing jobs with statuses in the specified list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
