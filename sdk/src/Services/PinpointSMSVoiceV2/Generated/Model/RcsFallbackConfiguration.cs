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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Configuration for SMS or MMS fallback when RCS delivery fails or the TimeToLive expires
    /// without delivery confirmation.
    /// </summary>
    public partial class RcsFallbackConfiguration
    {
        private RcsFallbackChannel _channel;
        private List<string> _mediaUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _messageBody;
        private string _originationIdentity;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The fallback channel to use when RCS delivery fails. Valid values are SMS and MMS.
        /// SMS and MMS are mutually exclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RcsFallbackChannel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property MediaUrls. 
        /// <para>
        /// An array of S3 URIs to media files for MMS fallback. Only valid when Channel is MMS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> MediaUrls
        {
            get { return this._mediaUrls; }
            set { this._mediaUrls = value; }
        }

        // Check to see if MediaUrls property is set
        internal bool IsSetMediaUrls()
        {
            return this._mediaUrls != null && (this._mediaUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The text body of the fallback message. Required for SMS fallback. For MMS fallback,
        /// at least one of MessageBody or MediaUrls must be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string MessageBody
        {
            get { return this._messageBody; }
            set { this._messageBody = value; }
        }

        // Check to see if MessageBody property is set
        internal bool IsSetMessageBody()
        {
            return this._messageBody != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use for the fallback message. This can be a PhoneNumber,
        /// PhoneNumberId, PhoneNumberArn, SenderId, or SenderIdArn. Pool IDs and pool ARNs are
        /// not accepted. If not specified and the original message was sent via a pool, the service
        /// selects a suitable number from the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

    }
}