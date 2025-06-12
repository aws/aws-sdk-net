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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMediaPipelineKinesisVideoStreamPool operation.
    /// Creates an Amazon Kinesis Video Stream pool for use with media stream pipelines.
    /// 
    ///  <note> 
    /// <para>
    /// If a meeting uses an opt-in Region as its <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html#chimesdk-meeting-chime_CreateMeeting-request-MediaRegion">MediaRegion</a>,
    /// the KVS stream must be in that same Region. For example, if a meeting uses the <c>af-south-1</c>
    /// Region, the KVS stream must also be in <c>af-south-1</c>. However, if the meeting
    /// uses a Region that AWS turns on by default, the KVS stream can be in any available
    /// Region, including an opt-in Region. For example, if the meeting uses <c>ca-central-1</c>,
    /// the KVS stream can be in <c>eu-west-2</c>, <c>us-east-1</c>, <c>af-south-1</c>, or
    /// any other Region that the Amazon Chime SDK supports.
    /// </para>
    ///  
    /// <para>
    /// To learn which AWS Region a meeting uses, call the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_GetMeeting.html">GetMeeting</a>
    /// API and use the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html#chimesdk-meeting-chime_CreateMeeting-request-MediaRegion">MediaRegion</a>
    /// parameter from the response.
    /// </para>
    ///  
    /// <para>
    /// For more information about opt-in Regions, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/sdk-available-regions.html">Available
    /// Regions</a> in the <i>Amazon Chime SDK Developer Guide</i>, and <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html#rande-manage-enable.html">Specify
    /// which AWS Regions your account can use</a>, in the <i>AWS Account Management Reference
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateMediaPipelineKinesisVideoStreamPoolRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _clientRequestToken;
        private string _poolName;
        private KinesisVideoStreamConfiguration _streamConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The token assigned to the client making the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property PoolName. 
        /// <para>
        /// The name of the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PoolName
        {
            get { return this._poolName; }
            set { this._poolName = value; }
        }

        // Check to see if PoolName property is set
        internal bool IsSetPoolName()
        {
            return this._poolName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamConfiguration. 
        /// <para>
        /// The configuration settings for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KinesisVideoStreamConfiguration StreamConfiguration
        {
            get { return this._streamConfiguration; }
            set { this._streamConfiguration = value; }
        }

        // Check to see if StreamConfiguration property is set
        internal bool IsSetStreamConfiguration()
        {
            return this._streamConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the stream pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}