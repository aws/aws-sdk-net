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
    /// Container for the parameters to the DetectStackDrift operation.
    /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
    /// its expected configuration, as defined in the stack template and any values specified
    /// as template parameters. For each resource in the stack that supports drift detection,
    /// CloudFormation compares the actual configuration of the resource with its expected
    /// template configuration. Only resource properties explicitly defined in the stack template
    /// are checked for drift. A stack is considered to have drifted if one or more of its
    /// resources differ from their expected template configurations. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
    /// unmanaged configuration changes to stacks and resources with drift detection</a>.
    /// 
    ///  
    /// <para>
    /// Use <c>DetectStackDrift</c> to detect drift on all supported resources for a given
    /// stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
    /// </para>
    ///  
    /// <para>
    /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
    /// type support for imports and drift detection</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>DetectStackDrift</c> can take up to several minutes, depending on the number of
    /// resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
    /// to monitor the progress of a detect stack drift operation. Once the drift detection
    /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
    /// about the stack and its resources.
    /// </para>
    ///  
    /// <para>
    /// When detecting drift on a stack, CloudFormation doesn't detect drift on any nested
    /// stacks belonging to that stack. Perform <c>DetectStackDrift</c> directly on the nested
    /// stack itself.
    /// </para>
    /// </summary>
    public partial class DetectStackDriftRequest : AmazonCloudFormationRequest
    {
        private List<string> _logicalResourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property LogicalResourceIds. 
        /// <para>
        /// The logical names of any resources you want to use as filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<string> LogicalResourceIds
        {
            get { return this._logicalResourceIds; }
            set { this._logicalResourceIds = value; }
        }

        // Check to see if LogicalResourceIds property is set
        internal bool IsSetLogicalResourceIds()
        {
            return this._logicalResourceIds != null && (this._logicalResourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for which you want to detect drift.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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