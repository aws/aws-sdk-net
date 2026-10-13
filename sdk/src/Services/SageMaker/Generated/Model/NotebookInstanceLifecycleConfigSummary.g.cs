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
    /// Provides a summary of a notebook instance lifecycle configuration.
    /// </summary>
    public partial class NotebookInstanceLifecycleConfigSummary
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
        [AWSProperty(Required = true, Min = 0, Max = 256)]
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
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigName property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigName() => this.NotebookInstanceLifecycleConfigName != null;
    }
}
