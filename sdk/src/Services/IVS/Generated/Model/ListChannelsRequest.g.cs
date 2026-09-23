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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannels operation. Gets summary information
    /// about all channels in your account, in the Amazon Web Services region where the API
    /// request is processed. This list can be filtered to match a specified name or recording-configuration
    /// ARN. Filters are mutually exclusive and cannot be used together. If you try to use
    /// both filters, you will get an error (409 ConflictException).
    /// </summary>
    public partial class ListChannelsRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property FilterByAdConfigurationArn. 
        /// <para>
        /// Filters the channel list to match the specified ad configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FilterByAdConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterByAdConfigurationArn property is set.
        /// </summary>
        internal bool IsSetFilterByAdConfigurationArn() => this.FilterByAdConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property FilterByName. 
        /// <para>
        /// Filters the channel list to match the specified name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FilterByName { get; set; }

        /// <summary>
        /// Checks to see if the FilterByName property is set.
        /// </summary>
        internal bool IsSetFilterByName() => this.FilterByName != null;

        /// <summary>
        /// Gets and sets the property FilterByPlaybackRestrictionPolicyArn. 
        /// <para>
        /// Filters the channel list to match the specified policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FilterByPlaybackRestrictionPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterByPlaybackRestrictionPolicyArn property is set.
        /// </summary>
        internal bool IsSetFilterByPlaybackRestrictionPolicyArn() => this.FilterByPlaybackRestrictionPolicyArn != null;

        /// <summary>
        /// Gets and sets the property FilterByRecordingConfigurationArn. 
        /// <para>
        /// Filters the channel list to match the specified recording-configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FilterByRecordingConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterByRecordingConfigurationArn property is set.
        /// </summary>
        internal bool IsSetFilterByRecordingConfigurationArn() => this.FilterByRecordingConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of channels to return. Default: 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The first channel to retrieve. This is used for pagination; see the <c>nextToken</c>
        /// response field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
