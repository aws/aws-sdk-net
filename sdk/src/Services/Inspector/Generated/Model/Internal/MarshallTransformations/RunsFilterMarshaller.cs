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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunsFilter Marshaller
    /// </summary>       
    public class RunsFilterMarshaller : IRequestMarshaller<RunsFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RunsFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCompletionTime())
            {
                context.Writer.WritePropertyName("completionTime");
                context.Writer.WriteObjectStart();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.CompletionTime, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreationTime())
            {
                context.Writer.WritePropertyName("creationTime");
                context.Writer.WriteObjectStart();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.CreationTime, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRulesPackages())
            {
                context.Writer.WritePropertyName("rulesPackages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRulesPackagesListValue in requestObject.RulesPackages)
                {
                        context.Writer.Write(requestObjectRulesPackagesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRunNamePatterns())
            {
                context.Writer.WritePropertyName("runNamePatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRunNamePatternsListValue in requestObject.RunNamePatterns)
                {
                        context.Writer.Write(requestObjectRunNamePatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRunStates())
            {
                context.Writer.WritePropertyName("runStates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRunStatesListValue in requestObject.RunStates)
                {
                        context.Writer.Write(requestObjectRunStatesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RunsFilterMarshaller Instance = new RunsFilterMarshaller();

    }
}