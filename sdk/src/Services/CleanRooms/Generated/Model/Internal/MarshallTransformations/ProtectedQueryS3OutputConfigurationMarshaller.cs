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
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProtectedQueryS3OutputConfiguration Marshaller
    /// </summary>
    public class ProtectedQueryS3OutputConfigurationMarshaller : IRequestMarshaller<ProtectedQueryS3OutputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProtectedQueryS3OutputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("bucket");
                context.Writer.Write(requestObject.Bucket);
            }

            if(requestObject.IsSetKeyPrefix())
            {
                context.Writer.WritePropertyName("keyPrefix");
                context.Writer.Write(requestObject.KeyPrefix);
            }

            if(requestObject.IsSetResultFormat())
            {
                context.Writer.WritePropertyName("resultFormat");
                context.Writer.Write(requestObject.ResultFormat);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProtectedQueryS3OutputConfigurationMarshaller Instance = new ProtectedQueryS3OutputConfigurationMarshaller();

    }
}