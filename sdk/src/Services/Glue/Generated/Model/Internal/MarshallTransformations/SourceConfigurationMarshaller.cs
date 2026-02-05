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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceConfiguration Marshaller
    /// </summary>
    public class SourceConfigurationMarshaller : IRequestMarshaller<SourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPaginationConfiguration())
            {
                context.Writer.WritePropertyName("PaginationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PaginationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PaginationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRequestMethod())
            {
                context.Writer.WritePropertyName("RequestMethod");
                context.Writer.Write(requestObject.RequestMethod);
            }

            if(requestObject.IsSetRequestParameters())
            {
                context.Writer.WritePropertyName("RequestParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRequestParametersListValue in requestObject.RequestParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectorPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectRequestParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRequestPath())
            {
                context.Writer.WritePropertyName("RequestPath");
                context.Writer.Write(requestObject.RequestPath);
            }

            if(requestObject.IsSetResponseConfiguration())
            {
                context.Writer.WritePropertyName("ResponseConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ResponseConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceConfigurationMarshaller Instance = new SourceConfigurationMarshaller();

    }
}