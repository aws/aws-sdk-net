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
    /// Container for the parameters to the DeleteContactData operation.
    /// Deletes the specified fields containing personally identifiable information (PII)
    /// from a contact in the specified Connect Customer instance. We redact PII (such as
    /// customer endpoints, additional email recipients, and the email subject) from the contact
    /// and its associated contact trace record (CTR). The contact must be in a terminated
    /// state.
    /// 
    ///  <important> 
    /// <para>
    ///  <b>This deletion is permanent and cannot be undone.</b> Performing this operation
    /// permanently deletes the specified PII. There is no retention period; you cannot recover
    /// the data after deletion. We remove only the fields that Connect Customer identifies
    /// and stores as PII. Any PII that you place in fields outside the scope of this operation
    /// remains your responsibility to remove.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteContactDataRequest : AmazonConnectRequest
    {
        private List<string> _contactFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _contactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactFields. 
        /// <para>
        /// The categories of PII to redact from the contact. Specify one or more of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOMER_ENDPOINT</c> – The customer's contact endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADDITIONAL_EMAIL_RECIPIENTS</c> – Additional recipients on an email contact (email
        /// channel only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL_SUBJECT</c> – The subject line of an email contact (email channel only).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ContactFields
        {
            get { return this._contactFields; }
            set { this._contactFields = value; }
        }

        // Check to see if ContactFields property is set
        internal bool IsSetContactFields()
        {
            return this._contactFields != null && (this._contactFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact. You can delete PII only from a contact that has been
        /// disconnected (is in a terminated state).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
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