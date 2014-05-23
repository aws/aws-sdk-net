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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeTimeBasedAutoScaling</code> request.
    /// </summary>
    public partial class DescribeTimeBasedAutoScalingResult : AmazonWebServiceResponse
    {
        private List<TimeBasedAutoScalingConfiguration> _timeBasedAutoScalingConfigurations = new List<TimeBasedAutoScalingConfiguration>();


        /// <summary>
        /// Gets and sets the property TimeBasedAutoScalingConfigurations. 
        /// <para>
        /// An array of <code>TimeBasedAutoScalingConfiguration</code> objects that describe the
        /// configuration for the specified instances.
        /// </para>
        /// </summary>
        public List<TimeBasedAutoScalingConfiguration> TimeBasedAutoScalingConfigurations
        {
            get { return this._timeBasedAutoScalingConfigurations; }
            set { this._timeBasedAutoScalingConfigurations = value; }
        }

        // Check to see if TimeBasedAutoScalingConfigurations property is set
        internal bool IsSetTimeBasedAutoScalingConfigurations()
        {
            return this._timeBasedAutoScalingConfigurations != null && this._timeBasedAutoScalingConfigurations.Count > 0; 
        }

    }
}