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
                        xmlWriter.WriteStartElement("DistributionConfig");
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases != null)
                        {
                            xmlWriter.WriteStartElement("Aliases");
                            var publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigAliasesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Quantity.Value));                 
=======
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Aliases.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors != null)
                        {
                            xmlWriter.WriteStartElement("CacheBehaviors");
                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItems) 
                                {
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("CacheBehavior");
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null)
                                    {
                                        xmlWriter.WriteStartElement("AllowedMethods");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods != null)
                                        {
                                            xmlWriter.WriteStartElement("CachedMethods");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsCachedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity.Value));                 
=======
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.CachedMethods.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                            xmlWriter.WriteEndElement();
                                        }
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCachePolicyId())
                                        xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.CachePolicyId));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetCompress())
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.Compress.Value));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                        xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.DefaultTTL.Value));                 
=======
                                        xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.Compress));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetDefaultTTL())
                                        xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.DefaultTTL));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetFieldLevelEncryptionId())
                                        xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FieldLevelEncryptionId));                 

                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null)
                                    {
                                        xmlWriter.WriteStartElement("ForwardedValues");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null)
                                        {
                                            xmlWriter.WriteStartElement("Cookies");
                                            if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                                xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward));                 

                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null)
                                            {
                                                xmlWriter.WriteStartElement("WhitelistedNames");
                                                var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                                if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));                 
=======
                                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                                xmlWriter.WriteEndElement();
                                            }
                                            xmlWriter.WriteEndElement();
                                        }
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null)
                                        {
                                            xmlWriter.WriteStartElement("Headers");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity.Value));                 
=======
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString.Value));                 
=======
                                            xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys != null)
                                        {
                                            xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueForwardedValuesQueryStringCacheKeysItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity.Value));                 
=======
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryStringCacheKeys.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations != null)
                                    {
                                        xmlWriter.WriteStartElement("FunctionAssociations");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.FunctionAssociations.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations != null)
                                    {
                                        xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                    xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody.Value));                 
=======
                                                    xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IncludeBody));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                                if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                                    xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 

                                                xmlWriter.WriteEndElement();
                                            }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.IsSetQuantity())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.LambdaFunctionAssociations.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMaxTTL())
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MaxTTL.Value));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MinTTL.Value));                 
=======
                                        xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MaxTTL));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                        xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.MinTTL));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetOriginRequestPolicyId())
                                        xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.OriginRequestPolicyId));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                        xmlWriter.WriteElementString("PathPattern", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.PathPattern));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetRealtimeLogConfigArn())
                                        xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.RealtimeLogConfigArn));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetResponseHeadersPolicyId())
                                        xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.ResponseHeadersPolicyId));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming.Value));                 
=======
                                        xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                        xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TargetOriginId));                 

                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups != null)
                                    {
                                        xmlWriter.WriteStartElement("TrustedKeyGroups");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.IsSetEnabled())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled.Value));                 
=======
                                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedKeyGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedKeyGroups.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null)
                                    {
                                        xmlWriter.WriteStartElement("TrustedSigners");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled.Value));                 
=======
                                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        var publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

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
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Quantity.Value));                 
=======
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CacheBehaviors.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetCallerReference())
                            xmlWriter.WriteElementString("CallerReference", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.CallerReference));                 

                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetComment())
                            xmlWriter.WriteElementString("Comment", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Comment));                 

                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetContinuousDeploymentPolicyId())
                            xmlWriter.WriteElementString("ContinuousDeploymentPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ContinuousDeploymentPolicyId));                 

                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses != null)
                        {
                            xmlWriter.WriteStartElement("CustomErrorResponses");
                            var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItems) 
                                {
                                if (publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("CustomErrorResponse");
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL.Value));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                        xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCode.Value));                 
=======
                                        xmlWriter.WriteElementString("ErrorCachingMinTTL", StringUtils.FromLong(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                        xmlWriter.WriteElementString("ErrorCode", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigCustomErrorResponsesItemsValue.ErrorCode));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

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
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Quantity.Value));                 
=======
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.CustomErrorResponses.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior != null)
                        {
                            xmlWriter.WriteStartElement("DefaultCacheBehavior");
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null)
                            {
                                xmlWriter.WriteStartElement("AllowedMethods");
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods != null)
                                {
                                    xmlWriter.WriteStartElement("CachedMethods");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity.Value));                 
=======
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.CachedMethods.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    xmlWriter.WriteEndElement();
                                }
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCachePolicyId())
                                xmlWriter.WriteElementString("CachePolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.CachePolicyId));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetCompress())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Compress", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.Compress.Value));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                                xmlWriter.WriteElementString("DefaultTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.DefaultTTL.Value));                 
=======
                                xmlWriter.WriteElementString("Compress", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.Compress));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetDefaultTTL())
                                xmlWriter.WriteElementString("DefaultTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.DefaultTTL));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetFieldLevelEncryptionId())
                                xmlWriter.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FieldLevelEncryptionId));                 

                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null)
                            {
                                xmlWriter.WriteStartElement("ForwardedValues");
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null)
                                {
                                    xmlWriter.WriteStartElement("Cookies");
                                    if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                        xmlWriter.WriteElementString("Forward", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward));                 

                                    if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null)
                                    {
                                        xmlWriter.WriteStartElement("WhitelistedNames");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null)
                                {
                                    xmlWriter.WriteStartElement("Headers");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity.Value));                 
