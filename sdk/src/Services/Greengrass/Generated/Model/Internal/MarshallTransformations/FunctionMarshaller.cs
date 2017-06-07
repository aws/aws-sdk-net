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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Function Marshaller
    /// </summary>       
    public class FunctionMarshaller : IRequestMarshaller<Function, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Function requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFunctionArn())
            {
                context.Writer.WritePropertyName("FunctionArn");
                context.Writer.Write(requestObject.FunctionArn);
            }

            if(requestObject.IsSetFunctionConfiguration())
            {
                context.Writer.WritePropertyName("FunctionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FunctionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FunctionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FunctionMarshaller Instance = new FunctionMarshaller();

    }
}