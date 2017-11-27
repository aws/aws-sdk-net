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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobSettings Object
    /// </summary>  
    public class JobSettingsUnmarshaller : IUnmarshaller<JobSettings, XmlUnmarshallerContext>, IUnmarshaller<JobSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobSettings IUnmarshaller<JobSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobSettings unmarshalledObject = new JobSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adAvailOffset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AdAvailOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availBlanking", targetDepth))
                {
                    var unmarshaller = AvailBlankingUnmarshaller.Instance;
                    unmarshalledObject.AvailBlanking = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Input, InputUnmarshaller>(InputUnmarshaller.Instance);
                    unmarshalledObject.Inputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nielsenConfiguration", targetDepth))
                {
                    var unmarshaller = NielsenConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NielsenConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputGroup, OutputGroupUnmarshaller>(OutputGroupUnmarshaller.Instance);
                    unmarshalledObject.OutputGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeConfig", targetDepth))
                {
                    var unmarshaller = TimecodeConfigUnmarshaller.Instance;
                    unmarshalledObject.TimecodeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataInsertion", targetDepth))
                {
                    var unmarshaller = TimedMetadataInsertionUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataInsertion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobSettingsUnmarshaller _instance = new JobSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}