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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;
using Amazon.Util;
using System;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RenameObject Request Marshaller
    /// </summary>       
    public partial class RenameObjectRequestMarshaller : IMarshaller<IRequest, RenameObjectRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, RenameObjectRequest publicRequest)
        {
            
            if (renameObjectRequest == null)
                throw new ArgumentNullException(nameof(renameObjectRequest));

            if (!publicRequest.IsSetRenameSource())
            {
                throw new ArgumentException("RenameSource is a required property and must be set before making this call.", nameof(publicRequest));
            }

            /// For backward compatibility with the previous custom implementation, we automatically generate
            /// a unique client token (GUID) when the caller doesn't explicitly set one. This complements the
            /// generated RenameObjectRequestMarshaller.Marshall() method (in the Generated folder), which
            /// handles the check for ClientToken existence.
            if (!publicRequest.IsSetClientToken())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzClientTokenHeader, Guid.NewGuid().ToString());
            }
        }
    }
}