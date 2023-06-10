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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Alexa for Business metadata associated with an Amazon Chime user, used to integrate
    /// Alexa for Business with a device.
    /// </summary>
    public partial class AlexaForBusinessMetadata
    {
        private string _alexaForBusinessRoomArn;
        private bool? _isAlexaForBusinessEnabled;

        /// <summary>
        /// Gets and sets the property AlexaForBusinessRoomArn. 
        /// <para>
        /// The ARN of the room resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AlexaForBusinessRoomArn
        {
            get { return this._alexaForBusinessRoomArn; }
            set { this._alexaForBusinessRoomArn = value; }
        }

        // Check to see if AlexaForBusinessRoomArn property is set
        internal bool IsSetAlexaForBusinessRoomArn()
        {
            return this._alexaForBusinessRoomArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsAlexaForBusinessEnabled. 
        /// <para>
        /// Starts or stops Alexa for Business.
        /// </para>
        /// </summary>
        public bool IsAlexaForBusinessEnabled
        {
            get { return this._isAlexaForBusinessEnabled.GetValueOrDefault(); }
            set { this._isAlexaForBusinessEnabled = value; }
        }

        // Check to see if IsAlexaForBusinessEnabled property is set
        internal bool IsSetIsAlexaForBusinessEnabled()
        {
            return this._isAlexaForBusinessEnabled.HasValue; 
        }

    }
}