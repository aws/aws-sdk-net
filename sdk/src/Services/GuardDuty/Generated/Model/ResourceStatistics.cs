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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private string _accountId;
        private DateTime? _lastGeneratedAt;
        private string _resourceId;
        private string _resourceType;
        private int? _totalFindings;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which the statistics for this resource was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt
        {
            get { return this._lastGeneratedAt; }
            set { this._lastGeneratedAt = value; }
        }

        // Check to see if LastGeneratedAt property is set
        internal bool IsSetLastGeneratedAt()
        {
            return this._lastGeneratedAt.HasValue; 
        }

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
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings associated with this resource.
        /// </para>
        /// </summary>
        public int? TotalFindings
        {
            get { return this._totalFindings; }
            set { this._totalFindings = value; }
        }

        // Check to see if TotalFindings property is set
        internal bool IsSetTotalFindings()
        {
            return this._totalFindings.HasValue; 
        }

    }
}