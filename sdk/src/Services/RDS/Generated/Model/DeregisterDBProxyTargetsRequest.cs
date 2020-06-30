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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterDBProxyTargets operation.
    /// Remove the association between one or more <code>DBProxyTarget</code> data structures
    /// and a <code>DBProxyTargetGroup</code>.
    /// </summary>
    public partial class DeregisterDBProxyTargetsRequest : AmazonRDSRequest
    {
        private List<string> _dbClusterIdentifiers = new List<string>();
        private List<string> _dbInstanceIdentifiers = new List<string>();
        private string _dbProxyName;
        private string _targetGroupName;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifiers. 
        /// <para>
        /// One or more DB cluster identifiers.
        /// </para>
        /// </summary>
        public List<string> DBClusterIdentifiers
        {
            get { return this._dbClusterIdentifiers; }
            set { this._dbClusterIdentifiers = value; }
        }

        // Check to see if DBClusterIdentifiers property is set
        internal bool IsSetDBClusterIdentifiers()
        {
            return this._dbClusterIdentifiers != null && this._dbClusterIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifiers. 
        /// <para>
        /// One or more DB instance identifiers.
        /// </para>
        /// </summary>
        public List<string> DBInstanceIdentifiers
        {
            get { return this._dbInstanceIdentifiers; }
            set { this._dbInstanceIdentifiers = value; }
        }

        // Check to see if DBInstanceIdentifiers property is set
        internal bool IsSetDBInstanceIdentifiers()
        {
            return this._dbInstanceIdentifiers != null && this._dbInstanceIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier of the <code>DBProxy</code> that is associated with the <code>DBProxyTargetGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The identifier of the <code>DBProxyTargetGroup</code>.
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

    }
}