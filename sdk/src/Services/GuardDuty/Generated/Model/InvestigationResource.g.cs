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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about an Amazon Web Services resource that is relevant to an
    /// investigation.
    /// </summary>
    public partial class InvestigationResource
    {
        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Details that are specific to the type of the resource.
        /// </para>
        /// </summary>
        public InvestigationResourceData Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource. Possible values are <c>EC2_INSTANCE</c>, <c>EBS_VOLUME</c>,
        /// <c>S3_BUCKET</c>, <c>IAM_ROLE</c>, <c>IAM_USER</c>, <c>IAM_ACCESS_KEY</c>, <c>LAMBDA_FUNCTION</c>,
        /// <c>EKS_CLUSTER</c>, <c>ECS_CLUSTER</c>, <c>KUBERNETES_WORKLOAD</c>, <c>RDS_INSTANCE</c>,
        /// <c>RDS_DB_USER</c>, and <c>EC2_SECURITY_GROUP</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvestigationResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the resource. This is the Amazon Resource Name (ARN) of the
        /// resource when it's available. Otherwise, it's the name or ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
