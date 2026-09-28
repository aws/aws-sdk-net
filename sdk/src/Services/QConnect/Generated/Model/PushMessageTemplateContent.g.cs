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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Adm. 
        /// <para>
        /// The content of the message template that applies to ADM (Amazon Device Messaging)
        /// notification service.
        /// </para>
        /// </summary>
        public PushADMMessageTemplateContent Adm { get; set; }

        /// <summary>
        /// Checks to see if the Adm property is set.
        /// </summary>
        internal bool IsSetAdm() => this.Adm != null;

        /// <summary>
        /// Gets and sets the property Apns. 
        /// <para>
        /// The content of the message template that applies to APNS(Apple Push Notification service)
        /// notification service.
        /// </para>
        /// </summary>
        public PushAPNSMessageTemplateContent Apns { get; set; }

        /// <summary>
        /// Checks to see if the Apns property is set.
        /// </summary>
        internal bool IsSetApns() => this.Apns != null;

        /// <summary>
        /// Gets and sets the property Baidu. 
        /// <para>
        /// The content of the message template that applies to Baidu notification service.
        /// </para>
        /// </summary>
        public PushBaiduMessageTemplateContent Baidu { get; set; }

        /// <summary>
        /// Checks to see if the Baidu property is set.
        /// </summary>
        internal bool IsSetBaidu() => this.Baidu != null;

        /// <summary>
        /// Gets and sets the property Fcm. 
        /// <para>
        /// The content of the message template that applies to FCM (Firebase Cloud Messaging)
        /// notification service.
        /// </para>
        /// </summary>
        public PushFCMMessageTemplateContent Fcm { get; set; }

        /// <summary>
        /// Checks to see if the Fcm property is set.
        /// </summary>
        internal bool IsSetFcm() => this.Fcm != null;
    }
}
