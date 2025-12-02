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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ObservabilityAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdvancedFieldSelector Marshaller
    /// </summary>
    public class AdvancedFieldSelectorMarshaller : IRequestMarshaller<AdvancedFieldSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AdvancedFieldSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndsWith())
            {
                context.Writer.WritePropertyName("EndsWith");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndsWithListValue in requestObject.EndsWith)
                {
                        context.Writer.Write(requestObjectEndsWithListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEquals())
            {
                context.Writer.WritePropertyName("Equals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEqualsListValue in requestObject.Equals)
                {
                        context.Writer.Write(requestObjectEqualsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetField())
            {
                context.Writer.WritePropertyName("Field");
                context.Writer.Write(requestObject.Field);
            }

            if(requestObject.IsSetNotEndsWith())
            {
                context.Writer.WritePropertyName("NotEndsWith");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotEndsWithListValue in requestObject.NotEndsWith)
                {
                        context.Writer.Write(requestObjectNotEndsWithListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNotEquals())
            {
                context.Writer.WritePropertyName("NotEquals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotEqualsListValue in requestObject.NotEquals)
                {
                        context.Writer.Write(requestObjectNotEqualsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNotStartsWith())
            {
                context.Writer.WritePropertyName("NotStartsWith");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotStartsWithListValue in requestObject.NotStartsWith)
                {
                        context.Writer.Write(requestObjectNotStartsWithListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartsWith())
            {
                context.Writer.WritePropertyName("StartsWith");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStartsWithListValue in requestObject.StartsWith)
                {
                        context.Writer.Write(requestObjectStartsWithListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AdvancedFieldSelectorMarshaller Instance = new AdvancedFieldSelectorMarshaller();

    }
}