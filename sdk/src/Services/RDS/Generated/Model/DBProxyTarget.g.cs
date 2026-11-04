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
        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The writer endpoint for the RDS DB instance or Aurora DB cluster.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the RDS Proxy uses to connect to the target RDS DB instance or Aurora
        /// DB cluster.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RdsResourceId. 
        /// <para>
        /// The identifier representing the target. It can be the instance identifier for an RDS
        /// DB instance, or the cluster identifier for an Aurora DB cluster.
        /// </para>
        /// </summary>
        public string RdsResourceId { get; set; }

        /// <summary>
        /// Checks to see if the RdsResourceId property is set.
        /// </summary>
        internal bool IsSetRdsResourceId() => this.RdsResourceId != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// A value that indicates whether the target of the proxy can be used for read/write
        /// or read-only operations.
        /// </para>
        /// </summary>
        public TargetRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the RDS DB instance or Aurora DB cluster.
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;

        /// <summary>
        /// Gets and sets the property TargetHealth. 
        /// <para>
        /// Information about the connection health of the RDS Proxy target.
        /// </para>
        /// </summary>
        public TargetHealth TargetHealth { get; set; }

        /// <summary>
        /// Checks to see if the TargetHealth property is set.
        /// </summary>
        internal bool IsSetTargetHealth() => this.TargetHealth != null;

        /// <summary>
        /// Gets and sets the property TrackedClusterId. 
        /// <para>
        /// The DB cluster identifier when the target represents an Aurora DB cluster. This field
        /// is blank when the target represents an RDS DB instance.
        /// </para>
        /// </summary>
        public string TrackedClusterId { get; set; }

        /// <summary>
        /// Checks to see if the TrackedClusterId property is set.
        /// </summary>
        internal bool IsSetTrackedClusterId() => this.TrackedClusterId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the kind of database, such as an RDS DB instance or an Aurora DB cluster,
        /// that the target represents.
        /// </para>
        /// </summary>
        public TargetType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
