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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodeConfigurationParameters Marshaller
    /// </summary>
    public class CodeConfigurationParametersMarshaller : IRequestMarshaller<CodeConfigurationParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeConfigurationParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCodeLength())
            {
                context.Writer.WritePropertyName("codeLength");
                context.Writer.WriteNumberValue(requestObject.CodeLength.Value);
            }

            if(requestObject.IsSetCodeType())
            {
                context.Writer.WritePropertyName("codeType");
                context.Writer.WriteStringValue(requestObject.CodeType);
            }

            if(requestObject.IsSetMaxAttempts())
            {
                context.Writer.WritePropertyName("maxAttempts");
                context.Writer.WriteNumberValue(requestObject.MaxAttempts.Value);
            }

            if(requestObject.IsSetValidityPeriodMinutes())
            {
                context.Writer.WritePropertyName("validityPeriodMinutes");
                context.Writer.WriteNumberValue(requestObject.ValidityPeriodMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeConfigurationParametersMarshaller Instance = new CodeConfigurationParametersMarshaller();

    }
}