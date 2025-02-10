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
    /// Container for the parameters to the DetectStackResourceDrift operation.
    /// Returns information about whether a resource's actual configuration differs, or has
    /// <i>drifted</i>, from its expected configuration, as defined in the stack template
    /// and any values specified as template parameters. This information includes actual
    /// and expected property values for resources in which CloudFormation detects drift.
    /// Only resource properties explicitly defined in the stack template are checked for
    /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
    /// unmanaged configuration changes to stacks and resources with drift detection</a>.
    /// 
    ///  
    /// <para>
    /// Use <c>DetectStackResourceDrift</c> to detect drift on individual resources, or <a>DetectStackDrift</a>
    /// to detect drift on all resources in a given stack that support drift detection.
    /// </para>
    ///  
    /// <para>
    /// Resources that don't currently support drift detection can't be checked. For a list
    /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
    /// type support for imports and drift detection</a>.
    /// </para>
    /// </summary>
    public partial class DetectStackResourceDriftRequest : AmazonCloudFormationRequest
    {
        private string _logicalResourceId;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource for which to return drift information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack to which the resource belongs.
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