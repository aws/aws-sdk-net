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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Contact information that the SRT can use to contact you if you have proactive engagement
    /// enabled, for escalations to the SRT and to initiate proactive customer support.
    /// </summary>
    public partial class EmergencyContact
    {
        private string _contactNotes;
        private string _emailAddress;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property ContactNotes. 
        /// <para>
        /// Additional notes regarding the contact. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContactNotes
        {
            get { return this._contactNotes; }
            set { this._contactNotes = value; }
        }

        // Check to see if ContactNotes property is set
        internal bool IsSetContactNotes()
        {
            return this._contactNotes != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

    }
}