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
    public partial class SourceCode
    {
        private string _location;
        private string _projectName;
        private string _sourceVersion;
        private VersionControl _versionControl;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The repository name for the source code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property SourceVersion. 
        /// <para>
        ///  The branch of the source code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VersionControl. 
        /// <para>
        ///  The type of repository to use for the source code. 
        /// </para>
        /// </summary>
        public VersionControl VersionControl
        {
            get { return this._versionControl; }
            set { this._versionControl = value; }
        }

        // Check to see if VersionControl property is set
        internal bool IsSetVersionControl()
        {
            return this._versionControl != null;
        }

    }
}