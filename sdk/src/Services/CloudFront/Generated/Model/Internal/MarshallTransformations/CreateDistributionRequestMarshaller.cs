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
    /// CreateDistribution Request Marshaller
    /// </summary>       
    public partial class CreateDistributionRequestMarshaller : IMarshaller<IRequest, CreateDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/distribution";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetDistributionConfig())
                {
                    xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if (publicRequest.DistributionConfig.Aliases != null)
                    {
                        xmlWriter.WriteStartElement("Aliases");
                        var publicRequestDistributionConfigAliasesItems = publicRequest.DistributionConfig.Aliases.Items;
                        if (publicRequestDistributionConfigAliasesItems != null && (publicRequestDistributionConfigAliasesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigAliasesItemsValue in publicRequestDistributionConfigAliasesItems) 
                            {
                                xmlWriter.WriteStartElement("CNAME");
                                xmlWriter.WriteValue(publicRequestDistributionConfigAliasesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Aliases.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.Aliases.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetAnycastIpListId())
                        xmlWriter.WriteElementString("AnycastIpListId", StringUtils.FromString(publicRequest.DistributionConfig.AnycastIpListId));

                    if (publicRequest.DistributionConfig.CacheBehaviors != null)
                    {
                        xmlWriter.WriteStartElement("CacheBehaviors");
                        var publicRequestDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfig.CacheBehaviors.Items;
                        if (publicRequestDistributionConfigCacheBehaviorsItems != null && (publicRequestDistributionConfigCacheBehaviorsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigCacheBehaviorsItems) 
                            {
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("CacheBehavior");
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null)
                                {
                                    xmlWriter.WriteStartElement("AllowedMethods");
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null)
                                    {
                                        xmlWriter.WriteStartElement("CachedMethods");
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                            {
                                                xmlWriter.WriteStartElement("Method");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetCachePolicyId())
                                    xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.CachePolicyId));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
                                    xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.Compress.Value));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                    xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.DefaultTTL.Value));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                    xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null)
                                {
                                    xmlWriter.WriteStartElement("ForwardedValues");
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null)
                                    {
                                        xmlWriter.WriteStartElement("Cookies");
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                            xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null)
                                        {
                                            xmlWriter.WriteStartElement("WhitelistedNames");
                                            var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                            if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Name");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null)
                                    {
                                        xmlWriter.WriteStartElement("Headers");
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                        xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString.Value));
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys != null)
                                    {
                                        xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations != null)
                                {
                                    xmlWriter.WriteStartElement("FunctionAssociations");
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems) 
                                        {
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("FunctionAssociation");
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.EventType));
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetFunctionARN())
                                                xmlWriter.WriteElementString("FunctionARN", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.FunctionARN));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.GrpcConfig != null)
                                {
                                    xmlWriter.WriteStartElement("GrpcConfig");
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.GrpcConfig.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.GrpcConfig.Enabled.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations != null)
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems) 
                                        {
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("LambdaFunctionAssociation");
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.EventType));
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                                xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody.Value));
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
                                    xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.MaxTTL.Value));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                    xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.MinTTL.Value));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetOriginRequestPolicyId())
                                    xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.OriginRequestPolicyId));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                    xmlWriter.WriteElementString("PathPattern", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.PathPattern));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetRealtimeLogConfigArn())
                                    xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.RealtimeLogConfigArn));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetResponseHeadersPolicyId())
                                    xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ResponseHeadersPolicyId));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                    xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming.Value));
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                    xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups != null)
                                {
                                    xmlWriter.WriteStartElement("TrustedKeyGroups");
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled.Value));
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems) 
                                        {
                                            xmlWriter.WriteStartElement("KeyGroup");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null)
                                {
                                    xmlWriter.WriteStartElement("TrustedSigners");
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled.Value));
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                        {
                                            xmlWriter.WriteStartElement("AwsAccountNumber");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                    xmlWriter.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.CacheBehaviors.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.CacheBehaviors.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.DistributionConfig.CallerReference));

                    if(publicRequest.DistributionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.DistributionConfig.Comment));

                    if(publicRequest.DistributionConfig.IsSetConnectionMode())
                        xmlWriter.WriteElementString("ConnectionMode", StringUtils.FromString(publicRequest.DistributionConfig.ConnectionMode));

                    if(publicRequest.DistributionConfig.IsSetContinuousDeploymentPolicyId())
                        xmlWriter.WriteElementString("ContinuousDeploymentPolicyId", StringUtils.FromString(publicRequest.DistributionConfig.ContinuousDeploymentPolicyId));

                    if (publicRequest.DistributionConfig.CustomErrorResponses != null)
                    {
                        xmlWriter.WriteStartElement("CustomErrorResponses");
                        var publicRequestDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfig.CustomErrorResponses.Items;
                        if (publicRequestDistributionConfigCustomErrorResponsesItems != null && (publicRequestDistributionConfigCustomErrorResponsesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigCustomErrorResponsesItems) 
                            {
                            if (publicRequestDistributionConfigCustomErrorResponsesItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("CustomErrorResponse");
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                    xmlWriter.WriteElementString("ErrorCachingMinTTL", StringUtils.FromLong(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL.Value));
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                    xmlWriter.WriteElementString("ErrorCode", StringUtils.FromInt(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCode.Value));
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                    xmlWriter.WriteElementString("ResponseCode", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                    xmlWriter.WriteElementString("ResponsePagePath", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.CustomErrorResponses.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior != null)
                    {
                        xmlWriter.WriteStartElement("DefaultCacheBehavior");
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null)
                        {
                            xmlWriter.WriteStartElement("AllowedMethods");
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null)
                            {
                                xmlWriter.WriteStartElement("CachedMethods");
                                var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                                {
                                    xmlWriter.WriteStartElement("Method");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetCachePolicyId())
                            xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.CachePolicyId));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
                            xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.Compress.Value));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                            xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.DefaultTTL.Value));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                            xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null)
                        {
                            xmlWriter.WriteStartElement("ForwardedValues");
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null)
                            {
                                xmlWriter.WriteStartElement("Cookies");
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                    xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));
                                if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null)
                                {
                                    xmlWriter.WriteStartElement("WhitelistedNames");
                                    var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                    if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null)
                            {
                                xmlWriter.WriteStartElement("Headers");
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                                xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString.Value));
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys != null)
                            {
                                xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations != null)
                        {
                            xmlWriter.WriteStartElement("FunctionAssociations");
                            var publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems) 
                                {
                                if (publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("FunctionAssociation");
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetEventType())
                                        xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.EventType));
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetFunctionARN())
                                        xmlWriter.WriteElementString("FunctionARN", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.FunctionARN));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.GrpcConfig != null)
                        {
                            xmlWriter.WriteStartElement("GrpcConfig");
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.GrpcConfig.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.GrpcConfig.Enabled.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations != null)
                        {
                            xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                            var publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems) 
                                {
                                if (publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociation");
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                        xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.EventType));
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                        xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody.Value));
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                        xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
                            xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.MaxTTL.Value));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                            xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.MinTTL.Value));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetOriginRequestPolicyId())
                            xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.OriginRequestPolicyId));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetRealtimeLogConfigArn())
                            xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.RealtimeLogConfigArn));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetResponseHeadersPolicyId())
                            xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ResponseHeadersPolicyId));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                            xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.SmoothStreaming.Value));
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                            xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.TargetOriginId));
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups != null)
                        {
                            xmlWriter.WriteStartElement("TrustedKeyGroups");
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled.Value));
                            var publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems) 
                                {
                                    xmlWriter.WriteStartElement("KeyGroup");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null)
                        {
                            xmlWriter.WriteStartElement("TrustedSigners");
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled.Value));
                            var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && (publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                            xmlWriter.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetDefaultRootObject())
                        xmlWriter.WriteElementString("DefaultRootObject", StringUtils.FromString(publicRequest.DistributionConfig.DefaultRootObject));

                    if(publicRequest.DistributionConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.Enabled.Value));

                    if(publicRequest.DistributionConfig.IsSetHttpVersion())
                        xmlWriter.WriteElementString("HttpVersion", StringUtils.FromString(publicRequest.DistributionConfig.HttpVersion));

                    if(publicRequest.DistributionConfig.IsSetIsIPV6Enabled())
                        xmlWriter.WriteElementString("IsIPV6Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.IsIPV6Enabled.Value));

                    if (publicRequest.DistributionConfig.Logging != null)
                    {
                        xmlWriter.WriteStartElement("Logging");
                        if(publicRequest.DistributionConfig.Logging.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Bucket));
                        if(publicRequest.DistributionConfig.Logging.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.Enabled.Value));
                        if(publicRequest.DistributionConfig.Logging.IsSetIncludeCookies())
                            xmlWriter.WriteElementString("IncludeCookies", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.IncludeCookies.Value));
                        if(publicRequest.DistributionConfig.Logging.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Prefix));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfig.OriginGroups != null)
                    {
                        xmlWriter.WriteStartElement("OriginGroups");
                        var publicRequestDistributionConfigOriginGroupsItems = publicRequest.DistributionConfig.OriginGroups.Items;
                        if (publicRequestDistributionConfigOriginGroupsItems != null && (publicRequestDistributionConfigOriginGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigOriginGroupsItemsValue in publicRequestDistributionConfigOriginGroupsItems) 
                            {
                            if (publicRequestDistributionConfigOriginGroupsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("OriginGroup");
                                if (publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria != null)
                                {
                                    xmlWriter.WriteStartElement("FailoverCriteria");
                                    if (publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes != null)
                                    {
                                        xmlWriter.WriteStartElement("StatusCodes");
                                        var publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems = publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Items;
                                        if (publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems != null && (publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue in publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems) 
                                            {
                                                xmlWriter.WriteStartElement("StatusCode");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginGroupsItemsValue.IsSetId())
                                    xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestDistributionConfigOriginGroupsItemsValue.Id));
                                if (publicRequestDistributionConfigOriginGroupsItemsValue.Members != null)
                                {
                                    xmlWriter.WriteStartElement("Members");
                                    var publicRequestDistributionConfigOriginGroupsItemsValueMembersItems = publicRequestDistributionConfigOriginGroupsItemsValue.Members.Items;
                                    if (publicRequestDistributionConfigOriginGroupsItemsValueMembersItems != null && (publicRequestDistributionConfigOriginGroupsItemsValueMembersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue in publicRequestDistributionConfigOriginGroupsItemsValueMembersItems) 
                                        {
                                        if (publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("OriginGroupMember");
                                            if(publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue.IsSetOriginId())
                                                xmlWriter.WriteElementString("OriginId", StringUtils.FromString(publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue.OriginId));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigOriginGroupsItemsValue.Members.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigOriginGroupsItemsValue.Members.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginGroupsItemsValue.IsSetSelectionCriteria())
                                    xmlWriter.WriteElementString("SelectionCriteria", StringUtils.FromString(publicRequestDistributionConfigOriginGroupsItemsValue.SelectionCriteria));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.OriginGroups.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.OriginGroups.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfig.Origins != null)
                    {
                        xmlWriter.WriteStartElement("Origins");
                        var publicRequestDistributionConfigOriginsItems = publicRequest.DistributionConfig.Origins.Items;
                        if (publicRequestDistributionConfigOriginsItems != null && (publicRequestDistributionConfigOriginsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigOriginsItemsValue in publicRequestDistributionConfigOriginsItems) 
                            {
                            if (publicRequestDistributionConfigOriginsItemsValue != null)
                            {
                                xmlWriter.WriteStartElement("Origin");
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetConnectionAttempts())
                                    xmlWriter.WriteElementString("ConnectionAttempts", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.ConnectionAttempts.Value));
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                    xmlWriter.WriteElementString("ConnectionTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.ConnectionTimeout.Value));
                                if (publicRequestDistributionConfigOriginsItemsValue.CustomHeaders != null)
                                {
                                    xmlWriter.WriteStartElement("CustomHeaders");
                                    var publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                    if (publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems != null && (publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue in publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems) 
                                        {
                                        if (publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("OriginCustomHeader");
                                            if(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderName())
                                                xmlWriter.WriteElementString("HeaderName", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderName));
                                            if(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderValue())
                                                xmlWriter.WriteElementString("HeaderValue", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderValue));
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig != null)
                                {
                                    xmlWriter.WriteStartElement("CustomOriginConfig");
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                        xmlWriter.WriteElementString("HTTPPort", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                        xmlWriter.WriteElementString("HTTPSPort", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetIpAddressType())
                                        xmlWriter.WriteElementString("IpAddressType", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IpAddressType));
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                        xmlWriter.WriteElementString("OriginKeepaliveTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                        xmlWriter.WriteElementString("OriginProtocolPolicy", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
                                        xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout.Value));
                                    if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols != null)
                                    {
                                        xmlWriter.WriteStartElement("OriginSslProtocols");
                                        var publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                        if (publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems != null && (publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue in publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems) 
                                            {
                                                xmlWriter.WriteStartElement("SslProtocol");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetDomainName())
                                    xmlWriter.WriteElementString("DomainName", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.DomainName));
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetId())
                                    xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.Id));
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetOriginAccessControlId())
                                    xmlWriter.WriteElementString("OriginAccessControlId", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginAccessControlId));
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetOriginPath())
                                    xmlWriter.WriteElementString("OriginPath", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginPath));
                                if (publicRequestDistributionConfigOriginsItemsValue.OriginShield != null)
                                {
                                    xmlWriter.WriteStartElement("OriginShield");
                                    if(publicRequestDistributionConfigOriginsItemsValue.OriginShield.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigOriginsItemsValue.OriginShield.Enabled.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.OriginShield.IsSetOriginShieldRegion())
                                        xmlWriter.WriteElementString("OriginShieldRegion", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginShield.OriginShieldRegion));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetResponseCompletionTimeout())
                                    xmlWriter.WriteElementString("ResponseCompletionTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.ResponseCompletionTimeout.Value));
                                if (publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig != null)
                                {
                                    xmlWriter.WriteStartElement("S3OriginConfig");
                                    if(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                        xmlWriter.WriteElementString("OriginAccessIdentity", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));
                                    if(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginReadTimeout())
                                        xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.OriginReadTimeout.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig != null)
                                {
                                    xmlWriter.WriteStartElement("VpcOriginConfig");
                                    if(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetOriginKeepaliveTimeout())
                                        xmlWriter.WriteElementString("OriginKeepaliveTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.OriginKeepaliveTimeout.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetOriginReadTimeout())
                                        xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.OriginReadTimeout.Value));
                                    if(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetVpcOriginId())
                                        xmlWriter.WriteElementString("VpcOriginId", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.VpcOriginConfig.VpcOriginId));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Origins.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.Origins.Quantity.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetPriceClass())
                        xmlWriter.WriteElementString("PriceClass", StringUtils.FromString(publicRequest.DistributionConfig.PriceClass));

                    if (publicRequest.DistributionConfig.Restrictions != null)
                    {
                        xmlWriter.WriteStartElement("Restrictions");
                        if (publicRequest.DistributionConfig.Restrictions.GeoRestriction != null)
                        {
                            xmlWriter.WriteStartElement("GeoRestriction");
                            var publicRequestDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfig.Restrictions.GeoRestriction.Items;
                            if (publicRequestDistributionConfigRestrictionsGeoRestrictionItems != null && (publicRequestDistributionConfigRestrictionsGeoRestrictionItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigRestrictionsGeoRestrictionItems) 
                                {
                                    xmlWriter.WriteStartElement("Location");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfig.Restrictions.GeoRestriction.Quantity.Value));
                            if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                xmlWriter.WriteElementString("RestrictionType", StringUtils.FromString(publicRequest.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetStaging())
                        xmlWriter.WriteElementString("Staging", StringUtils.FromBool(publicRequest.DistributionConfig.Staging.Value));

                    if (publicRequest.DistributionConfig.TenantConfig != null)
                    {
                        xmlWriter.WriteStartElement("TenantConfig");
                        var publicRequestDistributionConfigTenantConfigParameterDefinitions = publicRequest.DistributionConfig.TenantConfig.ParameterDefinitions;
                        if (publicRequestDistributionConfigTenantConfigParameterDefinitions != null && (publicRequestDistributionConfigTenantConfigParameterDefinitions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                        {
                            xmlWriter.WriteStartElement("ParameterDefinitions");
                            foreach (var publicRequestDistributionConfigTenantConfigParameterDefinitionsValue in publicRequestDistributionConfigTenantConfigParameterDefinitions) 
                            {
                            if (publicRequestDistributionConfigTenantConfigParameterDefinitionsValue != null)
                            {
                                xmlWriter.WriteStartElement("member");
                                if (publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition != null)
                                {
                                    xmlWriter.WriteStartElement("Definition");
                                    if (publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema != null)
                                    {
                                        xmlWriter.WriteStartElement("StringSchema");
                                        if(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetComment())
                                            xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.Comment));
                                        if(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetDefaultValue())
                                            xmlWriter.WriteElementString("DefaultValue", StringUtils.FromString(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.DefaultValue));
                                        if(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetRequired())
                                            xmlWriter.WriteElementString("Required", StringUtils.FromBool(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.Required.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.IsSetName())
                                    xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestDistributionConfigTenantConfigParameterDefinitionsValue.Name));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfig.ViewerCertificate != null)
                    {
                        xmlWriter.WriteStartElement("ViewerCertificate");
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                            xmlWriter.WriteElementString("ACMCertificateArn", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.ACMCertificateArn));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCertificate())
                            xmlWriter.WriteElementString("Certificate", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.Certificate));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                            xmlWriter.WriteElementString("CertificateSource", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.CertificateSource));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                            xmlWriter.WriteElementString("CloudFrontDefaultCertificate", StringUtils.FromBool(publicRequest.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate.Value));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                            xmlWriter.WriteElementString("IAMCertificateId", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.IAMCertificateId));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                            xmlWriter.WriteElementString("MinimumProtocolVersion", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                            xmlWriter.WriteElementString("SSLSupportMethod", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.SSLSupportMethod));
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetWebACLId())
                        xmlWriter.WriteElementString("WebACLId", StringUtils.FromString(publicRequest.DistributionConfig.WebACLId));


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
        private static CreateDistributionRequestMarshaller _instance = new CreateDistributionRequestMarshaller();        

        internal static CreateDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateDistributionRequest publicRequest);
    }    
}