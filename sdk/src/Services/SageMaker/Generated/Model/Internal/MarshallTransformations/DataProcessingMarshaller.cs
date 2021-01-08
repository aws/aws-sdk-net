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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataProcessing Marshaller
    /// </summary>       
    public class DataProcessingMarshaller : IRequestMarshaller<DataProcessing, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataProcessing requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInputFilter())
            {
                context.Writer.WritePropertyName("InputFilter");
                context.Writer.Write(requestObject.InputFilter);
            }

            if(requestObject.IsSetJoinSource())
            {
                context.Writer.WritePropertyName("JoinSource");
                context.Writer.Write(requestObject.JoinSource);
            }

            if(requestObject.IsSetOutputFilter())
            {
                context.Writer.WritePropertyName("OutputFilter");
                context.Writer.Write(requestObject.OutputFilter);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DataProcessingMarshaller Instance = new DataProcessingMarshaller();

    }
}