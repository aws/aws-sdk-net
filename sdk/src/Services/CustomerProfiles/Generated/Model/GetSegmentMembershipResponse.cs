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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private List<ProfileQueryFailures> _failures = AWSConfigs.InitializeCollections ? new List<ProfileQueryFailures>() : null;
        private List<ProfileQueryResult> _profiles = AWSConfigs.InitializeCollections ? new List<ProfileQueryResult>() : null;
        private string _segmentDefinitionName;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// An array of maps where each contains a response per profile failed for the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileQueryFailures> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// An array of maps where each contains a response per profile requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileQueryResult> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The unique name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SegmentDefinitionName
        {
            get { return this._segmentDefinitionName; }
            set { this._segmentDefinitionName = value; }
        }

        // Check to see if SegmentDefinitionName property is set
        internal bool IsSetSegmentDefinitionName()
        {
            return this._segmentDefinitionName != null;
        }

    }
}