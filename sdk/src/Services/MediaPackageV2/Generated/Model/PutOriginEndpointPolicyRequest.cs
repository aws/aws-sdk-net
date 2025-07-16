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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutOriginEndpointPolicy operation.
    /// Attaches an IAM policy to the specified origin endpoint. You can attach only one policy
    /// with each request.
    /// </summary>
    public partial class PutOriginEndpointPolicyRequest : AmazonMediaPackageV2Request
    {
        private CdnAuthConfiguration _cdnAuthConfiguration;
        private string _channelGroupName;
        private string _channelName;
        private string _originEndpointName;
        private string _policy;

        /// <summary>
        /// Gets and sets the property CdnAuthConfiguration. 
        /// <para>
        /// The settings for using authorization headers between the MediaPackage endpoint and
        /// your CDN. 
        /// </para>
        ///  
        /// <para>
        /// For information about CDN authorization, see <a href="https://docs.aws.amazon.com/mediapackage/latest/userguide/cdn-auth.html">CDN
        /// authorization in Elemental MediaPackage</a> in the MediaPackage user guide. 
        /// </para>
        /// </summary>
        public CdnAuthConfiguration CdnAuthConfiguration
        {
            get { return this._cdnAuthConfiguration; }
            set { this._cdnAuthConfiguration = value; }
        }

        // Check to see if CdnAuthConfiguration property is set
        internal bool IsSetCdnAuthConfiguration()
        {
            return this._cdnAuthConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelGroupName
        {
            get { return this._channelGroupName; }
            set { this._channelGroupName = value; }
        }

        // Check to see if ChannelGroupName property is set
        internal bool IsSetChannelGroupName()
        {
            return this._channelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name that describes the channel. The name is the primary identifier for the channel,
        /// and must be unique for your account in the AWS Region and channel group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name that describes the origin endpoint. The name is the primary identifier for
        /// the origin endpoint, and and must be unique for your account in the AWS Region and
        /// channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OriginEndpointName
        {
            get { return this._originEndpointName; }
            set { this._originEndpointName = value; }
        }

        // Check to see if OriginEndpointName property is set
        internal bool IsSetOriginEndpointName()
        {
            return this._originEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy to attach to the specified origin endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=6144)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}