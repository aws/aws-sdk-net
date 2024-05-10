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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEfsAccessPointDetails Marshaller
    /// </summary>
    public class AwsEfsAccessPointDetailsMarshaller : IRequestMarshaller<AwsEfsAccessPointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEfsAccessPointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessPointId())
            {
                context.Writer.WritePropertyName("AccessPointId");
                context.Writer.Write(requestObject.AccessPointId);
            }

            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.Write(requestObject.ClientToken);
            }

            if(requestObject.IsSetFileSystemId())
            {
                context.Writer.WritePropertyName("FileSystemId");
                context.Writer.Write(requestObject.FileSystemId);
            }

            if(requestObject.IsSetPosixUser())
            {
                context.Writer.WritePropertyName("PosixUser");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEfsAccessPointPosixUserDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.PosixUser, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRootDirectory())
            {
                context.Writer.WritePropertyName("RootDirectory");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEfsAccessPointRootDirectoryDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RootDirectory, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEfsAccessPointDetailsMarshaller Instance = new AwsEfsAccessPointDetailsMarshaller();

    }
}