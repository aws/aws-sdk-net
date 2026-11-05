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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannelClass operation. Changes the class
    /// of the channel.
    /// </summary>
    public partial class UpdateChannelClassRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelClass. The channel class that you wish to update
        /// this channel to use.
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelClass ChannelClass { get; set; }

        /// <summary>
        /// Checks to see if the ChannelClass property is set.
        /// </summary>
        internal bool IsSetChannelClass() => this.ChannelClass != null;

        /// <summary>
        /// Gets and sets the property ChannelId. Channel Id of the channel whose class should
        /// be updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property Destinations. A list of output destinations for this channel.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
