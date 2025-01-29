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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DestinationDescription Object
    /// </summary>  
    public class DestinationDescriptionUnmarshaller : IJsonUnmarshaller<DestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DestinationDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DestinationDescription unmarshalledObject = new DestinationDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AmazonOpenSearchServerlessDestinationDescription", targetDepth))
                {
                    var unmarshaller = AmazonOpenSearchServerlessDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.AmazonOpenSearchServerlessDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonopensearchserviceDestinationDescription", targetDepth))
                {
                    var unmarshaller = AmazonopensearchserviceDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.AmazonopensearchserviceDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DestinationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElasticsearchDestinationDescription", targetDepth))
                {
                    var unmarshaller = ElasticsearchDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExtendedS3DestinationDescription", targetDepth))
                {
                    var unmarshaller = ExtendedS3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ExtendedS3DestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HttpEndpointDestinationDescription", targetDepth))
                {
                    var unmarshaller = HttpEndpointDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.HttpEndpointDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IcebergDestinationDescription", targetDepth))
                {
                    var unmarshaller = IcebergDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.IcebergDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftDestinationDescription", targetDepth))
                {
                    var unmarshaller = RedshiftDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.RedshiftDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeDestinationDescription", targetDepth))
                {
                    var unmarshaller = SnowflakeDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SplunkDestinationDescription", targetDepth))
                {
                    var unmarshaller = SplunkDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SplunkDestinationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DestinationDescriptionUnmarshaller _instance = new DestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}