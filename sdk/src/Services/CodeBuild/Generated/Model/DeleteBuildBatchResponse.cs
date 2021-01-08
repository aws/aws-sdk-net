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
    /// This is the response object from the DeleteBuildBatch operation.
    /// </summary>
    public partial class DeleteBuildBatchResponse : AmazonWebServiceResponse
    {
        private List<string> _buildsDeleted = new List<string>();
        private List<BuildNotDeleted> _buildsNotDeleted = new List<BuildNotDeleted>();
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property BuildsDeleted. 
        /// <para>
        /// An array of strings that contain the identifiers of the builds that were deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> BuildsDeleted
        {
            get { return this._buildsDeleted; }
            set { this._buildsDeleted = value; }
        }

        // Check to see if BuildsDeleted property is set
        internal bool IsSetBuildsDeleted()
        {
            return this._buildsDeleted != null && this._buildsDeleted.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BuildsNotDeleted. 
        /// <para>
        /// An array of <code>BuildNotDeleted</code> objects that specify the builds that could
        /// not be deleted.
        /// </para>
        /// </summary>
        public List<BuildNotDeleted> BuildsNotDeleted
        {
            get { return this._buildsNotDeleted; }
            set { this._buildsNotDeleted = value; }
        }

        // Check to see if BuildsNotDeleted property is set
        internal bool IsSetBuildsNotDeleted()
        {
            return this._buildsNotDeleted != null && this._buildsNotDeleted.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}