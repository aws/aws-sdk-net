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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Metadata associated with received licenses and grants.
    /// </summary>
    public partial class ReceivedMetadata
    {
        private List<string> _allowedOperations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ReceivedStatus _receivedStatus;
        private string _receivedStatusReason;

        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public List<string> AllowedOperations
        {
            get { return this._allowedOperations; }
            set { this._allowedOperations = value; }
        }

        // Check to see if AllowedOperations property is set
        internal bool IsSetAllowedOperations()
        {
            return this._allowedOperations != null && (this._allowedOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property ReceivedStatusReason. 
        /// <para>
        /// Received status reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max=400)]
        public string ReceivedStatusReason
        {
            get { return this._receivedStatusReason; }
            set { this._receivedStatusReason = value; }
        }

        // Check to see if ReceivedStatusReason property is set
        internal bool IsSetReceivedStatusReason()
        {
            return this._receivedStatusReason != null;
        }

    }
}