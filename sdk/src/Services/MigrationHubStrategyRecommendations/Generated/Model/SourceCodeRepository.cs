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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Object containing source code information that is linked to an application component.
    /// </summary>
    public partial class SourceCodeRepository
    {
        private string _branch;
        private string _projectName;
        private string _repository;
        private string _versionControlType;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        ///  The branch of the source code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The repository name for the source code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property VersionControlType. 
        /// <para>
        ///  The type of repository to use for the source code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string VersionControlType
        {
            get { return this._versionControlType; }
            set { this._versionControlType = value; }
        }

        // Check to see if VersionControlType property is set
        internal bool IsSetVersionControlType()
        {
            return this._versionControlType != null;
        }

    }
}