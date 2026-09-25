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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Details of the SAP HANA system replication for the instance.
    /// </summary>
    public partial class Resilience
    {
        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The cluster status of the component.
        /// </para>
        /// </summary>
        public ClusterStatus ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property EnqueueReplication. 
        /// <para>
        /// Indicates if or not enqueue replication is enabled for the ASCS component.
        /// </para>
        /// </summary>
        public bool? EnqueueReplication { get; set; }

        /// <summary>
        /// Checks to see if the EnqueueReplication property is set.
        /// </summary>
        internal bool IsSetEnqueueReplication() => this.EnqueueReplication.HasValue;

        /// <summary>
        /// Gets and sets the property HsrOperationMode. 
        /// <para>
        /// The operation mode of the component.
        /// </para>
        /// </summary>
        public OperationMode HsrOperationMode { get; set; }

        /// <summary>
        /// Checks to see if the HsrOperationMode property is set.
        /// </summary>
        internal bool IsSetHsrOperationMode() => this.HsrOperationMode != null;

        /// <summary>
        /// Gets and sets the property HsrReplicationMode. 
        /// <para>
        /// The replication mode of the component.
        /// </para>
        /// </summary>
        public ReplicationMode HsrReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the HsrReplicationMode property is set.
        /// </summary>
        internal bool IsSetHsrReplicationMode() => this.HsrReplicationMode != null;

        /// <summary>
        /// Gets and sets the property HsrTier. 
        /// <para>
        /// The tier of the component.
        /// </para>
        /// </summary>
        public string HsrTier { get; set; }

        /// <summary>
        /// Checks to see if the HsrTier property is set.
        /// </summary>
        internal bool IsSetHsrTier() => this.HsrTier != null;
    }
}
