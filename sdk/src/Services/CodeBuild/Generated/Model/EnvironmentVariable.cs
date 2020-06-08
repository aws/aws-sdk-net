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
        ///  <code>PARAMETER_STORE</code>: An environment variable stored in Amazon EC2 Systems
        /// Manager Parameter Store. To learn how to specify a parameter store environment variable,
        /// see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#parameter-store-build-spec">
        /// parameter store reference-key in the buildspec file</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLAINTEXT</code>: An environment variable in plain text format. This is the
        /// default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SECRETS_MANAGER</code>: An environment variable stored in AWS Secrets Manager.
        /// To learn how to specify a secrets manager environment variable, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#secrets-manager-build-spec">
        /// secrets manager reference-key in the buildspec file</a>.
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
        /// We strongly discourage the use of <code>PLAINTEXT</code> environment variables to
        /// store sensitive values, especially AWS secret key IDs and secret access keys. <code>PLAINTEXT</code>
        /// environment variables can be displayed in plain text using the AWS CodeBuild console
        /// and the AWS Command Line Interface (AWS CLI). For sensitive values, we recommend you
        /// use an environment variable of type <code>PARAMETER_STORE</code> or <code>SECRETS_MANAGER</code>.
        /// 
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