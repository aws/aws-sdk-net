/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceDetails Marshaller
    /// </summary>       
    public class ResourceDetailsMarshaller : IRequestMarshaller<ResourceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAwsAutoScalingAutoScalingGroup())
            {
                context.Writer.WritePropertyName("AwsAutoScalingAutoScalingGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAutoScalingAutoScalingGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAutoScalingAutoScalingGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCloudFrontDistribution())
            {
                context.Writer.WritePropertyName("AwsCloudFrontDistribution");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudFrontDistributionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudFrontDistribution, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCodeBuildProject())
            {
                context.Writer.WritePropertyName("AwsCodeBuildProject");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCodeBuildProjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCodeBuildProject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Instance())
            {
                context.Writer.WritePropertyName("AwsEc2Instance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2InstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Instance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2NetworkInterface())
            {
                context.Writer.WritePropertyName("AwsEc2NetworkInterface");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2NetworkInterfaceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2NetworkInterface, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2SecurityGroup())
            {
                context.Writer.WritePropertyName("AwsEc2SecurityGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2SecurityGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2SecurityGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Volume())
            {
                context.Writer.WritePropertyName("AwsEc2Volume");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VolumeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Volume, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Vpc())
            {
                context.Writer.WritePropertyName("AwsEc2Vpc");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VpcDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Vpc, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElasticsearchDomain())
            {
                context.Writer.WritePropertyName("AwsElasticsearchDomain");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElasticsearchDomain, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElbv2LoadBalancer())
            {
                context.Writer.WritePropertyName("AwsElbv2LoadBalancer");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbv2LoadBalancerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElbv2LoadBalancer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamAccessKey())
            {
                context.Writer.WritePropertyName("AwsIamAccessKey");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamAccessKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamAccessKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamRole())
            {
                context.Writer.WritePropertyName("AwsIamRole");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamRoleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamRole, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsKmsKey())
            {
                context.Writer.WritePropertyName("AwsKmsKey");
                context.Writer.WriteObjectStart();

                var marshaller = AwsKmsKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsKmsKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsLambdaFunction())
            {
                context.Writer.WritePropertyName("AwsLambdaFunction");
                context.Writer.WriteObjectStart();

                var marshaller = AwsLambdaFunctionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaFunction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsLambdaLayerVersion())
            {
                context.Writer.WritePropertyName("AwsLambdaLayerVersion");
                context.Writer.WriteObjectStart();

                var marshaller = AwsLambdaLayerVersionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaLayerVersion, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbInstance())
            {
                context.Writer.WritePropertyName("AwsRdsDbInstance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbInstance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3Bucket())
            {
                context.Writer.WritePropertyName("AwsS3Bucket");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3BucketDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Bucket, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3Object())
            {
                context.Writer.WritePropertyName("AwsS3Object");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3ObjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Object, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSnsTopic())
            {
                context.Writer.WritePropertyName("AwsSnsTopic");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSnsTopicDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSnsTopic, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSqsQueue())
            {
                context.Writer.WritePropertyName("AwsSqsQueue");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSqsQueueDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSqsQueue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafWebAcl())
            {
                context.Writer.WritePropertyName("AwsWafWebAcl");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafWebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafWebAcl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOther())
            {
                context.Writer.WritePropertyName("Other");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectOtherKvp in requestObject.Other)
                {
                    context.Writer.WritePropertyName(requestObjectOtherKvp.Key);
                    var requestObjectOtherValue = requestObjectOtherKvp.Value;

                        context.Writer.Write(requestObjectOtherValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ResourceDetailsMarshaller Instance = new ResourceDetailsMarshaller();

    }
}