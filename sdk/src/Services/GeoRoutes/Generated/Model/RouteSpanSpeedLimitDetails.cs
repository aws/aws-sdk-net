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
    /// Details about the speed limit corresponding to the span.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>KilometersPerHour</c> 
    /// </para>
    /// </summary>
    public partial class RouteSpanSpeedLimitDetails
    {
        private double? _maxSpeed;
        private bool? _unlimited;

        /// <summary>
        /// Gets and sets the property MaxSpeed. 
        /// <para>
        /// Maximum speed.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? MaxSpeed
        {
            get { return this._maxSpeed; }
            set { this._maxSpeed = value; }
        }

        // Check to see if MaxSpeed property is set
        internal bool IsSetMaxSpeed()
        {
            return this._maxSpeed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If the span doesn't have a speed limit like the Autobahn.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Unlimited
        {
            get { return this._unlimited; }
            set { this._unlimited = value; }
        }

        // Check to see if Unlimited property is set
        internal bool IsSetUnlimited()
        {
            return this._unlimited.HasValue; 
        }

    }
}