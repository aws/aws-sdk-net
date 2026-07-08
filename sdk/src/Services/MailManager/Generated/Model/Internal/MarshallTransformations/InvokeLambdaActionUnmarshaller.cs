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
    /// Response Unmarshaller for InvokeLambdaAction Object
    /// </summary>  
    public class InvokeLambdaActionUnmarshaller : ICborUnmarshaller<InvokeLambdaAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InvokeLambdaAction Unmarshall(CborUnmarshallerContext context)
        {
            InvokeLambdaAction unmarshalledObject = new InvokeLambdaAction();
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
                    case "ActionFailurePolicy":
                        {
                            context.AddPathSegment("ActionFailurePolicy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActionFailurePolicy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FunctionArn":
                        {
                            context.AddPathSegment("FunctionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FunctionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InvocationType":
                        {
                            context.AddPathSegment("InvocationType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InvocationType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RetryTimeMinutes":
                        {
                            context.AddPathSegment("RetryTimeMinutes");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.RetryTimeMinutes = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RoleArn":
                        {
                            context.AddPathSegment("RoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
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


        private static InvokeLambdaActionUnmarshaller _instance = new InvokeLambdaActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeLambdaActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}