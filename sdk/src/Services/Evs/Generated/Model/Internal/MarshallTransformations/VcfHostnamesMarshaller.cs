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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Evs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Evs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VcfHostnames Marshaller
    /// </summary>
    public class VcfHostnamesMarshaller : IRequestMarshaller<VcfHostnames, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VcfHostnames requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudBuilder())
            {
                context.Writer.WritePropertyName("cloudBuilder");
                context.Writer.WriteStringValue(requestObject.CloudBuilder);
            }

            if(requestObject.IsSetNsx())
            {
                context.Writer.WritePropertyName("nsx");
                context.Writer.WriteStringValue(requestObject.Nsx);
            }

            if(requestObject.IsSetNsxEdge1())
            {
                context.Writer.WritePropertyName("nsxEdge1");
                context.Writer.WriteStringValue(requestObject.NsxEdge1);
            }

            if(requestObject.IsSetNsxEdge2())
            {
                context.Writer.WritePropertyName("nsxEdge2");
                context.Writer.WriteStringValue(requestObject.NsxEdge2);
            }

            if(requestObject.IsSetNsxManager1())
            {
                context.Writer.WritePropertyName("nsxManager1");
                context.Writer.WriteStringValue(requestObject.NsxManager1);
            }

            if(requestObject.IsSetNsxManager2())
            {
                context.Writer.WritePropertyName("nsxManager2");
                context.Writer.WriteStringValue(requestObject.NsxManager2);
            }

            if(requestObject.IsSetNsxManager3())
            {
                context.Writer.WritePropertyName("nsxManager3");
                context.Writer.WriteStringValue(requestObject.NsxManager3);
            }

            if(requestObject.IsSetSddcManager())
            {
                context.Writer.WritePropertyName("sddcManager");
                context.Writer.WriteStringValue(requestObject.SddcManager);
            }

            if(requestObject.IsSetVCenter())
            {
                context.Writer.WritePropertyName("vCenter");
                context.Writer.WriteStringValue(requestObject.VCenter);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VcfHostnamesMarshaller Instance = new VcfHostnamesMarshaller();

    }
}