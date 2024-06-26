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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImportTableDescription Object
    /// </summary>  
    public class ImportTableDescriptionUnmarshaller : IUnmarshaller<ImportTableDescription, XmlUnmarshallerContext>, IUnmarshaller<ImportTableDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImportTableDescription IUnmarshaller<ImportTableDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ImportTableDescription Unmarshall(JsonUnmarshallerContext context)
        {
            ImportTableDescription unmarshalledObject = new ImportTableDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ClientToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchLogGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLogGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ErrorCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImportArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportedItemCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ImportedItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImportStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputCompressionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputCompressionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputFormatOptions", targetDepth))
                {
                    var unmarshaller = InputFormatOptionsUnmarshaller.Instance;
                    unmarshalledObject.InputFormatOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessedItemCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProcessedItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessedSizeBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProcessedSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BucketSource", targetDepth))
                {
                    var unmarshaller = S3BucketSourceUnmarshaller.Instance;
                    unmarshalledObject.S3BucketSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableCreationParameters", targetDepth))
                {
                    var unmarshaller = TableCreationParametersUnmarshaller.Instance;
                    unmarshalledObject.TableCreationParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ImportTableDescriptionUnmarshaller _instance = new ImportTableDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportTableDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}