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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains information about whether the stack's actual configuration differs, or has
    /// <i>drifted</i>, from its expected configuration, as defined in the stack template
    /// and any values specified as template parameters. A stack is considered to have drifted
    /// if one or more of its resources have drifted.
    /// </summary>
    public partial class StackDriftInformation
    {
        private DateTime? _lastCheckTimestamp;
        private StackDriftStatus _stackDriftStatus;

        /// <summary>
        /// Gets and sets the property LastCheckTimestamp. 
        /// <para>
        /// Most recent time when a drift detection operation was initiated on the stack, or any
        /// of its individual resources that support drift detection.
        /// </para>
        /// </summary>
        public DateTime LastCheckTimestamp
        {
            get { return this._lastCheckTimestamp.GetValueOrDefault(); }
            set { this._lastCheckTimestamp = value; }
        }

        // Check to see if LastCheckTimestamp property is set
        internal bool IsSetLastCheckTimestamp()
        {
            return this._lastCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackDriftStatus. 
        /// <para>
        /// Status of the stack's actual configuration compared to its expected template configuration.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DRIFTED</code>: The stack differs from its expected template configuration.
        /// A stack is considered to have drifted if one or more of its resources have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation has not checked if the stack differs
        /// from its expected template configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: The stack's actual configuration matches its expected template
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN</code>: This value is reserved for future use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftStatus StackDriftStatus
        {
            get { return this._stackDriftStatus; }
            set { this._stackDriftStatus = value; }
        }

        // Check to see if StackDriftStatus property is set
        internal bool IsSetStackDriftStatus()
        {
            return this._stackDriftStatus != null;
        }

    }
}