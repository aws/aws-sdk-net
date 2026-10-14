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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configuration settings for connecting a router output to a MediaLive input.
    /// 
    ///  
    /// <para>
    /// To connect the router output to the MediaLive input, provide both <c>mediaLiveInputArn</c>
    /// and <c>mediaLivePipelineId</c>. To disconnect it, call the update operation and omit
    /// both fields while keeping this configuration object.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't change <c>destinationTransitEncryption</c> while the router output is connected
    /// to a MediaLive input. To change it, first disconnect the router output, then update
    /// the encryption.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MediaLiveInputRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationTransitEncryption. 
        /// <para>
        /// The encryption configuration for the MediaLive input when connected to this router
        /// output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaLiveTransitEncryption DestinationTransitEncryption { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTransitEncryption property is set.
        /// </summary>
        internal bool IsSetDestinationTransitEncryption() => this.DestinationTransitEncryption != null;

        /// <summary>
        /// Gets and sets the property MediaLiveInputArn. 
        /// <para>
        /// The ARN of the MediaLive input to connect to this router output.
        /// </para>
        /// </summary>
        public string MediaLiveInputArn { get; set; }

        /// <summary>
        /// Checks to see if the MediaLiveInputArn property is set.
        /// </summary>
        internal bool IsSetMediaLiveInputArn() => this.MediaLiveInputArn != null;

        /// <summary>
        /// Gets and sets the property MediaLivePipelineId. 
        /// <para>
        /// The index of the MediaLive pipeline to connect to this router output.
        /// </para>
        /// </summary>
        public MediaLiveInputPipelineId MediaLivePipelineId { get; set; }

        /// <summary>
        /// Checks to see if the MediaLivePipelineId property is set.
        /// </summary>
        internal bool IsSetMediaLivePipelineId() => this.MediaLivePipelineId != null;
    }
}
