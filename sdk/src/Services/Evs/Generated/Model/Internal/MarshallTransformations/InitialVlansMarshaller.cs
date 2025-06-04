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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Evs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InitialVlans Marshaller
    /// </summary>
    public class InitialVlansMarshaller : IRequestMarshaller<InitialVlans, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InitialVlans requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEdgeVTep())
            {
                context.Writer.WritePropertyName("edgeVTep");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.EdgeVTep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExpansionVlan1())
            {
                context.Writer.WritePropertyName("expansionVlan1");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ExpansionVlan1, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExpansionVlan2())
            {
                context.Writer.WritePropertyName("expansionVlan2");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ExpansionVlan2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHcx())
            {
                context.Writer.WritePropertyName("hcx");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.Hcx, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNsxUplink())
            {
                context.Writer.WritePropertyName("nsxUplink");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.NsxUplink, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVmkManagement())
            {
                context.Writer.WritePropertyName("vmkManagement");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.VmkManagement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVmManagement())
            {
                context.Writer.WritePropertyName("vmManagement");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.VmManagement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVMotion())
            {
                context.Writer.WritePropertyName("vMotion");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.VMotion, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVSan())
            {
                context.Writer.WritePropertyName("vSan");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.VSan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVTep())
            {
                context.Writer.WritePropertyName("vTep");
                context.Writer.WriteObjectStart();

                var marshaller = InitialVlanInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.VTep, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InitialVlansMarshaller Instance = new InitialVlansMarshaller();

    }
}