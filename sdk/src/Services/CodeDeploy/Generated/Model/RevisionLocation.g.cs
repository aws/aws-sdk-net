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
    /// Information about the location of an application revision.
    /// </summary>
    public partial class RevisionLocation
    {
        /// <summary>
        /// Gets and sets the property AppSpecContent. 
        /// <para>
        ///  The content of an AppSpec file for an Lambda or Amazon ECS deployment. The content
        /// is formatted as JSON or YAML and stored as a RawString. 
        /// </para>
        /// </summary>
        public AppSpecContent AppSpecContent { get; set; }

        /// <summary>
        /// Checks to see if the AppSpecContent property is set.
        /// </summary>
        internal bool IsSetAppSpecContent() => this.AppSpecContent != null;

        /// <summary>
        /// Gets and sets the property GitHubLocation. 
        /// <para>
        /// Information about the location of application artifacts stored in GitHub.
        /// </para>
        /// </summary>
        public GitHubLocation GitHubLocation { get; set; }

        /// <summary>
        /// Checks to see if the GitHubLocation property is set.
        /// </summary>
        internal bool IsSetGitHubLocation() => this.GitHubLocation != null;

        /// <summary>
        /// Gets and sets the property RevisionType. 
        /// <para>
        /// The type of application revision:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// S3: An application revision stored in Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GitHub: An application revision stored in GitHub (EC2/On-premises deployments only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// String: A YAML-formatted or JSON-formatted string (Lambda deployments only).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppSpecContent: An <c>AppSpecContent</c> object that contains the contents of an AppSpec
        /// file for an Lambda or Amazon ECS deployment. The content is formatted as JSON or YAML
        /// stored as a RawString.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RevisionLocationType RevisionType { get; set; }

        /// <summary>
        /// Checks to see if the RevisionType property is set.
        /// </summary>
        internal bool IsSetRevisionType() => this.RevisionType != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// Information about the location of a revision stored in Amazon S3. 
        /// </para>
        /// </summary>
        public S3Location S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// Information about the location of an Lambda deployment revision stored as a RawString.
        /// </para>
        /// </summary>
        public RawString String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;
    }
}
