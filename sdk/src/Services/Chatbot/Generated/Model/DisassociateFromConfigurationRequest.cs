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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateFromConfiguration operation.
    /// Unlink a resource, for example a custom action, from a channel configuration.
    /// </summary>
    public partial class DisassociateFromConfigurationRequest : AmazonChatbotRequest
    {
        private string _chatConfiguration;
        private string _resource;

        /// <summary>
        /// Gets and sets the property ChatConfiguration. 
        /// <para>
        /// The channel configuration the resource is being disassociated from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=1169)]
        public string ChatConfiguration
        {
            get { return this._chatConfiguration; }
            set { this._chatConfiguration = value; }
        }

        // Check to see if ChatConfiguration property is set
        internal bool IsSetChatConfiguration()
        {
            return this._chatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource (for example, a custom action) Amazon Resource Name (ARN) to unlink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}