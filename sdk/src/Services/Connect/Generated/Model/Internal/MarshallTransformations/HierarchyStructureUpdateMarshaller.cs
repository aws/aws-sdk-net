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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HierarchyStructureUpdate Marshaller
    /// </summary>
    public class HierarchyStructureUpdateMarshaller : IRequestMarshaller<HierarchyStructureUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HierarchyStructureUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLevelFive())
            {
                context.Writer.WritePropertyName("LevelFive");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyLevelUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LevelFive, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLevelFour())
            {
                context.Writer.WritePropertyName("LevelFour");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyLevelUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LevelFour, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLevelOne())
            {
                context.Writer.WritePropertyName("LevelOne");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyLevelUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LevelOne, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLevelThree())
            {
                context.Writer.WritePropertyName("LevelThree");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyLevelUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LevelThree, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLevelTwo())
            {
                context.Writer.WritePropertyName("LevelTwo");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyLevelUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.LevelTwo, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HierarchyStructureUpdateMarshaller Instance = new HierarchyStructureUpdateMarshaller();

    }
}