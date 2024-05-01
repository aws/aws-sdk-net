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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVoiceTemplate operation.
    /// Creates a message template for messages that are sent through the voice channel.
    /// </summary>
    public partial class CreateVoiceTemplateRequest : AmazonPinpointRequest
    {
        private string _templateName;
        private VoiceTemplateRequest _voiceTemplateRequest;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template. A template name must start with an alphanumeric
        /// character and can contain a maximum of 128 characters. The characters can be alphanumeric
        /// characters, underscores (_), or hyphens (-). Template names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceTemplateRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public VoiceTemplateRequest VoiceTemplateRequest
        {
            get { return this._voiceTemplateRequest; }
            set { this._voiceTemplateRequest = value; }
        }

        // Check to see if VoiceTemplateRequest property is set
        internal bool IsSetVoiceTemplateRequest()
        {
            return this._voiceTemplateRequest != null;
        }

    }
}