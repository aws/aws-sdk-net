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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDistributionWithTags Request Marshaller
    /// </summary>       
    public class CreateDistributionWithTagsRequestMarshaller : IMarshaller<IRequest, CreateDistributionWithTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            request.HttpMethod = "POST";
            request.AddSubResource("WithTags");
            request.ResourcePath = "/2020-05-31/distribution";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetDistributionConfigWithTags())
                {
                    xmlWriter.WriteStartElement("DistributionConfigWithTags", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig != null) 
                    {
                        xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases != null) 
                        {
                            xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems) 
                                {
                                    xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors != null) 
                        {
                            xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems) 
                                {
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null) 
                                    {
                                        xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null) 
                                        {
                                            xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                            {
                                                xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCachePolicyId())
                                        xmlWriter.WriteElementString("CachePolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.CachePolicyId));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
                                        xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.Compress));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                        xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.DefaultTTL));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                        xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null) 
                                    {
                                        xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null) 
                                        {
                                            xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                                xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));                 
                            
                                            
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null) 
                                            {
                                                xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                                var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                                {                        
                                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                                    {
                                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                        xmlWriter.WriteEndElement();
                                                    }            
                                                    xmlWriter.WriteEndElement();            
                                                }
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                                
                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null) 
                                        {
                                            xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                            xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString));                 
                        
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys != null) 
                                        {
                                            xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations != null) 
                                    {
                                        xmlWriter.WriteStartElement("FunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems) 
                                            {
                                            
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue != null) 
                                            {
                                                xmlWriter.WriteStartElement("FunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetEventType())
                                                    xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.EventType));                 
                                
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetFunctionARN())
                                                    xmlWriter.WriteElementString("FunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.FunctionARN));                 
                                
                                                xmlWriter.WriteEndElement();
                                            }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations != null) 
                                    {
                                        xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems) 
                                            {
                                            
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue != null) 
                                            {
                                                xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                    xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.EventType));                 
                                
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                                    xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody));                 
                                
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                    xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                                
                                                xmlWriter.WriteEndElement();
                                            }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
                                        xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MaxTTL));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MinTTL));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetOriginRequestPolicyId())
                                        xmlWriter.WriteElementString("OriginRequestPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.OriginRequestPolicyId));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                        xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.PathPattern));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetRealtimeLogConfigArn())
                                        xmlWriter.WriteElementString("RealtimeLogConfigArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.RealtimeLogConfigArn));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetResponseHeadersPolicyId())
                                        xmlWriter.WriteElementString("ResponseHeadersPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ResponseHeadersPolicyId));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                        xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                        xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups != null) 
                                    {
                                        xmlWriter.WriteStartElement("TrustedKeyGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetEnabled())
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled));                 
                        
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems) 
                                            {
                                                xmlWriter.WriteStartElement("KeyGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null) 
                                    {
                                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled));                 
                        
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                            {
                                                xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                        xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCallerReference())
                            xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.CallerReference));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetComment())
                            xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Comment));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetContinuousDeploymentPolicyId())
                            xmlWriter.WriteElementString("ContinuousDeploymentPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ContinuousDeploymentPolicyId));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses != null) 
                        {
                            xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems) 
                                {
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                        xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                        xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCode));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                        xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                        xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior != null) 
                        {
                            xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null) 
                                {
                                    xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCachePolicyId())
                                xmlWriter.WriteElementString("CachePolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.CachePolicyId));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
                                xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.Compress));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                                xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.DefaultTTL));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                                xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));                 
            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null) 
                            {
                                xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null) 
                                {
                                    xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                        xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));                 
                    
                                    
                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null) 
                                    {
                                        xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null) 
                                {
                                    xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString));                 
                
                                
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys != null) 
                                {
                                    xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations != null) 
                            {
                                xmlWriter.WriteStartElement("FunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems) 
                                    {
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue != null) 
                                    {
                                        xmlWriter.WriteStartElement("FunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetEventType())
                                            xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.EventType));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetFunctionARN())
                                            xmlWriter.WriteElementString("FunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.FunctionARN));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations != null) 
                            {
                                xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems) 
                                    {
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue != null) 
                                    {
                                        xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                            xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.EventType));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                            xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                            xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
                                xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MaxTTL));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MinTTL));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetOriginRequestPolicyId())
                                xmlWriter.WriteElementString("OriginRequestPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.OriginRequestPolicyId));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetRealtimeLogConfigArn())
                                xmlWriter.WriteElementString("RealtimeLogConfigArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.RealtimeLogConfigArn));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetResponseHeadersPolicyId())
                                xmlWriter.WriteElementString("ResponseHeadersPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ResponseHeadersPolicyId));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                                xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.SmoothStreaming));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                                xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TargetOriginId));                 
            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedKeyGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled));                 
                
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems) 
                                    {
                                        xmlWriter.WriteStartElement("KeyGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled));                 
                
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                                    {
                                        xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                                xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetDefaultRootObject())
                            xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultRootObject));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Enabled));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetHttpVersion())
                            xmlWriter.WriteElementString("HttpVersion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.HttpVersion));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetIsIPV6Enabled())
                            xmlWriter.WriteElementString("IsIPV6Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.IsIPV6Enabled));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Logging != null) 
                        {
                            xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Bucket));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Enabled));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetIncludeCookies())
                                xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IncludeCookies));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Prefix));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups != null) 
                        {
                            xmlWriter.WriteStartElement("OriginGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems) 
                                {
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("OriginGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria != null) 
                                    {
                                        xmlWriter.WriteStartElement("FailoverCriteria", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes != null) 
                                        {
                                            xmlWriter.WriteStartElement("StatusCodes", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems) 
                                                {
                                                    xmlWriter.WriteStartElement("StatusCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetId())
                                        xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Id));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members != null) 
                                    {
                                        xmlWriter.WriteStartElement("Members", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems) 
                                            {
                                            
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue != null) 
                                            {
                                                xmlWriter.WriteStartElement("OriginGroupMember", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue.IsSetOriginId())
                                                    xmlWriter.WriteElementString("OriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItemsValue.OriginId));                 
                                
                                                xmlWriter.WriteEndElement();
                                            }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Origins != null) 
                        {
                            xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems) 
                                {
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionAttempts())
                                        xmlWriter.WriteElementString("ConnectionAttempts", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionAttempts));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                        xmlWriter.WriteElementString("ConnectionTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionTimeout));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders != null) 
                                    {
                                        xmlWriter.WriteStartElement("CustomHeaders", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems) 
                                            {
                                            
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue != null) 
                                            {
                                                xmlWriter.WriteStartElement("OriginCustomHeader", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderName())
                                                    xmlWriter.WriteElementString("HeaderName", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderName));                 
                                
                                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderValue())
                                                    xmlWriter.WriteElementString("HeaderValue", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderValue));                 
                                
                                                xmlWriter.WriteEndElement();
                                            }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig != null) 
                                    {
                                        xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                            xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                            xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                            xmlWriter.WriteElementString("OriginKeepaliveTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                            xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
                                            xmlWriter.WriteElementString("OriginReadTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout));                 
                        
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols != null) 
                                        {
                                            xmlWriter.WriteStartElement("OriginSslProtocols", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems) 
                                                {
                                                    xmlWriter.WriteStartElement("SslProtocol", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetDomainName())
                                        xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.DomainName));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetId())
                                        xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.Id));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginAccessControlId())
                                        xmlWriter.WriteElementString("OriginAccessControlId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginAccessControlId));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginPath())
                                        xmlWriter.WriteElementString("OriginPath", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginPath));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield != null) 
                                    {
                                        xmlWriter.WriteStartElement("OriginShield", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetEnabled())
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.Enabled));                 
                        
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetOriginShieldRegion())
                                            xmlWriter.WriteElementString("OriginShieldRegion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.OriginShieldRegion));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig != null) 
                                    {
                                        xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                            xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetPriceClass())
                            xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.PriceClass));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions != null) 
                        {
                            xmlWriter.WriteStartElement("Restrictions", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction != null) 
                            {
                                xmlWriter.WriteStartElement("GeoRestriction", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems != null && publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems) 
                                    {
                                        xmlWriter.WriteStartElement("Location", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Quantity));                 
                
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                    xmlWriter.WriteElementString("RestrictionType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetStaging())
                            xmlWriter.WriteElementString("Staging", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Staging));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate != null) 
                        {
                            xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                                xmlWriter.WriteElementString("ACMCertificateArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.ACMCertificateArn));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificate())
                                xmlWriter.WriteElementString("Certificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.Certificate));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                                xmlWriter.WriteElementString("CertificateSource", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CertificateSource));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                                xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                                xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IAMCertificateId));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                                xmlWriter.WriteElementString("MinimumProtocolVersion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                                xmlWriter.WriteElementString("SSLSupportMethod", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.SSLSupportMethod));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetWebACLId())
                            xmlWriter.WriteElementString("WebACLId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.WebACLId));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfigWithTags.Tags != null) 
                    {
                        xmlWriter.WriteStartElement("Tags", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigWithTagsTagsItems = publicRequest.DistributionConfigWithTags.Tags.Items;
                        if (publicRequestDistributionConfigWithTagsTagsItems != null && publicRequestDistributionConfigWithTagsTagsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigWithTagsTagsItemsValue in publicRequestDistributionConfigWithTagsTagsItems) 
                            {
                            
                            if (publicRequestDistributionConfigWithTagsTagsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("Tag", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Key));                 
                
                                if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Value));                 
                
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

    }    
}