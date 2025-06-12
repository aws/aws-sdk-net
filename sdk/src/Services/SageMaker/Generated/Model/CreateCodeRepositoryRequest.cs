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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeRepository operation.
    /// Creates a Git repository as a resource in your SageMaker AI account. You can associate
    /// the repository with notebook instances so that you can use Git source control for
    /// the notebooks you create. The Git repository is a resource in your SageMaker AI account,
    /// so it can be associated with more than one notebook instance, and it persists independently
    /// from the lifecycle of any notebook instances it is associated with.
    /// 
    ///  
    /// <para>
    /// The repository can be hosted either in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
    /// Web Services CodeCommit</a> or in any other Git repository.
    /// </para>
    /// </summary>
    public partial class CreateCodeRepositoryRequest : AmazonSageMakerRequest
    {
        private string _codeRepositoryName;
        private GitConfig _gitConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CodeRepositoryName. 
        /// <para>
        /// The name of the Git repository. The name must have 1 to 63 characters. Valid characters
        /// are a-z, A-Z, 0-9, and - (hyphen).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CodeRepositoryName
        {
            get { return this._codeRepositoryName; }
            set { this._codeRepositoryName = value; }
        }

        // Check to see if CodeRepositoryName property is set
        internal bool IsSetCodeRepositoryName()
        {
            return this._codeRepositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property GitConfig. 
        /// <para>
        /// Specifies details about the repository, including the URL where the repository is
        /// located, the default branch, and credentials to use to access the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GitConfig GitConfig
        {
            get { return this._gitConfig; }
            set { this._gitConfig = value; }
        }

        // Check to see if GitConfig property is set
        internal bool IsSetGitConfig()
        {
            return this._gitConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}