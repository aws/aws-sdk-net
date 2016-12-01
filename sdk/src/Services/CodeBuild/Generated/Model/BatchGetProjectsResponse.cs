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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetProjects operation.
    /// </summary>
    public partial class BatchGetProjectsResponse : AmazonWebServiceResponse
    {
        private List<Project> _projects = new List<Project>();
        private List<string> _projectsNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property Projects. 
        /// <para>
        /// Information about the requested build projects.
        /// </para>
        /// </summary>
        public List<Project> Projects
        {
            get { return this._projects; }
            set { this._projects = value; }
        }

        // Check to see if Projects property is set
        internal bool IsSetProjects()
        {
            return this._projects != null && this._projects.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProjectsNotFound. 
        /// <para>
        /// The names of build projects for which information could not be found.
        /// </para>
        /// </summary>
        public List<string> ProjectsNotFound
        {
            get { return this._projectsNotFound; }
            set { this._projectsNotFound = value; }
        }

        // Check to see if ProjectsNotFound property is set
        internal bool IsSetProjectsNotFound()
        {
            return this._projectsNotFound != null && this._projectsNotFound.Count > 0; 
        }

    }
}