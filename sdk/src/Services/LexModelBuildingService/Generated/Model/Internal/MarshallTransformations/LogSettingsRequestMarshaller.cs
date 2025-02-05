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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogSettingsRequest Marshaller
    /// </summary>
    public class LogSettingsRequestMarshaller : IRequestMarshaller<LogSettingsRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogSettingsRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("kmsKeyArn");
                context.Writer.WriteStringValue(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetLogType())
            {
                context.Writer.WritePropertyName("logType");
                context.Writer.WriteStringValue(requestObject.LogType);
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("resourceArn");
                context.Writer.WriteStringValue(requestObject.ResourceArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogSettingsRequestMarshaller Instance = new LogSettingsRequestMarshaller();

    }
}