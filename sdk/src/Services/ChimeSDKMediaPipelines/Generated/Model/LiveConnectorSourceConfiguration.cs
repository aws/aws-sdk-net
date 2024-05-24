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
    /// The data source configuration object of a streaming media pipeline.
    /// </summary>
    public partial class LiveConnectorSourceConfiguration
    {
        private ChimeSdkMeetingLiveConnectorConfiguration _chimeSdkMeetingLiveConnectorConfiguration;
        private LiveConnectorSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property ChimeSdkMeetingLiveConnectorConfiguration. 
        /// <para>
        /// The configuration settings of the connector pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChimeSdkMeetingLiveConnectorConfiguration ChimeSdkMeetingLiveConnectorConfiguration
        {
            get { return this._chimeSdkMeetingLiveConnectorConfiguration; }
            set { this._chimeSdkMeetingLiveConnectorConfiguration = value; }
        }

        // Check to see if ChimeSdkMeetingLiveConnectorConfiguration property is set
        internal bool IsSetChimeSdkMeetingLiveConnectorConfiguration()
        {
            return this._chimeSdkMeetingLiveConnectorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source configuration's media source type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LiveConnectorSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}