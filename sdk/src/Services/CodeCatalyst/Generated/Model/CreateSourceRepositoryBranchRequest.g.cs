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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSourceRepositoryBranch operation. Creates
    /// a branch in a specified source repository in Amazon CodeCatalyst. <note> <para> This
    /// API only creates a branch in a source repository hosted in Amazon CodeCatalyst. You
    /// cannot use this API to create a branch in a linked repository. </para> </note>
    /// </summary>
    public partial class CreateSourceRepositoryBranchRequest : AmazonCodeCatalystRequest
    {
        /// <summary>
        /// Gets and sets the property HeadCommitId. 
        /// <para>
        /// The commit ID in an existing branch from which you want to create the new branch.
        /// </para>
        /// </summary>
        public string HeadCommitId { get; set; }

        /// <summary>
        /// Checks to see if the HeadCommitId property is set.
        /// </summary>
        internal bool IsSetHeadCommitId() => this.HeadCommitId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the branch you're creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property SourceRepositoryName. 
        /// <para>
        /// The name of the repository where you want to create a branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SourceRepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the SourceRepositoryName property is set.
        /// </summary>
        internal bool IsSetSourceRepositoryName() => this.SourceRepositoryName != null;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;
    }
}
