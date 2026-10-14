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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Contains detailed information about the specified resource.
    /// </summary>
    public partial class ResourceDetails
    {
        /// <summary>
        /// Gets and sets the property AuroraDbClusterStorage. 
        /// <para>
        /// The Aurora DB cluster storage recommendation details.
        /// </para>
        /// </summary>
        public AuroraDbClusterStorage AuroraDbClusterStorage { get; set; }

        /// <summary>
        /// Checks to see if the AuroraDbClusterStorage property is set.
        /// </summary>
        internal bool IsSetAuroraDbClusterStorage() => this.AuroraDbClusterStorage != null;

        /// <summary>
        /// Gets and sets the property ComputeSavingsPlans. 
        /// <para>
        /// The Compute Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public ComputeSavingsPlans ComputeSavingsPlans { get; set; }

        /// <summary>
        /// Checks to see if the ComputeSavingsPlans property is set.
        /// </summary>
        internal bool IsSetComputeSavingsPlans() => this.ComputeSavingsPlans != null;

        /// <summary>
        /// Gets and sets the property DocumentDbCluster. 
        /// <para>
        /// The Amazon DocumentDB cluster recommendation details.
        /// </para>
        /// </summary>
        public DocumentDbCluster DocumentDbCluster { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDbCluster property is set.
        /// </summary>
        internal bool IsSetDocumentDbCluster() => this.DocumentDbCluster != null;

        /// <summary>
        /// Gets and sets the property DynamoDbReservedCapacity. 
        /// <para>
        /// The DynamoDB reserved capacity recommendation details.
        /// </para>
        /// </summary>
        public DynamoDbReservedCapacity DynamoDbReservedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDbReservedCapacity property is set.
        /// </summary>
        internal bool IsSetDynamoDbReservedCapacity() => this.DynamoDbReservedCapacity != null;

        /// <summary>
        /// Gets and sets the property DynamoDbTable. 
        /// <para>
        /// The DynamoDB table recommendation details.
        /// </para>
        /// </summary>
        public DynamoDbTable DynamoDbTable { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDbTable property is set.
        /// </summary>
        internal bool IsSetDynamoDbTable() => this.DynamoDbTable != null;

        /// <summary>
        /// Gets and sets the property EbsVolume. 
        /// <para>
        /// The Amazon Elastic Block Store volume recommendation details.
        /// </para>
        /// </summary>
        public EbsVolume EbsVolume { get; set; }

        /// <summary>
        /// Checks to see if the EbsVolume property is set.
        /// </summary>
        internal bool IsSetEbsVolume() => this.EbsVolume != null;

        /// <summary>
        /// Gets and sets the property Ec2AutoScalingGroup. 
        /// <para>
        /// The EC2 Auto Scaling group recommendation details.
        /// </para>
        /// </summary>
        public Ec2AutoScalingGroup Ec2AutoScalingGroup { get; set; }

        /// <summary>
        /// Checks to see if the Ec2AutoScalingGroup property is set.
        /// </summary>
        internal bool IsSetEc2AutoScalingGroup() => this.Ec2AutoScalingGroup != null;

        /// <summary>
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// The EC2 instance recommendation details.
        /// </para>
        /// </summary>
        public Ec2Instance Ec2Instance { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Instance property is set.
        /// </summary>
        internal bool IsSetEc2Instance() => this.Ec2Instance != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceSavingsPlans. 
        /// <para>
        /// The EC2 instance Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public Ec2InstanceSavingsPlans Ec2InstanceSavingsPlans { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceSavingsPlans property is set.
        /// </summary>
        internal bool IsSetEc2InstanceSavingsPlans() => this.Ec2InstanceSavingsPlans != null;

        /// <summary>
        /// Gets and sets the property Ec2ReservedInstances. 
        /// <para>
        /// The EC2 reserved instances recommendation details.
        /// </para>
        /// </summary>
        public Ec2ReservedInstances Ec2ReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the Ec2ReservedInstances property is set.
        /// </summary>
        internal bool IsSetEc2ReservedInstances() => this.Ec2ReservedInstances != null;

        /// <summary>
        /// Gets and sets the property EcsService. 
        /// <para>
        /// The ECS service recommendation details.
        /// </para>
        /// </summary>
        public EcsService EcsService { get; set; }

        /// <summary>
        /// Checks to see if the EcsService property is set.
        /// </summary>
        internal bool IsSetEcsService() => this.EcsService != null;

        /// <summary>
        /// Gets and sets the property ElastiCacheCluster. 
        /// <para>
        /// The ElastiCache cluster recommendation details.
        /// </para>
        /// </summary>
        public ElastiCacheCluster ElastiCacheCluster { get; set; }

        /// <summary>
        /// Checks to see if the ElastiCacheCluster property is set.
        /// </summary>
        internal bool IsSetElastiCacheCluster() => this.ElastiCacheCluster != null;

        /// <summary>
        /// Gets and sets the property ElastiCacheReservedInstances. 
        /// <para>
        /// The ElastiCache reserved instances recommendation details.
        /// </para>
        /// </summary>
        public ElastiCacheReservedInstances ElastiCacheReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the ElastiCacheReservedInstances property is set.
        /// </summary>
        internal bool IsSetElastiCacheReservedInstances() => this.ElastiCacheReservedInstances != null;

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// The Lambda function recommendation details.
        /// </para>
        /// </summary>
        public LambdaFunction LambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunction property is set.
        /// </summary>
        internal bool IsSetLambdaFunction() => this.LambdaFunction != null;

        /// <summary>
        /// Gets and sets the property MemoryDbCluster. 
        /// <para>
        /// The MemoryDB cluster recommendation details.
        /// </para>
        /// </summary>
        public MemoryDbCluster MemoryDbCluster { get; set; }

        /// <summary>
        /// Checks to see if the MemoryDbCluster property is set.
        /// </summary>
        internal bool IsSetMemoryDbCluster() => this.MemoryDbCluster != null;

        /// <summary>
        /// Gets and sets the property MemoryDbReservedInstances. 
        /// <para>
        /// The MemoryDB reserved instances recommendation details.
        /// </para>
        /// </summary>
        public MemoryDbReservedInstances MemoryDbReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the MemoryDbReservedInstances property is set.
        /// </summary>
        internal bool IsSetMemoryDbReservedInstances() => this.MemoryDbReservedInstances != null;

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// The NAT Gateway recommendation details.
        /// </para>
        /// </summary>
        public NatGateway NatGateway { get; set; }

        /// <summary>
        /// Checks to see if the NatGateway property is set.
        /// </summary>
        internal bool IsSetNatGateway() => this.NatGateway != null;

        /// <summary>
        /// Gets and sets the property OpenSearchReservedInstances. 
        /// <para>
        /// The OpenSearch reserved instances recommendation details.
        /// </para>
        /// </summary>
        public OpenSearchReservedInstances OpenSearchReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the OpenSearchReservedInstances property is set.
        /// </summary>
        internal bool IsSetOpenSearchReservedInstances() => this.OpenSearchReservedInstances != null;

        /// <summary>
        /// Gets and sets the property RdsDbInstance. 
        /// <para>
        /// The DB instance recommendation details.
        /// </para>
        /// </summary>
        public RdsDbInstance RdsDbInstance { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbInstance property is set.
        /// </summary>
        internal bool IsSetRdsDbInstance() => this.RdsDbInstance != null;

        /// <summary>
        /// Gets and sets the property RdsDbInstanceStorage. 
        /// <para>
        /// The DB instance storage recommendation details.
        /// </para>
        /// </summary>
        public RdsDbInstanceStorage RdsDbInstanceStorage { get; set; }

        /// <summary>
        /// Checks to see if the RdsDbInstanceStorage property is set.
        /// </summary>
        internal bool IsSetRdsDbInstanceStorage() => this.RdsDbInstanceStorage != null;

        /// <summary>
        /// Gets and sets the property RdsReservedInstances. 
        /// <para>
        /// The RDS reserved instances recommendation details.
        /// </para>
        /// </summary>
        public RdsReservedInstances RdsReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the RdsReservedInstances property is set.
        /// </summary>
        internal bool IsSetRdsReservedInstances() => this.RdsReservedInstances != null;

        /// <summary>
        /// Gets and sets the property RedshiftReservedInstances. 
        /// <para>
        /// The Redshift reserved instances recommendation details.
        /// </para>
        /// </summary>
        public RedshiftReservedInstances RedshiftReservedInstances { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftReservedInstances property is set.
        /// </summary>
        internal bool IsSetRedshiftReservedInstances() => this.RedshiftReservedInstances != null;

        /// <summary>
        /// Gets and sets the property SageMakerEndpoint. 
        /// <para>
        /// The SageMaker endpoint recommendation details.
        /// </para>
        /// </summary>
        public SageMakerEndpoint SageMakerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerEndpoint property is set.
        /// </summary>
        internal bool IsSetSageMakerEndpoint() => this.SageMakerEndpoint != null;

        /// <summary>
        /// Gets and sets the property SageMakerSavingsPlans. 
        /// <para>
        /// The SageMaker AI Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public SageMakerSavingsPlans SageMakerSavingsPlans { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerSavingsPlans property is set.
        /// </summary>
        internal bool IsSetSageMakerSavingsPlans() => this.SageMakerSavingsPlans != null;

        /// <summary>
        /// Gets and sets the property WorkSpaces. 
        /// <para>
        /// The WorkSpaces recommendation details.
        /// </para>
        /// </summary>
        public WorkSpaces WorkSpaces { get; set; }

        /// <summary>
        /// Checks to see if the WorkSpaces property is set.
        /// </summary>
        internal bool IsSetWorkSpaces() => this.WorkSpaces != null;
    }
}
