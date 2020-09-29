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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContactAttributes operation.
    /// Creates or updates the contact attributes associated with the specified contact.
    /// 
    ///  
    /// <para>
    /// You can add or update attributes for both ongoing and completed contacts. For example,
    /// you can update the customer's name or the reason the customer called while the call
    /// is active, or add notes about steps that the agent took during the call that are displayed
    /// to the next agent that takes the call. You can also update attributes for a contact
    /// using data from your CRM application and save the data with the contact in Amazon
    /// Connect. You could also flag calls for additional analysis, such as legal review or
    /// identifying abusive callers.
    /// </para>
    ///  
    /// <para>
    /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
    /// </para>
    ///  
    /// <para>
    /// This operation is also available in the Amazon Connect Flow language. See <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-actions-updatecontactattributes.html">UpdateContactAttributes</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Important:</b> You cannot use the operation to update attributes for contacts
    /// that occurred prior to the release of the API, September 12, 2018. You can update
    /// attributes only for contacts that started after the release of the API. If you attempt
    /// to update attributes for a contact that occurred prior to the release of the API,
    /// a 400 error is returned. This applies also to queued callbacks that were initiated
    /// prior to the release of the API but are still active in your instance.
    /// </para>
    /// </summary>
    public partial class UpdateContactAttributesRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _initialContactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The Amazon Connect attributes. These attributes can be accessed in contact flows just
        /// like any other contact attributes.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 32,768 UTF-8 bytes across all attributes for a contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with the contact center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}