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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EntityFilter Marshaller
    /// </summary>
    public class EntityFilterMarshaller : IRequestMarshaller<EntityFilter, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityFilter requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEntityArns())
            {
                context.Writer.WriteTextString("entityArns");
                context.Writer.WriteStartArray(requestObject.EntityArns.Count);
                foreach(var requestObjectEntityArnsListValue in requestObject.EntityArns)
                {
                        context.Writer.WriteTextString(requestObjectEntityArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEntityValues())
            {
                context.Writer.WriteTextString("entityValues");
                context.Writer.WriteStartArray(requestObject.EntityValues.Count);
                foreach(var requestObjectEntityValuesListValue in requestObject.EntityValues)
                {
                        context.Writer.WriteTextString(requestObjectEntityValuesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEventArns())
            {
                context.Writer.WriteTextString("eventArns");
                context.Writer.WriteStartArray(requestObject.EventArns.Count);
                foreach(var requestObjectEventArnsListValue in requestObject.EventArns)
                {
                        context.Writer.WriteTextString(requestObjectEventArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetLastUpdatedTimes())
            {
                context.Writer.WriteTextString("lastUpdatedTimes");
                context.Writer.WriteStartArray(requestObject.LastUpdatedTimes.Count);
                foreach(var requestObjectLastUpdatedTimesListValue in requestObject.LastUpdatedTimes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DateTimeRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastUpdatedTimesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetStatusCodes())
            {
                context.Writer.WriteTextString("statusCodes");
                context.Writer.WriteStartArray(requestObject.StatusCodes.Count);
                foreach(var requestObjectStatusCodesListValue in requestObject.StatusCodes)
                {
                        context.Writer.WriteTextString(requestObjectStatusCodesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);
                    foreach (var requestObjectTagsListValueKvp in requestObjectTagsListValue)
                    {
                        context.Writer.WriteTextString(requestObjectTagsListValueKvp.Key);
                        var requestObjectTagsListValueValue = requestObjectTagsListValueKvp.Value;

                            context.Writer.WriteTextString(requestObjectTagsListValueValue);
                    }
                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EntityFilterMarshaller Instance = new EntityFilterMarshaller();

    }
}