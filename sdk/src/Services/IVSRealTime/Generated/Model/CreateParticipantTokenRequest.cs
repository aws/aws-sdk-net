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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateParticipantToken operation.
    /// Creates an additional token for a specified stage. This can be done after stage creation
    /// or when tokens expire. Tokens always are scoped to the stage for which they are created.
    /// 
    ///  
    /// <para>
    /// Encryption keys are owned by Amazon IVS and never used directly by your application.
    /// </para>
    /// </summary>
    public partial class CreateParticipantTokenRequest : AmazonIVSRealTimeRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private List<string> _capabilities = new List<string>();
        private int? _duration;
        private string _stageArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a stage. Map
        /// keys and values can contain UTF-8 encoded text. The maximum length of this field is
        /// 1 KB total. <i>This field is exposed to all stage participants and should not be used
        /// for personally identifying, confidential, or sensitive information.</i> 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Set of capabilities that the user is allowed to perform in the stage. Default: <code>PUBLISH,
        /// SUBSCRIBE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration (in minutes), after which the token expires. Default: 60 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20160)]
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage to which this token is scoped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StageArn
        {
            get { return this._stageArn; }
            set { this._stageArn = value; }
        }

        // Check to see if StageArn property is set
        internal bool IsSetStageArn()
        {
            return this._stageArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Name that can be specified to help identify the token. This can be any UTF-8 encoded
        /// text. <i>This field is exposed to all stage participants and should not be used for
        /// personally identifying, confidential, or sensitive information.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}