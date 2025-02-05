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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StepAction Marshaller
    /// </summary>
    public class StepActionMarshaller : IRequestMarshaller<StepAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StepAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompareAction())
            {
                context.Writer.WritePropertyName("compareAction");
                context.Writer.WriteStartObject();

                var marshaller = CompareActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CompareAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMainframeAction())
            {
                context.Writer.WritePropertyName("mainframeAction");
                context.Writer.WriteStartObject();

                var marshaller = MainframeActionMarshaller.Instance;
                marshaller.Marshall(requestObject.MainframeAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceAction())
            {
                context.Writer.WritePropertyName("resourceAction");
                context.Writer.WriteStartObject();

                var marshaller = ResourceActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceAction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StepActionMarshaller Instance = new StepActionMarshaller();

    }
}