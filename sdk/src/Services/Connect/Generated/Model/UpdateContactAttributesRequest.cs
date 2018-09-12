/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContactAttributes operation.
    /// The <code>UpdateContactAttributes</code> operation lets you programmatically create
    /// new or update existing contact attributes associated with a contact. You can use the
    /// operation to add or update attributes for both ongoing and completed contacts. For
    /// example, you can update the customer's name or the reason the customer called while
    /// the call is active, or add notes about steps that the agent took during the call that
    /// are displayed to the next agent that takes the call. You can also use the <code>UpdateContactAttributes</code>
    /// operation to update attributes for a contact using data from your CRM application
    /// and save the data with the contact in Amazon Connect. You could also flag calls for
    /// additional analysis, or flag abusive callers.
    /// 
    ///  
    /// <para>
    /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
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
        /// The key-value pairs for the attribute to update.
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
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// The unique identifier of the contact for which to update attributes. This is the identifier
        /// for the contact associated with the first interaction with the contact center.
        /// </para>
        /// </summary>
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
        /// The identifier for your Amazon Connect instance. To find the ID of your Amazon Connect
        /// instance, open the AWS console and select Amazon Connect. Select the instance alias
        /// of the instance. The instance ID is displayed in the Overview section of your instance
        /// settings. For example, the instance ID is the set of characters at the end of the
        /// instance ARN, after instance/, such as 10a4c4eb-f57e-4d4c-b602-bf39176ced07.
        /// </para>
        /// </summary>
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