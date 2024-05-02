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
    /// A configuration that shifts traffic from one version of a Lambda function or ECS task
    /// set to another in equal increments, with an equal number of minutes between each increment.
    /// The original and target Lambda function versions or ECS task sets are specified in
    /// the deployment's AppSpec file.
    /// </summary>
    public partial class TimeBasedLinear
    {
        private int? _linearInterval;
        private int? _linearPercentage;

        /// <summary>
        /// Gets and sets the property LinearInterval. 
        /// <para>
        /// The number of minutes between each incremental traffic shift of a <c>TimeBasedLinear</c>
        /// deployment.
        /// </para>
        /// </summary>
        public int? LinearInterval
        {
            get { return this._linearInterval; }
            set { this._linearInterval = value; }
        }

        // Check to see if LinearInterval property is set
        internal bool IsSetLinearInterval()
        {
            return this._linearInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinearPercentage. 
        /// <para>
        /// The percentage of traffic that is shifted at the start of each increment of a <c>TimeBasedLinear</c>
        /// deployment.
        /// </para>
        /// </summary>
        public int? LinearPercentage
        {
            get { return this._linearPercentage; }
            set { this._linearPercentage = value; }
        }

        // Check to see if LinearPercentage property is set
        internal bool IsSetLinearPercentage()
        {
            return this._linearPercentage.HasValue; 
        }

    }
}