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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubRefactorSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubRefactorSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UriPathRouteInput Marshaller
    /// </summary>
    public class UriPathRouteInputMarshaller : IRequestMarshaller<UriPathRouteInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UriPathRouteInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActivationState())
            {
                context.Writer.WritePropertyName("ActivationState");
                context.Writer.WriteStringValue(requestObject.ActivationState);
            }

            if(requestObject.IsSetAppendSourcePath())
            {
                context.Writer.WritePropertyName("AppendSourcePath");
                context.Writer.WriteBooleanValue(requestObject.AppendSourcePath.Value);
            }

            if(requestObject.IsSetIncludeChildPaths())
            {
                context.Writer.WritePropertyName("IncludeChildPaths");
                context.Writer.WriteBooleanValue(requestObject.IncludeChildPaths.Value);
            }

            if(requestObject.IsSetMethods())
            {
                context.Writer.WritePropertyName("Methods");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMethodsListValue in requestObject.Methods)
                {
                        context.Writer.WriteStringValue(requestObjectMethodsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourcePath())
            {
                context.Writer.WritePropertyName("SourcePath");
                context.Writer.WriteStringValue(requestObject.SourcePath);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UriPathRouteInputMarshaller Instance = new UriPathRouteInputMarshaller();

    }
}