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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResponseInspectionHeader Marshaller
    /// </summary>
    public class ResponseInspectionHeaderMarshaller : IRequestMarshaller<ResponseInspectionHeader, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResponseInspectionHeader requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFailureValues())
            {
                context.Writer.WritePropertyName("FailureValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFailureValuesListValue in requestObject.FailureValues)
                {
                        context.Writer.WriteStringValue(requestObjectFailureValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetSuccessValues())
            {
                context.Writer.WritePropertyName("SuccessValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSuccessValuesListValue in requestObject.SuccessValues)
                {
                        context.Writer.WriteStringValue(requestObjectSuccessValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResponseInspectionHeaderMarshaller Instance = new ResponseInspectionHeaderMarshaller();

    }
}