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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Provides details about the product's connection sync and contains the following sub-fields.
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>LastSyncTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastSyncStatus</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastSyncStatusMessage</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastSuccessfulSyncTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastSuccessfulSyncProvisioningArtifactID</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LastSync
    {
        private string _lastSuccessfulSyncProvisioningArtifactId;
        private DateTime? _lastSuccessfulSyncTime;
        private LastSyncStatus _lastSyncStatus;
        private string _lastSyncStatusMessage;
        private DateTime? _lastSyncTime;

        /// <summary>
        /// Gets and sets the property LastSuccessfulSyncProvisioningArtifactId. 
        /// <para>
        /// The ProvisioningArtifactID of the ProvisioningArtifact created from the latest successful
        /// sync. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastSuccessfulSyncProvisioningArtifactId
        {
            get { return this._lastSuccessfulSyncProvisioningArtifactId; }
            set { this._lastSuccessfulSyncProvisioningArtifactId = value; }
        }

        // Check to see if LastSuccessfulSyncProvisioningArtifactId property is set
        internal bool IsSetLastSuccessfulSyncProvisioningArtifactId()
        {
            return this._lastSuccessfulSyncProvisioningArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulSyncTime. 
        /// <para>
        /// The time of the latest successful sync from the source repo artifact to the Service
        /// Catalog product.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulSyncTime
        {
            get { return this._lastSuccessfulSyncTime; }
            set { this._lastSuccessfulSyncTime = value; }
        }

        // Check to see if LastSuccessfulSyncTime property is set
        internal bool IsSetLastSuccessfulSyncTime()
        {
            return this._lastSuccessfulSyncTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSyncStatus. 
        /// <para>
        /// The current status of the sync. Responses include <c>SUCCEEDED</c> or <c>FAILED</c>.
        /// 
        /// </para>
        /// </summary>
        public LastSyncStatus LastSyncStatus
        {
            get { return this._lastSyncStatus; }
            set { this._lastSyncStatus = value; }
        }

        // Check to see if LastSyncStatus property is set
        internal bool IsSetLastSyncStatus()
        {
            return this._lastSyncStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastSyncStatusMessage. 
        /// <para>
        /// The sync's status message. 
        /// </para>
        /// </summary>
        public string LastSyncStatusMessage
        {
            get { return this._lastSyncStatusMessage; }
            set { this._lastSyncStatusMessage = value; }
        }

        // Check to see if LastSyncStatusMessage property is set
        internal bool IsSetLastSyncStatusMessage()
        {
            return this._lastSyncStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastSyncTime. 
        /// <para>
        /// The time of the last attempted sync from the repository to the Service Catalog product.
        /// 
        /// </para>
        /// </summary>
        public DateTime? LastSyncTime
        {
            get { return this._lastSyncTime; }
            set { this._lastSyncTime = value; }
        }

        // Check to see if LastSyncTime property is set
        internal bool IsSetLastSyncTime()
        {
            return this._lastSyncTime.HasValue; 
        }

    }
}