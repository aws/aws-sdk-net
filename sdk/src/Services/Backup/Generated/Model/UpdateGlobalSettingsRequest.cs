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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGlobalSettings operation.
    /// Updates whether the Amazon Web Services account is opted in to cross-account backup.
    /// Returns an error if the account is not an Organizations management account. Use the
    /// <c>DescribeGlobalSettings</c> API to determine the current settings.
    /// </summary>
    public partial class UpdateGlobalSettingsRequest : AmazonBackupRequest
    {
        private Dictionary<string, string> _globalSettings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property GlobalSettings. 
        /// <para>
        /// Inputs can include:
        /// </para>
        ///  
        /// <para>
        /// A value for <c>isCrossAccountBackupEnabled</c> and a Region. Example: <c>update-global-settings
        /// --global-settings isCrossAccountBackupEnabled=false --region us-west-2</c>.
        /// </para>
        ///  
        /// <para>
        /// A value for Multi-party approval, styled as "Mpa": <c>isMpaEnabled</c>. Values can
        /// be true or false. Example: <c>update-global-settings --global-settings isMpaEnabled=false
        /// --region us-west-2</c>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> GlobalSettings
        {
            get { return this._globalSettings; }
            set { this._globalSettings = value; }
        }

        // Check to see if GlobalSettings property is set
        internal bool IsSetGlobalSettings()
        {
            return this._globalSettings != null && (this._globalSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}