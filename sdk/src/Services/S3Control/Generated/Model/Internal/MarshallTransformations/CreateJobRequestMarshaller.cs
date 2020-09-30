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

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "POST";
        
            if(publicRequest.IsSetAccountId())
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            request.ResourcePath = "/v20180820/jobs";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                xmlWriter.WriteStartElement("CreateJobRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");    
                if(publicRequest.IsSetClientRequestToken())
                    xmlWriter.WriteElementString("ClientRequestToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.ClientRequestToken));                    
                else                
                    xmlWriter.WriteElementString("ClientRequestToken", "http://awss3control.amazonaws.com/doc/2018-08-20/", Guid.NewGuid().ToString());                

                if(publicRequest.IsSetConfirmationRequired())
                    xmlWriter.WriteElementString("ConfirmationRequired", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.ConfirmationRequired));                    

                if(publicRequest.IsSetDescription())
                    xmlWriter.WriteElementString("Description", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Description));                    

                
                if (publicRequest.Manifest != null) 
                {
                    xmlWriter.WriteStartElement("Manifest", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    
                    if (publicRequest.Manifest.Location != null) 
                    {
                        xmlWriter.WriteStartElement("Location", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.Manifest.Location.IsSetETag())
                            xmlWriter.WriteElementString("ETag", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Manifest.Location.ETag));                 
        
                        if(publicRequest.Manifest.Location.IsSetObjectArn())
                            xmlWriter.WriteElementString("ObjectArn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Manifest.Location.ObjectArn));                 
        
                        if(publicRequest.Manifest.Location.IsSetObjectVersionId())
                            xmlWriter.WriteElementString("ObjectVersionId", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Manifest.Location.ObjectVersionId));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Manifest.Spec != null) 
                    {
                        xmlWriter.WriteStartElement("Spec", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        var publicRequestManifestSpecFields = publicRequest.Manifest.Spec.Fields;
                        if (publicRequestManifestSpecFields != null && publicRequestManifestSpecFields.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Fields", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestManifestSpecFieldsValue in publicRequestManifestSpecFields) 
                            {
                                xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                xmlWriter.WriteValue(publicRequestManifestSpecFieldsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Manifest.Spec.IsSetFormat())
                            xmlWriter.WriteElementString("Format", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Manifest.Spec.Format));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.Operation != null) 
                {
                    xmlWriter.WriteStartElement("Operation", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    
                    if (publicRequest.Operation.LambdaInvoke != null) 
                    {
                        xmlWriter.WriteStartElement("LambdaInvoke", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.Operation.LambdaInvoke.IsSetFunctionArn())
                            xmlWriter.WriteElementString("FunctionArn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.LambdaInvoke.FunctionArn));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3InitiateRestoreObject != null) 
                    {
                        xmlWriter.WriteStartElement("S3InitiateRestoreObject", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.Operation.S3InitiateRestoreObject.IsSetExpirationInDays())
                            xmlWriter.WriteElementString("ExpirationInDays", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequest.Operation.S3InitiateRestoreObject.ExpirationInDays));                 
        
                        if(publicRequest.Operation.S3InitiateRestoreObject.IsSetGlacierJobTier())
                            xmlWriter.WriteElementString("GlacierJobTier", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3InitiateRestoreObject.GlacierJobTier));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3PutObjectAcl != null) 
                    {
                        xmlWriter.WriteStartElement("S3PutObjectAcl", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        
                        if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy != null) 
                        {
                            xmlWriter.WriteStartElement("AccessControlPolicy", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            
                            if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList != null) 
                            {
                                xmlWriter.WriteStartElement("AccessControlList", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                var publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants = publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Grants;
                                if (publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants != null && publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Grants", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                    foreach (var publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue in publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants) 
                                    {
                                    
                                    if (publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue != null) 
                                    {
                                        xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                        
                                        if (publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee != null) 
                                        {
                                            xmlWriter.WriteStartElement("Grantee", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetDisplayName())
                                                xmlWriter.WriteElementString("DisplayName", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.DisplayName));                 
                            
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetIdentifier())
                                                xmlWriter.WriteElementString("Identifier", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.Identifier));                 
                            
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetTypeIdentifier())
                                                xmlWriter.WriteElementString("TypeIdentifier", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.TypeIdentifier));                 
                            
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.IsSetPermission())
                                            xmlWriter.WriteElementString("Permission", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Permission));                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                
                                if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner != null) 
                                {
                                    xmlWriter.WriteStartElement("Owner", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.DisplayName));                 
                    
                                    if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.IsSetID())
                                        xmlWriter.WriteElementString("ID", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.ID));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.IsSetCannedAccessControlList())
                                xmlWriter.WriteElementString("CannedAccessControlList", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.CannedAccessControlList));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3PutObjectCopy != null) 
                    {
                        xmlWriter.WriteStartElement("S3PutObjectCopy", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        var publicRequestOperationS3PutObjectCopyAccessControlGrants = publicRequest.Operation.S3PutObjectCopy.AccessControlGrants;
                        if (publicRequestOperationS3PutObjectCopyAccessControlGrants != null && publicRequestOperationS3PutObjectCopyAccessControlGrants.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("AccessControlGrants", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestOperationS3PutObjectCopyAccessControlGrantsValue in publicRequestOperationS3PutObjectCopyAccessControlGrants) 
                            {
                            
                            if (publicRequestOperationS3PutObjectCopyAccessControlGrantsValue != null) 
                            {
                                xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                
                                if (publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee != null) 
                                {
                                    xmlWriter.WriteStartElement("Grantee", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.DisplayName));                 
                    
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetIdentifier())
                                        xmlWriter.WriteElementString("Identifier", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.Identifier));                 
                    
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetTypeIdentifier())
                                        xmlWriter.WriteElementString("TypeIdentifier", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.TypeIdentifier));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.IsSetPermission())
                                    xmlWriter.WriteElementString("Permission", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Permission));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetCannedAccessControlList())
                            xmlWriter.WriteElementString("CannedAccessControlList", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.CannedAccessControlList));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetMetadataDirective())
                            xmlWriter.WriteElementString("MetadataDirective", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.MetadataDirective));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetModifiedSinceConstraint())
                            xmlWriter.WriteElementString("ModifiedSinceConstraint", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequest.Operation.S3PutObjectCopy.ModifiedSinceConstraint));                 
        
                        
                        if (publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata != null) 
                        {
                            xmlWriter.WriteStartElement("NewObjectMetadata", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetCacheControl())
                                xmlWriter.WriteElementString("CacheControl", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.CacheControl));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentDisposition())
                                xmlWriter.WriteElementString("ContentDisposition", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentDisposition));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentEncoding())
                                xmlWriter.WriteElementString("ContentEncoding", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentEncoding));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentLanguage())
                                xmlWriter.WriteElementString("ContentLanguage", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentLanguage));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentLength())
                                xmlWriter.WriteElementString("ContentLength", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromLong(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentLength));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentMD5())
                                xmlWriter.WriteElementString("ContentMD5", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentMD5));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentType())
                                xmlWriter.WriteElementString("ContentType", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentType));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetHttpExpiresDate())
                                xmlWriter.WriteElementString("HttpExpiresDate", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.HttpExpiresDate));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetRequesterCharged())
                                xmlWriter.WriteElementString("RequesterCharged", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.RequesterCharged));                 
            
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetSSEAlgorithm())
                                xmlWriter.WriteElementString("SSEAlgorithm", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.SSEAlgorithm));                 
            
                                xmlWriter.WriteStartElement("UserMetadata", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                foreach (var kvp in publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.UserMetadata) 
                                {
                                    xmlWriter.WriteStartElement("entry", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                                    xmlWriter.WriteElementString("key", "http://awss3control.amazonaws.com/doc/2018-08-20/", kvp.Key);
                                    xmlWriter.WriteElementString("value", "http://awss3control.amazonaws.com/doc/2018-08-20/", kvp.Value);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();                
                            xmlWriter.WriteEndElement();
                        }
                        var publicRequestOperationS3PutObjectCopyNewObjectTagging = publicRequest.Operation.S3PutObjectCopy.NewObjectTagging;
                        if (publicRequestOperationS3PutObjectCopyNewObjectTagging != null && publicRequestOperationS3PutObjectCopyNewObjectTagging.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("NewObjectTagging", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestOperationS3PutObjectCopyNewObjectTaggingValue in publicRequestOperationS3PutObjectCopyNewObjectTagging) 
                            {
                            
                            if (publicRequestOperationS3PutObjectCopyNewObjectTaggingValue != null) 
                            {
                                xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.Key));                 
                
                                if(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.Value));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockLegalHoldStatus())
                            xmlWriter.WriteElementString("ObjectLockLegalHoldStatus", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.ObjectLockLegalHoldStatus));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockMode())
                            xmlWriter.WriteElementString("ObjectLockMode", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.ObjectLockMode));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockRetainUntilDate())
                            xmlWriter.WriteElementString("ObjectLockRetainUntilDate", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequest.Operation.S3PutObjectCopy.ObjectLockRetainUntilDate));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetRedirectLocation())
                            xmlWriter.WriteElementString("RedirectLocation", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.RedirectLocation));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetRequesterPays())
                            xmlWriter.WriteElementString("RequesterPays", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Operation.S3PutObjectCopy.RequesterPays));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetSSEAwsKmsKeyId())
                            xmlWriter.WriteElementString("SSEAwsKmsKeyId", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.SSEAwsKmsKeyId));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetStorageClass())
                            xmlWriter.WriteElementString("StorageClass", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.StorageClass));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetTargetKeyPrefix())
                            xmlWriter.WriteElementString("TargetKeyPrefix", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.TargetKeyPrefix));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetTargetResource())
                            xmlWriter.WriteElementString("TargetResource", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.TargetResource));                 
        
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetUnModifiedSinceConstraint())
                            xmlWriter.WriteElementString("UnModifiedSinceConstraint", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequest.Operation.S3PutObjectCopy.UnModifiedSinceConstraint));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3PutObjectLegalHold != null) 
                    {
                        xmlWriter.WriteStartElement("S3PutObjectLegalHold", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        
                        if (publicRequest.Operation.S3PutObjectLegalHold.LegalHold != null) 
                        {
                            xmlWriter.WriteStartElement("LegalHold", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.Operation.S3PutObjectLegalHold.LegalHold.IsSetStatus())
                                xmlWriter.WriteElementString("Status", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectLegalHold.LegalHold.Status));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3PutObjectRetention != null) 
                    {
                        xmlWriter.WriteStartElement("S3PutObjectRetention", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequest.Operation.S3PutObjectRetention.IsSetBypassGovernanceRetention())
                            xmlWriter.WriteElementString("BypassGovernanceRetention", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Operation.S3PutObjectRetention.BypassGovernanceRetention));                 
        
                        
                        if (publicRequest.Operation.S3PutObjectRetention.Retention != null) 
                        {
                            xmlWriter.WriteStartElement("Retention", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                            if(publicRequest.Operation.S3PutObjectRetention.Retention.IsSetMode())
                                xmlWriter.WriteElementString("Mode", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Operation.S3PutObjectRetention.Retention.Mode));                 
            
                            if(publicRequest.Operation.S3PutObjectRetention.Retention.IsSetRetainUntilDate())
                                xmlWriter.WriteElementString("RetainUntilDate", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromDateTimeToISO8601(publicRequest.Operation.S3PutObjectRetention.Retention.RetainUntilDate));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.Operation.S3PutObjectTagging != null) 
                    {
                        xmlWriter.WriteStartElement("S3PutObjectTagging", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        var publicRequestOperationS3PutObjectTaggingTagSet = publicRequest.Operation.S3PutObjectTagging.TagSet;
                        if (publicRequestOperationS3PutObjectTaggingTagSet != null && publicRequestOperationS3PutObjectTaggingTagSet.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("TagSet", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                            foreach (var publicRequestOperationS3PutObjectTaggingTagSetValue in publicRequestOperationS3PutObjectTaggingTagSet) 
                            {
                            
                            if (publicRequestOperationS3PutObjectTaggingTagSetValue != null) 
                            {
                                xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                                if(publicRequestOperationS3PutObjectTaggingTagSetValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectTaggingTagSetValue.Key));                 
                
                                if(publicRequestOperationS3PutObjectTaggingTagSetValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestOperationS3PutObjectTaggingTagSetValue.Value));                 
                
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetPriority())
                    xmlWriter.WriteElementString("Priority", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromInt(publicRequest.Priority));                    

                
                if (publicRequest.Report != null) 
                {
                    xmlWriter.WriteStartElement("Report", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                    if(publicRequest.Report.IsSetBucket())
                        xmlWriter.WriteElementString("Bucket", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Report.Bucket));                 
    
                    if(publicRequest.Report.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromBool(publicRequest.Report.Enabled));                 
    
                    if(publicRequest.Report.IsSetFormat())
                        xmlWriter.WriteElementString("Format", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Report.Format));                 
    
                    if(publicRequest.Report.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Report.Prefix));                 
    
                    if(publicRequest.Report.IsSetReportScope())
                        xmlWriter.WriteElementString("ReportScope", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.Report.ReportScope));                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetRoleArn())
                    xmlWriter.WriteElementString("RoleArn", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequest.RoleArn));                    

                var publicRequestTags = publicRequest.Tags;
                if (publicRequestTags != null && publicRequestTags.Count > 0) 
                {                        
                    xmlWriter.WriteStartElement("Tags", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    
                    if (publicRequestTagsValue != null) 
                    {
                        xmlWriter.WriteStartElement("member", "http://awss3control.amazonaws.com/doc/2018-08-20/");            
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Key));                 
        
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", "http://awss3control.amazonaws.com/doc/2018-08-20/", StringUtils.FromString(publicRequestTagsValue.Value));                 
        
                        xmlWriter.WriteEndElement();
                    }
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
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-20";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }


            var hostPrefixLabels = new
            {
                AccountId = StringUtils.FromString(publicRequest.AccountId),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.AccountId))
                throw new AmazonS3ControlException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.AccountId}.";
            return request;
        }
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}