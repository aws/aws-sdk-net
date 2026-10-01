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
    /// Container for the parameters to the UpdateWorkflow operation. Updates information
    /// about a workflow. <para> You can update the following workflow information: </para>
    /// <ul> <li> <para> Name </para> </li> <li> <para> Description </para> </li> <li> <para>
    /// Default storage type </para> </li> <li> <para> Default storage capacity (with workflow
    /// ID) </para> </li> </ul> <para> This operation returns a response with no body if the
    /// operation is successful. You can check the workflow updates by calling the <c>GetWorkflow</c>
    /// API operation. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/update-private-workflow.html">Update
    /// a private workflow</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. </para>
    /// </summary>
    public partial class UpdateWorkflowRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The workflow's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReadmeMarkdown. 
        /// <para>
        /// The markdown content for the workflow's README file. This provides documentation and
        /// usage information for users of the workflow.
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
        /// or workflow version. 
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
        /// The default storage type for runs that use this workflow. STATIC storage allocates
        /// a fixed amount of storage. DYNAMIC storage dynamically scales the storage up or down,
        /// based on file system utilization. For more information about static and dynamic storage,
        /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/Using-workflows.html">Running
        /// workflows</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
