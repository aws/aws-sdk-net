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
        /// The action that is enabled or disabled.
        /// </para>
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
        /// Indicates whether the action is enabled or disabled.
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
