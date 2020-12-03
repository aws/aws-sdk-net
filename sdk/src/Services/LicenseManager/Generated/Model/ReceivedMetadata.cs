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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Metadata associated with received licenses and grants.
    /// </summary>
    public partial class ReceivedMetadata
    {
        private List<string> _allowedOperations = new List<string>();
        private ReceivedStatus _receivedStatus;

        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }

        // Check to see if AllowedOperations property is set
        internal bool IsSetAllowedOperations()
        {
            return this._allowedOperations != null && this._allowedOperations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReceivedStatus. 
        /// <para>
        /// Received status.
        /// </para>
        /// </summary>
        public ReceivedStatus ReceivedStatus
        {
            get { return this._receivedStatus; }
            set { this._receivedStatus = value; }
        }

        // Check to see if ReceivedStatus property is set
        internal bool IsSetReceivedStatus()
        {
            return this._receivedStatus != null;
        }

    }
}