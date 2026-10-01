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
    /// This is the response object from the PutChannelMembershipPreferences operation.
    /// </summary>
    public partial class PutChannelMembershipPreferencesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        /// The details of a user.
        /// </para>
        /// </summary>
        public Identity Member { get; set; }

        /// <summary>
        /// Checks to see if the Member property is set.
        /// </summary>
        internal bool IsSetMember() => this.Member != null;

        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// The ARN and metadata of the member being added.
        /// </para>
        /// </summary>
        public ChannelMembershipPreferences Preferences { get; set; }

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null;
    }
}
