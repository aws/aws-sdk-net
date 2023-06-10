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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// If a service instance is manually updated, Proton wants to prevent accidentally overriding
    /// a manual change.
    /// 
    ///  
    /// <para>
    /// A blocker is created because of the manual update or deletion of a service instance.
    /// The summary describes the blocker as being active or resolved.
    /// </para>
    /// </summary>
    public partial class ServiceSyncBlockerSummary
    {
        private List<SyncBlocker> _latestBlockers = new List<SyncBlocker>();
        private string _serviceInstanceName;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property LatestBlockers. 
        /// <para>
        /// The latest active blockers for the synced service.
        /// </para>
        /// </summary>
        public List<SyncBlocker> LatestBlockers
        {
            get { return this._latestBlockers; }
            set { this._latestBlockers = value; }
        }

        // Check to see if LatestBlockers property is set
        internal bool IsSetLatestBlockers()
        {
            return this._latestBlockers != null && this._latestBlockers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want sync your service configuration with.
        /// </para>
        /// </summary>
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that you want to get the sync blocker summary for. If given
        /// a service instance name and a service name, it will return the blockers only applying
        /// to the instance that is blocked.
        /// </para>
        ///  
        /// <para>
        /// If given only a service name, it will return the blockers that apply to all of the
        /// instances. In order to get the blockers for a single instance, you will need to make
        /// two distinct calls, one to get the sync blocker summary for the service and the other
        /// to get the sync blocker for the service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}