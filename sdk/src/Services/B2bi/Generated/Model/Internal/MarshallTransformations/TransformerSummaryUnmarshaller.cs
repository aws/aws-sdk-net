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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TransformerSummary Object
    /// </summary>  
    public class TransformerSummaryUnmarshaller : IUnmarshaller<TransformerSummary, XmlUnmarshallerContext>, IUnmarshaller<TransformerSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TransformerSummary IUnmarshaller<TransformerSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TransformerSummary Unmarshall(JsonUnmarshallerContext context)
        {
            TransformerSummary unmarshalledObject = new TransformerSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ediType", targetDepth))
                {
                    var unmarshaller = EdiTypeUnmarshaller.Instance;
                    unmarshalledObject.EdiType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputConversion", targetDepth))
                {
                    var unmarshaller = InputConversionUnmarshaller.Instance;
                    unmarshalledObject.InputConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mapping", targetDepth))
                {
                    var unmarshaller = MappingUnmarshaller.Instance;
                    unmarshalledObject.Mapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mappingTemplate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MappingTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputConversion", targetDepth))
                {
                    var unmarshaller = OutputConversionUnmarshaller.Instance;
                    unmarshalledObject.OutputConversion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleDocument", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleDocuments", targetDepth))
                {
                    var unmarshaller = SampleDocumentsUnmarshaller.Instance;
                    unmarshalledObject.SampleDocuments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transformerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransformerId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransformerSummaryUnmarshaller _instance = new TransformerSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransformerSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}