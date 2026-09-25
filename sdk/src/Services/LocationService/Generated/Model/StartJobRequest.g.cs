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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartJob operation. <c>StartJob</c> starts a new
    /// asynchronous bulk processing job. You specify the input data location in Amazon S3,
    /// the action to perform, and the output location where results are written. <para> For
    /// more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/jobs-concepts.html">Job
    /// concepts</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class StartJobRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on the input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ActionOptions. 
        /// <para>
        /// Additional parameters that can be requested for each result.
        /// </para>
        /// </summary>
        public JobActionOptions ActionOptions { get; set; }

        /// <summary>
        /// Checks to see if the ActionOptions property is set.
        /// </summary>
        internal bool IsSetActionOptions() => this.ActionOptions != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for this request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Location Service assumes
        /// during job processing. Amazon Location Service uses this role to access the input
        /// and output locations specified for the job.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IAM role must be created in the same Amazon Web Services account where you plan
        /// to run your job.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about configuring IAM roles for Amazon Location jobs, see <a
        /// href="https://docs.aws.amazon.com/location/latest/developerguide/configure-iam-role-policy-credentials.html">Configure
        /// IAM permissions</a> in the <i>Amazon Location Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputOptions. 
        /// <para>
        /// Configuration for input data location and format.
        /// </para>
        ///  <note> 
        /// <para>
        /// Input files have a limitation of 10gb per file, and 1gb per Parquet row-group within
        /// the file.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobInputOptions InputOptions { get; set; }

        /// <summary>
        /// Checks to see if the InputOptions property is set.
        /// </summary>
        internal bool IsSetInputOptions() => this.InputOptions != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for the job resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputOptions. 
        /// <para>
        /// Configuration for output data location and format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobOutputOptions OutputOptions { get; set; }

        /// <summary>
        /// Checks to see if the OutputOptions property is set.
        /// </summary>
        internal bool IsSetOutputOptions() => this.OutputOptions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags and corresponding values to be associated with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
