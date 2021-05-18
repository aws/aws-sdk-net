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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReportGenerator Object
    /// </summary>  
    public class ReportGeneratorUnmarshaller : IUnmarshaller<ReportGenerator, XmlUnmarshallerContext>, IUnmarshaller<ReportGenerator, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReportGenerator IUnmarshaller<ReportGenerator, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReportGenerator Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReportGenerator unmarshalledObject = new ReportGenerator();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastReportGenerationTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastReportGenerationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastRunFailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastRunFailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastRunStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastRunStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseManagerReportGeneratorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseManagerReportGeneratorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportContext", targetDepth))
                {
                    var unmarshaller = ReportContextUnmarshaller.Instance;
                    unmarshalledObject.ReportContext = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportCreatorAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReportCreatorAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportFrequency", targetDepth))
                {
                    var unmarshaller = ReportFrequencyUnmarshaller.Instance;
                    unmarshalledObject.ReportFrequency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportGeneratorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReportGeneratorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReportType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Location", targetDepth))
                {
                    var unmarshaller = S3LocationUnmarshaller.Instance;
                    unmarshalledObject.S3Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReportGeneratorUnmarshaller _instance = new ReportGeneratorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReportGeneratorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}