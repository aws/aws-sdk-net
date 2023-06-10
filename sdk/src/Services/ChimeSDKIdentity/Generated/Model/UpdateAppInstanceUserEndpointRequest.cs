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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAppInstanceUserEndpoint operation.
    /// Updates the details of an <code>AppInstanceUserEndpoint</code>. You can update the
    /// name and <code>AllowMessage</code> values.
    /// </summary>
    public partial class UpdateAppInstanceUserEndpointRequest : AmazonChimeSDKIdentityRequest
    {
        private AllowMessages _allowMessages;
        private string _appInstanceUserArn;
        private string _endpointId;
        private string _name;

        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the <code>AppInstanceUserEndpoint</code> is opted in
        /// to receive messages. <code>ALL</code> indicates the endpoint will receive all messages.
        /// <code>NONE</code> indicates the endpoint will receive no messages.
        /// </para>
        /// </summary>
        public AllowMessages AllowMessages
        {
            get { return this._allowMessages; }
            set { this._allowMessages = value; }
        }

        // Check to see if AllowMessages property is set
        internal bool IsSetAllowMessages()
        {
            return this._allowMessages != null;
        }

        /// <summary>
        /// Gets and sets the property AppInstanceUserArn. 
        /// <para>
        /// The ARN of the <code>AppInstanceUser</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=5, Max=1600)]
        public string AppInstanceUserArn
        {
            get { return this._appInstanceUserArn; }
            set { this._appInstanceUserArn = value; }
        }

        // Check to see if AppInstanceUserArn property is set
        internal bool IsSetAppInstanceUserArn()
        {
            return this._appInstanceUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the <code>AppInstanceUserEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=64)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <code>AppInstanceUserEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1600)]
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

    }
}