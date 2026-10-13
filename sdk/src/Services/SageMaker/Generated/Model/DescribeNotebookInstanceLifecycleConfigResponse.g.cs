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
    /// This is the response object from the DescribeNotebookInstanceLifecycleConfig operation.
    /// </summary>
    public partial class DescribeNotebookInstanceLifecycleConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that tells when the lifecycle configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that tells when the lifecycle configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookInstanceLifecycleConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigArn property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigArn() => this.NotebookInstanceLifecycleConfigArn != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of the lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;

        /// <summary>
        /// Gets and sets the property OnCreate. 
        /// <para>
        /// The shell script that runs only once, when you create a notebook instance.
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
        /// The shell script that runs every time you start a notebook instance, including when
        /// you create the notebook instance.
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
    }
}
