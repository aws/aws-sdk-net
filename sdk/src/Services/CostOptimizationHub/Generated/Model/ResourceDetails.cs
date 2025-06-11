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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
        private AuroraDbClusterStorage _auroraDbClusterStorage;
        private ComputeSavingsPlans _computeSavingsPlans;
        private DynamoDbReservedCapacity _dynamoDbReservedCapacity;
        private EbsVolume _ebsVolume;
        private Ec2AutoScalingGroup _ec2AutoScalingGroup;
        private Ec2Instance _ec2Instance;
        private Ec2InstanceSavingsPlans _ec2InstanceSavingsPlans;
        private Ec2ReservedInstances _ec2ReservedInstances;
        private EcsService _ecsService;
        private ElastiCacheReservedInstances _elastiCacheReservedInstances;
        private LambdaFunction _lambdaFunction;
        private MemoryDbReservedInstances _memoryDbReservedInstances;
        private OpenSearchReservedInstances _openSearchReservedInstances;
        private RdsDbInstance _rdsDbInstance;
        private RdsDbInstanceStorage _rdsDbInstanceStorage;
        private RdsReservedInstances _rdsReservedInstances;
        private RedshiftReservedInstances _redshiftReservedInstances;
        private SageMakerSavingsPlans _sageMakerSavingsPlans;

        /// <summary>
        /// Gets and sets the property AuroraDbClusterStorage. 
        /// <para>
        /// The Aurora DB cluster storage recommendation details.
        /// </para>
        /// </summary>
        public AuroraDbClusterStorage AuroraDbClusterStorage
        {
            get { return this._auroraDbClusterStorage; }
            set { this._auroraDbClusterStorage = value; }
        }

        // Check to see if AuroraDbClusterStorage property is set
        internal bool IsSetAuroraDbClusterStorage()
        {
            return this._auroraDbClusterStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeSavingsPlans. 
        /// <para>
        /// The Compute Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public ComputeSavingsPlans ComputeSavingsPlans
        {
            get { return this._computeSavingsPlans; }
            set { this._computeSavingsPlans = value; }
        }

        // Check to see if ComputeSavingsPlans property is set
        internal bool IsSetComputeSavingsPlans()
        {
            return this._computeSavingsPlans != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDbReservedCapacity. 
        /// <para>
        /// The DynamoDB reserved capacity recommendation details.
        /// </para>
        /// </summary>
        public DynamoDbReservedCapacity DynamoDbReservedCapacity
        {
            get { return this._dynamoDbReservedCapacity; }
            set { this._dynamoDbReservedCapacity = value; }
        }

        // Check to see if DynamoDbReservedCapacity property is set
        internal bool IsSetDynamoDbReservedCapacity()
        {
            return this._dynamoDbReservedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property EbsVolume. 
        /// <para>
        /// The Amazon Elastic Block Store volume recommendation details.
        /// </para>
        /// </summary>
        public EbsVolume EbsVolume
        {
            get { return this._ebsVolume; }
            set { this._ebsVolume = value; }
        }

        // Check to see if EbsVolume property is set
        internal bool IsSetEbsVolume()
        {
            return this._ebsVolume != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2AutoScalingGroup. 
        /// <para>
        /// The EC2 Auto Scaling group recommendation details.
        /// </para>
        /// </summary>
        public Ec2AutoScalingGroup Ec2AutoScalingGroup
        {
            get { return this._ec2AutoScalingGroup; }
            set { this._ec2AutoScalingGroup = value; }
        }

        // Check to see if Ec2AutoScalingGroup property is set
        internal bool IsSetEc2AutoScalingGroup()
        {
            return this._ec2AutoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2Instance. 
        /// <para>
        /// The EC2 instance recommendation details.
        /// </para>
        /// </summary>
        public Ec2Instance Ec2Instance
        {
            get { return this._ec2Instance; }
            set { this._ec2Instance = value; }
        }

        // Check to see if Ec2Instance property is set
        internal bool IsSetEc2Instance()
        {
            return this._ec2Instance != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceSavingsPlans. 
        /// <para>
        /// The EC2 instance Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public Ec2InstanceSavingsPlans Ec2InstanceSavingsPlans
        {
            get { return this._ec2InstanceSavingsPlans; }
            set { this._ec2InstanceSavingsPlans = value; }
        }

        // Check to see if Ec2InstanceSavingsPlans property is set
        internal bool IsSetEc2InstanceSavingsPlans()
        {
            return this._ec2InstanceSavingsPlans != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2ReservedInstances. 
        /// <para>
        /// The EC2 reserved instances recommendation details.
        /// </para>
        /// </summary>
        public Ec2ReservedInstances Ec2ReservedInstances
        {
            get { return this._ec2ReservedInstances; }
            set { this._ec2ReservedInstances = value; }
        }

        // Check to see if Ec2ReservedInstances property is set
        internal bool IsSetEc2ReservedInstances()
        {
            return this._ec2ReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property EcsService. 
        /// <para>
        /// The ECS service recommendation details.
        /// </para>
        /// </summary>
        public EcsService EcsService
        {
            get { return this._ecsService; }
            set { this._ecsService = value; }
        }

        // Check to see if EcsService property is set
        internal bool IsSetEcsService()
        {
            return this._ecsService != null;
        }

        /// <summary>
        /// Gets and sets the property ElastiCacheReservedInstances. 
        /// <para>
        /// The ElastiCache reserved instances recommendation details.
        /// </para>
        /// </summary>
        public ElastiCacheReservedInstances ElastiCacheReservedInstances
        {
            get { return this._elastiCacheReservedInstances; }
            set { this._elastiCacheReservedInstances = value; }
        }

        // Check to see if ElastiCacheReservedInstances property is set
        internal bool IsSetElastiCacheReservedInstances()
        {
            return this._elastiCacheReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// The Lambda function recommendation details.
        /// </para>
        /// </summary>
        public LambdaFunction LambdaFunction
        {
            get { return this._lambdaFunction; }
            set { this._lambdaFunction = value; }
        }

        // Check to see if LambdaFunction property is set
        internal bool IsSetLambdaFunction()
        {
            return this._lambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryDbReservedInstances. 
        /// <para>
        /// The MemoryDB reserved instances recommendation details.
        /// </para>
        /// </summary>
        public MemoryDbReservedInstances MemoryDbReservedInstances
        {
            get { return this._memoryDbReservedInstances; }
            set { this._memoryDbReservedInstances = value; }
        }

        // Check to see if MemoryDbReservedInstances property is set
        internal bool IsSetMemoryDbReservedInstances()
        {
            return this._memoryDbReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property OpenSearchReservedInstances. 
        /// <para>
        /// The OpenSearch reserved instances recommendation details.
        /// </para>
        /// </summary>
        public OpenSearchReservedInstances OpenSearchReservedInstances
        {
            get { return this._openSearchReservedInstances; }
            set { this._openSearchReservedInstances = value; }
        }

        // Check to see if OpenSearchReservedInstances property is set
        internal bool IsSetOpenSearchReservedInstances()
        {
            return this._openSearchReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstance. 
        /// <para>
        /// The DB instance recommendation details.
        /// </para>
        /// </summary>
        public RdsDbInstance RdsDbInstance
        {
            get { return this._rdsDbInstance; }
            set { this._rdsDbInstance = value; }
        }

        // Check to see if RdsDbInstance property is set
        internal bool IsSetRdsDbInstance()
        {
            return this._rdsDbInstance != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstanceStorage. 
        /// <para>
        /// The DB instance storage recommendation details.
        /// </para>
        /// </summary>
        public RdsDbInstanceStorage RdsDbInstanceStorage
        {
            get { return this._rdsDbInstanceStorage; }
            set { this._rdsDbInstanceStorage = value; }
        }

        // Check to see if RdsDbInstanceStorage property is set
        internal bool IsSetRdsDbInstanceStorage()
        {
            return this._rdsDbInstanceStorage != null;
        }

        /// <summary>
        /// Gets and sets the property RdsReservedInstances. 
        /// <para>
        /// The RDS reserved instances recommendation details.
        /// </para>
        /// </summary>
        public RdsReservedInstances RdsReservedInstances
        {
            get { return this._rdsReservedInstances; }
            set { this._rdsReservedInstances = value; }
        }

        // Check to see if RdsReservedInstances property is set
        internal bool IsSetRdsReservedInstances()
        {
            return this._rdsReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftReservedInstances. 
        /// <para>
        /// The Redshift reserved instances recommendation details.
        /// </para>
        /// </summary>
        public RedshiftReservedInstances RedshiftReservedInstances
        {
            get { return this._redshiftReservedInstances; }
            set { this._redshiftReservedInstances = value; }
        }

        // Check to see if RedshiftReservedInstances property is set
        internal bool IsSetRedshiftReservedInstances()
        {
            return this._redshiftReservedInstances != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerSavingsPlans. 
        /// <para>
        /// The SageMaker AI Savings Plans recommendation details.
        /// </para>
        /// </summary>
        public SageMakerSavingsPlans SageMakerSavingsPlans
        {
            get { return this._sageMakerSavingsPlans; }
            set { this._sageMakerSavingsPlans = value; }
        }

        // Check to see if SageMakerSavingsPlans property is set
        internal bool IsSetSageMakerSavingsPlans()
        {
            return this._sageMakerSavingsPlans != null;
        }

    }
}