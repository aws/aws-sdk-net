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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduleRunConfiguration Marshaller
    /// </summary>       
    public class ScheduleRunConfigurationMarshaller : IRequestMarshaller<ScheduleRunConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduleRunConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuxiliaryApps())
            {
                context.Writer.WritePropertyName("auxiliaryApps");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAuxiliaryAppsListValue in requestObject.AuxiliaryApps)
                {
                        context.Writer.Write(requestObjectAuxiliaryAppsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBillingMethod())
            {
                context.Writer.WritePropertyName("billingMethod");
                context.Writer.Write(requestObject.BillingMethod);
            }

            if(requestObject.IsSetCustomerArtifactPaths())
            {
                context.Writer.WritePropertyName("customerArtifactPaths");
                context.Writer.WriteObjectStart();

                var marshaller = CustomerArtifactPathsMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomerArtifactPaths, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExtraDataPackageArn())
            {
                context.Writer.WritePropertyName("extraDataPackageArn");
                context.Writer.Write(requestObject.ExtraDataPackageArn);
            }

            if(requestObject.IsSetLocale())
            {
                context.Writer.WritePropertyName("locale");
                context.Writer.Write(requestObject.Locale);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("location");
                context.Writer.WriteObjectStart();

                var marshaller = LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.Location, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkProfileArn())
            {
                context.Writer.WritePropertyName("networkProfileArn");
                context.Writer.Write(requestObject.NetworkProfileArn);
            }

            if(requestObject.IsSetRadios())
            {
                context.Writer.WritePropertyName("radios");
                context.Writer.WriteObjectStart();

                var marshaller = RadiosMarshaller.Instance;
                marshaller.Marshall(requestObject.Radios, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpceConfigurationArns())
            {
                context.Writer.WritePropertyName("vpceConfigurationArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpceConfigurationArnsListValue in requestObject.VpceConfigurationArns)
                {
                        context.Writer.Write(requestObjectVpceConfigurationArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ScheduleRunConfigurationMarshaller Instance = new ScheduleRunConfigurationMarshaller();

    }
}