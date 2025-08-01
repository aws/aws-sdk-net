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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAccessPointForObjectLambda Request Marshaller
    /// </summary>       
    public partial class CreateAccessPointForObjectLambdaRequestMarshaller : IMarshaller<IRequest, CreateAccessPointForObjectLambdaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAccessPointForObjectLambdaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAccessPointForObjectLambdaRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetName())
                throw new AmazonS3ControlException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v20180820/accesspointforobjectlambda/{name}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateAccessPointForObjectLambdaRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if (publicRequest.Configuration != null)
                {
                    xmlWriter.WriteStartElement("Configuration");
                    var publicRequestConfigurationAllowedFeatures = publicRequest.Configuration.AllowedFeatures;
                    if (publicRequestConfigurationAllowedFeatures != null && (publicRequestConfigurationAllowedFeatures.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("AllowedFeatures");
                        foreach (var publicRequestConfigurationAllowedFeaturesValue in publicRequestConfigurationAllowedFeatures) 
                        {
                            xmlWriter.WriteStartElement("AllowedFeature");
                            xmlWriter.WriteValue(publicRequestConfigurationAllowedFeaturesValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.Configuration.IsSetCloudWatchMetricsEnabled())
                        xmlWriter.WriteElementString("CloudWatchMetricsEnabled", StringUtils.FromBool(publicRequest.Configuration.CloudWatchMetricsEnabled.Value));
                    if(publicRequest.Configuration.IsSetSupportingAccessPoint())
                        xmlWriter.WriteElementString("SupportingAccessPoint", StringUtils.FromString(publicRequest.Configuration.SupportingAccessPoint));
                    var publicRequestConfigurationTransformationConfigurations = publicRequest.Configuration.TransformationConfigurations;
                    if (publicRequestConfigurationTransformationConfigurations != null && (publicRequestConfigurationTransformationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("TransformationConfigurations");
                        foreach (var publicRequestConfigurationTransformationConfigurationsValue in publicRequestConfigurationTransformationConfigurations) 
                        {
                        if (publicRequestConfigurationTransformationConfigurationsValue != null)
                        {
                            xmlWriter.WriteStartElement("TransformationConfiguration");
                            var publicRequestConfigurationTransformationConfigurationsValueActions = publicRequestConfigurationTransformationConfigurationsValue.Actions;
                            if (publicRequestConfigurationTransformationConfigurationsValueActions != null && (publicRequestConfigurationTransformationConfigurationsValueActions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Actions");
                                foreach (var publicRequestConfigurationTransformationConfigurationsValueActionsValue in publicRequestConfigurationTransformationConfigurationsValueActions) 
                                {
                                    xmlWriter.WriteStartElement("Action");
                                    xmlWriter.WriteValue(publicRequestConfigurationTransformationConfigurationsValueActionsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if (publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation != null)
                            {
                                xmlWriter.WriteStartElement("ContentTransformation");
                                if (publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda != null)
                                {
                                    xmlWriter.WriteStartElement("AwsLambda");
                                    if(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.IsSetFunctionArn())
                                        xmlWriter.WriteElementString("FunctionArn", StringUtils.FromString(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.FunctionArn));
                                    if(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.IsSetFunctionPayload())
                                        xmlWriter.WriteElementString("FunctionPayload", StringUtils.FromString(publicRequestConfigurationTransformationConfigurationsValue.ContentTransformation.AwsLambda.FunctionPayload));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static CreateAccessPointForObjectLambdaRequestMarshaller _instance = new CreateAccessPointForObjectLambdaRequestMarshaller();        

        internal static CreateAccessPointForObjectLambdaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAccessPointForObjectLambdaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateAccessPointForObjectLambdaRequest publicRequest);
    }    
}