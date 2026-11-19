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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains usage information about the cost of Amazon Inspector operation.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider associated with the usage information. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Microsoft Azure resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GCP</c> – Google Cloud Platform (GCP) resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CloudProvider CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency type used when calculating usage data.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The estimated monthly cost of Amazon Inspector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? EstimatedMonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyCost() => this.EstimatedMonthlyCost.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total of usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of scan. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services – <c>EC2_INSTANCE_HOURS</c>, <c>EC2_AGENTLESS_INSTANCE_HOURS</c>,
        /// <c>EC2_AMI_HOURS</c>, <c>EC2_AMI_ONE_SHOT_SCAN</c>, <c>ECR_INITIAL_SCAN</c>, <c>ECR_RESCAN</c>,
        /// <c>LAMBDA_FUNCTION_HOURS</c>, <c>LAMBDA_FUNCTION_CODE_HOURS</c>, <c>CODE_REPOSITORY_SAST</c>,
        /// <c>CODE_REPOSITORY_IAC</c>, or <c>CODE_REPOSITORY_SCA</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft Azure – <c>AZURE_VM_AGENT_BASED_INSTANCE_HOURS</c>, <c>AZURE_CONTAINER_IMAGE_INITIAL_SCAN</c>,
        /// <c>AZURE_CONTAINER_IMAGE_RESCAN</c>, or <c>AZURE_SERVERLESS_FUNCTION_HOURS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Google Cloud Platform (GCP) – <c>GCP_VM_AGENT_BASED_INSTANCE_HOURS</c>, <c>GCP_CONTAINER_IMAGE_INITIAL_SCAN</c>,
        /// <c>GCP_CONTAINER_IMAGE_RESCAN</c>, or <c>GCP_CLOUD_RUN_HOURS</c> (Cloud Run functions).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UsageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
