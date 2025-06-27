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
    /// Information about the additional TO and CC recipients of an inbound email contact.
    /// 
    ///  <note> 
    /// <para>
    /// You can include up to 50 email addresses in total, distributed across <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartEmailContact.html#API_StartEmailContact_RequestBody">DestinationEmailAddress</a>,
    /// <c>ToAddresses</c>, and <c>CcAddresses</c>. This total must include one required <c>DestinationEmailAddress</c>.
    /// You can then specify up to 49 addresses allocated across <c>ToAddresses</c> and <c>CcAddresses</c>
    /// as needed.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InboundAdditionalRecipients
    {
        private List<EmailAddressInfo> _ccAddresses = AWSConfigs.InitializeCollections ? new List<EmailAddressInfo>() : null;
        private List<EmailAddressInfo> _toAddresses = AWSConfigs.InitializeCollections ? new List<EmailAddressInfo>() : null;

        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// The <b>additional</b> recipients information present in cc list. You must have 1 required
        /// recipient (<c>DestinationEmailAddress</c>). You can then specify up to 49 additional
        /// recipients (across <c>ToAddresses</c> and <c>CcAddresses</c>), for a total of 50 recipients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<EmailAddressInfo> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && (this._ccAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// The <b>additional</b> recipients information present in to list. You must have 1 required
        /// recipient (<c>DestinationEmailAddress</c>). You can then specify up to 49 additional
        /// recipients (across <c>ToAddresses</c> and <c>CcAddresses</c>), for a total of 50 recipients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<EmailAddressInfo> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && (this._toAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}