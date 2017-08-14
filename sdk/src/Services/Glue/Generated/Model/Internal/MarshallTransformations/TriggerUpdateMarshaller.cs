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

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TriggerUpdate Marshaller
    /// </summary>       
    public class TriggerUpdateMarshaller : IRequestMarshaller<TriggerUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TriggerUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPredicate())
            {
                context.Writer.WritePropertyName("Predicate");
                context.Writer.WriteObjectStart();

                var marshaller = PredicateMarshaller.Instance;
                marshaller.Marshall(requestObject.Predicate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.Write(requestObject.Schedule);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TriggerUpdateMarshaller Instance = new TriggerUpdateMarshaller();

    }
}