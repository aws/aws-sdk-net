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
    /// The configuration of the channel.
    /// </summary>
    public partial class ChannelListConfiguration
    {
        private string _arn;
        private List<string> _attachedMultiviewChannels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _channelGroupName;
        private string _channelName;
        private DateTime? _createdAt;
        private string _description;
        private InputType _inputType;
        private DateTime? _modifiedAt;
        private MultiviewConfiguration _multiviewConfiguration;
        private OutputLockingMode _outputLockingMode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedMultiviewChannels. 
        /// <para>
        /// The multiview channels, in the same channel group, that list this channel as an available
        /// source. This is a read-only field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachedMultiviewChannels
        {
            get { return this._attachedMultiviewChannels; }
            set { this._attachedMultiviewChannels = value; }
        }

        // Check to see if AttachedMultiviewChannels property is set
        internal bool IsSetAttachedMultiviewChannels()
        {
            return this._attachedMultiviewChannels != null && (this._attachedMultiviewChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name that describes the channel group. The name is the primary identifier for
        /// the channel group, and must be unique for your account in the AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any descriptive information that you want to add to the channel for future identification
        /// purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// The input type is an immutable field. It defines whether the channel allows CMAF ingest,
        /// HLS ingest, or server-side multiview output. Multiview channels receive no ingest
        /// of their own. If unprovided, the value defaults to HLS.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HLS</c> - The HLS streaming specification (which defines M3U8 manifests and TS
        /// segments).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CMAF</c> - The DASH-IF CMAF Ingest specification (which defines CMAF segments
        /// with optional DASH manifests).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTIVIEW</c> – Server-side multiview. The channel receives no ingest of its own.
        /// Instead, it composites video from the source channels in its <c>MultiviewConfiguration</c>
        /// into a single tiled output stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InputType InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time the channel was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiviewConfiguration. 
        /// <para>
        /// The multiview configuration for the channel. This is present only when <c>InputType</c>
        /// is <c>MULTIVIEW</c>.
        /// </para>
        /// </summary>
        public MultiviewConfiguration MultiviewConfiguration
        {
            get { return this._multiviewConfiguration; }
            set { this._multiviewConfiguration = value; }
        }

        // Check to see if MultiviewConfiguration property is set
        internal bool IsSetMultiviewConfiguration()
        {
            return this._multiviewConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLockingMode. 
        /// <para>
        /// The output locking mode configured for the channel.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EPOCH_LOCKED</c> - The channel uses epoch-locked behavior with deterministic sequence
        /// numbering and fixed segment boundaries aligned to epoch time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_EPOCH_LOCKED</c> - The channel uses non-epoch-locked behavior with duration-based
        /// segment combining and monotonically increasing sequence numbers starting from 0.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OutputLockingMode OutputLockingMode
        {
            get { return this._outputLockingMode; }
            set { this._outputLockingMode = value; }
        }

        // Check to see if OutputLockingMode property is set
        internal bool IsSetOutputLockingMode()
        {
            return this._outputLockingMode != null;
        }

    }
}