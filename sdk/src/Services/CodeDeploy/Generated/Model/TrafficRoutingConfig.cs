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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// The configuration that specifies how traffic is shifted from one version of a Lambda
    /// function to another version during an Lambda deployment, or from one Amazon ECS task
    /// set to another during an Amazon ECS deployment.
    /// </summary>
    public partial class TrafficRoutingConfig
    {
        private TimeBasedCanary _timeBasedCanary;
        private TimeBasedLinear _timeBasedLinear;
        private TrafficRoutingType _type;

        /// <summary>
        /// Gets and sets the property TimeBasedCanary. 
        /// <para>
        /// A configuration that shifts traffic from one version of a Lambda function or ECS task
        /// set to another in two increments. The original and target Lambda function versions
        /// or ECS task sets are specified in the deployment's AppSpec file.
        /// </para>
        /// </summary>
        public TimeBasedCanary TimeBasedCanary
        {
            get { return this._timeBasedCanary; }
            set { this._timeBasedCanary = value; }
        }

        // Check to see if TimeBasedCanary property is set
        internal bool IsSetTimeBasedCanary()
        {
            return this._timeBasedCanary != null;
        }

        /// <summary>
        /// Gets and sets the property TimeBasedLinear. 
        /// <para>
        /// A configuration that shifts traffic from one version of a Lambda function or Amazon
        /// ECS task set to another in equal increments, with an equal number of minutes between
        /// each increment. The original and target Lambda function versions or Amazon ECS task
        /// sets are specified in the deployment's AppSpec file.
        /// </para>
        /// </summary>
        public TimeBasedLinear TimeBasedLinear
        {
            get { return this._timeBasedLinear; }
            set { this._timeBasedLinear = value; }
        }

        // Check to see if TimeBasedLinear property is set
        internal bool IsSetTimeBasedLinear()
        {
            return this._timeBasedLinear != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of traffic shifting (<c>TimeBasedCanary</c> or <c>TimeBasedLinear</c>) used
        /// by a deployment configuration.
        /// </para>
        /// </summary>
        public TrafficRoutingType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}