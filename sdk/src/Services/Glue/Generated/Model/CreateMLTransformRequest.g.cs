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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMLTransform operation. Creates an Glue machine
    /// learning transform. This operation creates the transform and all the necessary parameters
    /// to train it. <para> Call this operation as the first step in the process of using
    /// a machine learning transform (such as the <c>FindMatches</c> transform) for deduplicating
    /// data. You can provide an optional <c>Description</c>, in addition to the parameters
    /// that you want to use for your algorithm. </para> <para> You must also specify certain
    /// parameters for the tasks that Glue runs on your behalf as part of learning from your
    /// data and creating a high-quality machine learning transform. These parameters include
    /// <c>Role</c>, and optionally, <c>AllocatedCapacity</c>, <c>Timeout</c>, and <c>MaxRetries</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html">Jobs</a>.
    /// </para>
    /// </summary>
    public partial class CreateMLTransformRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the machine learning transform that is being defined. The default
        /// is an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// This value determines which version of Glue this machine learning transform is compatible
        /// with. Glue 1.0 is recommended for most customers. If the value is not set, the Glue
        /// compatibility defaults to Glue 0.9. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/release-notes.html#release-notes-versions">Glue
        /// Versions</a> in the developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property InputRecordTables. 
        /// <para>
        /// A list of Glue table definitions used by the transform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<GlueTable> InputRecordTables { get; set; } = AWSConfigs.InitializeCollections ? new List<GlueTable>() : null;

        /// <summary>
        /// Checks to see if the InputRecordTables property is set.
        /// </summary>
        internal bool IsSetInputRecordTables() => this.InputRecordTables != null && (this.InputRecordTables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The number of Glue data processing units (DPUs) that are allocated to task runs for
        /// this transform. You can allocate from 2 to 100 DPUs; the default is 10. A DPU is a
        /// relative measure of processing power that consists of 4 vCPUs of compute capacity
        /// and 16 GB of memory. For more information, see the <a href="https://aws.amazon.com/glue/pricing/">Glue
        /// pricing page</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <c>MaxCapacity</c> is a mutually exclusive option with <c>NumberOfWorkers</c> and
        /// <c>WorkerType</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If either <c>NumberOfWorkers</c> or <c>WorkerType</c> is set, then <c>MaxCapacity</c>
        /// cannot be set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>MaxCapacity</c> is set then neither <c>NumberOfWorkers</c> or <c>WorkerType</c>
        /// can be set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>WorkerType</c> is set, then <c>NumberOfWorkers</c> is required (and vice versa).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxCapacity</c> and <c>NumberOfWorkers</c> must both be at least 1.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When the <c>WorkerType</c> field is set to a value other than <c>Standard</c>, the
        /// <c>MaxCapacity</c> field is set automatically and becomes read-only.
        /// </para>
        ///  
        /// <para>
        /// When the <c>WorkerType</c> field is set to a value other than <c>Standard</c>, the
        /// <c>MaxCapacity</c> field is set automatically and becomes read-only.
        /// </para>
        /// </summary>
        public double? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry a task for this transform after a task run fails.
        /// </para>
        /// </summary>
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetries property is set.
        /// </summary>
        internal bool IsSetMaxRetries() => this.MaxRetries.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name that you give the transform when you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>workerType</c> that are allocated when this
        /// task runs.
        /// </para>
        ///  
        /// <para>
        /// If <c>WorkerType</c> is set, then <c>NumberOfWorkers</c> is required (and vice versa).
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The algorithmic parameters that are specific to the transform type used. Conditionally
        /// dependent on the transform type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformParameters Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role with the required permissions.
        /// The required permissions include both Glue service role permissions to Glue resources,
        /// and Amazon S3 permissions required by the transform. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This role needs Glue service role permissions to allow access to resources in Glue.
        /// See <a href="https://docs.aws.amazon.com/glue/latest/dg/attach-policy-iam-user.html">Attach
        /// a Policy to IAM Users That Access Glue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This role needs permission to your Amazon Simple Storage Service (Amazon S3) sources,
        /// targets, temporary directory, scripts, and any libraries used by the task run for
        /// this transform.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this machine learning transform. You may use tags to limit access
        /// to the machine learning transform. For more information about tags in Glue, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon Web Services
        /// Tags in Glue</a> in the developer guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout of the task run for this transform in minutes. This is the maximum time
        /// that a task run for this transform can consume resources before it is terminated and
        /// enters <c>TIMEOUT</c> status. The default is 2,880 minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property TransformEncryption. 
        /// <para>
        /// The encryption-at-rest settings of the transform that apply to accessing user data.
        /// Machine learning transforms can access user data encrypted in Amazon S3 using KMS.
        /// </para>
        /// </summary>
        public TransformEncryption TransformEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TransformEncryption property is set.
        /// </summary>
        internal bool IsSetTransformEncryption() => this.TransformEncryption != null;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when this task runs. Accepts a value
        /// of Standard, G.1X, or G.2X.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>Standard</c> worker type, each worker provides 4 vCPU, 16 GB of memory
        /// and a 50GB disk, and 2 executors per worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.1X</c> worker type, each worker provides 4 vCPU, 16 GB of memory and
        /// a 64GB disk, and 1 executor per worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.2X</c> worker type, each worker provides 8 vCPU, 32 GB of memory and
        /// a 128GB disk, and 1 executor per worker.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>MaxCapacity</c> is a mutually exclusive option with <c>NumberOfWorkers</c> and
        /// <c>WorkerType</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If either <c>NumberOfWorkers</c> or <c>WorkerType</c> is set, then <c>MaxCapacity</c>
        /// cannot be set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>MaxCapacity</c> is set then neither <c>NumberOfWorkers</c> or <c>WorkerType</c>
        /// can be set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>WorkerType</c> is set, then <c>NumberOfWorkers</c> is required (and vice versa).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxCapacity</c> and <c>NumberOfWorkers</c> must both be at least 1.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
