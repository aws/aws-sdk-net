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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContinuousDeploymentPolicy Request Marshaller
    /// </summary>       
    public partial class CreateContinuousDeploymentPolicyRequestMarshaller : IMarshaller<IRequest, CreateContinuousDeploymentPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContinuousDeploymentPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContinuousDeploymentPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/continuous-deployment-policy";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetContinuousDeploymentPolicyConfig())
                {
                    xmlWriter.WriteStartElement("ContinuousDeploymentPolicyConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if(publicRequest.ContinuousDeploymentPolicyConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.ContinuousDeploymentPolicyConfig.Enabled.Value));

                    if (publicRequest.ContinuousDeploymentPolicyConfig.StagingDistributionDnsNames != null)
                    {
                        xmlWriter.WriteStartElement("StagingDistributionDnsNames");
                        var publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItems = publicRequest.ContinuousDeploymentPolicyConfig.StagingDistributionDnsNames.Items;
                        if (publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItems != null && (publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItemsValue in publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItems) 
                            {
                                xmlWriter.WriteStartElement("DnsName");
                                xmlWriter.WriteValue(publicRequestContinuousDeploymentPolicyConfigStagingDistributionDnsNamesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.ContinuousDeploymentPolicyConfig.StagingDistributionDnsNames.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.ContinuousDeploymentPolicyConfig.StagingDistributionDnsNames.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig != null)
                    {
                        xmlWriter.WriteStartElement("TrafficConfig");
                        if (publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleHeaderConfig != null)
                        {
                            xmlWriter.WriteStartElement("SingleHeaderConfig");
                            if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleHeaderConfig.IsSetHeader())
                                xmlWriter.WriteElementString("Header", StringUtils.FromString(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleHeaderConfig.Header));
                            if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleHeaderConfig.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleHeaderConfig.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig != null)
                        {
                            xmlWriter.WriteStartElement("SingleWeightConfig");
                            if (publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.SessionStickinessConfig != null)
                            {
                                xmlWriter.WriteStartElement("SessionStickinessConfig");
                                if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.SessionStickinessConfig.IsSetIdleTTL())
                                    xmlWriter.WriteElementString("IdleTTL", StringUtils.FromInt(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.SessionStickinessConfig.IdleTTL.Value));
                                if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.SessionStickinessConfig.IsSetMaximumTTL())
                                    xmlWriter.WriteElementString("MaximumTTL", StringUtils.FromInt(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.SessionStickinessConfig.MaximumTTL.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.IsSetWeight())
                                xmlWriter.WriteElementString("Weight", StringUtils.FromFloat(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.SingleWeightConfig.Weight.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.ContinuousDeploymentPolicyConfig.TrafficConfig.Type));
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateContinuousDeploymentPolicyRequestMarshaller _instance = new CreateContinuousDeploymentPolicyRequestMarshaller();        

        internal static CreateContinuousDeploymentPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContinuousDeploymentPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateContinuousDeploymentPolicyRequest publicRequest);
    }    
}