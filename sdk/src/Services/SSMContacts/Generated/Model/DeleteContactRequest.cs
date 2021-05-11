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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteContact operation.
    /// To remove a contact from Incident Manager, you can delete the contact. Deleting a
    /// contact removes them from all escalation plans and related response plans. Deleting
    /// an escalation plan removes it from all related response plans. You will have to recreate
    /// the contact and its contact channels before you can use it again.
    /// </summary>
    public partial class DeleteContactRequest : AmazonSSMContactsRequest
    {
        private string _contactId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact that you're deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

    }
}