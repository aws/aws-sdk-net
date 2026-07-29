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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserStackAssociation Object
    /// </summary>  
    public class UserStackAssociationUnmarshaller : ICborUnmarshaller<UserStackAssociation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public UserStackAssociation Unmarshall(CborUnmarshallerContext context)
        {
            UserStackAssociation unmarshalledObject = new UserStackAssociation();
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
                    case "AuthenticationType":
                        {
                            context.AddPathSegment("AuthenticationType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AuthenticationType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SendEmailNotification":
                        {
                            context.AddPathSegment("SendEmailNotification");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.SendEmailNotification = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StackName":
                        {
                            context.AddPathSegment("StackName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StackName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UserName":
                        {
                            context.AddPathSegment("UserName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UserName = unmarshaller.Unmarshall(context);
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


        private static UserStackAssociationUnmarshaller _instance = new UserStackAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserStackAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}