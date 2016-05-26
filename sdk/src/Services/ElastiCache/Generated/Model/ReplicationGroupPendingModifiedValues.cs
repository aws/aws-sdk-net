/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The settings to be applied to the replication group, either immediately or during
    /// the next maintenance window.
    /// </summary>
    public partial class ReplicationGroupPendingModifiedValues
    {
        private PendingAutomaticFailoverStatus _automaticFailoverStatus;
        private string _primaryClusterId;

        /// <summary>
        /// Gets and sets the property AutomaticFailoverStatus. 
        /// <para>
        /// Indicates the status of Multi-AZ for this replication group.
        /// </para>
        ///  <note> 
        /// <para>
        /// ElastiCache Multi-AZ replication groups are not supported on:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Redis versions earlier than 2.8.6.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// T1 and T2 cache node types.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public PendingAutomaticFailoverStatus AutomaticFailoverStatus
        {
            get { return this._automaticFailoverStatus; }
            set { this._automaticFailoverStatus = value; }
        }

        // Check to see if AutomaticFailoverStatus property is set
        internal bool IsSetAutomaticFailoverStatus()
        {
            return this._automaticFailoverStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// The primary cluster ID which will be applied immediately (if <code>--apply-immediately</code>
        /// was specified), or during the next maintenance window.
        /// </para>
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this._primaryClusterId; }
            set { this._primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this._primaryClusterId != null;
        }

    }
}