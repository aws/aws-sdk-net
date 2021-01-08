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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePhoneNumber operation.
    /// Moves the specified phone number into the <b>Deletion queue</b>. A phone number must
    /// be disassociated from any users or Amazon Chime Voice Connectors before it can be
    /// deleted.
    /// 
    ///  
    /// <para>
    /// Deleted phone numbers remain in the <b>Deletion queue</b> for 7 days before they are
    /// deleted permanently.
    /// </para>
    /// </summary>
    public partial class DeletePhoneNumberRequest : AmazonChimeRequest
    {
        private string _phoneNumberId;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

    }
}