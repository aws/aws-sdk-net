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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The summary of the cluster step.
    /// </summary>
    public partial class StepSummary
    {
        /// <summary>
        /// Gets and sets the property ActionOnFailure. 
        /// <para>
        /// The action to take when the cluster step fails. Possible values are TERMINATE_CLUSTER,
        /// CANCEL_AND_WAIT, and CONTINUE. TERMINATE_JOB_FLOW is available for backward compatibility.
        /// </para>
        /// </summary>
        public ActionOnFailure ActionOnFailure { get; set; }

        /// <summary>
        /// Checks to see if the ActionOnFailure property is set.
        /// </summary>
        internal bool IsSetActionOnFailure() => this.ActionOnFailure != null;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// The Hadoop job configuration of the cluster step.
        /// </para>
        /// </summary>
        public HadoopStepConfig Config { get; set; }

        /// <summary>
        /// Checks to see if the Config property is set.
        /// </summary>
        internal bool IsSetConfig() => this.Config != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The KMS key ARN to encrypt the logs published to the given Amazon S3 destination.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the cluster step.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The Amazon S3 destination URI for log publishing.
        /// </para>
        /// </summary>
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster step.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status details of the cluster step.
        /// </para>
        /// </summary>
        public StepStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
