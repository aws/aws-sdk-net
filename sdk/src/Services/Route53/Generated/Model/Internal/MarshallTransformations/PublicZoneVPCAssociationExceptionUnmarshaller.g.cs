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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for PublicZoneVPCAssociationException
    /// </summary>
    public partial class PublicZoneVPCAssociationExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<PublicZoneVPCAssociationException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public PublicZoneVPCAssociationException Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public PublicZoneVPCAssociationException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            PublicZoneVPCAssociationException unmarshalledObject = new PublicZoneVPCAssociationException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
            }
            return unmarshalledObject;
        }

        private static PublicZoneVPCAssociationExceptionUnmarshaller _instance = new PublicZoneVPCAssociationExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PublicZoneVPCAssociationExceptionUnmarshaller Instance => _instance;
    }
}
