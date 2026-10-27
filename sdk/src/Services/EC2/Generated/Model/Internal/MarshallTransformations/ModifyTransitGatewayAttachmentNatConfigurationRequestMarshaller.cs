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
    /// ModifyTransitGatewayAttachmentNatConfiguration Request Marshaller
    /// </summary>       
    public class ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyTransitGatewayAttachmentNatConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTransitGatewayAttachmentNatConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyTransitGatewayAttachmentNatConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyTransitGatewayAttachmentNatConfiguration");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetNatGatewayRules())
                {
                    if (publicRequest.NatGatewayRules.Count == 0)
                        request.Parameters.Add("NatGatewayRule", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NatGatewayRules)
                         {
                            if(publicRequestlistValue.IsSetMatchSourceCidr())
                            {
                                request.Parameters.Add("NatGatewayRule" + "." + publicRequestlistValueIndex + "." + "MatchSourceCidr", StringUtils.FromString(publicRequestlistValue.MatchSourceCidr));
                            }
                            if(publicRequestlistValue.IsSetNatCidr())
                            {
                                request.Parameters.Add("NatGatewayRule" + "." + publicRequestlistValueIndex + "." + "NatCidr", StringUtils.FromString(publicRequestlistValue.NatCidr));
                            }
                            if(publicRequestlistValue.IsSetRuleNumber())
                            {
                                request.Parameters.Add("NatGatewayRule" + "." + publicRequestlistValueIndex + "." + "RuleNumber", StringUtils.FromInt(publicRequestlistValue.RuleNumber));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNatGatewaySupport())
                {
                    request.Parameters.Add("NatGatewaySupport", StringUtils.FromString(publicRequest.NatGatewaySupport));
                }
                if(publicRequest.IsSetNatSystemRouteSupport())
                {
                    request.Parameters.Add("NatSystemRouteSupport", StringUtils.FromString(publicRequest.NatSystemRouteSupport));
                }
                if(publicRequest.IsSetResetNatGatewayRules())
                {
                    request.Parameters.Add("ResetNatGatewayRules", StringUtils.FromBool(publicRequest.ResetNatGatewayRules));
                }
                if(publicRequest.IsSetTransitGatewayAttachmentId())
                {
                    request.Parameters.Add("TransitGatewayAttachmentId", StringUtils.FromString(publicRequest.TransitGatewayAttachmentId));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller _instance = new ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller();        

        internal static ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyTransitGatewayAttachmentNatConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}