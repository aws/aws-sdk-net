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
using ThirdParty.Json.LitJson;

namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DICOMTags Object
    /// </summary>  
    public class DICOMTagsUnmarshaller : IUnmarshaller<DICOMTags, XmlUnmarshallerContext>, IUnmarshaller<DICOMTags, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DICOMTags IUnmarshaller<DICOMTags, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DICOMTags Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DICOMTags unmarshalledObject = new DICOMTags();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DICOMAccessionNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMAccessionNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMNumberOfStudyRelatedInstances", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DICOMNumberOfStudyRelatedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMNumberOfStudyRelatedSeries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DICOMNumberOfStudyRelatedSeries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMPatientBirthDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientBirthDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMPatientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMPatientName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMPatientSex", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMPatientSex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMStudyDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMStudyDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMStudyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMStudyInstanceUID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyInstanceUID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DICOMStudyTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DICOMStudyTime = unmarshaller.Unmarshall(context);
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