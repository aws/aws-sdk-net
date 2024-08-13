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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the GetRetentionSettings operation.
    /// </summary>
    public partial class GetRetentionSettingsResponse : AmazonWebServiceResponse
    {
        private DateTime? _initiateDeletionTimestamp;
        private RetentionSettings _retentionSettings;

        /// <summary>
        /// Gets and sets the property InitiateDeletionTimestamp. 
        /// <para>
        /// The timestamp representing the time at which the specified items are permanently deleted,
        /// in ISO 8601 format.
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

        /// <summary>
        /// Gets and sets the property RetentionSettings. 
        /// <para>
        /// The retention settings.
        /// </para>
        /// </summary>
        public RetentionSettings RetentionSettings
        {
            get { return this._retentionSettings; }
            set { this._retentionSettings = value; }
        }

        // Check to see if RetentionSettings property is set
        internal bool IsSetRetentionSettings()
        {
            return this._retentionSettings != null;
        }

    }
}