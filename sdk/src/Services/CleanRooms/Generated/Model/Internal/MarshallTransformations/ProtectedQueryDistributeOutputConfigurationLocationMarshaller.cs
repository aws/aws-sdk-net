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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProtectedQueryDistributeOutputConfigurationLocation Marshaller
    /// </summary>
    public class ProtectedQueryDistributeOutputConfigurationLocationMarshaller : IRequestMarshaller<ProtectedQueryDistributeOutputConfigurationLocation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProtectedQueryDistributeOutputConfigurationLocation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMember())
            {
                context.Writer.WritePropertyName("member");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedQueryMemberOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Member, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("s3");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedQueryS3OutputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProtectedQueryDistributeOutputConfigurationLocationMarshaller Instance = new ProtectedQueryDistributeOutputConfigurationLocationMarshaller();

    }
}