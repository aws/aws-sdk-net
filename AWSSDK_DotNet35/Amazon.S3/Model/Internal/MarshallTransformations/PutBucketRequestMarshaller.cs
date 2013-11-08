/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Globalization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Request Marshaller
    /// </summary>       
    public class PutBucketRequestMarshaller : IMarshaller<IRequest, PutBucketRequest>
    {
        
    

        public IRequest Marshall(PutBucketRequest putBucketRequest)
        {
            IRequest request = new DefaultRequest(putBucketRequest, "AmazonS3");



            request.HttpMethod = "PUT";
            if (putBucketRequest.IsSetCannedACL())
                request.Headers.Add("x-amz-acl", putBucketRequest.CannedACL.Value);
            else if (putBucketRequest.Grants != null && putBucketRequest.Grants.Count > 0)
                ConvertPutWithACLRequest(putBucketRequest, request);

            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}";
            uriResourcePath = uriResourcePath.Replace("{Bucket}", putBucketRequest.IsSetBucketName() ? S3Transforms.ToStringValue(putBucketRequest.BucketName) : "");
            string path = uriResourcePath;


            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            if (queryIndex != -1)
            {
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                path = uriResourcePath.Substring(0, queryIndex);

                S3Transforms.BuildQueryParameterMap(request, queryParameters, queryString);
            }

            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters);
            uriResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);

            request.ResourcePath = uriResourcePath;


            StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {


                if (putBucketRequest != null)
                {
                    string regionCode = null;
                    S3Region region = putBucketRequest.BucketRegion;
                    if (region != null && !string.IsNullOrEmpty(region.Value))
                    {
                        regionCode = region.Value;
                    }
                    else if (!string.IsNullOrEmpty(putBucketRequest.BucketRegionName))
                    {
                        if (putBucketRequest.BucketRegionName == "eu-west-1")
                            regionCode = "EU";
                        else if (putBucketRequest.BucketRegionName != "us-east-1")
                            regionCode = putBucketRequest.BucketRegionName;
                    }

                    if (regionCode != null)
                    {
                        xmlWriter.WriteStartElement("PutBucketConfiguration", "");
                        xmlWriter.WriteElementString("LocationConstraint", "", regionCode);
                        xmlWriter.WriteEndElement();
                    }
                }
            }

            try
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";


                request.Parameters[S3QueryParameter.ContentType.ToString()] = "application/xml";
                string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[Amazon.Util.AWSSDKUtils.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            if (!request.UseQueryString)
            {
                string queryString = Amazon.Util.AWSSDKUtils.GetParametersAsString(request.Parameters);
                if (!string.IsNullOrEmpty(queryString))
                {
                    if (request.ResourcePath.Contains("?"))
                        request.ResourcePath = string.Concat(request.ResourcePath, "&", queryString);
                    else
                        request.ResourcePath = string.Concat(request.ResourcePath, "?", queryString);
                }
            }


            return request;
        }

        protected internal static void ConvertPutWithACLRequest(PutWithACLRequest request, IRequest irequest)
        {
            Dictionary<S3Permission, string> protoHeaders = new Dictionary<S3Permission, string>();
            foreach (var grant in request.Grants)
            {
                string grantee = null;
                if (grant.Grantee.CanonicalUser != null && !string.IsNullOrEmpty(grant.Grantee.CanonicalUser))
                    grantee = string.Format(CultureInfo.InvariantCulture, "id=\"{0}\"", grant.Grantee.CanonicalUser);
                else if (grant.Grantee.IsSetEmailAddress())
                    grantee = string.Format(CultureInfo.InvariantCulture, "emailAddress=\"{0}\"", grant.Grantee.EmailAddress);
                else if (grant.Grantee.IsSetURI())
                    grantee = string.Format(CultureInfo.InvariantCulture, "uri=\"{0}\"", grant.Grantee.URI);
                else continue;

                string glist = null;
                if (protoHeaders.TryGetValue(grant.Permission, out glist))
                    protoHeaders[grant.Permission] = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", glist, grantee);
                else
                    protoHeaders.Add(grant.Permission, grantee);
            }

            foreach (var permission in protoHeaders.Keys)
            {
                if (permission == S3Permission.READ)
                    irequest.Headers[S3Constants.AmzGrantHeaderRead] = protoHeaders[permission];
                if (permission == S3Permission.WRITE)
                    irequest.Headers[S3Constants.AmzGrantHeaderWrite] = protoHeaders[permission];
                if (permission == S3Permission.READ_ACP)
                    irequest.Headers[S3Constants.AmzGrantHeaderReadAcp] = protoHeaders[permission];
                if (permission == S3Permission.WRITE_ACP)
                    irequest.Headers[S3Constants.AmzGrantHeaderWriteAcp] = protoHeaders[permission];
                if (permission == S3Permission.RESTORE_OBJECT)
                    irequest.Headers[S3Constants.AmzGrantHeaderRestoreObject] = protoHeaders[permission];
                if (permission == S3Permission.FULL_CONTROL)
                    irequest.Headers[S3Constants.AmzGrantHeaderFullControl] = protoHeaders[permission];
            }
        }
    }
}

