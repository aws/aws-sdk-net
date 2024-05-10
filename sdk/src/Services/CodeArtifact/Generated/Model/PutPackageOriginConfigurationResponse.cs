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
    /// This is the response object from the PutPackageOriginConfiguration operation.
    /// </summary>
    public partial class PutPackageOriginConfigurationResponse : AmazonWebServiceResponse
    {
        private PackageOriginConfiguration _originConfiguration;

        /// <summary>
        /// Gets and sets the property OriginConfiguration. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginConfiguration.html">PackageOriginConfiguration</a>
        /// object that describes the origin configuration set for the package. It contains a
        /// <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>
        /// object that describes how new versions of the package can be introduced to the repository.
        /// </para>
        /// </summary>
        public PackageOriginConfiguration OriginConfiguration
        {
            get { return this._originConfiguration; }
            set { this._originConfiguration = value; }
        }

        // Check to see if OriginConfiguration property is set
        internal bool IsSetOriginConfiguration()
        {
            return this._originConfiguration != null;
        }

    }
}