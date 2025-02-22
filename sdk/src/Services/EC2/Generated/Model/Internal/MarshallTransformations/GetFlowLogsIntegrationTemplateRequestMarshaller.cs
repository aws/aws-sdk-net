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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFlowLogsIntegrationTemplate Request Marshaller
    /// </summary>       
    public class GetFlowLogsIntegrationTemplateRequestMarshaller : IMarshaller<IRequest, GetFlowLogsIntegrationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFlowLogsIntegrationTemplateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetFlowLogsIntegrationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetFlowLogsIntegrationTemplate");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfigDeliveryS3DestinationArn())
                {
                    request.Parameters.Add("ConfigDeliveryS3DestinationArn", StringUtils.FromString(publicRequest.ConfigDeliveryS3DestinationArn));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFlowLogId())
                {
                    request.Parameters.Add("FlowLogId", StringUtils.FromString(publicRequest.FlowLogId));
                }
                if(publicRequest.IsSetIntegrateServices())
                {
                    if(publicRequest.IntegrateServices.IsSetAthenaIntegrations())
                    {
                        if (publicRequest.IntegrateServices.AthenaIntegrations.Count == 0)
                            request.Parameters.Add("IntegrateService" + "." + "AthenaIntegration", "");
                        else
                        {
                             int publicRequestIntegrateServiceslistValueIndex = 1;
                             foreach(var publicRequestIntegrateServiceslistValue in publicRequest.IntegrateServices.AthenaIntegrations)
                             {
                                if(publicRequestIntegrateServiceslistValue.IsSetIntegrationResultS3DestinationArn())
                                {
                                    request.Parameters.Add("IntegrateService" + "." + "AthenaIntegration" + "." + publicRequestIntegrateServiceslistValueIndex + "." + "IntegrationResultS3DestinationArn", StringUtils.FromString(publicRequestIntegrateServiceslistValue.IntegrationResultS3DestinationArn));
                                }
                                if(publicRequestIntegrateServiceslistValue.IsSetPartitionEndDate())
                                {
                                    request.Parameters.Add("IntegrateService" + "." + "AthenaIntegration" + "." + publicRequestIntegrateServiceslistValueIndex + "." + "PartitionEndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestIntegrateServiceslistValue.PartitionEndDate));
                                }
                                if(publicRequestIntegrateServiceslistValue.IsSetPartitionLoadFrequency())
                                {
                                    request.Parameters.Add("IntegrateService" + "." + "AthenaIntegration" + "." + publicRequestIntegrateServiceslistValueIndex + "." + "PartitionLoadFrequency", StringUtils.FromString(publicRequestIntegrateServiceslistValue.PartitionLoadFrequency));
                                }
                                if(publicRequestIntegrateServiceslistValue.IsSetPartitionStartDate())
                                {
                                    request.Parameters.Add("IntegrateService" + "." + "AthenaIntegration" + "." + publicRequestIntegrateServiceslistValueIndex + "." + "PartitionStartDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestIntegrateServiceslistValue.PartitionStartDate));
                                }
                                 publicRequestIntegrateServiceslistValueIndex++;
                             }
                        }
                    }
                }
            }
            return request;
        }
                    private static GetFlowLogsIntegrationTemplateRequestMarshaller _instance = new GetFlowLogsIntegrationTemplateRequestMarshaller();        

        internal static GetFlowLogsIntegrationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetFlowLogsIntegrationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}