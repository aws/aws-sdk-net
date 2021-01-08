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
    /// This is the response object from the CopyPackageVersions operation.
    /// </summary>
    public partial class CopyPackageVersionsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, PackageVersionError> _failedVersions = new Dictionary<string, PackageVersionError>();
        private Dictionary<string, SuccessfulPackageVersionInfo> _successfulVersions = new Dictionary<string, SuccessfulPackageVersionInfo>();

        /// <summary>
        /// Gets and sets the property FailedVersions. 
        /// <para>
        ///  A map of package versions that failed to copy and their error codes. The possible
        /// error codes are in the <code>PackageVersionError</code> data type. They are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALREADY_EXISTS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISMATCHED_REVISION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISMATCHED_STATUS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_ALLOWED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_FOUND</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIPPED</code> 
        /// </para>
        ///  </li> </ul>
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
        ///  A list of the package versions that were successfully copied to your repository.
        /// 
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