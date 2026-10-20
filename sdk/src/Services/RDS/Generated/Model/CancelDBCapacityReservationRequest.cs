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
    /// Container for the parameters to the CancelDBCapacityReservation operation.
    /// Cancels a DB capacity reservation. Amazon RDS changes the state of the reservation
    /// to <c>cancelled</c> and stops reporting available capacity for it. Amazon RDS then
    /// releases the reserved capacity.
    /// 
    ///  
    /// <para>
    /// A DB instance that uses the reservation keeps running. It continues on unreserved
    /// capacity, and Amazon RDS doesn't stop it or modify it. However, Amazon RDS no longer
    /// reserves capacity for the DB instance. If Amazon RDS later moves the DB instance to
    /// different hardware, for example during hardware maintenance, that move can fail when
    /// the Amazon Web Services Region has insufficient capacity for the DB instance class.
    /// </para>
    ///  
    /// <para>
    /// You can't cancel a reservation in the <c>active</c> state during a capacity commitment.
    /// The response of <c>DescribeDBCapacityReservations</c> reports the end of the commitment
    /// in <c>CommitmentInfo</c>.
    /// </para>
    ///  
    /// <para>
    /// Constraints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The reservation must be in the <c>active</c>, <c>assessing</c>, or <c>delayed</c>
    /// state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The reservation must not be past its end date.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelDBCapacityReservationRequest : AmazonRDSRequest
    {
        private string _dbCapacityReservationIdentifier;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation to cancel. You can specify
        /// the identifier, which has the prefix <c>dbcr-</c>, or the reservation name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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

    }
}