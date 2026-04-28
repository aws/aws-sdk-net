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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Details about a resource that failed to deploy.
    /// </summary>
    public partial class NetworkMigrationFailedResourceDetails
    {
        private string _logicalid;
        private NetworkMigrationFailedResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical ID of the failed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogicalID
        {
            get { return this._logicalid; }
            set { this._logicalid = value; }
        }

        // Check to see if LogicalID property is set
        internal bool IsSetLogicalID()
        {
            return this._logicalid != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the failed resource.
        /// </para>
        /// </summary>
        public NetworkMigrationFailedResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason why the resource failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}