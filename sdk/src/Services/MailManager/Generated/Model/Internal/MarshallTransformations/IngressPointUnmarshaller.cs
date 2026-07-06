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
    /// Response Unmarshaller for IngressPoint Object
    /// </summary>  
    public class IngressPointUnmarshaller : ICborUnmarshaller<IngressPoint, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IngressPoint Unmarshall(CborUnmarshallerContext context)
        {
            IngressPoint unmarshalledObject = new IngressPoint();
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
                    case "ARecord":
                        {
                            context.AddPathSegment("ARecord");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ARecord = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IngressPointId":
                        {
                            context.AddPathSegment("IngressPointId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IngressPointId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IngressPointName":
                        {
                            context.AddPathSegment("IngressPointName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IngressPointName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Type":
                        {
                            context.AddPathSegment("Type");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Type = unmarshaller.Unmarshall(context);
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


        private static IngressPointUnmarshaller _instance = new IngressPointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IngressPointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}