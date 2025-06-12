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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
    /// This is the response object from the CreateResourceSet operation.
    /// </summary>
    public partial class CreateResourceSetResponse : AmazonWebServiceResponse
    {
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private string _resourceSetArn;
        private string _resourceSetName;
        private string _resourceSetType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of resource objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ResourceSetArn
        {
            get { return this._resourceSetArn; }
            set { this._resourceSetArn = value; }
        }

        // Check to see if ResourceSetArn property is set
        internal bool IsSetResourceSetArn()
        {
            return this._resourceSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSetName. 
        /// <para>
        /// The name of the resource set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ResourceSetName
        {
            get { return this._resourceSetName; }
            set { this._resourceSetName = value; }
        }

        // Check to see if ResourceSetName property is set
        internal bool IsSetResourceSetName()
        {
            return this._resourceSetName != null;
        }

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
        public string ResourceSetType
        {
            get { return this._resourceSetType; }
            set { this._resourceSetType = value; }
        }

        // Check to see if ResourceSetType property is set
        internal bool IsSetResourceSetType()
        {
            return this._resourceSetType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}