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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a Lambda function specified in a deployment.
    /// </summary>
    public partial class LambdaFunctionInfo
    {
        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        ///  The version of a Lambda function that production traffic points to. 
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property FunctionAlias. 
        /// <para>
        ///  The alias of a Lambda function. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Lambda
        /// Function Aliases</a> in the <i>Lambda Developer Guide</i>.
        /// </para>
        /// </summary>
        public string FunctionAlias { get; set; }

        /// <summary>
        /// Checks to see if the FunctionAlias property is set.
        /// </summary>
        internal bool IsSetFunctionAlias() => this.FunctionAlias != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        ///  The name of a Lambda function. 
        /// </para>
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        ///  The version of a Lambda function that production traffic points to after the Lambda
        /// function is deployed. 
        /// </para>
        /// </summary>
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;

        /// <summary>
        /// Gets and sets the property TargetVersionWeight. 
        /// <para>
        ///  The percentage of production traffic that the target version of a Lambda function
        /// receives. 
        /// </para>
        /// </summary>
        public double? TargetVersionWeight { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersionWeight property is set.
        /// </summary>
        internal bool IsSetTargetVersionWeight() => this.TargetVersionWeight.HasValue;
    }
}
