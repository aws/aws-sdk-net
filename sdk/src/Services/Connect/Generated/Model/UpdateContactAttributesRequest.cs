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
    /// Container for the parameters to the UpdateContactAttributes operation.
    /// Creates or updates user-defined contact attributes associated with the specified contact.
    /// 
    ///  
    /// <para>
    /// You can create or update user-defined attributes for both ongoing and completed contacts.
    /// For example, while the call is active, you can update the customer's name or the reason
    /// the customer called. You can add notes about steps that the agent took during the
    /// call that display to the next agent that takes the call. You can also update attributes
    /// for a contact using data from your CRM application and save the data with the contact
    /// in Amazon Connect. You could also flag calls for additional analysis, such as legal
    /// review or to identify abusive callers.
    /// </para>
    ///  
    /// <para>
    /// Contact attributes are available in Amazon Connect for 24 months, and are then deleted.
    /// For information about contact record retention and the maximum size of the contact
    /// record attributes section, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
    /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// </para>
    /// </summary>
    public partial class UpdateContactAttributesRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _initialContactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The Amazon Connect attributes. These attributes can be accessed in flows just like
        /// any other contact attributes.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 32,768 UTF-8 bytes across all attributes for a contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
        /// </para>
        ///  
        /// <para>
        /// In the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-contact-attributes.html">Set
        /// contact attributes</a> block, when the attributes for a contact exceed 32 KB, the
        /// contact is routed down the Error branch of the flow. As a mitigation, consider the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Remove unnecessary attributes by setting their values to empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the attributes are only used in one flow and don't need to be referred to outside
        /// of that flow (for example, by a Lambda or another flow), then use flow attributes.
        /// This way you aren't needlessly persisting the 32 KB of information from one flow to
        /// another. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-contact-attributes.html">Flow
        /// block: Set contact attributes</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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