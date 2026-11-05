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
    /// Represents a set of RDS DB instances, Aurora DB clusters, or both that a proxy can
    /// connect to. Currently, each target group is associated with exactly one RDS DB instance
    /// or Aurora DB cluster.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBProxyTargetGroups</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBProxyTargetGroup
    {
        /// <summary>
        /// Gets and sets the property ConnectionPoolConfig. 
        /// <para>
        /// The settings that determine the size and behavior of the connection pool for the target
        /// group.
        /// </para>
        /// </summary>
        public ConnectionPoolConfigurationInfo ConnectionPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionPoolConfig property is set.
        /// </summary>
        internal bool IsSetConnectionPoolConfig() => this.ConnectionPoolConfig != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the target group was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the RDS proxy associated with this target group.
        /// </para>
        /// </summary>
        public string DBProxyName { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyName property is set.
        /// </summary>
        internal bool IsSetDBProxyName() => this.DBProxyName != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this target group is the first one used for connection requests
        /// by the associated proxy. Because each proxy is currently associated with a single
        /// target group, currently this setting is always <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this target group. A status of <c>available</c> means the target
        /// group is correctly associated with a database. Other values indicate that you must
        /// wait for the target group to be ready, or take some action to resolve an issue.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) representing the target group.
        /// </para>
        /// </summary>
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The identifier for the target group. This name must be unique for all target groups
        /// owned by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string TargetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupName property is set.
        /// </summary>
        internal bool IsSetTargetGroupName() => this.TargetGroupName != null;

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The date and time when the target group was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedDate property is set.
        /// </summary>
        internal bool IsSetUpdatedDate() => this.UpdatedDate.HasValue;
    }
}
