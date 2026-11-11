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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.SimpleEmail.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConfigurationSetEventDestination Request Marshaller
    /// </summary>
    public partial class CreateConfigurationSetEventDestinationRequestMarshaller : IMarshaller<IRequest, CreateConfigurationSetEventDestinationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConfigurationSetEventDestinationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateConfigurationSetEventDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateConfigurationSetEventDestination");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetConfigurationSetName())
            {
                request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
            }
            if (publicRequest.IsSetEventDestination())
            {
                if (publicRequest.EventDestination.IsSetCloudWatchDestination())
                {
                    if (publicRequest.EventDestination.CloudWatchDestination.IsSetDimensionConfigurations())
                    {
                        if (publicRequest.EventDestination.CloudWatchDestination.DimensionConfigurations.Count == 0)
                        {
                            request.Parameters.Add("EventDestination" + ".CloudWatchDestination" + ".DimensionConfigurations", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.EventDestination.CloudWatchDestination.DimensionConfigurations)
                            {
                                if (item2.IsSetDefaultDimensionValue())
                                {
                                    request.Parameters.Add("EventDestination" + ".CloudWatchDestination" + ".DimensionConfigurations" + ".member" + "." + index2 + ".DefaultDimensionValue", StringUtils.FromString(item2.DefaultDimensionValue));
                                }
                                if (item2.IsSetDimensionName())
                                {
                                    request.Parameters.Add("EventDestination" + ".CloudWatchDestination" + ".DimensionConfigurations" + ".member" + "." + index2 + ".DimensionName", StringUtils.FromString(item2.DimensionName));
                                }
                                if (item2.IsSetDimensionValueSource())
                                {
                                    request.Parameters.Add("EventDestination" + ".CloudWatchDestination" + ".DimensionConfigurations" + ".member" + "." + index2 + ".DimensionValueSource", StringUtils.FromString(item2.DimensionValueSource));
                                }
                                index2++;
                            }
                        }
                    }
                }
                if (publicRequest.EventDestination.IsSetEnabled())
                {
                    request.Parameters.Add("EventDestination" + ".Enabled", StringUtils.FromBool(publicRequest.EventDestination.Enabled.Value));
                }
                if (publicRequest.EventDestination.IsSetKinesisFirehoseDestination())
                {
                    if (publicRequest.EventDestination.KinesisFirehoseDestination.IsSetDeliveryStreamARN())
                    {
                        request.Parameters.Add("EventDestination" + ".KinesisFirehoseDestination" + ".DeliveryStreamARN", StringUtils.FromString(publicRequest.EventDestination.KinesisFirehoseDestination.DeliveryStreamARN));
                    }
                    if (publicRequest.EventDestination.KinesisFirehoseDestination.IsSetIAMRoleARN())
                    {
                        request.Parameters.Add("EventDestination" + ".KinesisFirehoseDestination" + ".IAMRoleARN", StringUtils.FromString(publicRequest.EventDestination.KinesisFirehoseDestination.IAMRoleARN));
                    }
                }
                if (publicRequest.EventDestination.IsSetMatchingEventTypes())
                {
                    if (publicRequest.EventDestination.MatchingEventTypes.Count == 0)
                    {
                        request.Parameters.Add("EventDestination" + ".MatchingEventTypes", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.EventDestination.MatchingEventTypes)
                        {
                            request.Parameters.Add("EventDestination" + ".MatchingEventTypes" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.EventDestination.IsSetName())
                {
                    request.Parameters.Add("EventDestination" + ".Name", StringUtils.FromString(publicRequest.EventDestination.Name));
                }
                if (publicRequest.EventDestination.IsSetSNSDestination())
                {
                    if (publicRequest.EventDestination.SNSDestination.IsSetTopicARN())
                    {
                        request.Parameters.Add("EventDestination" + ".SNSDestination" + ".TopicARN", StringUtils.FromString(publicRequest.EventDestination.SNSDestination.TopicARN));
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateConfigurationSetEventDestinationRequestMarshaller _instance = new();

        internal static CreateConfigurationSetEventDestinationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateConfigurationSetEventDestinationRequestMarshaller Instance => _instance;
    }
}
