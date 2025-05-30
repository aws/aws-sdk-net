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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A time windows during which maintenance was deferred for an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterDeferredMaintenanceWindow
    {
        private string _deferMaintenanceEndTime;
        private string _deferMaintenanceIdentifier;
        private string _deferMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceEndTime. 
        /// <para>
        /// The end of the time window for which maintenance was deferred.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string DeferMaintenanceEndTime
        {
            get { return this._deferMaintenanceEndTime; }
            set { this._deferMaintenanceEndTime = value; }
        }

        // Check to see if DeferMaintenanceEndTime property is set
        internal bool IsSetDeferMaintenanceEndTime()
        {
            return this._deferMaintenanceEndTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceIdentifier. 
        /// <para>
        /// The identifier of the maintenance window.
        /// </para>
        /// </summary>
        public string DeferMaintenanceIdentifier
        {
            get { return this._deferMaintenanceIdentifier; }
            set { this._deferMaintenanceIdentifier = value; }
        }

        // Check to see if DeferMaintenanceIdentifier property is set
        internal bool IsSetDeferMaintenanceIdentifier()
        {
            return this._deferMaintenanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceStartTime. 
        /// <para>
        /// The start of the time window for which maintenance was deferred.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string DeferMaintenanceStartTime
        {
            get { return this._deferMaintenanceStartTime; }
            set { this._deferMaintenanceStartTime = value; }
        }

        // Check to see if DeferMaintenanceStartTime property is set
        internal bool IsSetDeferMaintenanceStartTime()
        {
            return this._deferMaintenanceStartTime != null;
        }

    }
}