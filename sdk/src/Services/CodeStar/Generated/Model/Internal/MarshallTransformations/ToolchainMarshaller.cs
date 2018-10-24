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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeStar.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeStar.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Toolchain Marshaller
    /// </summary>       
    public class ToolchainMarshaller : IRequestMarshaller<Toolchain, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Toolchain requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteObjectStart();

                var marshaller = ToolchainSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStackParameters())
            {
                context.Writer.WritePropertyName("stackParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectStackParametersKvp in requestObject.StackParameters)
                {
                    context.Writer.WritePropertyName(requestObjectStackParametersKvp.Key);
                    var requestObjectStackParametersValue = requestObjectStackParametersKvp.Value;

                        context.Writer.Write(requestObjectStackParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ToolchainMarshaller Instance = new ToolchainMarshaller();

    }
}