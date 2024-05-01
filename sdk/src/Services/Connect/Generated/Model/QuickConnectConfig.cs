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
    /// Contains configuration settings for a quick connect.
    /// </summary>
    public partial class QuickConnectConfig
    {
        private PhoneNumberQuickConnectConfig _phoneConfig;
        private QueueQuickConnectConfig _queueConfig;
        private QuickConnectType _quickConnectType;
        private UserQuickConnectConfig _userConfig;

        /// <summary>
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// The phone configuration. This is required only if QuickConnectType is PHONE_NUMBER.
        /// </para>
        /// </summary>
        public PhoneNumberQuickConnectConfig PhoneConfig
        {
            get { return this._phoneConfig; }
            set { this._phoneConfig = value; }
        }

        // Check to see if PhoneConfig property is set
        internal bool IsSetPhoneConfig()
        {
            return this._phoneConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueueConfig. 
        /// <para>
        /// The queue configuration. This is required only if QuickConnectType is QUEUE.
        /// </para>
        /// </summary>
        public QueueQuickConnectConfig QueueConfig
        {
            get { return this._queueConfig; }
            set { this._queueConfig = value; }
        }

        // Check to see if QueueConfig property is set
        internal bool IsSetQueueConfig()
        {
            return this._queueConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QuickConnectType. 
        /// <para>
        /// The type of quick connect. In the Amazon Connect admin website, when you create a
        /// quick connect, you are prompted to assign one of the following types: Agent (USER),
        /// External (PHONE_NUMBER), or Queue (QUEUE). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UserConfig. 
        /// <para>
        /// The user configuration. This is required only if QuickConnectType is USER.
        /// </para>
        /// </summary>
        public UserQuickConnectConfig UserConfig
        {
            get { return this._userConfig; }
            set { this._userConfig = value; }
        }

        // Check to see if UserConfig property is set
        internal bool IsSetUserConfig()
        {
            return this._userConfig != null;
        }

    }
}