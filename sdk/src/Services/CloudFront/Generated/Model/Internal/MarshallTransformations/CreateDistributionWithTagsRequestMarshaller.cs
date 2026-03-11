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
    /// CreateDistributionWithTags Request Marshaller
    /// </summary>       
    public partial class CreateDistributionWithTagsRequestMarshaller : IMarshaller<IRequest, CreateDistributionWithTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDistributionWithTagsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDistributionWithTagsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.AddSubResource("WithTags");
            request.ResourcePath = "/2020-05-31/distribution";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetDistributionConfigWithTags())
                {
                    xmlWriter.WriteStartElement("DistributionConfigWithTags", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    if (publicRequest.DistributionConfigWithTags.IsSetDistributionConfig())
                    {
                        xmlWriter.WriteStartElement("DistributionConfig");
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetAliases())
                        {
                            xmlWriter.WriteStartElement("Aliases");
                            var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Items;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.IsSetItems()) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems) 
                                {
                                    xmlWriter.WriteStartElement("CNAME");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetAnycastIpListId())
                            xmlWriter.WriteElementString("AnycastIpListId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.AnycastIpListId));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCacheBehaviors())
                        {
                            xmlWriter.WriteStartElement("CacheBehaviors");
                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Items;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.IsSetItems()) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems) 
                                {
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("CacheBehavior");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetAllowedMethods())
                                        {
                                            xmlWriter.WriteStartElement("AllowedMethods");
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetCachedMethods())
                                            {
                                                xmlWriter.WriteStartElement("CachedMethods");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetItems()) 
                                                {
                                                    xmlWriter.WriteStartElement("Items");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("Method");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Method");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCachePolicyId())
                                            xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.CachePolicyId));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
                                            xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.Compress.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                            xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.DefaultTTL.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                            xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetForwardedValues())
                                        {
                                            xmlWriter.WriteStartElement("ForwardedValues");
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetCookies())
                                            {
                                                xmlWriter.WriteStartElement("Cookies");
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                                    xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetWhitelistedNames())
                                                {
                                                    xmlWriter.WriteStartElement("WhitelistedNames");
                                                    var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetItems()) 
                                                    {
                                                        xmlWriter.WriteStartElement("Items");
                                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                                        {
                                                            xmlWriter.WriteStartElement("Name");
                                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                            xmlWriter.WriteEndElement();
                                                        }            
                                                        xmlWriter.WriteEndElement();            
                                                    }
                                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));
                                                    xmlWriter.WriteEndElement();
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetHeaders())
                                            {
                                                xmlWriter.WriteStartElement("Headers");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetItems()) 
                                                {
                                                    xmlWriter.WriteStartElement("Items");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("Name");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                                xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString.Value));
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryStringCacheKeys())
                                            {
                                                xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetItems()) 
                                                {
                                                    xmlWriter.WriteStartElement("Items");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("Name");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetFunctionAssociations())
                                        {
                                            xmlWriter.WriteStartElement("FunctionAssociations");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems) 
                                                {
                                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue != null)
                                                    {
                                                        xmlWriter.WriteStartElement("FunctionAssociation");
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetEventType())
                                                            xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.EventType));
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetFunctionARN())
                                                            xmlWriter.WriteElementString("FunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.FunctionARN));
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetGrpcConfig())
                                        {
                                            xmlWriter.WriteStartElement("GrpcConfig");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.GrpcConfig.IsSetEnabled())
                                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.GrpcConfig.Enabled.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetLambdaFunctionAssociations())
                                        {
                                            xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems) 
                                                {
                                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue != null)
                                                    {
                                                        xmlWriter.WriteStartElement("LambdaFunctionAssociation");
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                            xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.EventType));
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                                            xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody.Value));
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                            xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
                                            xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MaxTTL.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                            xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MinTTL.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetOriginRequestPolicyId())
                                            xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.OriginRequestPolicyId));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                            xmlWriter.WriteElementString("PathPattern", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.PathPattern));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetRealtimeLogConfigArn())
                                            xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.RealtimeLogConfigArn));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetResponseHeadersPolicyId())
                                            xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ResponseHeadersPolicyId));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                            xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                            xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTrustedKeyGroups())
                                        {
                                            xmlWriter.WriteStartElement("TrustedKeyGroups");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetEnabled())
                                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled.Value));
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems) 
                                                {
                                                    xmlWriter.WriteStartElement("KeyGroup");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTrustedSigners())
                                        {
                                            xmlWriter.WriteStartElement("TrustedSigners");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled.Value));
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                                {
                                                    xmlWriter.WriteStartElement("AwsAccountNumber");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                            xmlWriter.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCallerReference())
                            xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.CallerReference));
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetComment())
                            xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Comment));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetConnectionFunctionAssociation())
                        {
                            xmlWriter.WriteStartElement("ConnectionFunctionAssociation");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ConnectionFunctionAssociation.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ConnectionFunctionAssociation.Id));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetConnectionMode())
                            xmlWriter.WriteElementString("ConnectionMode", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ConnectionMode));
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetContinuousDeploymentPolicyId())
                            xmlWriter.WriteElementString("ContinuousDeploymentPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ContinuousDeploymentPolicyId));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCustomErrorResponses())
                        {
                            xmlWriter.WriteStartElement("CustomErrorResponses");
                            var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Items;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.IsSetItems()) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems) 
                                {
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("CustomErrorResponse");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                            xmlWriter.WriteElementString("ErrorCachingMinTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                            xmlWriter.WriteElementString("ErrorCode", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCode.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                            xmlWriter.WriteElementString("ResponseCode", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                            xmlWriter.WriteElementString("ResponsePagePath", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetDefaultCacheBehavior())
                        {
                            xmlWriter.WriteStartElement("DefaultCacheBehavior");
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetAllowedMethods())
                            {
                                xmlWriter.WriteStartElement("AllowedMethods");
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetCachedMethods())
                                {
                                    xmlWriter.WriteStartElement("CachedMethods");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetItems()) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCachePolicyId())
                                xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.CachePolicyId));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
                                xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.Compress.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                                xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.DefaultTTL.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                                xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetForwardedValues())
                            {
                                xmlWriter.WriteStartElement("ForwardedValues");
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetCookies())
                                {
                                    xmlWriter.WriteStartElement("Cookies");
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                        xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));
                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetWhitelistedNames())
                                    {
                                        xmlWriter.WriteStartElement("WhitelistedNames");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetItems()) 
                                        {
                                            xmlWriter.WriteStartElement("Items");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetHeaders())
                                {
                                    xmlWriter.WriteStartElement("Headers");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetItems()) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                                    xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString.Value));
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryStringCacheKeys())
                                {
                                    xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetItems()) 
                                    {
                                        xmlWriter.WriteStartElement("Items");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity.Value));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetFunctionAssociations())
                            {
                                xmlWriter.WriteStartElement("FunctionAssociations");
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems) 
                                    {
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("FunctionAssociation");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.EventType));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetFunctionARN())
                                                xmlWriter.WriteElementString("FunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.FunctionARN));
                                            xmlWriter.WriteEndElement();
                                        }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetGrpcConfig())
                            {
                                xmlWriter.WriteStartElement("GrpcConfig");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.GrpcConfig.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.GrpcConfig.Enabled.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetLambdaFunctionAssociations())
                            {
                                xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems) 
                                    {
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue != null)
                                        {
                                            xmlWriter.WriteStartElement("LambdaFunctionAssociation");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.EventType));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                                xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));
                                            xmlWriter.WriteEndElement();
                                        }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
                                xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MaxTTL.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MinTTL.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetOriginRequestPolicyId())
                                xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.OriginRequestPolicyId));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetRealtimeLogConfigArn())
                                xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.RealtimeLogConfigArn));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetResponseHeadersPolicyId())
                                xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ResponseHeadersPolicyId));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                                xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.SmoothStreaming.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                                xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TargetOriginId));
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTrustedKeyGroups())
                            {
                                xmlWriter.WriteStartElement("TrustedKeyGroups");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled.Value));
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems) 
                                    {
                                        xmlWriter.WriteStartElement("KeyGroup");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTrustedSigners())
                            {
                                xmlWriter.WriteStartElement("TrustedSigners");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled.Value));
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                                    {
                                        xmlWriter.WriteStartElement("AwsAccountNumber");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                                xmlWriter.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetDefaultRootObject())
                            xmlWriter.WriteElementString("DefaultRootObject", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultRootObject));
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Enabled.Value));
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetHttpVersion())
                            xmlWriter.WriteElementString("HttpVersion", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.HttpVersion));
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetIsIPV6Enabled())
                            xmlWriter.WriteElementString("IsIPV6Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.IsIPV6Enabled.Value));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetLogging())
                        {
                            xmlWriter.WriteStartElement("Logging");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Bucket));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Enabled.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetIncludeCookies())
                                xmlWriter.WriteElementString("IncludeCookies", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IncludeCookies.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Prefix));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetOriginGroups())
                        {
                            xmlWriter.WriteStartElement("OriginGroups");
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Items;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.IsSetItems()) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems) 
                                {
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("OriginGroup");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetFailoverCriteria())
                                        {
                                            xmlWriter.WriteStartElement("FailoverCriteria");
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.IsSetStatusCodes())
                                            {
                                                xmlWriter.WriteStartElement("StatusCodes");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.IsSetItems()) 
                                                {
                                                    xmlWriter.WriteStartElement("Items");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("StatusCode");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetId())
                                            xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Id));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetMembers())
                                        {
                                            xmlWriter.WriteStartElement("Members");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems) 
                                                {
                                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue != null)
                                                    {
                                                        xmlWriter.WriteStartElement("OriginGroupMember");
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue.IsSetOriginId())
                                                            xmlWriter.WriteElementString("OriginId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue.OriginId));
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetSelectionCriteria())
                                            xmlWriter.WriteElementString("SelectionCriteria", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.SelectionCriteria));
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetOrigins())
                        {
                            xmlWriter.WriteStartElement("Origins");
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Items;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.IsSetItems()) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems) 
                                {
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("Origin");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionAttempts())
                                            xmlWriter.WriteElementString("ConnectionAttempts", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionAttempts.Value));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                            xmlWriter.WriteElementString("ConnectionTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionTimeout.Value));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetCustomHeaders())
                                        {
                                            xmlWriter.WriteStartElement("CustomHeaders");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.IsSetItems()) 
                                            {
                                                xmlWriter.WriteStartElement("Items");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems) 
                                                {
                                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue != null)
                                                    {
                                                        xmlWriter.WriteStartElement("OriginCustomHeader");
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderName())
                                                            xmlWriter.WriteElementString("HeaderName", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderName));
                                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderValue())
                                                            xmlWriter.WriteElementString("HeaderValue", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderValue));
                                                        xmlWriter.WriteEndElement();
                                                    }
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Quantity.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetCustomOriginConfig())
                                        {
                                            xmlWriter.WriteStartElement("CustomOriginConfig");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                                xmlWriter.WriteElementString("HTTPPort", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                                xmlWriter.WriteElementString("HTTPSPort", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetIpAddressType())
                                                xmlWriter.WriteElementString("IpAddressType", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IpAddressType));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                                xmlWriter.WriteElementString("OriginKeepaliveTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout.Value));
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginMtlsConfig())
                                            {
                                                xmlWriter.WriteStartElement("OriginMtlsConfig");
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginMtlsConfig.IsSetClientCertificateArn())
                                                    xmlWriter.WriteElementString("ClientCertificateArn", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginMtlsConfig.ClientCertificateArn));
                                                xmlWriter.WriteEndElement();
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                                xmlWriter.WriteElementString("OriginProtocolPolicy", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
                                                xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout.Value));
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginSslProtocols())
                                            {
                                                xmlWriter.WriteStartElement("OriginSslProtocols");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetItems()) 
                                                {
                                                    xmlWriter.WriteStartElement("Items");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("SslProtocol");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetDomainName())
                                            xmlWriter.WriteElementString("DomainName", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.DomainName));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetId())
                                            xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.Id));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginAccessControlId())
                                            xmlWriter.WriteElementString("OriginAccessControlId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginAccessControlId));
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginPath())
                                            xmlWriter.WriteElementString("OriginPath", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginPath));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginShield())
                                        {
                                            xmlWriter.WriteStartElement("OriginShield");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetEnabled())
                                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.Enabled.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetOriginShieldRegion())
                                                xmlWriter.WriteElementString("OriginShieldRegion", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.OriginShieldRegion));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetResponseCompletionTimeout())
                                            xmlWriter.WriteElementString("ResponseCompletionTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ResponseCompletionTimeout.Value));
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetS3OriginConfig())
                                        {
                                            xmlWriter.WriteStartElement("S3OriginConfig");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                                xmlWriter.WriteElementString("OriginAccessIdentity", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginReadTimeout())
                                                xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.OriginReadTimeout.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetVpcOriginConfig())
                                        {
                                            xmlWriter.WriteStartElement("VpcOriginConfig");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetOriginKeepaliveTimeout())
                                                xmlWriter.WriteElementString("OriginKeepaliveTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.OriginKeepaliveTimeout.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetOriginReadTimeout())
                                                xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.OriginReadTimeout.Value));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetOwnerAccountId())
                                                xmlWriter.WriteElementString("OwnerAccountId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.OwnerAccountId));
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.IsSetVpcOriginId())
                                                xmlWriter.WriteElementString("VpcOriginId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.VpcOriginConfig.VpcOriginId));
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Quantity.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetPriceClass())
                            xmlWriter.WriteElementString("PriceClass", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.PriceClass));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetRestrictions())
                        {
                            xmlWriter.WriteStartElement("Restrictions");
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.IsSetGeoRestriction())
                            {
                                xmlWriter.WriteStartElement("GeoRestriction");
                                var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Items;
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetItems()) 
                                {
                                    xmlWriter.WriteStartElement("Items");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems) 
                                    {
                                        xmlWriter.WriteStartElement("Location");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Quantity.Value));
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                    xmlWriter.WriteElementString("RestrictionType", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetStaging())
                            xmlWriter.WriteElementString("Staging", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Staging.Value));
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetTenantConfig())
                        {
                            xmlWriter.WriteStartElement("TenantConfig");
                            var publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitions = publicRequest.DistributionConfigWithTags.DistributionConfig.TenantConfig.ParameterDefinitions;
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.TenantConfig.IsSetParameterDefinitions()) 
                            {
                                xmlWriter.WriteStartElement("ParameterDefinitions");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue in publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitions) 
                                {
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.IsSetDefinition())
                                        {
                                            xmlWriter.WriteStartElement("Definition");
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.IsSetStringSchema())
                                            {
                                                xmlWriter.WriteStartElement("StringSchema");
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetComment())
                                                    xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.Comment));
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetDefaultValue())
                                                    xmlWriter.WriteElementString("DefaultValue", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.DefaultValue));
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.IsSetRequired())
                                                    xmlWriter.WriteElementString("Required", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Definition.StringSchema.Required.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.IsSetName())
                                            xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigTenantConfigParameterDefinitionsValue.Name));
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetViewerCertificate())
                        {
                            xmlWriter.WriteStartElement("ViewerCertificate");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                                xmlWriter.WriteElementString("ACMCertificateArn", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.ACMCertificateArn));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificate())
                                xmlWriter.WriteElementString("Certificate", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.Certificate));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                                xmlWriter.WriteElementString("CertificateSource", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CertificateSource));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                                xmlWriter.WriteElementString("CloudFrontDefaultCertificate", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate.Value));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                                xmlWriter.WriteElementString("IAMCertificateId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IAMCertificateId));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                                xmlWriter.WriteElementString("MinimumProtocolVersion", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                                xmlWriter.WriteElementString("SSLSupportMethod", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.SSLSupportMethod));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetViewerMtlsConfig())
                        {
                            xmlWriter.WriteStartElement("ViewerMtlsConfig");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.IsSetMode())
                                xmlWriter.WriteElementString("Mode", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.Mode));
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.IsSetTrustStoreConfig())
                            {
                                xmlWriter.WriteStartElement("TrustStoreConfig");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.IsSetAdvertiseTrustStoreCaNames())
                                    xmlWriter.WriteElementString("AdvertiseTrustStoreCaNames", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.AdvertiseTrustStoreCaNames.Value));
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.IsSetIgnoreCertificateExpiry())
                                    xmlWriter.WriteElementString("IgnoreCertificateExpiry", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.IgnoreCertificateExpiry.Value));
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.IsSetTrustStoreId())
                                    xmlWriter.WriteElementString("TrustStoreId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerMtlsConfig.TrustStoreConfig.TrustStoreId));
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetWebACLId())
                            xmlWriter.WriteElementString("WebACLId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.WebACLId));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfigWithTags.IsSetTags())
                    {
                        xmlWriter.WriteStartElement("Tags");
                        var publicRequestDistributionConfigWithTagsTagsItems = publicRequest.DistributionConfigWithTags.Tags.Items;
                        if (publicRequest.DistributionConfigWithTags.Tags.IsSetItems()) 
                        {
                            xmlWriter.WriteStartElement("Items");
                            foreach (var publicRequestDistributionConfigWithTagsTagsItemsValue in publicRequestDistributionConfigWithTagsTagsItems) 
                            {
                                if (publicRequestDistributionConfigWithTagsTagsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Tag");
                                    if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetKey())
                                        xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Key));
                                    if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetValue())
                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Value));
                                    xmlWriter.WriteEndElement();
                                }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
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
        private static CreateDistributionWithTagsRequestMarshaller _instance = new CreateDistributionWithTagsRequestMarshaller();        

        internal static CreateDistributionWithTagsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDistributionWithTagsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateDistributionWithTagsRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CreateDistributionWithTagsRequest publicRequest);
    }    
}