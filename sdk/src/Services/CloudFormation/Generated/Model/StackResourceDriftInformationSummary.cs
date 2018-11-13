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
    /// Summarizes information about whether the resource's actual configuration differs,
    /// or has <i>drifted</i>, from its expected configuration.
    /// </summary>
    public partial class StackResourceDriftInformationSummary
    {
        private DateTime? _lastCheckTimestamp;
        private StackResourceDriftStatus _stackResourceDriftStatus;

        /// <summary>
        /// Gets and sets the property LastCheckTimestamp. 
        /// <para>
        /// When AWS CloudFormation last checked if the resource had drifted from its expected
        /// configuration.
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
        /// Gets and sets the property StackResourceDriftStatus. 
        /// <para>
        /// Status of the resource's actual configuration compared to its expected configuration
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DELETED</code>: The resource differs from its expected configuration in that
        /// it has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODIFIED</code>: The resource differs from its expected configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation has not checked if the resource differs
        /// from its expected configuration.
        /// </para>
        ///  
        /// <para>
        /// Any resources that do not currently support drift detection have a status of <code>NOT_CHECKED</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>. If you performed an <a>ContinueUpdateRollback</a>
        /// operation on a stack, any resources included in <code>ResourcesToSkip</code> will
        /// also have a status of <code>NOT_CHECKED</code>. For more information on skipping resources
        /// during rollback operations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-continueupdaterollback.html">Continue
        /// Rolling Back an Update</a> in the AWS CloudFormation User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: The resources's actual configuration matches its expected configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackResourceDriftStatus StackResourceDriftStatus
        {
            get { return this._stackResourceDriftStatus; }
            set { this._stackResourceDriftStatus = value; }
        }

        // Check to see if StackResourceDriftStatus property is set
        internal bool IsSetStackResourceDriftStatus()
        {
            return this._stackResourceDriftStatus != null;
        }

    }
}