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
    /// UpdateDistribution Request Marshaller
    /// </summary>       
    public class UpdateDistributionRequestMarshaller : IMarshaller<IRequest, UpdateDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
            if (!publicRequest.IsSetId())
                throw new AmazonCloudFrontException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2020-05-31/distribution/{Id}/config";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetDistributionConfig())
                {
                    xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                    
                    if (publicRequest.DistributionConfig.Aliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigAliasesItems = publicRequest.DistributionConfig.Aliases.Items;
                        if (publicRequestDistributionConfigAliasesItems != null && publicRequestDistributionConfigAliasesItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigAliasesItemsValue in publicRequestDistributionConfigAliasesItems) 
                            {
                                xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigAliasesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Aliases.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.Aliases.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.CacheBehaviors != null) 
                    {
                        xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfig.CacheBehaviors.Items;
                        if (publicRequestDistributionConfigCacheBehaviorsItems != null && publicRequestDistributionConfigCacheBehaviorsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigCacheBehaviorsItems) 
                            {
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null) 
                                {
                                    xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null) 
                                    {
                                        xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                            {
                                                xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetCachePolicyId())
                                    xmlWriter.WriteElementString("CachePolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.CachePolicyId));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
                                    xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.Compress));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                    xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.DefaultTTL));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                    xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));                 
                
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null) 
                                {
                                    xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null) 
                                    {
                                        xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                            xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));                 
                        
                                        
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null) 
                                        {
                                            xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                            if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null) 
                                    {
                                        xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                        xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString));                 
                    
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys != null) 
                                    {
                                        xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations != null) 
                                {
                                    xmlWriter.WriteStartElement("FunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("FunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.EventType));                 
                            
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.IsSetFunctionARN())
                                                xmlWriter.WriteElementString("FunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItemsValue.FunctionARN));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations != null) 
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.EventType));                 
                            
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                                xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody));                 
                            
                                            if(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
                                    xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.MaxTTL));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                    xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.MinTTL));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetOriginRequestPolicyId())
                                    xmlWriter.WriteElementString("OriginRequestPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.OriginRequestPolicyId));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                    xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.PathPattern));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetRealtimeLogConfigArn())
                                    xmlWriter.WriteElementString("RealtimeLogConfigArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.RealtimeLogConfigArn));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetResponseHeadersPolicyId())
                                    xmlWriter.WriteElementString("ResponseHeadersPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ResponseHeadersPolicyId));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                    xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming));                 
                
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                    xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));                 
                
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups != null) 
                                {
                                    xmlWriter.WriteStartElement("TrustedKeyGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled));                 
                    
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems) 
                                        {
                                            xmlWriter.WriteStartElement("KeyGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null) 
                                {
                                    xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled));                 
                    
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                        {
                                            xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                    xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.CacheBehaviors.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.CacheBehaviors.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.CallerReference));                    
    
                    if(publicRequest.DistributionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.Comment));                    
    
                    if(publicRequest.DistributionConfig.IsSetContinuousDeploymentPolicyId())
                        xmlWriter.WriteElementString("ContinuousDeploymentPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ContinuousDeploymentPolicyId));                    
    
                    
                    if (publicRequest.DistributionConfig.CustomErrorResponses != null) 
                    {
                        xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfig.CustomErrorResponses.Items;
                        if (publicRequestDistributionConfigCustomErrorResponsesItems != null && publicRequestDistributionConfigCustomErrorResponsesItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigCustomErrorResponsesItems) 
                            {
                            
                            if (publicRequestDistributionConfigCustomErrorResponsesItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                    xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL));                 
                
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                    xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCode));                 
                
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                    xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));                 
                
                                if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                    xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.CustomErrorResponses.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior != null) 
                    {
                        xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null) 
                        {
                            xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                                {
                                    xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetCachePolicyId())
                            xmlWriter.WriteElementString("CachePolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.CachePolicyId));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
                            xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.Compress));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                            xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.DefaultTTL));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                            xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));                 
        
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null) 
                        {
                            xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null) 
                            {
                                xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                    xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));                 
                
                                
                                if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null) 
                                {
                                    xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                    if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null) 
                            {
                                xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                                xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString));                 
            
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys != null) 
                            {
                                xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations != null) 
                        {
                            xmlWriter.WriteStartElement("FunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems) 
                                {
                                
                                if (publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("FunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetEventType())
                                        xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.EventType));                 
                    
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.IsSetFunctionARN())
                                        xmlWriter.WriteElementString("FunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorFunctionAssociationsItemsValue.FunctionARN));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations != null) 
                        {
                            xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems) 
                                {
                                
                                if (publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                        xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.EventType));                 
                    
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetIncludeBody())
                                        xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody));                 
                    
                                    if(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                        xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
                            xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.MaxTTL));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                            xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.MinTTL));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetOriginRequestPolicyId())
                            xmlWriter.WriteElementString("OriginRequestPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.OriginRequestPolicyId));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetRealtimeLogConfigArn())
                            xmlWriter.WriteElementString("RealtimeLogConfigArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.RealtimeLogConfigArn));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetResponseHeadersPolicyId())
                            xmlWriter.WriteElementString("ResponseHeadersPolicyId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ResponseHeadersPolicyId));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                            xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.SmoothStreaming));                 
        
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                            xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.TargetOriginId));                 
        
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups != null) 
                        {
                            xmlWriter.WriteStartElement("TrustedKeyGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled));                 
            
                            var publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems) 
                                {
                                    xmlWriter.WriteStartElement("KeyGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null) 
                        {
                            xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled));                 
            
                            var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                            xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetDefaultRootObject())
                        xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultRootObject));                    
    
                    if(publicRequest.DistributionConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.Enabled));                    
    
                    if(publicRequest.DistributionConfig.IsSetHttpVersion())
                        xmlWriter.WriteElementString("HttpVersion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.HttpVersion));                    
    
                    if(publicRequest.DistributionConfig.IsSetIsIPV6Enabled())
                        xmlWriter.WriteElementString("IsIPV6Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.IsIPV6Enabled));                    
    
                    
                    if (publicRequest.DistributionConfig.Logging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        if(publicRequest.DistributionConfig.Logging.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Bucket));                 
        
                        if(publicRequest.DistributionConfig.Logging.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.Enabled));                 
        
                        if(publicRequest.DistributionConfig.Logging.IsSetIncludeCookies())
                            xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.IncludeCookies));                 
        
                        if(publicRequest.DistributionConfig.Logging.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Prefix));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.OriginGroups != null) 
                    {
                        xmlWriter.WriteStartElement("OriginGroups", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigOriginGroupsItems = publicRequest.DistributionConfig.OriginGroups.Items;
                        if (publicRequestDistributionConfigOriginGroupsItems != null && publicRequestDistributionConfigOriginGroupsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigOriginGroupsItemsValue in publicRequestDistributionConfigOriginGroupsItems) 
                            {
                            
                            if (publicRequestDistributionConfigOriginGroupsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("OriginGroup", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                
                                if (publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria != null) 
                                {
                                    xmlWriter.WriteStartElement("FailoverCriteria", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    
                                    if (publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes != null) 
                                    {
                                        xmlWriter.WriteStartElement("StatusCodes", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems = publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Items;
                                        if (publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems != null && publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue in publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems) 
                                            {
                                                xmlWriter.WriteStartElement("StatusCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginGroupsItemsValue.IsSetId())
                                    xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginGroupsItemsValue.Id));                 
                
                                
                                if (publicRequestDistributionConfigOriginGroupsItemsValue.Members != null) 
                                {
                                    xmlWriter.WriteStartElement("Members", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigOriginGroupsItemsValueMembersItems = publicRequestDistributionConfigOriginGroupsItemsValue.Members.Items;
                                    if (publicRequestDistributionConfigOriginGroupsItemsValueMembersItems != null && publicRequestDistributionConfigOriginGroupsItemsValueMembersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue in publicRequestDistributionConfigOriginGroupsItemsValueMembersItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("OriginGroupMember", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            if(publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue.IsSetOriginId())
                                                xmlWriter.WriteElementString("OriginId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginGroupsItemsValueMembersItemsValue.OriginId));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigOriginGroupsItemsValue.Members.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginGroupsItemsValue.Members.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.OriginGroups.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.OriginGroups.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.Origins != null) 
                    {
                        xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestDistributionConfigOriginsItems = publicRequest.DistributionConfig.Origins.Items;
                        if (publicRequestDistributionConfigOriginsItems != null && publicRequestDistributionConfigOriginsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestDistributionConfigOriginsItemsValue in publicRequestDistributionConfigOriginsItems) 
                            {
                            
                            if (publicRequestDistributionConfigOriginsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetConnectionAttempts())
                                    xmlWriter.WriteElementString("ConnectionAttempts", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.ConnectionAttempts));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                    xmlWriter.WriteElementString("ConnectionTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.ConnectionTimeout));                 
                
                                
                                if (publicRequestDistributionConfigOriginsItemsValue.CustomHeaders != null) 
                                {
                                    xmlWriter.WriteStartElement("CustomHeaders", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    var publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                    if (publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems != null && publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                        foreach (var publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue in publicRequestDistributionConfigOriginsItemsValueCustomHeadersItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("OriginCustomHeader", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                            if(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderName())
                                                xmlWriter.WriteElementString("HeaderName", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderName));                 
                            
                                            if(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderValue())
                                                xmlWriter.WriteElementString("HeaderValue", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderValue));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomHeaders.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig != null) 
                                {
                                    xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                        xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort));                 
                    
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                        xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort));                 
                    
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                        xmlWriter.WriteElementString("OriginKeepaliveTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout));                 
                    
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                        xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));                 
                    
                                    if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
                                        xmlWriter.WriteElementString("OriginReadTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout));                 
                    
                                    
                                    if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols != null) 
                                    {
                                        xmlWriter.WriteStartElement("OriginSslProtocols", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                        var publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                        if (publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems != null && publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                            foreach (var publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue in publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems) 
                                            {
                                                xmlWriter.WriteStartElement("SslProtocol", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetDomainName())
                                    xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.DomainName));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetId())
                                    xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.Id));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetOriginAccessControlId())
                                    xmlWriter.WriteElementString("OriginAccessControlId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginAccessControlId));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.IsSetOriginPath())
                                    xmlWriter.WriteElementString("OriginPath", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginPath));                 
                
                                
                                if (publicRequestDistributionConfigOriginsItemsValue.OriginShield != null) 
                                {
                                    xmlWriter.WriteStartElement("OriginShield", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigOriginsItemsValue.OriginShield.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigOriginsItemsValue.OriginShield.Enabled));                 
                    
                                    if(publicRequestDistributionConfigOriginsItemsValue.OriginShield.IsSetOriginShieldRegion())
                                        xmlWriter.WriteElementString("OriginShieldRegion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.OriginShield.OriginShieldRegion));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig != null) 
                                {
                                    xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                    if(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                        xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Origins.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.Origins.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetPriceClass())
                        xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.PriceClass));                    
    
                    
                    if (publicRequest.DistributionConfig.Restrictions != null) 
                    {
                        xmlWriter.WriteStartElement("Restrictions", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        
                        if (publicRequest.DistributionConfig.Restrictions.GeoRestriction != null) 
                        {
                            xmlWriter.WriteStartElement("GeoRestriction", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                            var publicRequestDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfig.Restrictions.GeoRestriction.Items;
                            if (publicRequestDistributionConfigRestrictionsGeoRestrictionItems != null && publicRequestDistributionConfigRestrictionsGeoRestrictionItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                foreach (var publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigRestrictionsGeoRestrictionItems) 
                                {
                                    xmlWriter.WriteStartElement("Location", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfig.Restrictions.GeoRestriction.Quantity));                 
            
                            if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                xmlWriter.WriteElementString("RestrictionType", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetStaging())
                        xmlWriter.WriteElementString("Staging", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.Staging));                    
    
                    
                    if (publicRequest.DistributionConfig.ViewerCertificate != null) 
                    {
                        xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                            xmlWriter.WriteElementString("ACMCertificateArn", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.ACMCertificateArn));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCertificate())
                            xmlWriter.WriteElementString("Certificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.Certificate));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                            xmlWriter.WriteElementString("CertificateSource", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.CertificateSource));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                            xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                            xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.IAMCertificateId));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                            xmlWriter.WriteElementString("MinimumProtocolVersion", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));                 
        
                        if(publicRequest.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                            xmlWriter.WriteElementString("SSLSupportMethod", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.SSLSupportMethod));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.IsSetWebACLId())
                        xmlWriter.WriteElementString("WebACLId", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.DistributionConfig.WebACLId));                    
    
    
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
        private static UpdateDistributionRequestMarshaller _instance = new UpdateDistributionRequestMarshaller();        

        internal static UpdateDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}