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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the SendChatIntegrationEvent operation.
    /// </summary>
    public partial class SendChatIntegrationEventResponse : AmazonWebServiceResponse
    {
        private string _initialContactId;
        private bool? _newChatCreated;

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// Identifier of chat contact used to handle integration event. This may be null if the
        /// integration event is not valid without an already existing chat contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property NewChatCreated. 
        /// <para>
        /// Whether handling the integration event resulted in creating a new chat or acting on
        /// existing chat.
        /// </para>
        /// </summary>
        public bool? NewChatCreated
        {
            get { return this._newChatCreated; }
            set { this._newChatCreated = value; }
        }

        // Check to see if NewChatCreated property is set
        internal bool IsSetNewChatCreated()
        {
            return this._newChatCreated.HasValue; 
        }

    }
}