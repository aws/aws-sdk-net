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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Criterion Marshaller
    /// </summary>       
    public class CriterionMarshaller : IRequestMarshaller<Criterion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Criterion requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContains())
            {
                context.Writer.WritePropertyName("contains");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContainsListValue in requestObject.Contains)
                {
                        context.Writer.Write(requestObjectContainsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEq())
            {
                context.Writer.WritePropertyName("eq");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEqListValue in requestObject.Eq)
                {
                        context.Writer.Write(requestObjectEqListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExists())
            {
                context.Writer.WritePropertyName("exists");
                context.Writer.Write(requestObject.Exists);
            }

            if(requestObject.IsSetNeq())
            {
                context.Writer.WritePropertyName("neq");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNeqListValue in requestObject.Neq)
                {
                        context.Writer.Write(requestObjectNeqListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CriterionMarshaller Instance = new CriterionMarshaller();

    }
}