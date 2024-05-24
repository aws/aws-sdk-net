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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
        private string _artifactPath;
        private string _branch;
        private string _connectionArn;
        private string _repository;

        /// <summary>
        /// Gets and sets the property ArtifactPath. 
        /// <para>
        /// The absolute path wehre the artifact resides within the repo and branch, formatted
        /// as "folder/file.json." 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ArtifactPath
        {
            get { return this._artifactPath; }
            set { this._artifactPath = value; }
        }

        // Check to see if ArtifactPath property is set
        internal bool IsSetArtifactPath()
        {
            return this._artifactPath != null;
        }

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The specific branch where the artifact resides. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The CodeStar ARN, which is the connection between Service Catalog and the external
        /// repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The specific repository where the product’s artifact-to-be-synced resides, formatted
        /// as "Account/Repo." 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}