=======
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString.Value));                 
=======
                                    xmlWriter.WriteElementString("QueryString", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys != null)
                                {
                                    xmlWriter.WriteStartElement("QueryStringCacheKeys");
                                    var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Items;
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeysItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity.Value));                 
=======
                                        xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryStringCacheKeys.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations != null)
                            {
                                xmlWriter.WriteStartElement("FunctionAssociations");
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.FunctionAssociations.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations != null)
                            {
                                xmlWriter.WriteStartElement("LambdaFunctionAssociations");
                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("IncludeBody", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody.Value));                 
=======
                                            xmlWriter.WriteElementString("IncludeBody", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IncludeBody));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.IsSetLambdaFunctionARN())
                                            xmlWriter.WriteElementString("LambdaFunctionARN", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItemsValue.LambdaFunctionARN));                 

                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.IsSetQuantity())
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.LambdaFunctionAssociations.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMaxTTL())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("MaxTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MaxTTL.Value));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MinTTL.Value));                 
=======
                                xmlWriter.WriteElementString("MaxTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MaxTTL));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", StringUtils.FromLong(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.MinTTL));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetOriginRequestPolicyId())
                                xmlWriter.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.OriginRequestPolicyId));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetRealtimeLogConfigArn())
                                xmlWriter.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.RealtimeLogConfigArn));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetResponseHeadersPolicyId())
                                xmlWriter.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ResponseHeadersPolicyId));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.SmoothStreaming.Value));                 
=======
                                xmlWriter.WriteElementString("SmoothStreaming", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.SmoothStreaming));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                                xmlWriter.WriteElementString("TargetOriginId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TargetOriginId));                 

                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups != null)
                            {
                                xmlWriter.WriteStartElement("TrustedKeyGroups");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.IsSetEnabled())
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled.Value));                 
=======
                                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedKeyGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedKeyGroups.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null)
                            {
                                xmlWriter.WriteStartElement("TrustedSigners");
                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled.Value));                 
=======
                                    xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                var publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                                xmlWriter.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy));                 

                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetDefaultRootObject())
                            xmlWriter.WriteElementString("DefaultRootObject", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.DefaultRootObject));                 

                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetEnabled())
<<<<<<< HEAD
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Enabled.Value));                 
=======
                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetHttpVersion())
                            xmlWriter.WriteElementString("HttpVersion", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.HttpVersion));                 

                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetIsIPV6Enabled())
<<<<<<< HEAD
                            xmlWriter.WriteElementString("IsIPV6Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.IsIPV6Enabled.Value));                 
=======
                            xmlWriter.WriteElementString("IsIPV6Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.IsIPV6Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Logging != null)
                        {
                            xmlWriter.WriteStartElement("Logging");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Bucket));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetEnabled())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Enabled.Value));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetIncludeCookies())
                                xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IncludeCookies.Value));                 
=======
                                xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Enabled));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetIncludeCookies())
                                xmlWriter.WriteElementString("IncludeCookies", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IncludeCookies));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Logging.Prefix));                 

                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups != null)
                        {
                            xmlWriter.WriteStartElement("OriginGroups");
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItems) 
                                {
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("OriginGroup");
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria != null)
                                    {
                                        xmlWriter.WriteStartElement("FailoverCriteria");
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes != null)
                                        {
                                            xmlWriter.WriteStartElement("StatusCodes");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueFailoverCriteriaStatusCodesItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity.Value));                 
=======
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.FailoverCriteria.StatusCodes.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                            xmlWriter.WriteEndElement();
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.IsSetId())
                                        xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Id));                 

                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members != null)
                                    {
                                        xmlWriter.WriteStartElement("Members");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValueMembersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginGroupsItemsValue.Members.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.IsSetQuantity())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Quantity.Value));                 
=======
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.OriginGroups.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Origins != null)
                        {
                            xmlWriter.WriteStartElement("Origins");
                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Items;
                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
                            {
                                xmlWriter.WriteStartElement("Items");
                                foreach (var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue in publicRequestDistributionConfigWithTagsDistributionConfigOriginsItems) 
                                {
                                if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue != null)
                                {
                                    xmlWriter.WriteStartElement("Origin");
                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionAttempts())
<<<<<<< HEAD
                                        xmlWriter.WriteElementString("ConnectionAttempts", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionAttempts.Value));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                        xmlWriter.WriteElementString("ConnectionTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionTimeout.Value));                 
=======
                                        xmlWriter.WriteElementString("ConnectionAttempts", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionAttempts));                 

                                    if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.IsSetConnectionTimeout())
                                        xmlWriter.WriteElementString("ConnectionTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.ConnectionTimeout));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders != null)
                                    {
                                        xmlWriter.WriteStartElement("CustomHeaders");
                                        var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Items;
                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomHeadersItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Quantity.Value));                 
