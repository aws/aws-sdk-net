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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The status of the last <code>UpdateDatalake</code> or <code>DeleteDatalake</code>
    /// API request. This is set to Completed after the configuration is updated, or removed
    /// if deletion of the data lake is successful.
    /// </summary>
    public partial class UpdateStatus
    {
        private LastUpdateFailure _lastUpdateFailure;
        private string _lastUpdateRequestId;
        private SettingsStatus _lastUpdateStatus;

        /// <summary>
        /// Gets and sets the property LastUpdateFailure. 
        /// <para>
        /// The details of the last <code>UpdateDatalake</code>or <code>DeleteDatalake</code>
        /// API request which failed.
        /// </para>
        /// </summary>
        public LastUpdateFailure LastUpdateFailure
        {
            get { return this._lastUpdateFailure; }
            set { this._lastUpdateFailure = value; }
        }

        // Check to see if LastUpdateFailure property is set
        internal bool IsSetLastUpdateFailure()
        {
            return this._lastUpdateFailure != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateRequestId. 
        /// <para>
        /// The unique ID for the <code>UpdateDatalake</code> or <code>DeleteDatalake</code> API
        /// request.
        /// </para>
        /// </summary>
        public string LastUpdateRequestId
        {
            get { return this._lastUpdateRequestId; }
            set { this._lastUpdateRequestId = value; }
        }

        // Check to see if LastUpdateRequestId property is set
        internal bool IsSetLastUpdateRequestId()
        {
            return this._lastUpdateRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the last <code>UpdateDatalake</code> or <code>DeleteDatalake</code>
        /// API request that was requested.
        /// </para>
        /// </summary>
        public SettingsStatus LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

    }
}