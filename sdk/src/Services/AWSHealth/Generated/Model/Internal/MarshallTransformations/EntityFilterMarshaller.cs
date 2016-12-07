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

namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EntityFilter Marshaller
    /// </summary>       
    public class EntityFilterMarshaller : IRequestMarshaller<EntityFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEntityArns())
            {
                context.Writer.WritePropertyName("entityArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityArnsListValue in requestObject.EntityArns)
                {
                        context.Writer.Write(requestObjectEntityArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntityValues())
            {
                context.Writer.WritePropertyName("entityValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityValuesListValue in requestObject.EntityValues)
                {
                        context.Writer.Write(requestObjectEntityValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventArns())
            {
                context.Writer.WritePropertyName("eventArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventArnsListValue in requestObject.EventArns)
                {
                        context.Writer.Write(requestObjectEventArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastUpdatedTimes())
            {
                context.Writer.WritePropertyName("lastUpdatedTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastUpdatedTimesListValue in requestObject.LastUpdatedTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastUpdatedTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatusCodes())
            {
                context.Writer.WritePropertyName("statusCodes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusCodesListValue in requestObject.StatusCodes)
                {
                        context.Writer.Write(requestObjectStatusCodesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectTagsListValueKvp in requestObjectTagsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectTagsListValueKvp.Key);
                        var requestObjectTagsListValueValue = requestObjectTagsListValueKvp.Value;

                            context.Writer.Write(requestObjectTagsListValueValue);
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EntityFilterMarshaller Instance = new EntityFilterMarshaller();

    }
}