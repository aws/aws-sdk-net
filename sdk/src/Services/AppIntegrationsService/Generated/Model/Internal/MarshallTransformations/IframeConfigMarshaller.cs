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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppIntegrationsService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IframeConfig Marshaller
    /// </summary>
    public class IframeConfigMarshaller : IRequestMarshaller<IframeConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IframeConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllow())
            {
                context.Writer.WritePropertyName("Allow");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowListValue in requestObject.Allow)
                {
                        context.Writer.WriteStringValue(requestObjectAllowListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSandbox())
            {
                context.Writer.WritePropertyName("Sandbox");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSandboxListValue in requestObject.Sandbox)
                {
                        context.Writer.WriteStringValue(requestObjectSandboxListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IframeConfigMarshaller Instance = new IframeConfigMarshaller();

    }
}