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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an Auto Scaling process that has been suspended. For more information, see
    /// <a>ProcessType</a>.
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