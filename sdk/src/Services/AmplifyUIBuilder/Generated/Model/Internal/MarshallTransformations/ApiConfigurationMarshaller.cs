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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApiConfiguration Marshaller
    /// </summary>
    public class ApiConfigurationMarshaller : IRequestMarshaller<ApiConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApiConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataStoreConfig())
            {
                context.Writer.WritePropertyName("dataStoreConfig");
                context.Writer.WriteStartObject();

                var marshaller = DataStoreRenderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DataStoreConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGraphQLConfig())
            {
                context.Writer.WritePropertyName("graphQLConfig");
                context.Writer.WriteStartObject();

                var marshaller = GraphQLRenderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.GraphQLConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNoApiConfig())
            {
                context.Writer.WritePropertyName("noApiConfig");
                context.Writer.WriteStartObject();

                var marshaller = NoApiRenderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.NoApiConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApiConfigurationMarshaller Instance = new ApiConfigurationMarshaller();

    }
}