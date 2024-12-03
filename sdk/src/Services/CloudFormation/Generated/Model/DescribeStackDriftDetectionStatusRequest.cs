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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStackDriftDetectionStatus operation.
    /// Returns information about a stack drift detection operation. A stack drift detection
    /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
    /// from its expected configuration, as defined in the stack template and any values specified
    /// as template parameters. A stack is considered to have drifted if one or more of its
    /// resources have drifted. For more information about stack and resource drift, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
    /// unmanaged configuration changes to stacks and resources with drift detection</a>.
    /// 
    ///  
    /// <para>
    /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <c>DetectStackDrift</c>
    /// returns a <c>StackDriftDetectionId</c> you can use to monitor the progress of the
    /// operation using <c>DescribeStackDriftDetectionStatus</c>. Once the drift detection
    /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
    /// about the stack and its resources.
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
        /// CloudFormation generates new results, with a new drift detection ID, each time this
        /// operation is run. However, the number of drift results CloudFormation retains for
        /// any given stack, and for how long, may vary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
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