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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an application revision's location.
    /// </summary>
    public partial class RevisionLocation
    {
        private GitHubLocation _gitHubLocation;
        private RevisionLocationType _revisionType;
        private S3Location _s3Location;

        /// <summary>
        /// Gets and sets the property GitHubLocation.
        /// </summary>
        public GitHubLocation GitHubLocation
        {
            get { return this._gitHubLocation; }
            set { this._gitHubLocation = value; }
        }

        // Check to see if GitHubLocation property is set
        internal bool IsSetGitHubLocation()
        {
            return this._gitHubLocation != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionType. 
        /// <para>
        /// The application revision's type:
        /// </para>
        ///  <ul> <li>S3: An application revision stored in Amazon S3.</li> <li>GitHub: An application
        /// revision stored in GitHub.</li> </ul>
        /// </summary>
        public RevisionLocationType RevisionType
        {
            get { return this._revisionType; }
            set { this._revisionType = value; }
        }

        // Check to see if RevisionType property is set
        internal bool IsSetRevisionType()
        {
            return this._revisionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location.
        /// </summary>
        public S3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

    }
}