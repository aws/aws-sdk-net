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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an Availability Zone impairment policy.
    /// </summary>
    public partial class AvailabilityZoneImpairmentPolicy
    {
        private ImpairedZoneHealthCheckBehavior _impairedZoneHealthCheckBehavior;
        private bool? _zonalShiftEnabled;

        /// <summary>
        /// Gets and sets the property ImpairedZoneHealthCheckBehavior. 
        /// <para>
        ///  Specifies the health check behavior for the impaired Availability Zone in an active
        /// zonal shift. If you select <c>Replace unhealthy</c>, instances that appear unhealthy
        /// will be replaced in all Availability Zones. If you select <c>Ignore unhealthy</c>,
        /// instances will not be replaced in the Availability Zone with the active zonal shift.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-zonal-shift.html">Auto
        /// Scaling group zonal shift</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public ImpairedZoneHealthCheckBehavior ImpairedZoneHealthCheckBehavior
        {
            get { return this._impairedZoneHealthCheckBehavior; }
            set { this._impairedZoneHealthCheckBehavior = value; }
        }

        // Check to see if ImpairedZoneHealthCheckBehavior property is set
        internal bool IsSetImpairedZoneHealthCheckBehavior()
        {
            return this._impairedZoneHealthCheckBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalShiftEnabled. 
        /// <para>
        ///  If <c>true</c>, enable zonal shift for your Auto Scaling group. 
        /// </para>
        /// </summary>
        public bool? ZonalShiftEnabled
        {
            get { return this._zonalShiftEnabled; }
            set { this._zonalShiftEnabled = value; }
        }

        // Check to see if ZonalShiftEnabled property is set
        internal bool IsSetZonalShiftEnabled()
        {
            return this._zonalShiftEnabled.HasValue; 
        }

    }
}