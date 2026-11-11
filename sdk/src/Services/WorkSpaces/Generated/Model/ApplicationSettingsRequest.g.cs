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
    /// The persistent application settings for WorkSpaces Pools users.
    /// </summary>
    public partial class ApplicationSettingsRequest
    {
        /// <summary>
        /// Gets and sets the property SettingsGroup. 
        /// <para>
        /// The path prefix for the S3 bucket where users’ persistent application settings are
        /// stored. You can allow the same persistent application settings to be used across multiple
        /// pools by specifying the same settings group for each pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string SettingsGroup { get; set; }

        /// <summary>
        /// Checks to see if the SettingsGroup property is set.
        /// </summary>
        internal bool IsSetSettingsGroup() => this.SettingsGroup != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Enables or disables persistent application settings for users during their pool sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationSettingsStatusEnum Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
