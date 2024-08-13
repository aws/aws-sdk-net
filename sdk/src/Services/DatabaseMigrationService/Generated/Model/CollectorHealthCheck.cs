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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes the last Fleet Advisor collector health check.
    /// </summary>
    public partial class CollectorHealthCheck
    {
        private CollectorStatus _collectorStatus;
        private bool? _localCollectorS3Access;
        private bool? _webCollectorGrantedRoleBasedAccess;
        private bool? _webCollectorS3Access;

        /// <summary>
        /// Gets and sets the property CollectorStatus. 
        /// <para>
        /// The status of the Fleet Advisor collector.
        /// </para>
        /// </summary>
        public CollectorStatus CollectorStatus
        {
            get { return this._collectorStatus; }
            set { this._collectorStatus = value; }
        }

        // Check to see if CollectorStatus property is set
        internal bool IsSetCollectorStatus()
        {
            return this._collectorStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LocalCollectorS3Access. 
        /// <para>
        /// Whether the local collector can access its Amazon S3 bucket.
        /// </para>
        /// </summary>
        public bool? LocalCollectorS3Access
        {
            get { return this._localCollectorS3Access; }
            set { this._localCollectorS3Access = value; }
        }

        // Check to see if LocalCollectorS3Access property is set
        internal bool IsSetLocalCollectorS3Access()
        {
            return this._localCollectorS3Access.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebCollectorGrantedRoleBasedAccess. 
        /// <para>
        /// Whether the role that you provided when creating the Fleet Advisor collector has sufficient
        /// permissions to access the Fleet Advisor web collector.
        /// </para>
        /// </summary>
        public bool? WebCollectorGrantedRoleBasedAccess
        {
            get { return this._webCollectorGrantedRoleBasedAccess; }
            set { this._webCollectorGrantedRoleBasedAccess = value; }
        }

        // Check to see if WebCollectorGrantedRoleBasedAccess property is set
        internal bool IsSetWebCollectorGrantedRoleBasedAccess()
        {
            return this._webCollectorGrantedRoleBasedAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebCollectorS3Access. 
        /// <para>
        /// Whether the web collector can access its Amazon S3 bucket.
        /// </para>
        /// </summary>
        public bool? WebCollectorS3Access
        {
            get { return this._webCollectorS3Access; }
            set { this._webCollectorS3Access = value; }
        }

        // Check to see if WebCollectorS3Access property is set
        internal bool IsSetWebCollectorS3Access()
        {
            return this._webCollectorS3Access.HasValue; 
        }

    }
}