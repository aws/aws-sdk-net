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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PatchOperation Marshaller
    /// </summary>       
    public class PatchOperationMarshaller : IRequestMarshaller<PatchOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PatchOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFrom())
            {
                context.Writer.WritePropertyName("from");
                context.Writer.Write(requestObject.From);
            }

            if(requestObject.IsSetOp())
            {
                context.Writer.WritePropertyName("op");
                context.Writer.Write(requestObject.Op);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.Write(requestObject.Path);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.Write(requestObject.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PatchOperationMarshaller Instance = new PatchOperationMarshaller();

    }
}