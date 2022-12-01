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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSourceRepositoryBranch operation.
    /// Creates a branch in a specified source repository in Amazon CodeCatalyst. 
    /// 
    ///  <note> 
    /// <para>
    /// This API only creates a branch in a source repository hosted in Amazon CodeCatalyst.
    /// You cannot use this API to create a branch in a linked repository.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateSourceRepositoryBranchRequest : AmazonCodeCatalystRequest
    {
        private string _headCommitId;
        private string _name;
        private string _projectName;
        private string _sourceRepositoryName;
        private string _spaceName;

        /// <summary>
        /// Gets and sets the property HeadCommitId. 
        /// <para>
        /// The commit ID in an existing branch from which you want to create the new branch.
        /// </para>
        /// </summary>
        public string HeadCommitId
        {
            get { return this._headCommitId; }
            set { this._headCommitId = value; }
        }

        // Check to see if HeadCommitId property is set
        internal bool IsSetHeadCommitId()
        {
            return this._headCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the branch you're creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property SourceRepositoryName. 
        /// <para>
        /// The name of the repository where you want to create a branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SourceRepositoryName
        {
            get { return this._sourceRepositoryName; }
            set { this._sourceRepositoryName = value; }
        }

        // Check to see if SourceRepositoryName property is set
        internal bool IsSetSourceRepositoryName()
        {
            return this._sourceRepositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

    }
}