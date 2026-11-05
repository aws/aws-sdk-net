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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDBInstance operation. You might need to
    /// reboot your instance, usually for maintenance reasons. For example, if you make certain
    /// changes, or if you change the cluster parameter group that is associated with the
    /// instance, you must reboot the instance for the changes to take effect. <para> Rebooting
    /// an instance restarts the database engine service. Rebooting an instance results in
    /// a momentary outage, during which the instance status is set to <i>rebooting</i>. </para>
    /// </summary>
    public partial class RebootDBInstanceRequest : AmazonDocDBRequest
    {
        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBInstance</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ForceFailover. 
        /// <para>
        ///  When <c>true</c>, the reboot is conducted through a Multi-AZ failover. 
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can't specify <c>true</c> if the instance is not configured for Multi-AZ.
        /// </para>
        /// </summary>
        public bool? ForceFailover { get; set; }

        /// <summary>
        /// Checks to see if the ForceFailover property is set.
        /// </summary>
        internal bool IsSetForceFailover() => this.ForceFailover.HasValue;
    }
}
