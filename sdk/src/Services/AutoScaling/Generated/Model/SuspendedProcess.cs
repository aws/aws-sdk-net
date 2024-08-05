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
    /// Describes an auto scaling process that has been suspended.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html#process-types">Types
    /// of processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SuspendedProcess
    {
        private string _processName;
        private string _suspensionReason;

        /// <summary>
        /// Gets and sets the property ProcessName. 
        /// <para>
        /// The name of the suspended process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property SuspensionReason. 
        /// <para>
        /// The reason that the process was suspended.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SuspensionReason
        {
            get { return this._suspensionReason; }
            set { this._suspensionReason = value; }
        }

        // Check to see if SuspensionReason property is set
        internal bool IsSetSuspensionReason()
        {
            return this._suspensionReason != null;
        }

    }
}