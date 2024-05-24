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
    /// This is the response object from the UpdateProjectVisibility operation.
    /// </summary>
    public partial class UpdateProjectVisibilityResponse : AmazonWebServiceResponse
    {
        private string _projectArn;
        private ProjectVisibilityType _projectVisibility;
        private string _publicProjectAlias;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectVisibility.
        /// </summary>
        public ProjectVisibilityType ProjectVisibility
        {
            get { return this._projectVisibility; }
            set { this._projectVisibility = value; }
        }

        // Check to see if ProjectVisibility property is set
        internal bool IsSetProjectVisibility()
        {
            return this._projectVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property PublicProjectAlias. 
        /// <para>
        /// Contains the project identifier used with the public build APIs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PublicProjectAlias
        {
            get { return this._publicProjectAlias; }
            set { this._publicProjectAlias = value; }
        }

        // Check to see if PublicProjectAlias property is set
        internal bool IsSetPublicProjectAlias()
        {
            return this._publicProjectAlias != null;
        }

    }
}