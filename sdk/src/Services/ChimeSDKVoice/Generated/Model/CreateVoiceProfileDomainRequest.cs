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
    /// Container for the parameters to the CreateVoiceProfileDomain operation.
    /// Creates a voice profile domain, a collection of voice profiles, their voice prints,
    /// and encrypted enrollment audio.
    /// 
    ///  <important> 
    /// <para>
    /// Before creating any voice profiles, you must provide all notices and obtain all consents
    /// from the speaker as required under applicable privacy and biometrics laws, and as
    /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
    /// for the Amazon Chime SDK.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about voice profile domains, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
    /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateVoiceProfileDomainRequest : AmazonChimeSDKVoiceRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _name;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// domain creation requests.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the voice profile domain.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the voice profile domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The server-side encryption configuration for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}