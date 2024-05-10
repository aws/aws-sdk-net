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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomModelTrainingParameters Marshaller
    /// </summary>
    public class CustomModelTrainingParametersMarshaller : IRequestMarshaller<CustomModelTrainingParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomModelTrainingParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSourceS3DirectoryPath())
            {
                context.Writer.WritePropertyName("sourceS3DirectoryPath");
                context.Writer.Write(requestObject.SourceS3DirectoryPath);
            }

            if(requestObject.IsSetTrainingEntryPointScript())
            {
                context.Writer.WritePropertyName("trainingEntryPointScript");
                context.Writer.Write(requestObject.TrainingEntryPointScript);
            }

            if(requestObject.IsSetTransformEntryPointScript())
            {
                context.Writer.WritePropertyName("transformEntryPointScript");
                context.Writer.Write(requestObject.TransformEntryPointScript);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomModelTrainingParametersMarshaller Instance = new CustomModelTrainingParametersMarshaller();

    }
}