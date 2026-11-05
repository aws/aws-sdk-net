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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The <c>Parameter</c> data type.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The key associated with the parameter. If you don't specify a key and value for a
        /// particular parameter, CloudFormation uses the default value that's specified in your
        /// template.
        /// </para>
        /// </summary>
        public string ParameterKey { get; set; }

        /// <summary>
        /// Checks to see if the ParameterKey property is set.
        /// </summary>
        internal bool IsSetParameterKey() => this.ParameterKey != null;

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The input value associated with the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// Checks to see if the ParameterValue property is set.
        /// </summary>
        internal bool IsSetParameterValue() => this.ParameterValue != null;

        /// <summary>
        /// Gets and sets the property ResolvedValue. 
        /// <para>
        /// Read-only. The value that corresponds to a Systems Manager parameter key. This field
        /// is returned only for Systems Manager parameter types in the template. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-supplied-parameter-types.html">Specify
        /// existing resources at runtime with CloudFormation-supplied parameter types</a> in
        /// the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string ResolvedValue { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedValue property is set.
        /// </summary>
        internal bool IsSetResolvedValue() => this.ResolvedValue != null;

        /// <summary>
        /// Gets and sets the property UsePreviousValue. 
        /// <para>
        /// During a stack update, use the existing parameter value that the stack is using for
        /// a given parameter key. If you specify <c>true</c>, do not specify a parameter value.
        /// </para>
        /// </summary>
        public bool? UsePreviousValue { get; set; }

        /// <summary>
        /// Checks to see if the UsePreviousValue property is set.
        /// </summary>
        internal bool IsSetUsePreviousValue() => this.UsePreviousValue.HasValue;
    }
}
