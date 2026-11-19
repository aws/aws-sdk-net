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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes an action and whether the action is enabled or disabled for users during
    /// their streaming sessions.
    /// </summary>
    public partial class UserSetting
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action you want to enable or disable. Choose from the following:
        /// </para>
        ///  <dl> <dt>AUTO_TIME_ZONE_REDIRECTION</dt> <dd> 
        /// <para>
        /// Controls whether the streaming session's time zone matches the time zone of your local
        /// device.
        /// </para>
        ///  </dd> <dt>CLIPBOARD_COPY_FROM_LOCAL_DEVICE</dt> <dd> 
        /// <para>
        /// Controls whether you can copy data from your local device and paste it into the streaming
        /// session.
        /// </para>
        ///  </dd> <dt>CLIPBOARD_COPY_TO_LOCAL_DEVICE</dt> <dd> 
        /// <para>
        /// Controls whether you can copy data from the streaming session and paste it to your
        /// local device.
        /// </para>
        ///  </dd> <dt>DOMAIN_PASSWORD_SIGNIN</dt> <dd> 
        /// <para>
        /// Controls whether you can sign in to a domain-joined streaming session by using your
        /// password.
        /// </para>
        ///  </dd> <dt>DOMAIN_SMART_CARD_SIGNIN</dt> <dd> 
        /// <para>
        /// Controls whether you can sign in to a domain-joined streaming session by using a smart
        /// card.
        /// </para>
        ///  </dd> <dt>FILE_DOWNLOAD</dt> <dd> 
        /// <para>
        /// Controls whether you can download files from the streaming session to your local device.
        /// </para>
        ///  </dd> <dt>FILE_UPLOAD</dt> <dd> 
        /// <para>
        /// Controls whether you can upload files from your local device to the streaming session.
        /// </para>
        ///  </dd> <dt>PRINTING_TO_LOCAL_DEVICE</dt> <dd> 
        /// <para>
        /// Controls whether you can print from the streaming session to a printer on your local
        /// device.
        /// </para>
        ///  </dd> <dt>SMART_CARD_REDIRECTION</dt> <dd> 
        /// <para>
        /// Controls whether smart cards connected to your local device are redirected into the
        /// streaming session. Applications in the session can access the local smart card for
        /// use cases such as authentication, digital signing, and email encryption.
        /// </para>
        ///  </dd> </dl> <note> 
        /// <para>
        /// Smart card redirection was on by default for existing streaming sessions that use
        /// a Windows single-session fleet. To preserve that behavior, <c>SMART_CARD_REDIRECTION</c>
        /// is <c>ENABLED</c> by default on existing stacks associated with Windows single-session
        /// fleets. To turn it off, call <c>UpdateStack</c> with <c>SMART_CARD_REDIRECTION</c>
        /// set to <c>DISABLED</c>, and use an image that includes the latest WorkSpaces Applications
        /// agent version.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public Action Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// Specifies the number of characters that can be copied by end users from the local
        /// device to the remote session, and to the local device from the remote session.
        /// </para>
        ///  
        /// <para>
        /// This can be specified only for the <c>CLIPBOARD_COPY_FROM_LOCAL_DEVICE</c> and <c>CLIPBOARD_COPY_TO_LOCAL_DEVICE</c>
        /// actions.
        /// </para>
        ///  
        /// <para>
        /// This defaults to 20,971,520 (20 MB) when unspecified and the permission is <c>ENABLED</c>.
        /// This can't be specified when the permission is <c>DISABLED</c>. 
        /// </para>
        ///  
        /// <para>
        /// The value can be between 1 and 20,971,520 (20 MB).
        /// </para>
        /// </summary>
        public int? MaximumLength { get; set; }

        /// <summary>
        /// Checks to see if the MaximumLength property is set.
        /// </summary>
        internal bool IsSetMaximumLength() => this.MaximumLength.HasValue;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// Specifies whether to turn the action on or off.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;
    }
}
