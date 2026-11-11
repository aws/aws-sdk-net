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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDBInstance operation. You might need to
    /// reboot your DB instance, usually for maintenance reasons. For example, if you make
    /// certain modifications, or if you change the DB parameter group associated with the
    /// DB instance, you must reboot the instance for the changes to take effect. <para> Rebooting
    /// a DB instance restarts the database engine service. Rebooting a DB instance results
    /// in a momentary outage, during which the DB instance status is set to rebooting. </para>
    /// </summary>
    public partial class RebootDBInstanceRequest : AmazonNeptuneRequest
    {
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
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ForceFailover. 
        /// <para>
        ///  When <c>true</c>, the reboot is conducted through a MultiAZ failover.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You can't specify <c>true</c> if the instance is not configured for MultiAZ.
        /// </para>
        /// </summary>
        public bool? ForceFailover { get; set; }

        /// <summary>
        /// Checks to see if the ForceFailover property is set.
        /// </summary>
        internal bool IsSetForceFailover() => this.ForceFailover.HasValue;
    }
}
