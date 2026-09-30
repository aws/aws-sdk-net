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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetSegmentMembership operation.
    /// </summary>
    public partial class GetSegmentMembershipResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// An array of maps where each contains a response per profile failed for the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileQueryFailures> Failures { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfileQueryFailures>() : null;

        /// <summary>
        /// Checks to see if the Failures property is set.
        /// </summary>
        internal bool IsSetFailures() => this.Failures != null && (this.Failures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastComputedAt. 
        /// <para>
        /// The timestamp indicating when the segment membership was last computed or updated.
        /// </para>
        /// </summary>
        public DateTime? LastComputedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastComputedAt property is set.
        /// </summary>
        internal bool IsSetLastComputedAt() => this.LastComputedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// An array of maps where each contains a response per profile requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileQueryResult> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfileQueryResult>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The unique name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SegmentDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDefinitionName property is set.
        /// </summary>
        internal bool IsSetSegmentDefinitionName() => this.SegmentDefinitionName != null;
    }
}
