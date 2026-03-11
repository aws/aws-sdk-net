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
    /// The failed constraint.
    /// </summary>
    public partial class WaypointOptimizationFailedConstraint
    {
        private WaypointOptimizationConstraint _constraint;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Constraint. 
        /// <para>
        /// The failed constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public WaypointOptimizationConstraint Constraint
        {
            get { return this._constraint; }
            set { this._constraint = value; }
        }

        // Check to see if Constraint property is set
        internal bool IsSetConstraint()
        {
            return this._constraint != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Reason for the failed constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}