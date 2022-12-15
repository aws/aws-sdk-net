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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the target Capacity Reservation or Capacity Reservation group in
    /// which to run an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataCapacityReservationSpecificationCapacityReservationTargetDetails
    {
        private string _capacityReservationId;
        private string _capacityReservationResourceGroupArn;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        ///  The ID of the Capacity Reservation in which to run the instance. 
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationResourceGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Capacity Reservation resource group in which
        /// to run the instance. 
        /// </para>
        /// </summary>
        public string CapacityReservationResourceGroupArn
        {
            get { return this._capacityReservationResourceGroupArn; }
            set { this._capacityReservationResourceGroupArn = value; }
        }

        // Check to see if CapacityReservationResourceGroupArn property is set
        internal bool IsSetCapacityReservationResourceGroupArn()
        {
            return this._capacityReservationResourceGroupArn != null;
        }

    }
}