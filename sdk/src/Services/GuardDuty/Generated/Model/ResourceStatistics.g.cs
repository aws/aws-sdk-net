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
    /// Information about each resource type associated with the <c>groupedByResource</c>
    /// statistics.
    /// </summary>
    public partial class ResourceStatistics
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which the statistics for this resource was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastGeneratedAt property is set.
        /// </summary>
        internal bool IsSetLastGeneratedAt() => this.LastGeneratedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// ID associated with each resource. The following list provides the mapping of the resource
        /// type and resource ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Mapping of resource and resource ID</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AccessKey - <c>resource.accessKeyDetails.accessKeyId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Container - <c>resource.containerDetails.id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ECSCluster - <c>resource.ecsClusterDetails.name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EKSCluster - <c>resource.eksClusterDetails.name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance - <c>resource.instanceDetails.instanceId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KubernetesCluster - <c>resource.kubernetesDetails.kubernetesWorkloadDetails.name</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda - <c>resource.lambdaDetails.functionName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDSDBInstance - <c>resource.rdsDbInstanceDetails.dbInstanceIdentifier</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// S3Bucket - <c>resource.s3BucketDetails.name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// S3Object - <c>resource.s3BucketDetails.name</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings associated with this resource.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
