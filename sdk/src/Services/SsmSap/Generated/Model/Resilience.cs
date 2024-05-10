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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
        private ClusterStatus _clusterStatus;
        private bool? _enqueueReplication;
        private OperationMode _hsrOperationMode;
        private ReplicationMode _hsrReplicationMode;
        private string _hsrTier;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The cluster status of the component.
        /// </para>
        /// </summary>
        public ClusterStatus ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnqueueReplication. 
        /// <para>
        /// Indicates if or not enqueue replication is enabled for the ASCS component.
        /// </para>
        /// </summary>
        public bool? EnqueueReplication
        {
            get { return this._enqueueReplication; }
            set { this._enqueueReplication = value; }
        }

        // Check to see if EnqueueReplication property is set
        internal bool IsSetEnqueueReplication()
        {
            return this._enqueueReplication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HsrOperationMode. 
        /// <para>
        /// The operation mode of the component.
        /// </para>
        /// </summary>
        public OperationMode HsrOperationMode
        {
            get { return this._hsrOperationMode; }
            set { this._hsrOperationMode = value; }
        }

        // Check to see if HsrOperationMode property is set
        internal bool IsSetHsrOperationMode()
        {
            return this._hsrOperationMode != null;
        }

        /// <summary>
        /// Gets and sets the property HsrReplicationMode. 
        /// <para>
        /// The replication mode of the component.
        /// </para>
        /// </summary>
        public ReplicationMode HsrReplicationMode
        {
            get { return this._hsrReplicationMode; }
            set { this._hsrReplicationMode = value; }
        }

        // Check to see if HsrReplicationMode property is set
        internal bool IsSetHsrReplicationMode()
        {
            return this._hsrReplicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property HsrTier. 
        /// <para>
        /// The tier of the component.
        /// </para>
        /// </summary>
        public string HsrTier
        {
            get { return this._hsrTier; }
            set { this._hsrTier = value; }
        }

        // Check to see if HsrTier property is set
        internal bool IsSetHsrTier()
        {
            return this._hsrTier != null;
        }

    }
}