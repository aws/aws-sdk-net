/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// A configuration that shifts traffic from one version of a Lambda function to another
    /// in two increments. The original and target Lambda function versions are specified
    /// in the deployment's AppSpec file.
    /// </summary>
    public partial class TimeBasedCanary
    {
        private int? _canaryInterval;
        private int? _canaryPercentage;

        /// <summary>
        /// Gets and sets the property CanaryInterval. 
        /// <para>
        /// The number of minutes between the first and second traffic shifts of a <code>TimeBasedCanary</code>
        /// deployment.
        /// </para>
        /// </summary>
        public int CanaryInterval
        {
            get { return this._canaryInterval.GetValueOrDefault(); }
            set { this._canaryInterval = value; }
        }

        // Check to see if CanaryInterval property is set
        internal bool IsSetCanaryInterval()
        {
            return this._canaryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanaryPercentage. 
        /// <para>
        /// The percentage of traffic to shift in the first increment of a <code>TimeBasedCanary</code>
        /// deployment.
        /// </para>
        /// </summary>
        public int CanaryPercentage
        {
            get { return this._canaryPercentage.GetValueOrDefault(); }
            set { this._canaryPercentage = value; }
        }

        // Check to see if CanaryPercentage property is set
        internal bool IsSetCanaryPercentage()
        {
            return this._canaryPercentage.HasValue; 
        }

    }
}