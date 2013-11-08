/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of enabling monitoring on a set of Amazon EC2 instances. Contains the updated monitoring status for each instance
    /// specified in the request. </para>
    /// </summary>
    public partial class MonitorInstancesResult : AmazonWebServiceResponse
    {
        
        private List<InstanceMonitoring> instanceMonitorings = new List<InstanceMonitoring>();


        /// <summary>
        /// A list of updated monitoring information for the instances specified in the request.
        ///  
        /// </summary>
        public List<InstanceMonitoring> InstanceMonitorings
        {
            get { return this.instanceMonitorings; }
            set { this.instanceMonitorings = value; }
        }

        // Check to see if InstanceMonitorings property is set
        internal bool IsSetInstanceMonitorings()
        {
            return this.instanceMonitorings.Count > 0;
        }
    }
}
