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
    /// Container for the parameters to the StartDBInstance operation.
    /// Starts an Amazon RDS DB instance that was stopped using the Amazon Web Services console,
    /// the stop-db-instance CLI command, or the <c>StopDBInstance</c> operation.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StartInstance.html">
    /// Starting an Amazon RDS DB instance That Was Previously Stopped</a> in the <i>Amazon
    /// RDS User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL. For
    /// Aurora DB clusters, use <c>StartDBCluster</c> instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbCapacityReservationIdentifier;
        private string _dbInstanceIdentifier;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation for the DB instance to use
        /// after it starts. You can specify the identifier, which has the prefix <c>dbcr-</c>,
        /// or the reservation name.
        /// </para>
        ///  
        /// <para>
        /// Specify this parameter when the DB instance stopped using a reservation, or when you
        /// want the DB instance to use a different reservation.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, and the DB instance kept a DB capacity reservation when
        /// it stopped, Amazon RDS starts the DB instance in that reservation.
        /// </para>
        ///  
        /// <para>
        /// If that reservation is deleted, ended, or cancelled, the DB instance still starts.
        /// Amazon RDS starts the DB instance outside the reservation, on unreserved capacity,
        /// and it charges on-demand prices for the DB instance.
        /// </para>
        ///  
        /// <para>
        /// If that reservation has no available capacity in the Availability Zone of the DB instance,
        /// the request fails. Amazon RDS doesn't start the DB instance, and it doesn't wait for
        /// capacity in that Availability Zone. Specify a reservation that has available capacity
        /// in that Availability Zone, or retry the request after the reservation has available
        /// capacity.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The reservation must be in the <c>active</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must reserve capacity for the DB instance class and the engine of
        /// the DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The reservation must cover the Availability Zone of the DB instance, and it must have
        /// available capacity in that Availability Zone.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DBCapacityReservationIdentifier
        {
            get { return this._dbCapacityReservationIdentifier; }
            set { this._dbCapacityReservationIdentifier = value; }
        }

        // Check to see if DBCapacityReservationIdentifier property is set
        internal bool IsSetDBCapacityReservationIdentifier()
        {
            return this._dbCapacityReservationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The user-supplied instance identifier.
        /// </para>
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

    }
}