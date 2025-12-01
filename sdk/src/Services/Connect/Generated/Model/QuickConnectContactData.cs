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
    /// Contact data associated with quick connect operations.
    /// </summary>
    public partial class QuickConnectContactData
    {
        private string _contactId;
        private DateTime? _initiationTimestamp;
        private string _quickConnectId;
        private string _quickConnectName;
        private QuickConnectType _quickConnectType;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        ///  The contact ID for quick connect contact data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        ///  Timestamp when the quick connect contact was initiated. 
        /// </para>
        /// </summary>
        public DateTime InitiationTimestamp
        {
            get { return this._initiationTimestamp.GetValueOrDefault(); }
            set { this._initiationTimestamp = value; }
        }

        // Check to see if InitiationTimestamp property is set
        internal bool IsSetInitiationTimestamp()
        {
            return this._initiationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        ///  The quick connect ID. 
        /// </para>
        /// </summary>
        public string QuickConnectId
        {
            get { return this._quickConnectId; }
            set { this._quickConnectId = value; }
        }

        // Check to see if QuickConnectId property is set
        internal bool IsSetQuickConnectId()
        {
            return this._quickConnectId != null;
        }

        /// <summary>
        /// Gets and sets the property QuickConnectName. 
        /// <para>
        ///  The name of the quick connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string QuickConnectName
        {
            get { return this._quickConnectName; }
            set { this._quickConnectName = value; }
        }

        // Check to see if QuickConnectName property is set
        internal bool IsSetQuickConnectName()
        {
            return this._quickConnectName != null;
        }

        /// <summary>
        /// Gets and sets the property QuickConnectType. 
        /// <para>
        ///  The type of the quick connect. 
        /// </para>
        /// </summary>
        public QuickConnectType QuickConnectType
        {
            get { return this._quickConnectType; }
            set { this._quickConnectType = value; }
        }

        // Check to see if QuickConnectType property is set
        internal bool IsSetQuickConnectType()
        {
            return this._quickConnectType != null;
        }

    }
}