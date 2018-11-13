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
    /// Container for the parameters to the DescribeStackDriftDetectionStatus operation.
    /// Returns information about a stack drift detection operation. A stack drift detection
    /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
    /// from it's expected configuration, as defined in the stack template and any values
    /// specified as template parameters. A stack is considered to have drifted if one or
    /// more of its resources have drifted. For more information on stack and resource drift,
    /// see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
    /// Unregulated Configuration Changes to Stacks and Resources</a>.
    /// 
    ///  
    /// <para>
    /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <code>DetectStackDrift</code>
    /// returns a <code>StackDriftDetectionId</code> you can use to monitor the progress of
    /// the operation using <code>DescribeStackDriftDetectionStatus</code>. Once the drift
    /// detection operation has completed, use <a>DescribeStackResourceDrifts</a> to return
    /// drift information about the stack and its resources.
    /// </para>
    /// </summary>
    public partial class DescribeStackDriftDetectionStatusRequest : AmazonCloudFormationRequest
    {
        private string _stackDriftDetectionId;

        /// <summary>
        /// Gets and sets the property StackDriftDetectionId. 
        /// <para>
        /// The ID of the drift detection results of this operation. 
        /// </para>
        ///  
        /// <para>
        /// AWS CloudFormation generates new results, with a new drift detection ID, each time
        /// this operation is run. However, the number of drift results AWS CloudFormation retains
        /// for any given stack, and for how long, may vary. 
        /// </para>
        /// </summary>
        public string StackDriftDetectionId
        {
            get { return this._stackDriftDetectionId; }
            set { this._stackDriftDetectionId = value; }
        }

        // Check to see if StackDriftDetectionId property is set
        internal bool IsSetStackDriftDetectionId()
        {
            return this._stackDriftDetectionId != null;
        }

    }
}