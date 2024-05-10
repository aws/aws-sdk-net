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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a physical resource identifier.
    /// </summary>
    public partial class PhysicalResourceId
    {
        private string _awsAccountId;
        private string _awsRegion;
        private string _identifier;
        private PhysicalIdentifierType _type;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account that owns the physical resource.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region that the physical resource is located in.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the physical resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of physical resource identifier.
        /// </para>
        ///  <dl> <dt>Arn</dt> <dd> 
        /// <para>
        /// The resource identifier is an Amazon Resource Name (ARN) and it can identify the following
        /// list of resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::ECS::Service</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EFS::FileSystem</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SNS::Topic</c> 
        /// </para>
        ///  </li> </ul> </dd> <dt>Native</dt> <dd> 
        /// <para>
        /// The resource identifier is an Resilience Hub-native identifier and it can identify
        /// the following list of resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::ApiGateway::RestApi</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ApiGatewayV2::Api</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::AutoScaling::AutoScalingGroup</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DocDB::DBCluster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DocDB::DBGlobalCluster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DocDB::DBInstance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::GlobalTable</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EC2::EC2Fleet</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EC2::Instance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EC2::NatGateway</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::EC2::Volume</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::ElasticLoadBalancing::LoadBalancer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::RDS::DBCluster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::RDS::DBInstance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::RDS::GlobalCluster</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Route53::RecordSet</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Bucket</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::SQS::Queue</c> 
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhysicalIdentifierType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}