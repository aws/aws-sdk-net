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
    /// Contains information about the phone configuration settings for a user.
    /// </summary>
    public partial class UserPhoneConfig
    {
        private int? _afterContactWorkTimeLimit;
        private bool? _autoAccept;
        private string _deskPhoneNumber;
        private bool? _persistentConnection;
        private PhoneType _phoneType;

        /// <summary>
        /// Gets and sets the property AfterContactWorkTimeLimit. 
        /// <para>
        /// The After Call Work (ACW) timeout setting, in seconds. This parameter has a minimum
        /// value of 0 and a maximum value of 2,000,000 seconds (24 days). Enter 0 if you don't
        /// want to allocate a specific amount of ACW time. It essentially means an indefinite
        /// amount of time. When the conversation ends, ACW starts; the agent must choose Close
        /// contact to end ACW. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When returned by a <c>SearchUsers</c> call, <c>AfterContactWorkTimeLimit</c> is returned
        /// in milliseconds. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AfterContactWorkTimeLimit
        {
            get { return this._afterContactWorkTimeLimit; }
            set { this._afterContactWorkTimeLimit = value; }
        }

        // Check to see if AfterContactWorkTimeLimit property is set
        internal bool IsSetAfterContactWorkTimeLimit()
        {
            return this._afterContactWorkTimeLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoAccept. 
        /// <para>
        /// The Auto accept setting.
        /// </para>
        /// </summary>
        public bool? AutoAccept
        {
            get { return this._autoAccept; }
            set { this._autoAccept = value; }
        }

        // Check to see if AutoAccept property is set
        internal bool IsSetAutoAccept()
        {
            return this._autoAccept.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeskPhoneNumber. 
        /// <para>
        /// The phone number for the user's desk phone.
        /// </para>
        /// </summary>
        public string DeskPhoneNumber
        {
            get { return this._deskPhoneNumber; }
            set { this._deskPhoneNumber = value; }
        }

        // Check to see if DeskPhoneNumber property is set
        internal bool IsSetDeskPhoneNumber()
        {
            return this._deskPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentConnection. 
        /// <para>
        /// The persistent connection setting for the user.
        /// </para>
        /// </summary>
        public bool? PersistentConnection
        {
            get { return this._persistentConnection; }
            set { this._persistentConnection = value; }
        }

        // Check to see if PersistentConnection property is set
        internal bool IsSetPersistentConnection()
        {
            return this._persistentConnection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PhoneType. 
        /// <para>
        /// The phone type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneType PhoneType
        {
            get { return this._phoneType; }
            set { this._phoneType = value; }
        }

        // Check to see if PhoneType property is set
        internal bool IsSetPhoneType()
        {
            return this._phoneType != null;
        }

    }
}