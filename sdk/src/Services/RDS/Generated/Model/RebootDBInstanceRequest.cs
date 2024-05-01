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
    /// Container for the parameters to the RebootDBInstance operation.
    /// You might need to reboot your DB instance, usually for maintenance reasons. For example,
    /// if you make certain modifications, or if you change the DB parameter group associated
    /// with the DB instance, you must reboot the instance for the changes to take effect.
    /// 
    ///  
    /// <para>
    /// Rebooting a DB instance restarts the database engine service. Rebooting a DB instance
    /// results in a momentary outage, during which the DB instance status is set to rebooting.
    /// </para>
    ///  
    /// <para>
    /// For more information about rebooting, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_RebootInstance.html">Rebooting
    /// a DB Instance</a> in the <i>Amazon RDS User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    ///  
    /// <para>
    /// If your DB instance is part of a Multi-AZ DB cluster, you can reboot the DB cluster
    /// with the <c>RebootDBCluster</c> operation.
    /// </para>
    /// </summary>
    public partial class RebootDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private bool? _forceFailover;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RebootDBInstanceRequest() { }

        /// <summary>
        /// Instantiates RebootDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li> Must match the identifier of an existing DBInstance. </li> </ul></param>
        public RebootDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The DB instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBInstance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ForceFailover. 
        /// <para>
        /// Specifies whether the reboot is conducted through a Multi-AZ failover.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can't enable force failover if the instance isn't configured for Multi-AZ.
        /// </para>
        /// </summary>
        public bool? ForceFailover
        {
            get { return this._forceFailover; }
            set { this._forceFailover = value; }
        }

        // Check to see if ForceFailover property is set
        internal bool IsSetForceFailover()
        {
            return this._forceFailover.HasValue; 
        }

    }
}