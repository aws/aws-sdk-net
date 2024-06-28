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
    /// The persistent application settings for WorkSpaces Pools users.
    /// </summary>
    public partial class ApplicationSettingsRequest
    {
        private string _settingsGroup;
        private ApplicationSettingsStatusEnum _status;

        /// <summary>
        /// Gets and sets the property SettingsGroup. 
        /// <para>
        /// The path prefix for the S3 bucket where users’ persistent application settings are
        /// stored. You can allow the same persistent application settings to be used across multiple
        /// pools by specifying the same settings group for each pool.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string SettingsGroup
        {
            get { return this._settingsGroup; }
            set { this._settingsGroup = value; }
        }

        // Check to see if SettingsGroup property is set
        internal bool IsSetSettingsGroup()
        {
            return this._settingsGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Enables or disables persistent application settings for users during their pool sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationSettingsStatusEnum Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}