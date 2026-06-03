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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Details about the EV charge at the current step.
    /// </summary>
    public partial class RouteChargeStepDetails
    {
        private double? _arrivalCharge;
        private double? _consumablePower;
        private double? _desiredCharge;

        /// <summary>
        /// Gets and sets the property ArrivalCharge. 
        /// <para>
        /// Estimated vehicle battery charge before this step (in kWh). 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? ArrivalCharge
        {
            get { return this._arrivalCharge; }
            set { this._arrivalCharge = value; }
        }

        // Check to see if ArrivalCharge property is set
        internal bool IsSetArrivalCharge()
        {
            return this._arrivalCharge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumablePower. 
        /// <para>
        /// Maximum charging power available to the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KwH</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? ConsumablePower
        {
            get { return this._consumablePower; }
            set { this._consumablePower = value; }
        }

        // Check to see if ConsumablePower property is set
        internal bool IsSetConsumablePower()
        {
            return this._consumablePower.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCharge. 
        /// <para>
        /// Details that are specific to a Charge step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KwH</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? DesiredCharge
        {
            get { return this._desiredCharge; }
            set { this._desiredCharge = value; }
        }

        // Check to see if DesiredCharge property is set
        internal bool IsSetDesiredCharge()
        {
            return this._desiredCharge.HasValue; 
        }

    }
}