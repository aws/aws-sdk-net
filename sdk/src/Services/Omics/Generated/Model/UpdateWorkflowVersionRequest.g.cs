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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkflowVersion operation. Updates information
    /// about the workflow version. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
    /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
    /// User Guide</i>.
    /// </summary>
    public partial class UpdateWorkflowVersionRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ReadmeMarkdown. 
        /// <para>
        /// The markdown content for the workflow version's README file. This provides documentation
        /// and usage information for users of this specific workflow version.
        /// </para>
        /// </summary>
        public string ReadmeMarkdown { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeMarkdown property is set.
        /// </summary>
        internal bool IsSetReadmeMarkdown() => this.ReadmeMarkdown != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The default static storage capacity (in gibibytes) for runs that use this workflow
        /// version. The <c>storageCapacity</c> can be overwritten at run time. The storage capacity
        /// is not required for runs with a <c>DYNAMIC</c> storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacity property is set.
        /// </summary>
        internal bool IsSetStorageCapacity() => this.StorageCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The default storage type for runs that use this workflow version. The <c>storageType</c>
        /// can be overridden at run time. <c>DYNAMIC</c> storage dynamically scales the storage
        /// up or down, based on file system utilization. STATIC storage allocates a fixed amount
        /// of storage. For more information about dynamic and static storage types, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-run-types.html">Run
        /// storage types</a> in the <i>in the <i>Amazon Web Services HealthOmics User Guide</i>
        /// </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The workflow's ID. The <c>workflowId</c> is not the UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
