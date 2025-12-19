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
    /// CreateJob Request Marshaller
    /// </summary>       
    public partial class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            request.ResourcePath = "/v20180820/jobs";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateJobRequest", "http://awss3control.amazonaws.com/doc/2018-08-20/");
                if(publicRequest.IsSetClientRequestToken())
                    xmlWriter.WriteElementString("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                else                
                    xmlWriter.WriteElementString("ClientRequestToken", Guid.NewGuid().ToString());                

                if(publicRequest.IsSetConfirmationRequired())
                    xmlWriter.WriteElementString("ConfirmationRequired", StringUtils.FromBool(publicRequest.ConfirmationRequired.Value));

                if(publicRequest.IsSetDescription())
                    xmlWriter.WriteElementString("Description", StringUtils.FromString(publicRequest.Description));

                if (publicRequest.IsSetManifest())
                {
                    xmlWriter.WriteStartElement("Manifest");
                    if (publicRequest.Manifest.IsSetLocation())
                    {
                        xmlWriter.WriteStartElement("Location");
                        if(publicRequest.Manifest.Location.IsSetETag())
                            xmlWriter.WriteElementString("ETag", StringUtils.FromString(publicRequest.Manifest.Location.ETag));
                        if(publicRequest.Manifest.Location.IsSetObjectArn())
                            xmlWriter.WriteElementString("ObjectArn", StringUtils.FromString(publicRequest.Manifest.Location.ObjectArn));
                        if(publicRequest.Manifest.Location.IsSetObjectVersionId())
                            xmlWriter.WriteElementString("ObjectVersionId", StringUtils.FromString(publicRequest.Manifest.Location.ObjectVersionId));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Manifest.IsSetSpec())
                    {
                        xmlWriter.WriteStartElement("Spec");
                        var publicRequestManifestSpecFields = publicRequest.Manifest.Spec.Fields;
                        if (publicRequest.Manifest.Spec.IsSetFields()) 
                        {
                            xmlWriter.WriteStartElement("Fields");
                            foreach (var publicRequestManifestSpecFieldsValue in publicRequestManifestSpecFields) 
                            {
                                xmlWriter.WriteStartElement("member");
                                xmlWriter.WriteValue(publicRequestManifestSpecFieldsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Manifest.Spec.IsSetFormat())
                            xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.Manifest.Spec.Format));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.IsSetManifestGenerator())
                {
                    xmlWriter.WriteStartElement("ManifestGenerator");
                    if (publicRequest.ManifestGenerator.IsSetS3JobManifestGenerator())
                    {
                        xmlWriter.WriteStartElement("S3JobManifestGenerator");
                        if(publicRequest.ManifestGenerator.S3JobManifestGenerator.IsSetEnableManifestOutput())
                            xmlWriter.WriteElementString("EnableManifestOutput", StringUtils.FromBool(publicRequest.ManifestGenerator.S3JobManifestGenerator.EnableManifestOutput.Value));
                        if(publicRequest.ManifestGenerator.S3JobManifestGenerator.IsSetExpectedBucketOwner())
                            xmlWriter.WriteElementString("ExpectedBucketOwner", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ExpectedBucketOwner));
                        if (publicRequest.ManifestGenerator.S3JobManifestGenerator.IsSetFilter())
                        {
                            xmlWriter.WriteStartElement("Filter");
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetCreatedAfter())
                                xmlWriter.WriteElementString("CreatedAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.CreatedAfter.Value));
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetCreatedBefore())
                                xmlWriter.WriteElementString("CreatedBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.CreatedBefore.Value));
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetEligibleForReplication())
                                xmlWriter.WriteElementString("EligibleForReplication", StringUtils.FromBool(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.EligibleForReplication.Value));
                            if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetKeyNameConstraint())
                            {
                                xmlWriter.WriteStartElement("KeyNameConstraint");
                                var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnyPrefix = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.MatchAnyPrefix;
                                if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.IsSetMatchAnyPrefix()) 
                                {
                                    xmlWriter.WriteStartElement("MatchAnyPrefix");
                                    foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnyPrefixValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnyPrefix) 
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        xmlWriter.WriteValue(publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnyPrefixValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySubstring = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.MatchAnySubstring;
                                if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.IsSetMatchAnySubstring()) 
                                {
                                    xmlWriter.WriteStartElement("MatchAnySubstring");
                                    foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySubstringValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySubstring) 
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        xmlWriter.WriteValue(publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySubstringValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySuffix = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.MatchAnySuffix;
                                if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.KeyNameConstraint.IsSetMatchAnySuffix()) 
                                {
                                    xmlWriter.WriteStartElement("MatchAnySuffix");
                                    foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySuffixValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySuffix) 
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        xmlWriter.WriteValue(publicRequestManifestGeneratorS3JobManifestGeneratorFilterKeyNameConstraintMatchAnySuffixValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryption = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.MatchAnyObjectEncryption;
                            if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetMatchAnyObjectEncryption()) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyObjectEncryption");
                                foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryption) 
                                {
                                if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue != null)
                                {
                                    xmlWriter.WriteStartElement("ObjectEncryption");
                                    if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.IsSetDSSEKMS())
                                    {
                                        xmlWriter.WriteStartElement("DSSE-KMS");
                                        if(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.DSSEKMS.IsSetKmsKeyArn())
                                            xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.DSSEKMS.KmsKeyArn));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.IsSetNOTSSE())
                                    {
                                        xmlWriter.WriteStartElement("NOT-SSE");
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.IsSetSSEC())
                                    {
                                        xmlWriter.WriteStartElement("SSE-C");
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.IsSetSSEKMS())
                                    {
                                        xmlWriter.WriteStartElement("SSE-KMS");
                                        if(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.SSEKMS.IsSetBucketKeyEnabled())
                                            xmlWriter.WriteElementString("BucketKeyEnabled", StringUtils.FromBool(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.SSEKMS.BucketKeyEnabled.Value));
                                        if(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.SSEKMS.IsSetKmsKeyArn())
                                            xmlWriter.WriteElementString("KmsKeyArn", StringUtils.FromString(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.SSEKMS.KmsKeyArn));
                                        xmlWriter.WriteEndElement();
                                    }
                                    if (publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyObjectEncryptionValue.IsSetSSES3())
                                    {
                                        xmlWriter.WriteStartElement("SSE-S3");
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyStorageClass = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.MatchAnyStorageClass;
                            if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetMatchAnyStorageClass()) 
                            {
                                xmlWriter.WriteStartElement("MatchAnyStorageClass");
                                foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyStorageClassValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyStorageClass) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestManifestGeneratorS3JobManifestGeneratorFilterMatchAnyStorageClassValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestManifestGeneratorS3JobManifestGeneratorFilterObjectReplicationStatuses = publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.ObjectReplicationStatuses;
                            if (publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetObjectReplicationStatuses()) 
                            {
                                xmlWriter.WriteStartElement("ObjectReplicationStatuses");
                                foreach (var publicRequestManifestGeneratorS3JobManifestGeneratorFilterObjectReplicationStatusesValue in publicRequestManifestGeneratorS3JobManifestGeneratorFilterObjectReplicationStatuses) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestManifestGeneratorS3JobManifestGeneratorFilterObjectReplicationStatusesValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetObjectSizeGreaterThanBytes())
                                xmlWriter.WriteElementString("ObjectSizeGreaterThanBytes", StringUtils.FromLong(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.ObjectSizeGreaterThanBytes.Value));
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.IsSetObjectSizeLessThanBytes())
                                xmlWriter.WriteElementString("ObjectSizeLessThanBytes", StringUtils.FromLong(publicRequest.ManifestGenerator.S3JobManifestGenerator.Filter.ObjectSizeLessThanBytes.Value));
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.ManifestGenerator.S3JobManifestGenerator.IsSetManifestOutputLocation())
                        {
                            xmlWriter.WriteStartElement("ManifestOutputLocation");
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.IsSetBucket())
                                xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.Bucket));
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.IsSetExpectedManifestBucketOwner())
                                xmlWriter.WriteElementString("ExpectedManifestBucketOwner", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ExpectedManifestBucketOwner));
                            if (publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.IsSetManifestEncryption())
                            {
                                xmlWriter.WriteStartElement("ManifestEncryption");
                                if (publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestEncryption.IsSetSSEKMS())
                                {
                                    xmlWriter.WriteStartElement("SSE-KMS");
                                    if(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestEncryption.SSEKMS.IsSetKeyId())
                                        xmlWriter.WriteElementString("KeyId", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestEncryption.SSEKMS.KeyId));
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestEncryption.IsSetSSES3())
                                {
                                    xmlWriter.WriteStartElement("SSE-S3");
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.IsSetManifestFormat())
                                xmlWriter.WriteElementString("ManifestFormat", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestFormat));
                            if(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.IsSetManifestPrefix())
                                xmlWriter.WriteElementString("ManifestPrefix", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.ManifestOutputLocation.ManifestPrefix));
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.ManifestGenerator.S3JobManifestGenerator.IsSetSourceBucket())
                            xmlWriter.WriteElementString("SourceBucket", StringUtils.FromString(publicRequest.ManifestGenerator.S3JobManifestGenerator.SourceBucket));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.IsSetOperation())
                {
                    xmlWriter.WriteStartElement("Operation");
                    if (publicRequest.Operation.IsSetLambdaInvoke())
                    {
                        xmlWriter.WriteStartElement("LambdaInvoke");
                        if(publicRequest.Operation.LambdaInvoke.IsSetFunctionArn())
                            xmlWriter.WriteElementString("FunctionArn", StringUtils.FromString(publicRequest.Operation.LambdaInvoke.FunctionArn));
                        if(publicRequest.Operation.LambdaInvoke.IsSetInvocationSchemaVersion())
                            xmlWriter.WriteElementString("InvocationSchemaVersion", StringUtils.FromString(publicRequest.Operation.LambdaInvoke.InvocationSchemaVersion));
                        if (publicRequest.Operation.LambdaInvoke.IsSetUserArguments())
                        {
                            xmlWriter.WriteStartElement("UserArguments");
                            foreach (var kvp in publicRequest.Operation.LambdaInvoke.UserArguments)
                            {
                                xmlWriter.WriteStartElement("entry");

                                xmlWriter.WriteElementString("key", kvp.Key);
                                xmlWriter.WriteElementString("value", kvp.Value);
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3ComputeObjectChecksum())
                    {
                        xmlWriter.WriteStartElement("S3ComputeObjectChecksum");
                        if(publicRequest.Operation.S3ComputeObjectChecksum.IsSetChecksumAlgorithm())
                            xmlWriter.WriteElementString("ChecksumAlgorithm", StringUtils.FromString(publicRequest.Operation.S3ComputeObjectChecksum.ChecksumAlgorithm));
                        if(publicRequest.Operation.S3ComputeObjectChecksum.IsSetChecksumType())
                            xmlWriter.WriteElementString("ChecksumType", StringUtils.FromString(publicRequest.Operation.S3ComputeObjectChecksum.ChecksumType));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3DeleteObjectTagging())
                    {
                        xmlWriter.WriteStartElement("S3DeleteObjectTagging");
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3InitiateRestoreObject())
                    {
                        xmlWriter.WriteStartElement("S3InitiateRestoreObject");
                        if(publicRequest.Operation.S3InitiateRestoreObject.IsSetExpirationInDays())
                            xmlWriter.WriteElementString("ExpirationInDays", StringUtils.FromInt(publicRequest.Operation.S3InitiateRestoreObject.ExpirationInDays.Value));
                        if(publicRequest.Operation.S3InitiateRestoreObject.IsSetGlacierJobTier())
                            xmlWriter.WriteElementString("GlacierJobTier", StringUtils.FromString(publicRequest.Operation.S3InitiateRestoreObject.GlacierJobTier));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3PutObjectAcl())
                    {
                        xmlWriter.WriteStartElement("S3PutObjectAcl");
                        if (publicRequest.Operation.S3PutObjectAcl.IsSetAccessControlPolicy())
                        {
                            xmlWriter.WriteStartElement("AccessControlPolicy");
                            if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.IsSetAccessControlList())
                            {
                                xmlWriter.WriteStartElement("AccessControlList");
                                var publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants = publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Grants;
                                if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.IsSetGrants()) 
                                {
                                    xmlWriter.WriteStartElement("Grants");
                                    foreach (var publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue in publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrants) 
                                    {
                                    if (publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        if (publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.IsSetGrantee())
                                        {
                                            xmlWriter.WriteStartElement("Grantee");
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetDisplayName())
                                                xmlWriter.WriteElementString("DisplayName", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.DisplayName));
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetIdentifier())
                                                xmlWriter.WriteElementString("Identifier", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.Identifier));
                                            if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.IsSetTypeIdentifier())
                                                xmlWriter.WriteElementString("TypeIdentifier", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Grantee.TypeIdentifier));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.IsSetPermission())
                                            xmlWriter.WriteElementString("Permission", StringUtils.FromString(publicRequestOperationS3PutObjectAclAccessControlPolicyAccessControlListGrantsValue.Permission));
                                        xmlWriter.WriteEndElement();
                                    }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if (publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.IsSetOwner())
                                {
                                    xmlWriter.WriteStartElement("Owner");
                                    if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.DisplayName));
                                    if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.IsSetID())
                                        xmlWriter.WriteElementString("ID", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.AccessControlList.Owner.ID));
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.IsSetCannedAccessControlList())
                                xmlWriter.WriteElementString("CannedAccessControlList", StringUtils.FromString(publicRequest.Operation.S3PutObjectAcl.AccessControlPolicy.CannedAccessControlList));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3PutObjectCopy())
                    {
                        xmlWriter.WriteStartElement("S3PutObjectCopy");
                        var publicRequestOperationS3PutObjectCopyAccessControlGrants = publicRequest.Operation.S3PutObjectCopy.AccessControlGrants;
                        if (publicRequest.Operation.S3PutObjectCopy.IsSetAccessControlGrants()) 
                        {
                            xmlWriter.WriteStartElement("AccessControlGrants");
                            foreach (var publicRequestOperationS3PutObjectCopyAccessControlGrantsValue in publicRequestOperationS3PutObjectCopyAccessControlGrants) 
                            {
                            if (publicRequestOperationS3PutObjectCopyAccessControlGrantsValue != null)
                            {
                                xmlWriter.WriteStartElement("member");
                                if (publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.IsSetGrantee())
                                {
                                    xmlWriter.WriteStartElement("Grantee");
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetDisplayName())
                                        xmlWriter.WriteElementString("DisplayName", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.DisplayName));
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetIdentifier())
                                        xmlWriter.WriteElementString("Identifier", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.Identifier));
                                    if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.IsSetTypeIdentifier())
                                        xmlWriter.WriteElementString("TypeIdentifier", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Grantee.TypeIdentifier));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.IsSetPermission())
                                    xmlWriter.WriteElementString("Permission", StringUtils.FromString(publicRequestOperationS3PutObjectCopyAccessControlGrantsValue.Permission));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetBucketKeyEnabled())
                            xmlWriter.WriteElementString("BucketKeyEnabled", StringUtils.FromBool(publicRequest.Operation.S3PutObjectCopy.BucketKeyEnabled.Value));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetCannedAccessControlList())
                            xmlWriter.WriteElementString("CannedAccessControlList", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.CannedAccessControlList));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetChecksumAlgorithm())
                            xmlWriter.WriteElementString("ChecksumAlgorithm", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.ChecksumAlgorithm));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetMetadataDirective())
                            xmlWriter.WriteElementString("MetadataDirective", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.MetadataDirective));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetModifiedSinceConstraint())
                            xmlWriter.WriteElementString("ModifiedSinceConstraint", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Operation.S3PutObjectCopy.ModifiedSinceConstraint.Value));
                        if (publicRequest.Operation.S3PutObjectCopy.IsSetNewObjectMetadata())
                        {
                            xmlWriter.WriteStartElement("NewObjectMetadata");
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetCacheControl())
                                xmlWriter.WriteElementString("CacheControl", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.CacheControl));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentDisposition())
                                xmlWriter.WriteElementString("ContentDisposition", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentDisposition));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentEncoding())
                                xmlWriter.WriteElementString("ContentEncoding", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentEncoding));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentLanguage())
                                xmlWriter.WriteElementString("ContentLanguage", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentLanguage));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentLength())
                                xmlWriter.WriteElementString("ContentLength", StringUtils.FromLong(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentLength.Value));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentMD5())
                                xmlWriter.WriteElementString("ContentMD5", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentMD5));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetContentType())
                                xmlWriter.WriteElementString("ContentType", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.ContentType));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetHttpExpiresDate())
                                xmlWriter.WriteElementString("HttpExpiresDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.HttpExpiresDate.Value));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetRequesterCharged())
                                xmlWriter.WriteElementString("RequesterCharged", StringUtils.FromBool(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.RequesterCharged.Value));
                            if(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetSSEAlgorithm())
                                xmlWriter.WriteElementString("SSEAlgorithm", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.SSEAlgorithm));
                            if (publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.IsSetUserMetadata())
                            {
                                xmlWriter.WriteStartElement("UserMetadata");
                                foreach (var kvp in publicRequest.Operation.S3PutObjectCopy.NewObjectMetadata.UserMetadata)
                                {
                                    xmlWriter.WriteStartElement("entry");

                                    xmlWriter.WriteElementString("key", kvp.Key);
                                    xmlWriter.WriteElementString("value", kvp.Value);
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        var publicRequestOperationS3PutObjectCopyNewObjectTagging = publicRequest.Operation.S3PutObjectCopy.NewObjectTagging;
                        if (publicRequest.Operation.S3PutObjectCopy.IsSetNewObjectTagging()) 
                        {
                            xmlWriter.WriteStartElement("NewObjectTagging");
                            foreach (var publicRequestOperationS3PutObjectCopyNewObjectTaggingValue in publicRequestOperationS3PutObjectCopyNewObjectTagging) 
                            {
                            if (publicRequestOperationS3PutObjectCopyNewObjectTaggingValue != null)
                            {
                                xmlWriter.WriteStartElement("member");
                                if(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.Key));
                                if(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestOperationS3PutObjectCopyNewObjectTaggingValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockLegalHoldStatus())
                            xmlWriter.WriteElementString("ObjectLockLegalHoldStatus", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.ObjectLockLegalHoldStatus));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockMode())
                            xmlWriter.WriteElementString("ObjectLockMode", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.ObjectLockMode));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetObjectLockRetainUntilDate())
                            xmlWriter.WriteElementString("ObjectLockRetainUntilDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Operation.S3PutObjectCopy.ObjectLockRetainUntilDate.Value));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetRedirectLocation())
                            xmlWriter.WriteElementString("RedirectLocation", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.RedirectLocation));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetRequesterPays())
                            xmlWriter.WriteElementString("RequesterPays", StringUtils.FromBool(publicRequest.Operation.S3PutObjectCopy.RequesterPays.Value));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetSSEAwsKmsKeyId())
                            xmlWriter.WriteElementString("SSEAwsKmsKeyId", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.SSEAwsKmsKeyId));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetStorageClass())
                            xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.StorageClass));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetTargetKeyPrefix())
                            xmlWriter.WriteElementString("TargetKeyPrefix", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.TargetKeyPrefix));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetTargetResource())
                            xmlWriter.WriteElementString("TargetResource", StringUtils.FromString(publicRequest.Operation.S3PutObjectCopy.TargetResource));
                        if(publicRequest.Operation.S3PutObjectCopy.IsSetUnModifiedSinceConstraint())
                            xmlWriter.WriteElementString("UnModifiedSinceConstraint", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Operation.S3PutObjectCopy.UnModifiedSinceConstraint.Value));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3PutObjectLegalHold())
                    {
                        xmlWriter.WriteStartElement("S3PutObjectLegalHold");
                        if (publicRequest.Operation.S3PutObjectLegalHold.IsSetLegalHold())
                        {
                            xmlWriter.WriteStartElement("LegalHold");
                            if(publicRequest.Operation.S3PutObjectLegalHold.LegalHold.IsSetStatus())
                                xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequest.Operation.S3PutObjectLegalHold.LegalHold.Status));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3PutObjectRetention())
                    {
                        xmlWriter.WriteStartElement("S3PutObjectRetention");
                        if(publicRequest.Operation.S3PutObjectRetention.IsSetBypassGovernanceRetention())
                            xmlWriter.WriteElementString("BypassGovernanceRetention", StringUtils.FromBool(publicRequest.Operation.S3PutObjectRetention.BypassGovernanceRetention.Value));
                        if (publicRequest.Operation.S3PutObjectRetention.IsSetRetention())
                        {
                            xmlWriter.WriteStartElement("Retention");
                            if(publicRequest.Operation.S3PutObjectRetention.Retention.IsSetMode())
                                xmlWriter.WriteElementString("Mode", StringUtils.FromString(publicRequest.Operation.S3PutObjectRetention.Retention.Mode));
                            if(publicRequest.Operation.S3PutObjectRetention.Retention.IsSetRetainUntilDate())
                                xmlWriter.WriteElementString("RetainUntilDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.Operation.S3PutObjectRetention.Retention.RetainUntilDate.Value));
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3PutObjectTagging())
                    {
                        xmlWriter.WriteStartElement("S3PutObjectTagging");
                        var publicRequestOperationS3PutObjectTaggingTagSet = publicRequest.Operation.S3PutObjectTagging.TagSet;
                        if (publicRequest.Operation.S3PutObjectTagging.IsSetTagSet()) 
                        {
                            xmlWriter.WriteStartElement("TagSet");
                            foreach (var publicRequestOperationS3PutObjectTaggingTagSetValue in publicRequestOperationS3PutObjectTaggingTagSet) 
                            {
                            if (publicRequestOperationS3PutObjectTaggingTagSetValue != null)
                            {
                                xmlWriter.WriteStartElement("member");
                                if(publicRequestOperationS3PutObjectTaggingTagSetValue.IsSetKey())
                                    xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestOperationS3PutObjectTaggingTagSetValue.Key));
                                if(publicRequestOperationS3PutObjectTaggingTagSetValue.IsSetValue())
                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestOperationS3PutObjectTaggingTagSetValue.Value));
                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.Operation.IsSetS3ReplicateObject())
                    {
                        xmlWriter.WriteStartElement("S3ReplicateObject");
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetPriority())
                    xmlWriter.WriteElementString("Priority", StringUtils.FromInt(publicRequest.Priority.Value));

                if (publicRequest.IsSetReport())
                {
                    xmlWriter.WriteStartElement("Report");
                    if(publicRequest.Report.IsSetBucket())
                        xmlWriter.WriteElementString("Bucket", StringUtils.FromString(publicRequest.Report.Bucket));
                    if(publicRequest.Report.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.Report.Enabled.Value));
                    if(publicRequest.Report.IsSetExpectedBucketOwner())
                        xmlWriter.WriteElementString("ExpectedBucketOwner", StringUtils.FromString(publicRequest.Report.ExpectedBucketOwner));
                    if(publicRequest.Report.IsSetFormat())
                        xmlWriter.WriteElementString("Format", StringUtils.FromString(publicRequest.Report.Format));
                    if(publicRequest.Report.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.Report.Prefix));
                    if(publicRequest.Report.IsSetReportScope())
                        xmlWriter.WriteElementString("ReportScope", StringUtils.FromString(publicRequest.Report.ReportScope));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetRoleArn())
                    xmlWriter.WriteElementString("RoleArn", StringUtils.FromString(publicRequest.RoleArn));

                var publicRequestTags = publicRequest.Tags;
                if (publicRequest.IsSetTags()) 
                {
                    xmlWriter.WriteStartElement("Tags");
                    foreach (var publicRequestTagsValue in publicRequestTags) 
                    {
                    if (publicRequestTagsValue != null)
                    {
                        xmlWriter.WriteStartElement("member");
                        if(publicRequestTagsValue.IsSetKey())
                            xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestTagsValue.Key));
                        if(publicRequestTagsValue.IsSetValue())
                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestTagsValue.Value));
                        xmlWriter.WriteEndElement();
                    }
                    }            
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, CreateJobRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, CreateJobRequest publicRequest);
    }    
}