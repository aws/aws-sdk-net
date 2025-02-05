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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CriteriaForJob Marshaller
    /// </summary>
    public class CriteriaForJobMarshaller : IRequestMarshaller<CriteriaForJob, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CriteriaForJob requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSimpleCriterion())
            {
                context.Writer.WritePropertyName("simpleCriterion");
                context.Writer.WriteStartObject();

                var marshaller = SimpleCriterionForJobMarshaller.Instance;
                marshaller.Marshall(requestObject.SimpleCriterion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTagCriterion())
            {
                context.Writer.WritePropertyName("tagCriterion");
                context.Writer.WriteStartObject();

                var marshaller = TagCriterionForJobMarshaller.Instance;
                marshaller.Marshall(requestObject.TagCriterion, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CriteriaForJobMarshaller Instance = new CriteriaForJobMarshaller();

    }
}