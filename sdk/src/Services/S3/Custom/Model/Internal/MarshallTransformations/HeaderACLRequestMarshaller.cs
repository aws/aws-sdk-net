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

using System.Collections.Generic;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public static class HeaderACLRequestMarshaller
    {
        public static void Marshall(IRequest request, PutWithACLRequest aclRequest)
        {
            var protoHeaders = new Dictionary<S3Permission, string>();
            foreach (var grant in aclRequest.Grants)
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
                if (S3Permission.READ == permission)
                    request.Headers[S3Constants.AmzGrantHeaderRead] = protoHeaders[permission];
                else if (S3Permission.WRITE == permission)
                    request.Headers[S3Constants.AmzGrantHeaderWrite] = protoHeaders[permission];
                else if (S3Permission.READ_ACP == permission)
                    request.Headers[S3Constants.AmzGrantHeaderReadAcp] = protoHeaders[permission];
                else if (S3Permission.WRITE_ACP == permission)
                    request.Headers[S3Constants.AmzGrantHeaderWriteAcp] = protoHeaders[permission];
                else if (S3Permission.RESTORE_OBJECT == permission)
                    request.Headers[S3Constants.AmzGrantHeaderRestoreObject] = protoHeaders[permission];
                else if (S3Permission.FULL_CONTROL == permission)
                    request.Headers[S3Constants.AmzGrantHeaderFullControl] = protoHeaders[permission];
            }
        }
    }
}
