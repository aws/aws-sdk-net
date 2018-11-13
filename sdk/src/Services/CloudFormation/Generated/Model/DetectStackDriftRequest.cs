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
    /// Container for the parameters to the DetectStackDrift operation.
    /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
    /// it's expected configuration, as defined in the stack template and any values specified
    /// as template parameters. For each resource in the stack that supports drift detection,
    /// AWS CloudFormation compares the actual configuration of the resource with its expected
    /// template configuration. Only resource properties explicitly defined in the stack template
    /// are checked for drift. A stack is considered to have drifted if one or more of its
    /// resources differ from their expected template configurations. For more information,
    /// see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
    /// Unregulated Configuration Changes to Stacks and Resources</a>.
    /// 
    ///  
    /// <para>
    /// Use <code>DetectStackDrift</code> to detect drift on all supported resources for a
    /// given stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
    /// </para>
    ///  
    /// <para>
    /// For a list of stack resources that currently support drift detection, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
    /// that Support Drift Detection</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>DetectStackDrift</code> can take up to several minutes, depending on the number
    /// of resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
    /// to monitor the progress of a detect stack drift operation. Once the drift detection
    /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
    /// about the stack and its resources.
    /// </para>
    ///  
    /// <para>
    /// When detecting drift on a stack, AWS CloudFormation does not detect drift on any nested
    /// stacks belonging to that stack. Perform <code>DetectStackDrift</code> directly on
    /// the nested stack itself.
    /// </para>
    /// </summary>
    public partial class DetectStackDriftRequest : AmazonCloudFormationRequest
    {
        private List<string> _logicalResourceIds = new List<string>();
        private string _stackName;

        /// <summary>
        /// Gets and sets the property LogicalResourceIds. 
        /// <para>
        /// The logical names of any resources you want to use as filters.
        /// </para>
        /// </summary>
        public List<string> LogicalResourceIds
        {
            get { return this._logicalResourceIds; }
            set { this._logicalResourceIds = value; }
        }

        // Check to see if LogicalResourceIds property is set
        internal bool IsSetLogicalResourceIds()
        {
            return this._logicalResourceIds != null && this._logicalResourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for which you want to detect drift. 
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}