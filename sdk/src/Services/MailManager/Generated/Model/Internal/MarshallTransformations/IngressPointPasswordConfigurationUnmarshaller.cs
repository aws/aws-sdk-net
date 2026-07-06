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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IngressPointPasswordConfiguration Object
    /// </summary>  
    public class IngressPointPasswordConfigurationUnmarshaller : ICborUnmarshaller<IngressPointPasswordConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IngressPointPasswordConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            IngressPointPasswordConfiguration unmarshalledObject = new IngressPointPasswordConfiguration();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "PreviousSmtpPasswordExpiryTimestamp":
                        {
                            context.AddPathSegment("PreviousSmtpPasswordExpiryTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.PreviousSmtpPasswordExpiryTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PreviousSmtpPasswordVersion":
                        {
                            context.AddPathSegment("PreviousSmtpPasswordVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PreviousSmtpPasswordVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SmtpPasswordVersion":
                        {
                            context.AddPathSegment("SmtpPasswordVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SmtpPasswordVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static IngressPointPasswordConfigurationUnmarshaller _instance = new IngressPointPasswordConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IngressPointPasswordConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}