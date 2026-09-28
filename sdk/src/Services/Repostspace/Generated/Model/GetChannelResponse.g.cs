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

namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// This is the response object from the GetChannel operation.
    /// </summary>
    public partial class GetChannelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChannelDescription. 
        /// <para>
        /// A description for the channel. This is used only to help you identify this channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string ChannelDescription { get; set; }

        /// <summary>
        /// Checks to see if the ChannelDescription property is set.
        /// </summary>
        internal bool IsSetChannelDescription() => this.ChannelDescription != null;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique ID of the private re:Post channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 24)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name for the channel. This must be unique per private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelRoles. 
        /// <para>
        /// The channel roles associated to the users and groups of the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> ChannelRoles { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the ChannelRoles property is set.
        /// </summary>
        internal bool IsSetChannelRoles() => this.ChannelRoles != null && (this.ChannelRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// The status pf the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelStatus ChannelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ChannelStatus property is set.
        /// </summary>
        internal bool IsSetChannelStatus() => this.ChannelStatus != null;

        /// <summary>
        /// Gets and sets the property CreateDateTime. 
        /// <para>
        /// The date when the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateDateTime property is set.
        /// </summary>
        internal bool IsSetCreateDateTime() => this.CreateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteDateTime. 
        /// <para>
        /// The date when the channel was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteDateTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDateTime property is set.
        /// </summary>
        internal bool IsSetDeleteDateTime() => this.DeleteDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
