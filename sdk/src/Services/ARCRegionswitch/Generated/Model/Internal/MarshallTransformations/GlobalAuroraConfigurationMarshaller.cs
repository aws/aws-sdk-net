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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GlobalAuroraConfiguration Marshaller
    /// </summary>
    public class GlobalAuroraConfigurationMarshaller : IRequestMarshaller<GlobalAuroraConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GlobalAuroraConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBehavior())
            {
                context.Writer.WritePropertyName("behavior");
                context.Writer.Write(requestObject.Behavior);
            }

            if(requestObject.IsSetCrossAccountRole())
            {
                context.Writer.WritePropertyName("crossAccountRole");
                context.Writer.Write(requestObject.CrossAccountRole);
            }

            if(requestObject.IsSetDatabaseClusterArns())
            {
                context.Writer.WritePropertyName("databaseClusterArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDatabaseClusterArnsListValue in requestObject.DatabaseClusterArns)
                {
                        context.Writer.Write(requestObjectDatabaseClusterArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExternalId())
            {
                context.Writer.WritePropertyName("externalId");
                context.Writer.Write(requestObject.ExternalId);
            }

            if(requestObject.IsSetGlobalClusterIdentifier())
            {
                context.Writer.WritePropertyName("globalClusterIdentifier");
                context.Writer.Write(requestObject.GlobalClusterIdentifier);
            }

            if(requestObject.IsSetTimeoutMinutes())
            {
                context.Writer.WritePropertyName("timeoutMinutes");
                context.Writer.Write(requestObject.TimeoutMinutes);
            }

            if(requestObject.IsSetUngraceful())
            {
                context.Writer.WritePropertyName("ungraceful");
                context.Writer.WriteObjectStart();

                var marshaller = GlobalAuroraUngracefulMarshaller.Instance;
                marshaller.Marshall(requestObject.Ungraceful, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GlobalAuroraConfigurationMarshaller Instance = new GlobalAuroraConfigurationMarshaller();

    }
}