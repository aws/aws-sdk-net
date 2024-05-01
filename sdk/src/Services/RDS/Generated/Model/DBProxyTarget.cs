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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details for an RDS Proxy target. It represents an RDS DB instance or
    /// Aurora DB cluster that the proxy can connect to. One or more targets are associated
    /// with an RDS Proxy target group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBProxyTargets</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBProxyTarget
    {
        private string _endpoint;
        private int? _port;
        private string _rdsResourceId;
        private TargetRole _role;
        private string _targetArn;
        private TargetHealth _targetHealth;
        private string _trackedClusterId;
        private TargetType _type;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The writer endpoint for the RDS DB instance or Aurora DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the RDS Proxy uses to connect to the target RDS DB instance or Aurora
        /// DB cluster.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RdsResourceId. 
        /// <para>
        /// The identifier representing the target. It can be the instance identifier for an RDS
        /// DB instance, or the cluster identifier for an Aurora DB cluster.
        /// </para>
        /// </summary>
        public string RdsResourceId
        {
            get { return this._rdsResourceId; }
            set { this._rdsResourceId = value; }
        }

        // Check to see if RdsResourceId property is set
        internal bool IsSetRdsResourceId()
        {
            return this._rdsResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// A value that indicates whether the target of the proxy can be used for read/write
        /// or read-only operations.
        /// </para>
        /// </summary>
        public TargetRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the RDS DB instance or Aurora DB cluster.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetHealth. 
        /// <para>
        /// Information about the connection health of the RDS Proxy target.
        /// </para>
        /// </summary>
        public TargetHealth TargetHealth
        {
            get { return this._targetHealth; }
            set { this._targetHealth = value; }
        }

        // Check to see if TargetHealth property is set
        internal bool IsSetTargetHealth()
        {
            return this._targetHealth != null;
        }

        /// <summary>
        /// Gets and sets the property TrackedClusterId. 
        /// <para>
        /// The DB cluster identifier when the target represents an Aurora DB cluster. This field
        /// is blank when the target represents an RDS DB instance.
        /// </para>
        /// </summary>
        public string TrackedClusterId
        {
            get { return this._trackedClusterId; }
            set { this._trackedClusterId = value; }
        }

        // Check to see if TrackedClusterId property is set
        internal bool IsSetTrackedClusterId()
        {
            return this._trackedClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the kind of database, such as an RDS DB instance or an Aurora DB cluster,
        /// that the target represents.
        /// </para>
        /// </summary>
        public TargetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}