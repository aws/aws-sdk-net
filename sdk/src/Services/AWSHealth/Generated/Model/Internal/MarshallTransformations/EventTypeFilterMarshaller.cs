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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventTypeFilter Marshaller
    /// </summary>
    public class EventTypeFilterMarshaller : IRequestMarshaller<EventTypeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventTypeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionabilities())
            {
                context.Writer.WritePropertyName("actionabilities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionabilitiesListValue in requestObject.Actionabilities)
                {
                        context.Writer.Write(requestObjectActionabilitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventTypeCategories())
            {
                context.Writer.WritePropertyName("eventTypeCategories");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventTypeCategoriesListValue in requestObject.EventTypeCategories)
                {
                        context.Writer.Write(requestObjectEventTypeCategoriesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventTypeCodes())
            {
                context.Writer.WritePropertyName("eventTypeCodes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventTypeCodesListValue in requestObject.EventTypeCodes)
                {
                        context.Writer.Write(requestObjectEventTypeCodesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPersonas())
            {
                context.Writer.WritePropertyName("personas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPersonasListValue in requestObject.Personas)
                {
                        context.Writer.Write(requestObjectPersonasListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetServices())
            {
                context.Writer.WritePropertyName("services");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                        context.Writer.Write(requestObjectServicesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventTypeFilterMarshaller Instance = new EventTypeFilterMarshaller();

    }
}