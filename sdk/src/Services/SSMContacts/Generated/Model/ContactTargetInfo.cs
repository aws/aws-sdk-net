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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// The contact that Incident Manager is engaging during an incident.
    /// </summary>
    public partial class ContactTargetInfo
    {
        private string _contactId;
        private bool? _isEssential;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property IsEssential. 
        /// <para>
        /// A Boolean value determining if the contact's acknowledgement stops the progress of
        /// stages in the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEssential
        {
            get { return this._isEssential; }
            set { this._isEssential = value; }
        }

        // Check to see if IsEssential property is set
        internal bool IsSetIsEssential()
        {
            return this._isEssential.HasValue; 
        }

    }
}