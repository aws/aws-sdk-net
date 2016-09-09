/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationDetail Object
    /// </summary>  
    public class ApplicationDetailUnmarshaller : IUnmarshaller<ApplicationDetail, XmlUnmarshallerContext>, IUnmarshaller<ApplicationDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ApplicationDetail IUnmarshaller<ApplicationDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ApplicationDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ApplicationDetail unmarshalledObject = new ApplicationDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputDescription, InputDescriptionUnmarshaller>(InputDescriptionUnmarshaller.Instance);
                    unmarshalledObject.InputDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputDescription, OutputDescriptionUnmarshaller>(OutputDescriptionUnmarshaller.Instance);
                    unmarshalledObject.OutputDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReferenceDataSourceDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReferenceDataSourceDescription, ReferenceDataSourceDescriptionUnmarshaller>(ReferenceDataSourceDescriptionUnmarshaller.Instance);
                    unmarshalledObject.ReferenceDataSourceDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ApplicationDetailUnmarshaller _instance = new ApplicationDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}