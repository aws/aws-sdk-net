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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ToolbarConfiguration Marshaller
    /// </summary>
    public class ToolbarConfigurationMarshaller : IRequestMarshaller<ToolbarConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ToolbarConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHiddenToolbarItems())
            {
                context.Writer.WritePropertyName("hiddenToolbarItems");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHiddenToolbarItemsListValue in requestObject.HiddenToolbarItems)
                {
                        context.Writer.WriteStringValue(requestObjectHiddenToolbarItemsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxDisplayResolution())
            {
                context.Writer.WritePropertyName("maxDisplayResolution");
                context.Writer.WriteStringValue(requestObject.MaxDisplayResolution);
            }

            if(requestObject.IsSetToolbarType())
            {
                context.Writer.WritePropertyName("toolbarType");
                context.Writer.WriteStringValue(requestObject.ToolbarType);
            }

            if(requestObject.IsSetVisualMode())
            {
                context.Writer.WritePropertyName("visualMode");
                context.Writer.WriteStringValue(requestObject.VisualMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ToolbarConfigurationMarshaller Instance = new ToolbarConfigurationMarshaller();

    }
}