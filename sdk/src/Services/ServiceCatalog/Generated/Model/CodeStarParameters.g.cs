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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The subtype containing details about the Codestar connection <c>Type</c>.
    /// </summary>
    public partial class CodeStarParameters
    {
        /// <summary>
        /// Gets and sets the property ArtifactPath. 
        /// <para>
        /// The absolute path wehre the artifact resides within the repo and branch, formatted
        /// as "folder/file.json." 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ArtifactPath { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactPath property is set.
        /// </summary>
        internal bool IsSetArtifactPath() => this.ArtifactPath != null;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The specific branch where the artifact resides. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The CodeStar ARN, which is the connection between Service Catalog and the external
        /// repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1224)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The specific repository where the product’s artifact-to-be-synced resides, formatted
        /// as "Account/Repo." 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
