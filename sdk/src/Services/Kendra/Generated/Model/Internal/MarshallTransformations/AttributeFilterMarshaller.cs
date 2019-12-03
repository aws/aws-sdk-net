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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeFilter Marshaller
    /// </summary>       
    public class AttributeFilterMarshaller : IRequestMarshaller<AttributeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAndAllFilters())
            {
                context.Writer.WritePropertyName("AndAllFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAndAllFiltersListValue in requestObject.AndAllFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndAllFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetContainsAll())
            {
                context.Writer.WritePropertyName("ContainsAll");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainsAll, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainsAny())
            {
                context.Writer.WritePropertyName("ContainsAny");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainsAny, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEqualsTo())
            {
                context.Writer.WritePropertyName("EqualsTo");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.EqualsTo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("GreaterThan");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGreaterThanOrEquals())
            {
                context.Writer.WritePropertyName("GreaterThanOrEquals");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEquals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("LessThan");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLessThanOrEquals())
            {
                context.Writer.WritePropertyName("LessThanOrEquals");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEquals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNotFilter())
            {
                context.Writer.WritePropertyName("NotFilter");
                context.Writer.WriteObjectStart();

                var marshaller = AttributeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NotFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOrAllFilters())
            {
                context.Writer.WritePropertyName("OrAllFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrAllFiltersListValue in requestObject.OrAllFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrAllFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AttributeFilterMarshaller Instance = new AttributeFilterMarshaller();

    }
}