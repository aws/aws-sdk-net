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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3ContentLocationUpdate Marshaller
    /// </summary>       
    public class S3ContentLocationUpdateMarshaller : IRequestMarshaller<S3ContentLocationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3ContentLocationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketARNUpdate())
            {
                context.Writer.WritePropertyName("BucketARNUpdate");
                context.Writer.Write(requestObject.BucketARNUpdate);
            }

            if(requestObject.IsSetFileKeyUpdate())
            {
                context.Writer.WritePropertyName("FileKeyUpdate");
                context.Writer.Write(requestObject.FileKeyUpdate);
            }

            if(requestObject.IsSetObjectVersionUpdate())
            {
                context.Writer.WritePropertyName("ObjectVersionUpdate");
                context.Writer.Write(requestObject.ObjectVersionUpdate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3ContentLocationUpdateMarshaller Instance = new S3ContentLocationUpdateMarshaller();

    }
}