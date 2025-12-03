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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Restore Object Request Marshaller
    /// </summary>       
    public partial class RestoreObjectRequestMarshaller : IMarshaller<IRequest, RestoreObjectRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
    {
        // UserMetadata needs a custom marshall because the model defines usermetadata as a list but the custom code had this as a dictionary. Even though S3 models this as a list
        // upon closer inspection the list has only two members which are Name and Value, so a dictionary makes more sense here anyways.
        void UserMetadataCustomMarshall(XmlWriter xmlWriter, RestoreObjectRequest publicRequest)
        {
            if (publicRequest.OutputLocation.S3.IsSetUserMetadata())
                publicRequest.OutputLocation.S3.UserMetadata.Marshall("UserMetadata", xmlWriter);
        }

        // Tier needs a custom marshall because Tier is actually a member of the GlacierJobParameters member on RestoreRequest. But since RestoreRequest has been flattened and moved up to the parent.
        // and Tier is nested inside RestoreRequest, the IsSet method will check RestoreRequest's Tier shape instead of checking it on the top-level RestoreObjectRequest.
        void TierCustomMarshall(XmlWriter xmlWriter, RestoreObjectRequest publicRequest)
        {
            if (publicRequest.IsSetTier())
            {
                xmlWriter.WriteStartElement("GlacierJobParameters");
                    xmlWriter.WriteElementString("Tier", StringUtils.FromString(publicRequest.Tier));
                xmlWriter.WriteEndElement();
            }
        }

        // AccessControlList needs a custom marshall because even though the model defines this as an AccessControlList which is just a list of grants, we created S3AccessControlList which contains
        // both a list of grants and an Owner shape. S3AccessControlList is shared across different operations as well, and in this specific case, it has its own marshall which only marshalls the 
        // grants and not the owner.
        void AccessControlListCustomMarshall(XmlWriter xmlWriter, RestoreObjectRequest publicRequest)
        {
            if (publicRequest.OutputLocation.S3.IsSetAccessControlList())
            {
                publicRequest.OutputLocation.S3.AccessControlList.Marshall("AccessControlList", xmlWriter);
            }
        }

        // All the validations from the custom code moved here for backwards compatibility
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, RestoreObjectRequest publicRequest)
        {
            if (publicRequest.SelectParameters != null)
            {
                if (!publicRequest.SelectParameters.IsSetInputSerialization()) throw new System.ArgumentException("SelectParameters.InputSerialization is a required property and must be set before making this call.");
                if (!publicRequest.SelectParameters.IsSetExpression()) throw new System.ArgumentException("SelectParameters.Expression is a required property and must be set before making this call.");
                if (!publicRequest.SelectParameters.IsSetExpressionType()) throw new System.ArgumentException("SelectParameters.ExpressionType is a required property and must be set before making this call.");
                if (!publicRequest.SelectParameters.IsSetOutputSerialization()) throw new System.ArgumentException("SelectParameters.OutputSerialization is a required property and must be set before making this call.");
            }

            if (publicRequest.OutputLocation != null && publicRequest.OutputLocation.S3 != null)
            {
                if (string.IsNullOrEmpty(publicRequest.OutputLocation.S3.BucketName)) throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "S3Location.BucketName");
                if (string.IsNullOrEmpty(publicRequest.OutputLocation.S3.Prefix)) throw new System.ArgumentException("Prefix is a required property and must be set before making this call.", "S3Location.Prefix");
                if (publicRequest.OutputLocation.S3.Encryption != null)
                {
                    if (!publicRequest.OutputLocation.S3.Encryption.IsSetEncryptionType()) throw new System.ArgumentException("EncryptionType is a required property and must be set before making this call.", "S3Encryption.EncryptionType");
                }
            }
        }
    }
}

