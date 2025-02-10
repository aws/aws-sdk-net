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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceFleetResizingSpecifications Marshaller
    /// </summary>
    public class InstanceFleetResizingSpecificationsMarshaller : IRequestMarshaller<InstanceFleetResizingSpecifications, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceFleetResizingSpecifications requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOnDemandResizeSpecification())
            {
                context.Writer.WritePropertyName("OnDemandResizeSpecification");
                context.Writer.WriteStartObject();

                var marshaller = OnDemandResizingSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.OnDemandResizeSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSpotResizeSpecification())
            {
                context.Writer.WritePropertyName("SpotResizeSpecification");
                context.Writer.WriteStartObject();

                var marshaller = SpotResizingSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.SpotResizeSpecification, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceFleetResizingSpecificationsMarshaller Instance = new InstanceFleetResizingSpecificationsMarshaller();

    }
}