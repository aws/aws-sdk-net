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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information for an SageMaker AI notebook instance.
    /// </summary>
    public partial class NotebookInstanceSummary
    {
        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositories. 
        /// <para>
        /// An array of up to three Git repositories associated with the notebook instance. These
        /// can be either the names of Git repositories stored as resources in your account, or
        /// the URL of Git repositories in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository. These repositories are
        /// cloned at the same level as the default repository of your notebook instance. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with SageMaker AI Notebook Instances</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> AdditionalCodeRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalCodeRepositories property is set.
        /// </summary>
        internal bool IsSetAdditionalCodeRepositories() => this.AdditionalCodeRepositories != null && (this.AdditionalCodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the notebook instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultCodeRepository. 
        /// <para>
        /// The Git repository associated with the notebook instance as its default code repository.
        /// This can be either the name of a Git repository stored as a resource in your account,
        /// or the URL of a Git repository in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository. When you open a notebook
        /// instance, it opens in the directory that contains this repository. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-git-repo.html">Associating
        /// Git Repositories with SageMaker AI Notebook Instances</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DefaultCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCodeRepository property is set.
        /// </summary>
        internal bool IsSetDefaultCodeRepository() => this.DefaultCodeRepository != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of ML compute instance that the notebook instance is running on.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the notebook instance was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotebookInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string NotebookInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceArn property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceArn() => this.NotebookInstanceArn != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of a notebook instance lifecycle configuration associated with this notebook
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the notebook instance that you want a summary for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string NotebookInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceName() => this.NotebookInstanceName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceStatus. 
        /// <para>
        /// The status of the notebook instance.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus NotebookInstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceStatus property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceStatus() => this.NotebookInstanceStatus != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that you use to connect to the Jupyter notebook running in your notebook instance.
        /// 
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