=======
                                            xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomHeaders.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig != null)
                                    {
                                        xmlWriter.WriteStartElement("CustomOriginConfig");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort.Value));                 

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                            xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort.Value));                 

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                            xmlWriter.WriteElementString("OriginKeepaliveTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout.Value));                 
=======
                                            xmlWriter.WriteElementString("HTTPPort", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort));                 

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                            xmlWriter.WriteElementString("HTTPSPort", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort));                 

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginKeepaliveTimeout())
                                            xmlWriter.WriteElementString("OriginKeepaliveTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginKeepaliveTimeout));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                            xmlWriter.WriteElementString("OriginProtocolPolicy", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy));                 

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginReadTimeout())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("OriginReadTimeout", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout.Value));                 
=======
                                            xmlWriter.WriteElementString("OriginReadTimeout", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginReadTimeout));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols != null)
                                        {
                                            xmlWriter.WriteStartElement("OriginSslProtocols");
                                            var publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems = publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Items;
                                            if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValueCustomOriginConfigOriginSslProtocolsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity.Value));                 
=======
                                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginSslProtocols.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

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

                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield != null)
                                    {
                                        xmlWriter.WriteStartElement("OriginShield");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetEnabled())
<<<<<<< HEAD
                                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.Enabled.Value));                 
=======
                                            xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.Enabled));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.IsSetOriginShieldRegion())
                                            xmlWriter.WriteElementString("OriginShieldRegion", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.OriginShield.OriginShieldRegion));                 

                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig != null)
                                    {
                                        xmlWriter.WriteStartElement("S3OriginConfig");
                                        if(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                            xmlWriter.WriteElementString("OriginAccessIdentity", StringUtils.FromString(publicRequestDistributionConfigWithTagsDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity));                 

                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.IsSetQuantity())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Quantity.Value));                 
=======
                                xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Origins.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetPriceClass())
                            xmlWriter.WriteElementString("PriceClass", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.PriceClass));                 

                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions != null)
                        {
                            xmlWriter.WriteStartElement("Restrictions");
                            if (publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction != null)
                            {
                                xmlWriter.WriteStartElement("GeoRestriction");
                                var publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Items;
                                if (publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems != null && (publicRequestDistributionConfigWithTagsDistributionConfigRestrictionsGeoRestrictionItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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
<<<<<<< HEAD
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Quantity.Value));                 
=======
                                    xmlWriter.WriteElementString("Quantity", StringUtils.FromInt(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.Quantity));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                                if(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                                    xmlWriter.WriteElementString("RestrictionType", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.Restrictions.GeoRestriction.RestrictionType));                 

                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetStaging())
<<<<<<< HEAD
                            xmlWriter.WriteElementString("Staging", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Staging.Value));                 
=======
                            xmlWriter.WriteElementString("Staging", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.Staging));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                        if (publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate != null)
                        {
                            xmlWriter.WriteStartElement("ViewerCertificate");
                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetACMCertificateArn())
                                xmlWriter.WriteElementString("ACMCertificateArn", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.ACMCertificateArn));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificate())
                                xmlWriter.WriteElementString("Certificate", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.Certificate));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCertificateSource())
                                xmlWriter.WriteElementString("CertificateSource", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CertificateSource));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
<<<<<<< HEAD
                                xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate.Value));                 
=======
                                xmlWriter.WriteElementString("CloudFrontDefaultCertificate", StringUtils.FromBool(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate));                 
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                                xmlWriter.WriteElementString("IAMCertificateId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IAMCertificateId));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetMinimumProtocolVersion())
                                xmlWriter.WriteElementString("MinimumProtocolVersion", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.MinimumProtocolVersion));                 

                            if(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                                xmlWriter.WriteElementString("SSLSupportMethod", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.ViewerCertificate.SSLSupportMethod));                 

                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfigWithTags.DistributionConfig.IsSetWebACLId())
                            xmlWriter.WriteElementString("WebACLId", StringUtils.FromString(publicRequest.DistributionConfigWithTags.DistributionConfig.WebACLId));                 

                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.DistributionConfigWithTags.Tags != null)
                    {
                        xmlWriter.WriteStartElement("Tags");
                        var publicRequestDistributionConfigWithTagsTagsItems = publicRequest.DistributionConfigWithTags.Tags.Items;
                        if (publicRequestDistributionConfigWithTagsTagsItems != null && (publicRequestDistributionConfigWithTagsTagsItems.Count > 0 || !AWSConfigs.InitializeCollections)) 
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