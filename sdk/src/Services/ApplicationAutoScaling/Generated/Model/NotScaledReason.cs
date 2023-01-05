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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Describes the reason for an activity that isn't scaled (<i>not scaled activity</i>),
    /// in machine-readable format. For help interpreting the not scaled reason details, see
    /// <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scaling-activities.html">Scaling
    /// activities for Application Auto Scaling</a>.
    /// </summary>
    public partial class NotScaledReason
    {
        private string _code;
        private int? _currentCapacity;
        private int? _maxCapacity;
        private int? _minCapacity;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A code that represents the reason for not scaling.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AutoScalingAnticipatedFlapping
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TargetServicePutResourceAsUnscalable
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AlreadyAtMaxCapacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AlreadyAtMinCapacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AlreadyAtDesiredCapacity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentCapacity. 
        /// <para>
        /// The current capacity.
        /// </para>
        /// </summary>
        public int CurrentCapacity
        {
            get { return this._currentCapacity.GetValueOrDefault(); }
            set { this._currentCapacity = value; }
        }

        // Check to see if CurrentCapacity property is set
        internal bool IsSetCurrentCapacity()
        {
            return this._currentCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum capacity.
        /// </para>
        /// </summary>
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum capacity.
        /// </para>
        /// </summary>
        public int MinCapacity
        {
            get { return this._minCapacity.GetValueOrDefault(); }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

    }
}