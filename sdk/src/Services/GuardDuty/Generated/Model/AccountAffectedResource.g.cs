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
    /// Contains the number of findings associated with a resource.
    /// </summary>
    public partial class AccountAffectedResource
    {
        /// <summary>
        /// Gets and sets the property FindingCount. 
        /// <para>
        /// The number of findings associated with the resource.
        /// </para>
        /// </summary>
        public int? FindingCount { get; set; }

        /// <summary>
        /// Checks to see if the FindingCount property is set.
        /// </summary>
        internal bool IsSetFindingCount() => this.FindingCount.HasValue;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource. Possible values are <c>EC2_INSTANCE</c>, <c>EBS_VOLUME</c>,
        /// <c>S3_BUCKET</c>, <c>IAM_ROLE</c>, <c>IAM_USER</c>, <c>IAM_ACCESS_KEY</c>, <c>LAMBDA_FUNCTION</c>,
        /// <c>EKS_CLUSTER</c>, <c>ECS_CLUSTER</c>, <c>KUBERNETES_WORKLOAD</c>, <c>RDS_INSTANCE</c>,
        /// <c>RDS_DB_USER</c>, and <c>EC2_SECURITY_GROUP</c>.
        /// </para>
        /// </summary>
        public InvestigationResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
