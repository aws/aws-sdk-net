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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about an exported environment variable. 
    /// 
    ///  
    /// <para>
    /// Exported environment variables are used in conjunction with AWS CodePipeline to export
    /// environment variables from the current build stage to subsequent stages in the pipeline.
    /// For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-variables.html">Working
    /// with variables</a> in the <i>AWS CodePipeline User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  During a build, the value of a variable is available starting with the <code>install</code>
    /// phase. It can be updated between the start of the <code>install</code> phase and the
    /// end of the <code>post_build</code> phase. After the <code>post_build</code> phase
    /// ends, the value of exported variables cannot change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ExportedEnvironmentVariable
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the exported environment variable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value assigned to the exported environment variable.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}