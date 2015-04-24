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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Object Acl Request Marshaller
    /// </summary>       
    public class PutACLRequestMarshaller : IMarshaller<IRequest, PutACLRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutACLRequest)input);
		}

        public IRequest Marshall(PutACLRequest putObjectAclRequest)
        {
            IRequest request = new DefaultRequest(putObjectAclRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putObjectAclRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, S3Transforms.ToStringValue(putObjectAclRequest.CannedACL));

            // if we are putting the acl onto the bucket, the keyname component will collapse to empty string
            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(putObjectAclRequest.BucketName),
                                                 S3Transforms.ToStringValue(putObjectAclRequest.Key));

            request.AddSubResource("acl");
            if (putObjectAclRequest.IsSetVersionId())
                request.AddSubResource("versionId", S3Transforms.ToStringValue(putObjectAclRequest.VersionId));

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (
                var xmlWriter = XmlWriter.Create(stringWriter,
                                                 new XmlWriterSettings()
                                                     {
                                                         Encoding = Encoding.UTF8,
                                                         OmitXmlDeclaration = true
                                                     }))
            {
                var accessControlPolicyAccessControlPolicy = putObjectAclRequest.AccessControlList;
                if (accessControlPolicyAccessControlPolicy != null)
                {
                    xmlWriter.WriteStartElement("AccessControlPolicy", "");
                    var accessControlPolicyAccessControlPolicygrantsList = accessControlPolicyAccessControlPolicy.Grants;
                    if (accessControlPolicyAccessControlPolicygrantsList != null &&
                        accessControlPolicyAccessControlPolicygrantsList.Count > 0)
                    {
                        xmlWriter.WriteStartElement("AccessControlList", "");
                        foreach (
                            var accessControlPolicyAccessControlPolicygrantsListValue in
                                accessControlPolicyAccessControlPolicygrantsList)
                        {
                            xmlWriter.WriteStartElement("Grant", "");
                            if (accessControlPolicyAccessControlPolicygrantsListValue != null)
                            {
                                var granteeGrantee = accessControlPolicyAccessControlPolicygrantsListValue.Grantee;
                                if (granteeGrantee != null)
                                {
                                    xmlWriter.WriteStartElement("Grantee", "");
                                    if (granteeGrantee.IsSetType())
                                    {
                                        xmlWriter.WriteAttributeString("xsi", "type",
                                                                       "http://www.w3.org/2001/XMLSchema-instance",
                                                                       granteeGrantee.Type.ToString());
                                    }
                                    if (granteeGrantee.IsSetDisplayName())
                                    {
                                        xmlWriter.WriteElementString("DisplayName", "",
                                                                     S3Transforms.ToXmlStringValue(
                                                                         granteeGrantee.DisplayName));
                                    }
                                    if (granteeGrantee.IsSetEmailAddress())
                                    {
                                        xmlWriter.WriteElementString("EmailAddress", "",
                                                                     S3Transforms.ToXmlStringValue(
                                                                         granteeGrantee.EmailAddress));
                                    }
                                    if (granteeGrantee.IsSetCanonicalUser())
                                    {
                                        xmlWriter.WriteElementString("ID", "",
                                                                     S3Transforms.ToXmlStringValue(
                                                                         granteeGrantee.CanonicalUser));
                                    }
                                    if (granteeGrantee.IsSetURI())
                                    {
                                        xmlWriter.WriteElementString("URI", "",
                                                                     S3Transforms.ToXmlStringValue(
                                                                         granteeGrantee.URI));
                                    }
                                    xmlWriter.WriteEndElement();
                                }

                                if (accessControlPolicyAccessControlPolicygrantsListValue.IsSetPermission())
                                {
                                    xmlWriter.WriteElementString("Permission", "",
                                                                 S3Transforms.ToXmlStringValue(
                                                                     accessControlPolicyAccessControlPolicygrantsListValue
                                                                         .Permission));
                                }
                            }
                            xmlWriter.WriteEndElement();
                        }

                        xmlWriter.WriteEndElement();

                        var ownerOwner = accessControlPolicyAccessControlPolicy.Owner;
                        if (ownerOwner != null)
                        {
                            xmlWriter.WriteStartElement("Owner", "");
                            if (ownerOwner.IsSetDisplayName())
                            {
                                xmlWriter.WriteElementString("DisplayName", "",
                                                             S3Transforms.ToXmlStringValue(ownerOwner.DisplayName));
                            }
                            if (ownerOwner.IsSetId())
                            {
                                xmlWriter.WriteElementString("ID", "", S3Transforms.ToXmlStringValue(ownerOwner.Id));
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }

                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                string checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
    }
}

