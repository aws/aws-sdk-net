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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PutRuntimeManagementConfig operation.
    /// Sets the runtime management configuration for a function's version. For more information,
    /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html">Runtime
    /// updates</a>.
    /// </summary>
    public partial class PutRuntimeManagementConfigRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private string _qualifier;
        private string _runtimeVersionArn;
        private UpdateRuntimeOn _updateRuntimeOn;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <code>my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Specify a version of the function. This can be <code>$LATEST</code> or a published
        /// version number. If no value is specified, the configuration for the <code>$LATEST</code>
        /// version is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeVersionArn. 
        /// <para>
        /// The ARN of the runtime version you want the function to use.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is only required if you're using the <b>Manual</b> runtime update mode.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=26, Max=2048)]
        public string RuntimeVersionArn
        {
            get { return this._runtimeVersionArn; }
            set { this._runtimeVersionArn = value; }
        }

        // Check to see if RuntimeVersionArn property is set
        internal bool IsSetRuntimeVersionArn()
        {
            return this._runtimeVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateRuntimeOn. 
        /// <para>
        /// Specify the runtime update mode.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Auto (default)</b> - Automatically update to the most recent and secure runtime
        /// version using a <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html#runtime-management-two-phase">Two-phase
        /// runtime version rollout</a>. This is the best choice for most customers to ensure
        /// they always benefit from runtime updates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function update</b> - Lambda updates the runtime of your function to the most
        /// recent and secure runtime version when you update your function. This approach synchronizes
        /// runtime updates with function deployments, giving you control over when runtime updates
        /// are applied and allowing you to detect and mitigate rare runtime update incompatibilities
        /// early. When using this setting, you need to regularly update your functions to keep
        /// their runtime up-to-date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Manual</b> - You specify a runtime version in your function configuration. The
        /// function will use this runtime version indefinitely. In the rare case where a new
        /// runtime version is incompatible with an existing function, this allows you to roll
        /// back your function to an earlier runtime version. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-update.html#runtime-management-rollback">Roll
        /// back a runtime version</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateRuntimeOn UpdateRuntimeOn
        {
            get { return this._updateRuntimeOn; }
            set { this._updateRuntimeOn = value; }
        }

        // Check to see if UpdateRuntimeOn property is set
        internal bool IsSetUpdateRuntimeOn()
        {
            return this._updateRuntimeOn != null;
        }

    }
}