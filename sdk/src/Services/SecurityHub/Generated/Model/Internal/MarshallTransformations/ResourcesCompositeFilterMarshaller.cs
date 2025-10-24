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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourcesCompositeFilter Marshaller
    /// </summary>
    public class ResourcesCompositeFilterMarshaller : IRequestMarshaller<ResourcesCompositeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourcesCompositeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDateFilters())
            {
                context.Writer.WritePropertyName("DateFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDateFiltersListValue in requestObject.DateFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourcesDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectDateFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMapFilters())
            {
                context.Writer.WritePropertyName("MapFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMapFiltersListValue in requestObject.MapFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourcesMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMapFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNestedCompositeFilters())
            {
                context.Writer.WritePropertyName("NestedCompositeFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNestedCompositeFiltersListValue in requestObject.NestedCompositeFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourcesCompositeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNestedCompositeFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNumberFilters())
            {
                context.Writer.WritePropertyName("NumberFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNumberFiltersListValue in requestObject.NumberFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourcesNumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNumberFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOperator())
            {
                context.Writer.WritePropertyName("Operator");
                context.Writer.Write(requestObject.Operator);
            }

            if(requestObject.IsSetStringFilters())
            {
                context.Writer.WritePropertyName("StringFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringFiltersListValue in requestObject.StringFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourcesStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourcesCompositeFilterMarshaller Instance = new ResourcesCompositeFilterMarshaller();

    }
}