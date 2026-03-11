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
    /// Container for the parameters to the ModifyDBProxyTargetGroup operation.
    /// Modifies the properties of a <c>DBProxyTargetGroup</c>.
    /// </summary>
    public partial class ModifyDBProxyTargetGroupRequest : AmazonRDSRequest
    {
        private ConnectionPoolConfiguration _connectionPoolConfig;
        private string _dbProxyName;
        private string _newName;
        private string _targetGroupName;

        /// <summary>
        /// Gets and sets the property ConnectionPoolConfig. 
        /// <para>
        /// The settings that determine the size and behavior of the connection pool for the target
        /// group.
        /// </para>
        /// </summary>
        public ConnectionPoolConfiguration ConnectionPoolConfig
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
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The name of the proxy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property NewName. 
        /// <para>
        /// The new name for the modified <c>DBProxyTarget</c>. An identifier must begin with
        /// a letter and must contain only ASCII letters, digits, and hyphens; it can't end with
        /// a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  
        /// <para>
        /// You can't rename the <c>default</c> target group.
        /// </para>
        /// </summary>
        public string NewName
        {
            get { return this._newName; }
            set { this._newName = value; }
        }

        // Check to see if NewName property is set
        internal bool IsSetNewName()
        {
            return this._newName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The name of the target group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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

    }
}