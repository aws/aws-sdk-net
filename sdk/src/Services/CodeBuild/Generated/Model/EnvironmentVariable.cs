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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about an environment variable for a build project or a build.
    /// </summary>
    public partial class EnvironmentVariable
    {
        private string _name;
        private EnvironmentVariableType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name or key of the environment variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of environment variable. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PARAMETER_STORE</c>: An environment variable stored in Systems Manager Parameter
        /// Store. For environment variables of this type, specify the name of the parameter as
        /// the <c>value</c> of the EnvironmentVariable. The parameter value will be substituted
        /// for the name at runtime. You can also define Parameter Store environment variables
        /// in the buildspec. To learn how to do so, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec.env.parameter-store">env/parameter-store</a>
        /// in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLAINTEXT</c>: An environment variable in plain text format. This is the default
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECRETS_MANAGER</c>: An environment variable stored in Secrets Manager. For environment
        /// variables of this type, specify the name of the secret as the <c>value</c> of the
        /// EnvironmentVariable. The secret value will be substituted for the name at runtime.
        /// You can also define Secrets Manager environment variables in the buildspec. To learn
        /// how to do so, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec.env.secrets-manager">env/secrets-manager</a>
        /// in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnvironmentVariableType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the environment variable.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly discourage the use of <c>PLAINTEXT</c> environment variables to store
        /// sensitive values, especially Amazon Web Services secret key IDs. <c>PLAINTEXT</c>
        /// environment variables can be displayed in plain text using the CodeBuild console and
        /// the CLI. For sensitive values, we recommend you use an environment variable of type
        /// <c>PARAMETER_STORE</c> or <c>SECRETS_MANAGER</c>. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
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