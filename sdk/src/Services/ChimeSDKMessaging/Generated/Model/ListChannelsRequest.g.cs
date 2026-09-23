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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannels operation. Lists all Channels created
    /// under a single Chime App as a paginated list. You can specify filters to narrow results.
    /// <para> <b>Functionality &amp; restrictions</b> </para> <ul> <li> <para> Use privacy
    /// = <c>PUBLIC</c> to retrieve all public channels in the account. </para> </li> <li>
    /// <para> Only an <c>AppInstanceAdmin</c> can set privacy = <c>PRIVATE</c> to list the
    /// private channels in an account. </para> </li> </ul> <note> <para> The <c>x-amz-chime-bearer</c>
    /// request header is mandatory. Use the ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c>
    /// that makes the API call as the value in the header. </para> </note>
    /// </summary>
    public partial class ListChannelsRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <c>AppInstance</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string AppInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceArn() => this.AppInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ChimeBearer. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c> or <c>AppInstanceBot</c> that makes the API
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChimeBearer { get; set; }

        /// <summary>
        /// Checks to see if the ChimeBearer property is set.
        /// </summary>
        internal bool IsSetChimeBearer() => this.ChimeBearer != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of channels that you want to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token passed by previous API calls until all requested channels are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Privacy. 
        /// <para>
        /// The privacy setting. <c>PUBLIC</c> retrieves all the public channels. <c>PRIVATE</c>
        /// retrieves private channels. Only an <c>AppInstanceAdmin</c> can retrieve private channels.
        /// 
        /// </para>
        /// </summary>
        public ChannelPrivacy Privacy { get; set; }

        /// <summary>
        /// Checks to see if the Privacy property is set.
        /// </summary>
        internal bool IsSetPrivacy() => this.Privacy != null;
    }
}
