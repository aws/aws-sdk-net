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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SparkSubmitJobDriver Marshaller
    /// </summary>       
    public class SparkSubmitJobDriverMarshaller : IRequestMarshaller<SparkSubmitJobDriver, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SparkSubmitJobDriver requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEntryPoint())
            {
                context.Writer.WritePropertyName("entryPoint");
                context.Writer.Write(requestObject.EntryPoint);
            }

            if(requestObject.IsSetEntryPointArguments())
            {
                context.Writer.WritePropertyName("entryPointArguments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntryPointArgumentsListValue in requestObject.EntryPointArguments)
                {
                        context.Writer.Write(requestObjectEntryPointArgumentsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSparkSubmitParameters())
            {
                context.Writer.WritePropertyName("sparkSubmitParameters");
                context.Writer.Write(requestObject.SparkSubmitParameters);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SparkSubmitJobDriverMarshaller Instance = new SparkSubmitJobDriverMarshaller();

    }
}