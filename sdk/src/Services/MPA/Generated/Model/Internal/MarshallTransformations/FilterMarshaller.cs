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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MPA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MPA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filter Marshaller
    /// </summary>
    public class FilterMarshaller : IRequestMarshaller<Filter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldName())
            {
                context.Writer.WritePropertyName("FieldName");
                context.Writer.WriteStringValue(requestObject.FieldName);
            }

            if(requestObject.IsSetOperator())
            {
                context.Writer.WritePropertyName("Operator");
                context.Writer.WriteStringValue(requestObject.Operator);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteStringValue(requestObject.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterMarshaller Instance = new FilterMarshaller();

    }
}