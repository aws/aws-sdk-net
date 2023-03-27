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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSipMediaApplication operation.
    /// Updates the details of the specified SIP media application.
    /// </summary>
    public partial class UpdateSipMediaApplicationRequest : AmazonChimeSDKVoiceRequest
    {
        private List<SipMediaApplicationEndpoint> _endpoints = new List<SipMediaApplicationEndpoint>();
        private string _name;
        private string _sipMediaApplicationId;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The new set of endpoints for the specified SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<SipMediaApplicationEndpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the specified SIP media application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The SIP media application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

    }
}