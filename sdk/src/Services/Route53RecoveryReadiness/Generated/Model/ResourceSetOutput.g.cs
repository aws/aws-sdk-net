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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// A collection of resources of the same type.
    /// </summary>
    public partial class ResourceSetOutput
    {
        /// <summary>
        /// Gets and sets the property ResourceSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ResourceSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetArn property is set.
        /// </summary>
        internal bool IsSetResourceSetArn() => this.ResourceSetArn != null;

        /// <summary>
        /// Gets and sets the property ResourceSetName. 
        /// <para>
        /// The name of the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ResourceSetName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetName property is set.
        /// </summary>
        internal bool IsSetResourceSetName() => this.ResourceSetName != null;

        /// <summary>
        /// Gets and sets the property ResourceSetType. 
        /// <para>
        /// The resource type of the resources in the resource set. Enter one of the following
        /// values for resource type:
        /// </para>
        ///  
        /// <para>
        /// AWS::ApiGateway::Stage, AWS::ApiGatewayV2::Stage, AWS::AutoScaling::AutoScalingGroup,
        /// AWS::CloudWatch::Alarm, AWS::EC2::CustomerGateway, AWS::DynamoDB::Table, AWS::EC2::Volume,
        /// AWS::ElasticLoadBalancing::LoadBalancer, AWS::ElasticLoadBalancingV2::LoadBalancer,
        /// AWS::Lambda::Function, AWS::MSK::Cluster, AWS::RDS::DBCluster, AWS::Route53::HealthCheck,
        /// AWS::SQS::Queue, AWS::SNS::Topic, AWS::SNS::Subscription, AWS::EC2::VPC, AWS::EC2::VPNConnection,
        /// AWS::EC2::VPNGateway, AWS::Route53RecoveryReadiness::DNSTargetResource
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceSetType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSetType property is set.
        /// </summary>
        internal bool IsSetResourceSetType() => this.ResourceSetType != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of resource objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Resource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
