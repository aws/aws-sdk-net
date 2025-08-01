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
    /// CreateAccessPoint Request Marshaller
    /// </summary>       
    public partial class CreateAccessPointRequestMarshaller : IMarshaller<IRequest, CreateAccessPointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAccessPointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAccessPointRequest publicRequest)
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
            request.ResourcePath = "/v20180820/accesspoint/{name}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateAccessPointRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if(publicRequest.IsSetBucket())
                    xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.Bucket));

                if(publicRequest.IsSetBucketAccountId())
                    xmlWriter.WriteElementString("BucketAccountId", StringUtils.FromString(publicRequest.BucketAccountId));

                if (publicRequest.PublicAccessBlockConfiguration != null)
                {
                    xmlWriter.WriteStartElement("PublicAccessBlockConfiguration");
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetBlockPublicAcls())
                        xmlWriter.WriteElementString("BlockPublicAcls", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.BlockPublicAcls.Value));
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetBlockPublicPolicy())
                        xmlWriter.WriteElementString("BlockPublicPolicy", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.BlockPublicPolicy.Value));
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetIgnorePublicAcls())
                        xmlWriter.WriteElementString("IgnorePublicAcls", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.IgnorePublicAcls.Value));
                    if(publicRequest.PublicAccessBlockConfiguration.IsSetRestrictPublicBuckets())
                        xmlWriter.WriteElementString("RestrictPublicBuckets", StringUtils.FromBool(publicRequest.PublicAccessBlockConfiguration.RestrictPublicBuckets.Value));
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.Scope != null)
                {
                    xmlWriter.WriteStartElement("Scope");
                    var publicRequestScopePermissions = publicRequest.Scope.Permissions;
                    if (publicRequestScopePermissions != null && (publicRequestScopePermissions.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Permissions");
                        foreach (var publicRequestScopePermissionsValue in publicRequestScopePermissions) 
                        {
                            xmlWriter.WriteStartElement("Permission");
                            xmlWriter.WriteValue(publicRequestScopePermissionsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    var publicRequestScopePrefixes = publicRequest.Scope.Prefixes;
                    if (publicRequestScopePrefixes != null && (publicRequestScopePrefixes.Count > 0 || !AWSConfigs.InitializeCollections)) 
                    {
                        xmlWriter.WriteStartElement("Prefixes");
                        foreach (var publicRequestScopePrefixesValue in publicRequestScopePrefixes) 
                        {
                            xmlWriter.WriteStartElement("Prefix");
                            xmlWriter.WriteValue(publicRequestScopePrefixesValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    xmlWriter.WriteEndElement();
                }
                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && (publicRequestTags.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    if (publicRequestTagsValue != null)
                    {
                        xmlWriter.WriteStartElement("Tag");
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsValue.Key));
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsValue.Value));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if (publicRequest.VpcConfiguration != null)
                {
                    xmlWriter.WriteStartElement("VpcConfiguration");
                    if(publicRequest.VpcConfiguration.IsSetVpcId())
                        xmlWriter.WriteElementString("VpcId", StringUtils.FromString(publicRequest.VpcConfiguration.VpcId));
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
        private static CreateAccessPointRequestMarshaller _instance = new CreateAccessPointRequestMarshaller();        

        internal static CreateAccessPointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAccessPointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateAccessPointRequest publicRequest);
    }    
}