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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Runbook Marshaller
    /// </summary>       
    public class RunbookMarshaller : IRequestMarshaller<Runbook, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Runbook requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDocumentName())
            {
                context.Writer.WritePropertyName("DocumentName");
                context.Writer.Write(requestObject.DocumentName);
            }

            if(requestObject.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("DocumentVersion");
                context.Writer.Write(requestObject.DocumentVersion);
            }

            if(requestObject.IsSetMaxConcurrency())
            {
                context.Writer.WritePropertyName("MaxConcurrency");
                context.Writer.Write(requestObject.MaxConcurrency);
            }

            if(requestObject.IsSetMaxErrors())
            {
                context.Writer.WritePropertyName("MaxErrors");
                context.Writer.Write(requestObject.MaxErrors);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectParametersValueListValue in requestObjectParametersValue)
                    {
                            context.Writer.Write(requestObjectParametersValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargetLocations())
            {
                context.Writer.WritePropertyName("TargetLocations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetLocationsListValue in requestObject.TargetLocations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetLocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetLocationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetParameterName())
            {
                context.Writer.WritePropertyName("TargetParameterName");
                context.Writer.Write(requestObject.TargetParameterName);
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetsListValue in requestObject.Targets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RunbookMarshaller Instance = new RunbookMarshaller();

    }
}