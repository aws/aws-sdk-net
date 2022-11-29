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
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DestinationDescription Object
    /// </summary>  
    public class DestinationDescriptionUnmarshaller : IUnmarshaller<DestinationDescription, XmlUnmarshallerContext>, IUnmarshaller<DestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DestinationDescription IUnmarshaller<DestinationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DestinationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DestinationDescription unmarshalledObject = new DestinationDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmazonOpenSearchServerlessDestinationDescription", targetDepth))
                {
                    var unmarshaller = AmazonOpenSearchServerlessDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.AmazonOpenSearchServerlessDestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmazonopensearchserviceDestinationDescription", targetDepth))
                {
                    var unmarshaller = AmazonopensearchserviceDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.AmazonopensearchserviceDestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticsearchDestinationDescription", targetDepth))
                {
                    var unmarshaller = ElasticsearchDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchDestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtendedS3DestinationDescription", targetDepth))
                {
                    var unmarshaller = ExtendedS3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ExtendedS3DestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpEndpointDestinationDescription", targetDepth))
                {
                    var unmarshaller = HttpEndpointDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.HttpEndpointDestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftDestinationDescription", targetDepth))
                {
                    var unmarshaller = RedshiftDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.RedshiftDestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SplunkDestinationDescription", targetDepth))
                {
                    var unmarshaller = SplunkDestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SplunkDestinationDescription = unmarshaller.Unmarshall(context);
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