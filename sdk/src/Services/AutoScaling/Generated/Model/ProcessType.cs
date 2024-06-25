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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a process type.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html#process-types">Types
    /// of processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ProcessType
    {
        private string _processName;

        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        /// One of the following processes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Launch</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AddToLoadBalancer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AlarmNotification</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZRebalance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HealthCheck</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceRefresh</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReplaceUnhealthy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ScheduledActions</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProcessName
        {
            get { return this._processName; }
            set { this._processName = value; }
        }

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this._processName != null;
        }

    }
}