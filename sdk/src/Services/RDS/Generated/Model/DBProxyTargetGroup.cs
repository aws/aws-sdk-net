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
        private ConnectionPoolConfigurationInfo _connectionPoolConfig;
        private DateTime? _createdDate;
        private string _dbProxyName;
        private bool? _isDefault;
        private string _status;
        private string _targetGroupArn;
        private string _targetGroupName;
        private DateTime? _updatedDate;

        /// <summary>
        /// Gets and sets the property ConnectionPoolConfig. 
        /// <para>
        /// The settings that determine the size and behavior of the connection pool for the target
        /// group.
        /// </para>
        /// </summary>
        public ConnectionPoolConfigurationInfo ConnectionPoolConfig
        {
            get { return this._connectionPoolConfig; }
            set { this._connectionPoolConfig = value; }
        }

        // Check to see if ConnectionPoolConfig property is set
        internal bool IsSetConnectionPoolConfig()
        {
            return this._connectionPoolConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the target group was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the RDS proxy associated with this target group.
        /// </para>
        /// </summary>
        public string DBProxyName
        {
            get { return this._dbProxyName; }
            set { this._dbProxyName = value; }
        }

        // Check to see if DBProxyName property is set
        internal bool IsSetDBProxyName()
        {
            return this._dbProxyName != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this target group is the first one used for connection requests
        /// by the associated proxy. Because each proxy is currently associated with a single
        /// target group, currently this setting is always <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this target group. A status of <c>available</c> means the target
        /// group is correctly associated with a database. Other values indicate that you must
        /// wait for the target group to be ready, or take some action to resolve an issue.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) representing the target group.
        /// </para>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The identifier for the target group. This name must be unique for all target groups
        /// owned by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string TargetGroupName
        {
            get { return this._targetGroupName; }
            set { this._targetGroupName = value; }
        }

        // Check to see if TargetGroupName property is set
        internal bool IsSetTargetGroupName()
        {
            return this._targetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The date and time when the target group was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate
        {
            get { return this._updatedDate; }
            set { this._updatedDate = value; }
        }

        // Check to see if UpdatedDate property is set
        internal bool IsSetUpdatedDate()
        {
            return this._updatedDate.HasValue; 
        }

    }
}