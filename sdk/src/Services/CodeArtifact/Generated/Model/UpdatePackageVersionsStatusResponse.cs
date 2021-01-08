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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the UpdatePackageVersionsStatus operation.
    /// </summary>
    public partial class UpdatePackageVersionsStatusResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, PackageVersionError> _failedVersions = new Dictionary<string, PackageVersionError>();
        private Dictionary<string, SuccessfulPackageVersionInfo> _successfulVersions = new Dictionary<string, SuccessfulPackageVersionInfo>();

        /// <summary>
        /// Gets and sets the property FailedVersions. 
        /// <para>
        ///  A list of <code>SuccessfulPackageVersionInfo</code> objects, one for each package
        /// version with a status that successfully updated. 
        /// </para>
        /// </summary>
        public Dictionary<string, PackageVersionError> FailedVersions
        {
            get { return this._failedVersions; }
            set { this._failedVersions = value; }
        }

        // Check to see if FailedVersions property is set
        internal bool IsSetFailedVersions()
        {
            return this._failedVersions != null && this._failedVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulVersions. 
        /// <para>
        ///  A list of <code>PackageVersionError</code> objects, one for each package version
        /// with a status that failed to update. 
        /// </para>
        /// </summary>
        public Dictionary<string, SuccessfulPackageVersionInfo> SuccessfulVersions
        {
            get { return this._successfulVersions; }
            set { this._successfulVersions = value; }
        }

        // Check to see if SuccessfulVersions property is set
        internal bool IsSetSuccessfulVersions()
        {
            return this._successfulVersions != null && this._successfulVersions.Count > 0; 
        }

    }
}