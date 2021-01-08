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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Location Marshaller
    /// </summary>       
    public class LocationMarshaller : IRequestMarshaller<Location, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Location requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDynamoDB())
            {
                context.Writer.WritePropertyName("DynamoDB");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDynamoDBListValue in requestObject.DynamoDB)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CodeGenNodeArgMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamoDBListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJdbc())
            {
                context.Writer.WritePropertyName("Jdbc");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectJdbcListValue in requestObject.Jdbc)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CodeGenNodeArgMarshaller.Instance;
                    marshaller.Marshall(requestObjectJdbcListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("S3");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectS3ListValue in requestObject.S3)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CodeGenNodeArgMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3ListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LocationMarshaller Instance = new LocationMarshaller();

    }
}