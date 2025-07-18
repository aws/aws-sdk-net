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

using System.Collections.Generic;
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
    /// Put Bucket Request Marshaller
    /// </summary>       
    public partial class PutBucketRequestMarshaller : IMarshaller<IRequest, PutBucketRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        protected internal static void ConvertPutWithACLRequest(PutWithACLRequest request, IRequest irequest)
        {
            Dictionary<S3Permission, string> protoHeaders = new Dictionary<S3Permission, string>();
            if (request.Grants != null)
            {
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

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketRequest publicRequest)
        {
            // the NoAcl logic exists because it was originally a part of the IsSetCannedACL()
            // method https://github.com/aws/aws-sdk-net/blob/623dc261499331cb38bfec47789ddc4ef456222c/sdk/src/Services/S3/Custom/Model/PutBucketRequest.cs#L195-L198
            if (publicRequest.IsSetCannedACL() && publicRequest.CannedACL == S3CannedACL.NoACL)
                defaultRequest.Headers.Remove("x-amz-acl");
            if (publicRequest.IsSetCannedACL())
                return;
            else if (publicRequest.Grants != null && publicRequest.Grants.Count > 0)
                ConvertPutWithACLRequest(publicRequest, defaultRequest);
        }
    }
}

