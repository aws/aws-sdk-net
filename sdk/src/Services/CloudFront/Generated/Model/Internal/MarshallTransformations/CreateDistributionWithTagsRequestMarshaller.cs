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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
            string uriResourcePath = "/2017-10-30/distribution";
            request.AddSubResource("WithTags");
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("DistributionConfigWithTags", "http://cloudfront.amazonaws.com/doc/2017-10-30/");                                
                
                if (publicRequest.DistributionConfigWithTags.DistributionConfig != null) 
                {
                    xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases != null) 
                    {
                        xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Items;
                        if (publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems) 
                            {
                                xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigAliasesItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors != null) 
                    {
                        xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Items;
                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems) 
                            {
                            
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null) 
                                {
                                    xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null) 
                                    {
                                        xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                            {
                                                xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
                                    xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.Compress));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                    xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.DefaultTTL));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                    xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));                 
                
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null) 
                                {
                                    xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null) 
                                    {
                                        xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                            xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));                 
                        
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null) 
                                        {
                                            xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                            {                        
                                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                                {
                                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                    xmlWriter.WriteEndElement();
                                                }            
                                                xmlWriter.WriteEndElement();            
                                            }
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null) 
                                    {
                                        xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                        xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys != null) 
                                    {
                                        xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations != null) 
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                                xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.EventType));                 
                            
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
                                    xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MaxTTL));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                    xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MinTTL));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                    xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.PathPattern));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                    xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                    xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));                 
                
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null) 
                                {
                                    xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled));                 
                    
                                    var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                        {
                                            xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                    xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.CallerReference));                 
    
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Comment));                 
    
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses != null) 
                    {
                        xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Items;
                        if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems) 
                            {
                            
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                    xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                    xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCode));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                    xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                    xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior != null) 
                    {
                        xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null) 
                        {
                            xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                                {
                                    xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
                            xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.Compress));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                            xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.DefaultTTL));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                            xmlWriter.WriteElementString("FieldLevelEncryptionId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null) 
                        {
                            xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null) 
                            {
                                xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                    xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));                 
                
                                
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null) 
                                {
                                    xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null) 
                            {
                                xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                                xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString));                 
            
                            
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys != null) 
                            {
                                xmlWriter.WriteStartElement("QueryStringCacheKeys", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations != null) 
                        {
                            xmlWriter.WriteStartElement("LambdaFunctionAssociations", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems) 
                                {
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("LambdaFunctionAssociation", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetEventType())
                                        xmlWriter.WriteElementString("EventType", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.EventType));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                        xmlWriter.WriteElementString("LambdaFunctionARN", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
                            xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MaxTTL));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                            xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MinTTL));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                            xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.SmoothStreaming));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                            xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TargetOriginId));                 
        
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null) 
                        {
                            xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled));                 
            
                            var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                                {
                                    xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                            xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetDefaultRootObject())
                        xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultRootObject));                 
    
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Enabled));                 
    
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetHttpVersion())
                        xmlWriter.WriteElementString("HttpVersion", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.HttpVersion));                 
    
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetIsIPV6Enabled())
                        xmlWriter.WriteElementString("IsIPV6Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.IsIPV6Enabled));                 
    
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.Logging != null) 
                    {
                        xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetBucket())
                            xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Bucket));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Enabled));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetIncludeCookies())
                            xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IncludeCookies));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetPrefix())
                            xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Prefix));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.Origins != null) 
                    {
                        xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Items;
                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems) 
                            {
                            
                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders != null) 
                                {
                                    xmlWriter.WriteStartElement("CustomHeaders", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                        foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems) 
                                        {
                                        
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue != null) 
                                        {
                                            xmlWriter.WriteStartElement("OriginCustomHeader", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderName())
                                                xmlWriter.WriteElementString("HeaderName", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderName));                 
                            
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.IsSetHeaderValue())
                                                xmlWriter.WriteElementString("HeaderValue", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItemsValue.HeaderValue));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig != null) 
                                {
                                    xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                        xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                        xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                        xmlWriter.WriteElementString("OriginKeepaliveTimeout", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                        xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));                 
                    
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
                                        xmlWriter.WriteElementString("OriginReadTimeout", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout));                 
                    
                                    
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols != null) 
                                    {
                                        xmlWriter.WriteStartElement("OriginSslProtocols", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems != null && publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                            foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems) 
                                            {
                                                xmlWriter.WriteStartElement("SslProtocol", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetDomainName())
                                    xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.DomainName));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetId())
                                    xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.Id));                 
                
                                if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetOriginPath())
                                    xmlWriter.WriteElementString("OriginPath", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginPath));                 
                
                                
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig != null) 
                                {
                                    xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                        xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetPriceClass())
                        xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.PriceClass));                 
    
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions != null) 
                    {
                        xmlWriter.WriteStartElement("Restrictions", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction != null) 
                        {
                            xmlWriter.WriteStartElement("GeoRestriction", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems != null && publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems) 
                                {
                                    xmlWriter.WriteStartElement("Location", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Quantity));                 
            
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                xmlWriter.WriteElementString("RestrictionType", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate != null) 
                    {
                        xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                            xmlWriter.WriteElementString("ACMCertificateArn", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.ACMCertificateArn));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificate())
                            xmlWriter.WriteElementString("Certificate", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.Certificate));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                            xmlWriter.WriteElementString("CertificateSource", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CertificateSource));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                            xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                            xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IAMCertificateId));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                            xmlWriter.WriteElementString("MinimumProtocolVersion", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));                 
        
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                            xmlWriter.WriteElementString("SSLSupportMethod", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.SSLSupportMethod));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetWebACLId())
                        xmlWriter.WriteElementString("WebACLId", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.WebACLId));                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfigWithTags.Tags != null) 
                {
                    xmlWriter.WriteStartElement("Tags", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                    var publicRequestDistributionConfigWithTagsTagsItems = publicRequest.DistributionConfigWithTags.Tags.Items;
                    if (publicRequestDistributionConfigWithTagsTagsItems != null && publicRequestDistributionConfigWithTagsTagsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2017-10-30/");
                        foreach (var publicRequestDistributionConfigWithTagsTagsItemsValue in publicRequestDistributionConfigWithTagsTagsItems) 
                        {
                        
                        if (publicRequestDistributionConfigWithTagsTagsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("Tag", "http://cloudfront.amazonaws.com/doc/2017-10-30/");            
                            if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetKey())
                                xmlWriter.WriteElementString("Key", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Key));                 
            
                            if(publicRequestDistributionConfigWithTagsTagsItemsValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", "http://cloudfront.amazonaws.com/doc/2017-10-30/", StringUtils.FromString(publicRequestDistributionConfigWithTagsTagsItemsValue.Value));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
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