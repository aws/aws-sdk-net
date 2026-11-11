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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about the health of a target.
    /// </summary>
    public partial class TargetHealthDescription
    {
        /// <summary>
        /// Gets and sets the property AdministrativeOverride. 
        /// <para>
        /// The administrative override information for the target.
        /// </para>
        /// </summary>
        public AdministrativeOverride AdministrativeOverride { get; set; }

        /// <summary>
        /// Checks to see if the AdministrativeOverride property is set.
        /// </summary>
        internal bool IsSetAdministrativeOverride() => this.AdministrativeOverride != null;

        /// <summary>
        /// Gets and sets the property AnomalyDetection. 
        /// <para>
        /// The anomaly detection result for the target.
        /// </para>
        ///  
        /// <para>
        /// If no anomalies were detected, the result is <c>normal</c>.
        /// </para>
        ///  
        /// <para>
        /// If anomalies were detected, the result is <c>anomalous</c>.
        /// </para>
        /// </summary>
        public AnomalyDetection AnomalyDetection { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetection property is set.
        /// </summary>
        internal bool IsSetAnomalyDetection() => this.AnomalyDetection != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPort. 
        /// <para>
        /// The port to use to connect with the target.
        /// </para>
        /// </summary>
        public string HealthCheckPort { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPort property is set.
        /// </summary>
        internal bool IsSetHealthCheckPort() => this.HealthCheckPort != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The description of the target.
        /// </para>
        /// </summary>
        public TargetDescription Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TargetHealth. 
        /// <para>
        /// The health information for the target.
        /// </para>
        /// </summary>
        public TargetHealth TargetHealth { get; set; }

        /// <summary>
        /// Checks to see if the TargetHealth property is set.
        /// </summary>
        internal bool IsSetTargetHealth() => this.TargetHealth != null;
    }
}
