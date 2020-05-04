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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// A list of files containing the environment variables to pass to a container. You can
    /// specify up to ten environment files. The file must have a <code>.env</code> file extension.
    /// Each line in an environment file should contain an environment variable in <code>VARIABLE=VALUE</code>
    /// format. Lines beginning with <code>#</code> are treated as comments and are ignored.
    /// For more information on the environment variable file syntax, see <a href="https://docs.docker.com/compose/env-file/">Declare
    /// default environment variables in file</a>.
    /// 
    ///  
    /// <para>
    /// If there are environment variables specified using the <code>environment</code> parameter
    /// in a container definition, they take precedence over the variables contained within
    /// an environment file. If multiple environment files are specified that contain the
    /// same variable, they are processed from the top down. It is recommended to use unique
    /// variable names. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/taskdef-envfiles.html">Specifying
    /// Environment Variables</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This field is not valid for containers in tasks using the Fargate launch type.
    /// </para>
    /// </summary>
    public partial class EnvironmentFile
    {
        private EnvironmentFileType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The file type to use. The only supported value is <code>s3</code>.
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