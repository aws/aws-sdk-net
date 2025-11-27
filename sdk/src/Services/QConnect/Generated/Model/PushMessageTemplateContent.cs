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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The content of the message template that applies to the push channel subtype.
    /// </summary>
    public partial class PushMessageTemplateContent
    {
        private PushADMMessageTemplateContent _adm;
        private PushAPNSMessageTemplateContent _apns;
        private PushBaiduMessageTemplateContent _baidu;
        private PushFCMMessageTemplateContent _fcm;

        /// <summary>
        /// Gets and sets the property Adm. 
        /// <para>
        /// The content of the message template that applies to ADM (Amazon Device Messaging)
        /// notification service.
        /// </para>
        /// </summary>
        public PushADMMessageTemplateContent Adm
        {
            get { return this._adm; }
            set { this._adm = value; }
        }

        // Check to see if Adm property is set
        internal bool IsSetAdm()
        {
            return this._adm != null;
        }

        /// <summary>
        /// Gets and sets the property Apns. 
        /// <para>
        /// The content of the message template that applies to APNS(Apple Push Notification service)
        /// notification service.
        /// </para>
        /// </summary>
        public PushAPNSMessageTemplateContent Apns
        {
            get { return this._apns; }
            set { this._apns = value; }
        }

        // Check to see if Apns property is set
        internal bool IsSetApns()
        {
            return this._apns != null;
        }

        /// <summary>
        /// Gets and sets the property Baidu. 
        /// <para>
        /// The content of the message template that applies to Baidu notification service.
        /// </para>
        /// </summary>
        public PushBaiduMessageTemplateContent Baidu
        {
            get { return this._baidu; }
            set { this._baidu = value; }
        }

        // Check to see if Baidu property is set
        internal bool IsSetBaidu()
        {
            return this._baidu != null;
        }

        /// <summary>
        /// Gets and sets the property Fcm. 
        /// <para>
        /// The content of the message template that applies to FCM (Firebase Cloud Messaging)
        /// notification service.
        /// </para>
        /// </summary>
        public PushFCMMessageTemplateContent Fcm
        {
            get { return this._fcm; }
            set { this._fcm = value; }
        }

        // Check to see if Fcm property is set
        internal bool IsSetFcm()
        {
            return this._fcm != null;
        }

    }
}