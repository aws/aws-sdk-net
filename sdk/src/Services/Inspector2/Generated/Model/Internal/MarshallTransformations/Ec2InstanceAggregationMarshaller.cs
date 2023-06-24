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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Ec2InstanceAggregation Marshaller
    /// </summary>
    public class Ec2InstanceAggregationMarshaller : IRequestMarshaller<Ec2InstanceAggregation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Ec2InstanceAggregation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAmis())
            {
                context.Writer.WritePropertyName("amis");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAmisListValue in requestObject.Amis)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAmisListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceIds())
            {
                context.Writer.WritePropertyName("instanceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceIdsListValue in requestObject.InstanceIds)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceIdsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceTags())
            {
                context.Writer.WritePropertyName("instanceTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceTagsListValue in requestObject.InstanceTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOperatingSystems())
            {
                context.Writer.WritePropertyName("operatingSystems");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOperatingSystemsListValue in requestObject.OperatingSystems)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOperatingSystemsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSortBy())
            {
                context.Writer.WritePropertyName("sortBy");
                context.Writer.Write(requestObject.SortBy);
            }

            if(requestObject.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("sortOrder");
                context.Writer.Write(requestObject.SortOrder);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Ec2InstanceAggregationMarshaller Instance = new Ec2InstanceAggregationMarshaller();

    }
}