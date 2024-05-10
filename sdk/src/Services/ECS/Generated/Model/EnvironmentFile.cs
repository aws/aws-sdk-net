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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// A list of files containing the environment variables to pass to a container. You can
    /// specify up to ten environment files. The file must have a <c>.env</c> file extension.
    /// Each line in an environment file should contain an environment variable in <c>VARIABLE=VALUE</c>
    /// format. Lines beginning with <c>#</c> are treated as comments and are ignored.
    /// 
    ///  
    /// <para>
    /// If there are environment variables specified using the <c>environment</c> parameter
    /// in a container definition, they take precedence over the variables contained within
    /// an environment file. If multiple environment files are specified that contain the
    /// same variable, they're processed from the top down. We recommend that you use unique
    /// variable names. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/use-environment-file.html">Use
    /// a file to pass environment variables to a container</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Environment variable files are objects in Amazon S3 and all Amazon S3 security considerations
    /// apply. 
    /// </para>
    ///  
    /// <para>
    /// You must use the following platforms for the Fargate launch type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Linux platform version <c>1.4.0</c> or later.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Windows platform version <c>1.0.0</c> or later.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Consider the following when using the Fargate launch type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The file is handled like a native Docker env-file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There is no support for shell escape handling.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The container entry point interperts the <c>VARIABLE</c> values.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EnvironmentFile
    {
        private EnvironmentFileType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The file type to use. Environment files are objects in Amazon S3. The only supported
        /// value is <c>s3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentFileType Type
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
        /// The Amazon Resource Name (ARN) of the Amazon S3 object containing the environment
        /// variable file.
        /// </para>
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