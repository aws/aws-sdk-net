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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
        private UserSettingActionEnum _action;
        private int? _maximumLength;
        private UserSettingPermissionEnum _permission;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Indicates the type of action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserSettingActionEnum Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumLength. 
        /// <para>
        /// Indicates the maximum character length for the specified user setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaximumLength
        {
            get { return this._maximumLength; }
            set { this._maximumLength = value; }
        }

        // Check to see if MaximumLength property is set
        internal bool IsSetMaximumLength()
        {
            return this._maximumLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// Indicates if the setting is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserSettingPermissionEnum Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

    }
}