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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProjectListFilter Marshaller
    /// </summary>
    public class ProjectListFilterMarshaller : IRequestMarshaller<ProjectListFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProjectListFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("comparisonOperator");
                context.Writer.Write(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetValues())
            {
                context.Writer.WritePropertyName("values");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValuesListValue in requestObject.Values)
                {
                        context.Writer.Write(requestObjectValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProjectListFilterMarshaller Instance = new ProjectListFilterMarshaller();

    }
}