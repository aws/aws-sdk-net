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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OnDeviceServiceConfiguration Marshaller
    /// </summary>
    public class OnDeviceServiceConfigurationMarshaller : IRequestMarshaller<OnDeviceServiceConfiguration, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OnDeviceServiceConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEKSOnDeviceService())
            {
                context.Writer.WriteTextString("EKSOnDeviceService");
                context.Writer.WriteStartMap(null);

                var marshaller = EKSOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EKSOnDeviceService, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetNFSOnDeviceService())
            {
                context.Writer.WriteTextString("NFSOnDeviceService");
                context.Writer.WriteStartMap(null);

                var marshaller = NFSOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NFSOnDeviceService, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetS3OnDeviceService())
            {
                context.Writer.WriteTextString("S3OnDeviceService");
                context.Writer.WriteStartMap(null);

                var marshaller = S3OnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3OnDeviceService, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetTGWOnDeviceService())
            {
                context.Writer.WriteTextString("TGWOnDeviceService");
                context.Writer.WriteStartMap(null);

                var marshaller = TGWOnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TGWOnDeviceService, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OnDeviceServiceConfigurationMarshaller Instance = new OnDeviceServiceConfigurationMarshaller();

    }
}