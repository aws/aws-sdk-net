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
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobsFilterCriteria Marshaller
    /// </summary>       
    public class ListJobsFilterCriteriaMarshaller : IRequestMarshaller<ListJobsFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListJobsFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExcludes())
            {
                context.Writer.WritePropertyName("excludes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludesListValue in requestObject.Excludes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ListJobsFilterTermMarshaller.Instance;
                    marshaller.Marshall(requestObjectExcludesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIncludes())
            {
                context.Writer.WritePropertyName("includes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIncludesListValue in requestObject.Includes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ListJobsFilterTermMarshaller.Instance;
                    marshaller.Marshall(requestObjectIncludesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ListJobsFilterCriteriaMarshaller Instance = new ListJobsFilterCriteriaMarshaller();

    }
}