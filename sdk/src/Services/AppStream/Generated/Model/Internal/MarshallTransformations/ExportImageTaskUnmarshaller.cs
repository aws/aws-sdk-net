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
    /// Response Unmarshaller for ExportImageTask Object
    /// </summary>  
    public class ExportImageTaskUnmarshaller : ICborUnmarshaller<ExportImageTask, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ExportImageTask Unmarshall(CborUnmarshallerContext context)
        {
            ExportImageTask unmarshalledObject = new ExportImageTask();
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
                    case "AmiDescription":
                        {
                            context.AddPathSegment("AmiDescription");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AmiDescription = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AmiId":
                        {
                            context.AddPathSegment("AmiId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AmiId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AmiName":
                        {
                            context.AddPathSegment("AmiName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AmiName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedDate":
                        {
                            context.AddPathSegment("CreatedDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ErrorDetails":
                        {
                            context.AddPathSegment("ErrorDetails");
                            var unmarshaller = new CborListUnmarshaller<ErrorDetails, ErrorDetailsUnmarshaller>(ErrorDetailsUnmarshaller.Instance);
                            unmarshalledObject.ErrorDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageArn":
                        {
                            context.AddPathSegment("ImageArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "State":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TagSpecifications":
                        {
                            context.AddPathSegment("TagSpecifications");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.TagSpecifications = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TaskId":
                        {
                            context.AddPathSegment("TaskId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
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


        private static ExportImageTaskUnmarshaller _instance = new ExportImageTaskUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportImageTaskUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}