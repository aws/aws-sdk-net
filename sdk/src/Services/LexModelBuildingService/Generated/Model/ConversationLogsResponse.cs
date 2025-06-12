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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Contains information about conversation log settings.
    /// </summary>
    public partial class ConversationLogsResponse
    {
        private string _iamRoleArn;
        private List<LogSettingsResponse> _logSettings = AWSConfigs.InitializeCollections ? new List<LogSettingsResponse>() : null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to write your logs to CloudWatch
        /// Logs or an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogSettings. 
        /// <para>
        /// The settings for your conversation logs. You can log text, audio, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogSettingsResponse> LogSettings
        {
            get { return this._logSettings; }
            set { this._logSettings = value; }
        }

        // Check to see if LogSettings property is set
        internal bool IsSetLogSettings()
        {
            return this._logSettings != null && (this._logSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}