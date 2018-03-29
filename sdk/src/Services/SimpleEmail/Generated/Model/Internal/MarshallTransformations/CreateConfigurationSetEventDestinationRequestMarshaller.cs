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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConfigurationSetEventDestination Request Marshaller
    /// </summary>       
    public class CreateConfigurationSetEventDestinationRequestMarshaller : IMarshaller<IRequest, CreateConfigurationSetEventDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConfigurationSetEventDestinationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConfigurationSetEventDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "CreateConfigurationSetEventDestination");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfigurationSetName())
                {
                    request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
                }
                if(publicRequest.IsSetEventDestination())
                {
                    if(publicRequest.EventDestination.IsSetCloudWatchDestination())
                    {
                        if(publicRequest.EventDestination.CloudWatchDestination.IsSetDimensionConfigurations())
                        {
                            int publicRequestEventDestinationCloudWatchDestinationlistValueIndex = 1;
                            foreach(var publicRequestEventDestinationCloudWatchDestinationlistValue in publicRequest.EventDestination.CloudWatchDestination.DimensionConfigurations)
                            {
                                if(publicRequestEventDestinationCloudWatchDestinationlistValue.IsSetDefaultDimensionValue())
                                {
                                    request.Parameters.Add("EventDestination" + "." + "CloudWatchDestination" + "." + "DimensionConfigurations" + "." + "member" + "." + publicRequestEventDestinationCloudWatchDestinationlistValueIndex + "." + "DefaultDimensionValue", StringUtils.FromString(publicRequestEventDestinationCloudWatchDestinationlistValue.DefaultDimensionValue));
                                }
                                if(publicRequestEventDestinationCloudWatchDestinationlistValue.IsSetDimensionName())
                                {
                                    request.Parameters.Add("EventDestination" + "." + "CloudWatchDestination" + "." + "DimensionConfigurations" + "." + "member" + "." + publicRequestEventDestinationCloudWatchDestinationlistValueIndex + "." + "DimensionName", StringUtils.FromString(publicRequestEventDestinationCloudWatchDestinationlistValue.DimensionName));
                                }
                                if(publicRequestEventDestinationCloudWatchDestinationlistValue.IsSetDimensionValueSource())
                                {
                                    request.Parameters.Add("EventDestination" + "." + "CloudWatchDestination" + "." + "DimensionConfigurations" + "." + "member" + "." + publicRequestEventDestinationCloudWatchDestinationlistValueIndex + "." + "DimensionValueSource", StringUtils.FromString(publicRequestEventDestinationCloudWatchDestinationlistValue.DimensionValueSource));
                                }
                                publicRequestEventDestinationCloudWatchDestinationlistValueIndex++;
                            }
                        }
                    }
                    if(publicRequest.EventDestination.IsSetEnabled())
                    {
                        request.Parameters.Add("EventDestination" + "." + "Enabled", StringUtils.FromBool(publicRequest.EventDestination.Enabled));
                    }
                    if(publicRequest.EventDestination.IsSetKinesisFirehoseDestination())
                    {
                        if(publicRequest.EventDestination.KinesisFirehoseDestination.IsSetDeliveryStreamARN())
                        {
                            request.Parameters.Add("EventDestination" + "." + "KinesisFirehoseDestination" + "." + "DeliveryStreamARN", StringUtils.FromString(publicRequest.EventDestination.KinesisFirehoseDestination.DeliveryStreamARN));
                        }
                        if(publicRequest.EventDestination.KinesisFirehoseDestination.IsSetIAMRoleARN())
                        {
                            request.Parameters.Add("EventDestination" + "." + "KinesisFirehoseDestination" + "." + "IAMRoleARN", StringUtils.FromString(publicRequest.EventDestination.KinesisFirehoseDestination.IAMRoleARN));
                        }
                    }
                    if(publicRequest.EventDestination.IsSetMatchingEventTypes())
                    {
                        int publicRequestEventDestinationlistValueIndex = 1;
                        foreach(var publicRequestEventDestinationlistValue in publicRequest.EventDestination.MatchingEventTypes)
                        {
                            request.Parameters.Add("EventDestination" + "." + "MatchingEventTypes" + "." + "member" + "." + publicRequestEventDestinationlistValueIndex, StringUtils.FromString(publicRequestEventDestinationlistValue));
                            publicRequestEventDestinationlistValueIndex++;
                        }
                    }
                    if(publicRequest.EventDestination.IsSetName())
                    {
                        request.Parameters.Add("EventDestination" + "." + "Name", StringUtils.FromString(publicRequest.EventDestination.Name));
                    }
                    if(publicRequest.EventDestination.IsSetSNSDestination())
                    {
                        if(publicRequest.EventDestination.SNSDestination.IsSetTopicARN())
                        {
                            request.Parameters.Add("EventDestination" + "." + "SNSDestination" + "." + "TopicARN", StringUtils.FromString(publicRequest.EventDestination.SNSDestination.TopicARN));
                        }
                    }
                }
            }
            return request;
        }
                    private static CreateConfigurationSetEventDestinationRequestMarshaller _instance = new CreateConfigurationSetEventDestinationRequestMarshaller();        

        internal static CreateConfigurationSetEventDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConfigurationSetEventDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}