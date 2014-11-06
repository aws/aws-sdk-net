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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
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
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDistributionRequest)input);
        }

        public IRequest Marshall(UpdateDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "PUT";
            string uriResourcePath = "/2014-10-21/distribution/{Id}/config";
        
            if(publicRequest.IsSetIfMatch())
                request.Headers["If-Match"] = publicRequest.IfMatch;
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.IsSetId() ? StringUtils.FromString(publicRequest.Id) : string.Empty);
            request.ResourcePath = uriResourcePath;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2014-10-21/");                                
                
                if (publicRequest.DistributionConfig.Aliases != null) 
                {
                    xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    var publicRequestDistributionConfigAliasesItems = publicRequest.DistributionConfig.Aliases.Items;
                    if (publicRequestDistributionConfigAliasesItems != null && publicRequestDistributionConfigAliasesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                        foreach (var publicRequestDistributionConfigAliasesItemsValue in publicRequestDistributionConfigAliasesItems) 
                        {
                            xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                            xmlWriter.WriteValue(publicRequestDistributionConfigAliasesItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.Aliases.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.Aliases.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.CacheBehaviors != null) 
                {
                    xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    var publicRequestDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfig.CacheBehaviors.Items;
                    if (publicRequestDistributionConfigCacheBehaviorsItems != null && publicRequestDistributionConfigCacheBehaviorsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigCacheBehaviorsItems) 
                        {
                        
                        if (publicRequestDistributionConfigCacheBehaviorsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null) 
                                {
                                    xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems) 
                                        {
                                            xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                    foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null) 
                            {
                                xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null) 
                                {
                                    xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                        xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));                 
                    
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null) 
                                    {
                                        xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null) 
                                {
                                    xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromLong(publicRequestDistributionConfigCacheBehaviorsItemsValue.MinTTL));                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.PathPattern));                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming));                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));                 
            
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled));                 
                
                                var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                    foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                    {
                                        xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.CacheBehaviors.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.CacheBehaviors.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.CallerReference));                    

                if(publicRequest.DistributionConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.Comment));                    

                
                if (publicRequest.DistributionConfig.CustomErrorResponses != null) 
                {
                    xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    var publicRequestDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfig.CustomErrorResponses.Items;
                    if (publicRequestDistributionConfigCustomErrorResponsesItems != null && publicRequestDistributionConfigCustomErrorResponsesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                        foreach (var publicRequestDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigCustomErrorResponsesItems) 
                        {
                        
                        if (publicRequestDistributionConfigCustomErrorResponsesItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromLong(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL));                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCode));                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponseCode));                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.CustomErrorResponses.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.DefaultCacheBehavior != null) 
                {
                    xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null) 
                    {
                        xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null) 
                        {
                            xmlWriter.WriteStartElement("CachedMethods", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems) 
                                {
                                    xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                        if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                            foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                            {
                                xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null) 
                    {
                        xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null) 
                        {
                            xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));                 
            
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null) 
                            {
                                xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null) 
                        {
                            xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                            xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromLong(publicRequest.DistributionConfig.DefaultCacheBehavior.MinTTL));                 
    
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                        xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.SmoothStreaming));                 
    
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                        xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.TargetOriginId));                 
    
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null) 
                    {
                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled));                 
        
                        var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                        if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                            foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                            {
                                xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                        xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetDefaultRootObject())
                    xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.DefaultRootObject));                    

                if(publicRequest.DistributionConfig.IsSetEnabled())
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.Enabled));                    

                
                if (publicRequest.DistributionConfig.Logging != null) 
                {
                    xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    if(publicRequest.DistributionConfig.Logging.IsSetBucket())
                        xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Bucket));                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.Enabled));                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetIncludeCookies())
                        xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.Logging.IncludeCookies));                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.Logging.Prefix));                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.Origins != null) 
                {
                    xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    var publicRequestDistributionConfigOriginsItems = publicRequest.DistributionConfig.Origins.Items;
                    if (publicRequestDistributionConfigOriginsItems != null && publicRequestDistributionConfigOriginsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                        foreach (var publicRequestDistributionConfigOriginsItemsValue in publicRequestDistributionConfigOriginsItems) 
                        {
                        
                        if (publicRequestDistributionConfigOriginsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                            
                            if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig != null) 
                            {
                                xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                    xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                    xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort));                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                    xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigOriginsItemsValue.IsSetDomainName())
                                xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.DomainName));                 
            
                            if(publicRequestDistributionConfigOriginsItemsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.Id));                 
            
                            
                            if (publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig != null) 
                            {
                                xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                                if(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                    xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.Origins.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.Origins.Quantity));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetPriceClass())
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.PriceClass));                    

                
                if (publicRequest.DistributionConfig.Restrictions != null) 
                {
                    xmlWriter.WriteStartElement("Restrictions", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    
                    if (publicRequest.DistributionConfig.Restrictions.GeoRestriction != null) 
                    {
                        xmlWriter.WriteStartElement("GeoRestriction", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                        var publicRequestDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfig.Restrictions.GeoRestriction.Items;
                        if (publicRequestDistributionConfigRestrictionsGeoRestrictionItems != null && publicRequestDistributionConfigRestrictionsGeoRestrictionItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                            foreach (var publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigRestrictionsGeoRestrictionItems) 
                            {
                                xmlWriter.WriteStartElement("Location", "http://cloudfront.amazonaws.com/doc/2014-10-21/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromInt(publicRequest.DistributionConfig.Restrictions.GeoRestriction.Quantity));                 
        
                        if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                            xmlWriter.WriteElementString("RestrictionType", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.ViewerCertificate != null) 
                {
                    xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2014-10-21/");            
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                        xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromBool(publicRequest.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate));                 
    
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                        xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.IAMCertificateId));                 
    
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                        xmlWriter.WriteElementString("MinimumProtocolVersion", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));                 
    
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                        xmlWriter.WriteElementString("SSLSupportMethod", "http://cloudfront.amazonaws.com/doc/2014-10-21/", StringUtils.FromString(publicRequest.DistributionConfig.ViewerCertificate.SSLSupportMethod));                 
    
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

        
    }    
}