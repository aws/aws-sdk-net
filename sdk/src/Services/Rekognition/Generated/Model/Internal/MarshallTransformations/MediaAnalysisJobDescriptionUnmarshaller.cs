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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MediaAnalysisJobDescription Object
    /// </summary>  
    public class MediaAnalysisJobDescriptionUnmarshaller : IUnmarshaller<MediaAnalysisJobDescription, XmlUnmarshallerContext>, IUnmarshaller<MediaAnalysisJobDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MediaAnalysisJobDescription IUnmarshaller<MediaAnalysisJobDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MediaAnalysisJobDescription Unmarshall(JsonUnmarshallerContext context)
        {
            MediaAnalysisJobDescription unmarshalledObject = new MediaAnalysisJobDescription();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CompletionTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletionTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureDetails", targetDepth))
                {
                    var unmarshaller = MediaAnalysisJobFailureDetailsUnmarshaller.Instance;
                    unmarshalledObject.FailureDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Input", targetDepth))
                {
                    var unmarshaller = MediaAnalysisInputUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestSummary", targetDepth))
                {
                    var unmarshaller = MediaAnalysisManifestSummaryUnmarshaller.Instance;
                    unmarshalledObject.ManifestSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OperationsConfig", targetDepth))
                {
                    var unmarshaller = MediaAnalysisOperationsConfigUnmarshaller.Instance;
                    unmarshalledObject.OperationsConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputConfig", targetDepth))
                {
                    var unmarshaller = MediaAnalysisOutputConfigUnmarshaller.Instance;
                    unmarshalledObject.OutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Results", targetDepth))
                {
                    var unmarshaller = MediaAnalysisResultsUnmarshaller.Instance;
                    unmarshalledObject.Results = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MediaAnalysisJobDescriptionUnmarshaller _instance = new MediaAnalysisJobDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MediaAnalysisJobDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618