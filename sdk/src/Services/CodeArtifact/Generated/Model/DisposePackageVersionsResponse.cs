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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the DisposePackageVersions operation.
    /// </summary>
    public partial class DisposePackageVersionsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, PackageVersionError> _failedVersions = AWSConfigs.InitializeCollections ? new Dictionary<string, PackageVersionError>() : null;
        private Dictionary<string, SuccessfulPackageVersionInfo> _successfulVersions = AWSConfigs.InitializeCollections ? new Dictionary<string, SuccessfulPackageVersionInfo>() : null;

        /// <summary>
        /// Gets and sets the property FailedVersions. 
        /// <para>
        ///  A <c>PackageVersionError</c> object that contains a map of errors codes for the disposed
        /// package versions that failed. The possible error codes are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALREADY_EXISTS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISMATCHED_REVISION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISMATCHED_STATUS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_ALLOWED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_FOUND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PackageVersionError> FailedVersions
        {
            get { return this._failedVersions; }
            set { this._failedVersions = value; }
        }

        // Check to see if FailedVersions property is set
        internal bool IsSetFailedVersions()
        {
            return this._failedVersions != null && (this._failedVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulVersions. 
        /// <para>
        ///  A list of the package versions that were successfully disposed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SuccessfulPackageVersionInfo> SuccessfulVersions
        {
            get { return this._successfulVersions; }
            set { this._successfulVersions = value; }
        }

        // Check to see if SuccessfulVersions property is set
        internal bool IsSetSuccessfulVersions()
        {
            return this._successfulVersions != null && (this._successfulVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}