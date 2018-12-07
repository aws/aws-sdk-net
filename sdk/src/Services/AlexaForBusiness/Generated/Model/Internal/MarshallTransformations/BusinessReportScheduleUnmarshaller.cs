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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BusinessReportSchedule Object
    /// </summary>  
    public class BusinessReportScheduleUnmarshaller : IUnmarshaller<BusinessReportSchedule, XmlUnmarshallerContext>, IUnmarshaller<BusinessReportSchedule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BusinessReportSchedule IUnmarshaller<BusinessReportSchedule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BusinessReportSchedule Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BusinessReportSchedule unmarshalledObject = new BusinessReportSchedule();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContentRange", targetDepth))
                {
                    var unmarshaller = BusinessReportContentRangeUnmarshaller.Instance;
                    unmarshalledObject.ContentRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Format", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Format = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastBusinessReport", targetDepth))
                {
                    var unmarshaller = BusinessReportUnmarshaller.Instance;
                    unmarshalledObject.LastBusinessReport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Recurrence", targetDepth))
                {
                    var unmarshaller = BusinessReportRecurrenceUnmarshaller.Instance;
                    unmarshalledObject.Recurrence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3KeyPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3KeyPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BusinessReportScheduleUnmarshaller _instance = new BusinessReportScheduleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BusinessReportScheduleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}