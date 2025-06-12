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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains the configuration information of SMS notifications.
    /// </summary>
    public partial class SMSConfiguration
    {
        private string _additionalMessage;
        private List<RecipientDetail> _recipients = AWSConfigs.InitializeCollections ? new List<RecipientDetail>() : null;
        private string _senderId;

        /// <summary>
        /// Gets and sets the property AdditionalMessage. 
        /// <para>
        /// The message that you want to send. The message can be up to 200 characters.
        /// </para>
        /// </summary>
        public string AdditionalMessage
        {
            get { return this._additionalMessage; }
            set { this._additionalMessage = value; }
        }

        // Check to see if AdditionalMessage property is set
        internal bool IsSetAdditionalMessage()
        {
            return this._additionalMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Recipients. 
        /// <para>
        /// Specifies one or more recipients who receive the message.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/addusers.html">add
        /// the users that receive SMS messages to your AWS SSO store</a>.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RecipientDetail> Recipients
        {
            get { return this._recipients; }
            set { this._recipients = value; }
        }

        // Check to see if Recipients property is set
        internal bool IsSetRecipients()
        {
            return this._recipients != null && (this._recipients.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The sender ID.
        /// </para>
        /// </summary>
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

    }
}