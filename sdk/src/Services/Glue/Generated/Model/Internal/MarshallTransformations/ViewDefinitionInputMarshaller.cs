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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ViewDefinitionInput Marshaller
    /// </summary>
    public class ViewDefinitionInputMarshaller : IRequestMarshaller<ViewDefinitionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ViewDefinitionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefiner())
            {
                context.Writer.WritePropertyName("Definer");
                context.Writer.Write(requestObject.Definer);
            }

            if(requestObject.IsSetIsProtected())
            {
                context.Writer.WritePropertyName("IsProtected");
                context.Writer.Write(requestObject.IsProtected);
            }

            if(requestObject.IsSetLastRefreshType())
            {
                context.Writer.WritePropertyName("LastRefreshType");
                context.Writer.Write(requestObject.LastRefreshType);
            }

            if(requestObject.IsSetRefreshSeconds())
            {
                context.Writer.WritePropertyName("RefreshSeconds");
                context.Writer.Write(requestObject.RefreshSeconds);
            }

            if(requestObject.IsSetRepresentations())
            {
                context.Writer.WritePropertyName("Representations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRepresentationsListValue in requestObject.Representations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ViewRepresentationInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectRepresentationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubObjects())
            {
                context.Writer.WritePropertyName("SubObjects");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubObjectsListValue in requestObject.SubObjects)
                {
                        context.Writer.Write(requestObjectSubObjectsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubObjectVersionIds())
            {
                context.Writer.WritePropertyName("SubObjectVersionIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubObjectVersionIdsListValue in requestObject.SubObjectVersionIds)
                {
                        context.Writer.Write(requestObjectSubObjectVersionIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetViewVersionId())
            {
                context.Writer.WritePropertyName("ViewVersionId");
                context.Writer.Write(requestObject.ViewVersionId);
            }

            if(requestObject.IsSetViewVersionToken())
            {
                context.Writer.WritePropertyName("ViewVersionToken");
                context.Writer.Write(requestObject.ViewVersionToken);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ViewDefinitionInputMarshaller Instance = new ViewDefinitionInputMarshaller();

    }
}