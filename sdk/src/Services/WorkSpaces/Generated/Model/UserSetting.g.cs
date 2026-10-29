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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Information about the user's permission settings.
    /// </summary>
    public partial class UserSetting
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Indicates the type of action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserSettingActionEnum Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// Indicates the maximum character length for the specified user setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaximumLength { get; set; }

        /// <summary>
        /// Checks to see if the MaximumLength property is set.
        /// </summary>
        internal bool IsSetMaximumLength() => this.MaximumLength.HasValue;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// Indicates if the setting is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserSettingPermissionEnum Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;
    }
}
