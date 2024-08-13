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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// This is the response object from the GetAppInstanceRetentionSettings operation.
    /// </summary>
    public partial class GetAppInstanceRetentionSettingsResponse : AmazonWebServiceResponse
    {
        private AppInstanceRetentionSettings _appInstanceRetentionSettings;
        private DateTime? _initiateDeletionTimestamp;

        /// <summary>
        /// Gets and sets the property AppInstanceRetentionSettings. 
        /// <para>
        /// The retention settings for the <c>AppInstance</c>.
        /// </para>
        /// </summary>
        public AppInstanceRetentionSettings AppInstanceRetentionSettings
        {
            get { return this._appInstanceRetentionSettings; }
            set { this._appInstanceRetentionSettings = value; }
        }

        // Check to see if AppInstanceRetentionSettings property is set
        internal bool IsSetAppInstanceRetentionSettings()
        {
            return this._appInstanceRetentionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property InitiateDeletionTimestamp. 
        /// <para>
        /// The timestamp representing the time at which the specified items are retained, in
        /// Epoch Seconds.
        /// </para>
        /// </summary>
        public DateTime? InitiateDeletionTimestamp
        {
            get { return this._initiateDeletionTimestamp; }
            set { this._initiateDeletionTimestamp = value; }
        }

        // Check to see if InitiateDeletionTimestamp property is set
        internal bool IsSetInitiateDeletionTimestamp()
        {
            return this._initiateDeletionTimestamp.HasValue; 
        }

    }
}