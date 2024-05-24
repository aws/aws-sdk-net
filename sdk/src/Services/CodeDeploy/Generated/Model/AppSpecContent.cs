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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
    /// A revision for an Lambda or Amazon ECS deployment that is a YAML-formatted or JSON-formatted
    /// string. For Lambda and Amazon ECS deployments, the revision is the same as the AppSpec
    /// file. This method replaces the deprecated <c>RawString</c> data type.
    /// </summary>
    public partial class AppSpecContent
    {
        private string _content;
        private string _sha256;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        ///  The YAML-formatted or JSON-formatted revision string. 
        /// </para>
        ///  
        /// <para>
        ///  For an Lambda deployment, the content includes a Lambda function name, the alias
        /// for its original version, and the alias for its replacement version. The deployment
        /// shifts traffic from the original version of the Lambda function to the replacement
        /// version. 
        /// </para>
        ///  
        /// <para>
        ///  For an Amazon ECS deployment, the content includes the task name, information about
        /// the load balancer that serves traffic to the container, and more. 
        /// </para>
        ///  
        /// <para>
        ///  For both types of deployments, the content can specify Lambda functions that run
        /// at specified hooks, such as <c>BeforeInstall</c>, during a deployment. 
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        ///  The SHA256 hash value of the revision content. 
        /// </para>
        /// </summary>
        public string Sha256
        {
            get { return this._sha256; }
            set { this._sha256 = value; }
        }

        // Check to see if Sha256 property is set
        internal bool IsSetSha256()
        {
            return this._sha256 != null;
        }

    }
}