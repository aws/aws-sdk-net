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
    /// Container for the parameters to the CreateNotebookInstanceLifecycleConfig operation.
    /// Creates a lifecycle configuration that you can associate with a notebook instance.
    /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
    /// create or start a notebook instance. <para> Each lifecycle configuration script has
    /// a limit of 16384 characters. </para> <para> The value of the <c>$PATH</c> environment
    /// variable that is available to both scripts is <c>/sbin:bin:/usr/sbin:/usr/bin</c>.
    /// </para> <para> View Amazon CloudWatch Logs for notebook instance lifecycle configurations
    /// in log group <c>/aws/sagemaker/NotebookInstances</c> in log stream <c>[notebook-instance-name]/[LifecycleConfigHook]</c>.
    /// </para> <para> Lifecycle configuration scripts cannot run for longer than 5 minutes.
    /// If a script runs for longer than 5 minutes, it fails and the notebook instance is
    /// not created or started. </para> <para> For information about notebook instance lifestyle
    /// configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
    /// 2.1: (Optional) Customize a Notebook Instance</a>. </para> <note> <para> Lifecycle
    /// configuration scripts execute with root access and the notebook instance's IAM execution
    /// role privileges. Grant this permission only to trusted principals. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Customize
    /// a Notebook Instance Using a Lifecycle Configuration Script</a> for security best practices.
    /// </para> </note>
    /// </summary>
    public partial class CreateNotebookInstanceLifecycleConfigRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of the lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property OnCreate. 
        /// <para>
        /// A shell script that runs only once, when you create a notebook instance. The shell
        /// script must be a base64-encoded string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<NotebookInstanceLifecycleHook> OnCreate { get; set; } = AWSConfigs.InitializeCollections ? new List<NotebookInstanceLifecycleHook>() : null;

        /// <summary>
        /// Checks to see if the OnCreate property is set.
        /// </summary>
        internal bool IsSetOnCreate() => this.OnCreate != null && (this.OnCreate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnStart. 
        /// <para>
        /// A shell script that runs every time you start a notebook instance, including when
        /// you create the notebook instance. The shell script must be a base64-encoded string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<NotebookInstanceLifecycleHook> OnStart { get; set; } = AWSConfigs.InitializeCollections ? new List<NotebookInstanceLifecycleHook>() : null;

        /// <summary>
        /// Checks to see if the OnStart property is set.
        /// </summary>
        internal bool IsSetOnStart() => this.OnStart != null && (this.OnStart.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
