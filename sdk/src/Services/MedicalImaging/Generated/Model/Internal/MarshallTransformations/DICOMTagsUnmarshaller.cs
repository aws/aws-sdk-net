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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MedicalImaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DICOMTags Object
    /// </summary>  
    public class DICOMTagsUnmarshaller : IJsonUnmarshaller<DICOMTags, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DICOMTags Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DICOMTags unmarshalledObject = new DICOMTags();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DICOMAccessionNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMAccessionNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMNumberOfStudyRelatedInstances", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DICOMNumberOfStudyRelatedInstances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMNumberOfStudyRelatedSeries", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DICOMNumberOfStudyRelatedSeries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMPatientBirthDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientBirthDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMPatientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMPatientName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMPatientSex", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientSex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMSeriesBodyPart", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMSeriesBodyPart = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMSeriesInstanceUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMSeriesInstanceUID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMSeriesModality", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMSeriesModality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMSeriesNumber", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DICOMSeriesNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMStudyDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMStudyDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMStudyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMStudyInstanceUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyInstanceUID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DICOMStudyTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DICOMTagsUnmarshaller _instance = new DICOMTagsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DICOMTagsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}