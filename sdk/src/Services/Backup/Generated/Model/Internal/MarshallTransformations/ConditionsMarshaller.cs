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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Conditions Marshaller
    /// </summary>
    public class ConditionsMarshaller : IRequestMarshaller<Conditions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Conditions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetStringEquals())
            {
                context.Writer.WritePropertyName("StringEquals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringEqualsListValue in requestObject.StringEquals)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringEqualsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringLike())
            {
                context.Writer.WritePropertyName("StringLike");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringLikeListValue in requestObject.StringLike)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringLikeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringNotEquals())
            {
                context.Writer.WritePropertyName("StringNotEquals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringNotEqualsListValue in requestObject.StringNotEquals)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringNotEqualsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringNotLike())
            {
                context.Writer.WritePropertyName("StringNotLike");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringNotLikeListValue in requestObject.StringNotLike)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringNotLikeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConditionsMarshaller Instance = new ConditionsMarshaller();

    }
}