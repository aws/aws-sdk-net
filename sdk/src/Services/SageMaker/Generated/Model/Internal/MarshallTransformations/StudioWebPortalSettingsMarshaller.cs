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
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StudioWebPortalSettings Marshaller
    /// </summary>
    public class StudioWebPortalSettingsMarshaller : IRequestMarshaller<StudioWebPortalSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StudioWebPortalSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHiddenAppTypes())
            {
                context.Writer.WritePropertyName("HiddenAppTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHiddenAppTypesListValue in requestObject.HiddenAppTypes)
                {
                        context.Writer.WriteStringValue(requestObjectHiddenAppTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHiddenInstanceTypes())
            {
                context.Writer.WritePropertyName("HiddenInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHiddenInstanceTypesListValue in requestObject.HiddenInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectHiddenInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHiddenMlTools())
            {
                context.Writer.WritePropertyName("HiddenMlTools");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHiddenMlToolsListValue in requestObject.HiddenMlTools)
                {
                        context.Writer.WriteStringValue(requestObjectHiddenMlToolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHiddenSageMakerImageVersionAliases())
            {
                context.Writer.WritePropertyName("HiddenSageMakerImageVersionAliases");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHiddenSageMakerImageVersionAliasesListValue in requestObject.HiddenSageMakerImageVersionAliases)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HiddenSageMakerImageMarshaller.Instance;
                    marshaller.Marshall(requestObjectHiddenSageMakerImageVersionAliasesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StudioWebPortalSettingsMarshaller Instance = new StudioWebPortalSettingsMarshaller();

    }
}