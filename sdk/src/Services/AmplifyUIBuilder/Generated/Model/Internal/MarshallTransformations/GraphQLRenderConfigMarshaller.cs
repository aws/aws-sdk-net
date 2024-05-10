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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GraphQLRenderConfig Marshaller
    /// </summary>
    public class GraphQLRenderConfigMarshaller : IRequestMarshaller<GraphQLRenderConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GraphQLRenderConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFragmentsFilePath())
            {
                context.Writer.WritePropertyName("fragmentsFilePath");
                context.Writer.Write(requestObject.FragmentsFilePath);
            }

            if(requestObject.IsSetMutationsFilePath())
            {
                context.Writer.WritePropertyName("mutationsFilePath");
                context.Writer.Write(requestObject.MutationsFilePath);
            }

            if(requestObject.IsSetQueriesFilePath())
            {
                context.Writer.WritePropertyName("queriesFilePath");
                context.Writer.Write(requestObject.QueriesFilePath);
            }

            if(requestObject.IsSetSubscriptionsFilePath())
            {
                context.Writer.WritePropertyName("subscriptionsFilePath");
                context.Writer.Write(requestObject.SubscriptionsFilePath);
            }

            if(requestObject.IsSetTypesFilePath())
            {
                context.Writer.WritePropertyName("typesFilePath");
                context.Writer.Write(requestObject.TypesFilePath);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GraphQLRenderConfigMarshaller Instance = new GraphQLRenderConfigMarshaller();

    }
}