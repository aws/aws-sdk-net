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
    /// Response Unmarshaller for ImportJob Object
    /// </summary>  
    public class ImportJobUnmarshaller : ICborUnmarshaller<ImportJob, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ImportJob Unmarshall(CborUnmarshallerContext context)
        {
            ImportJob unmarshalledObject = new ImportJob();
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
                    case "AddressListId":
                        {
                            context.AddPathSegment("AddressListId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AddressListId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CompletedTimestamp":
                        {
                            context.AddPathSegment("CompletedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CompletedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedTimestamp":
                        {
                            context.AddPathSegment("CreatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Error":
                        {
                            context.AddPathSegment("Error");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FailedItemsCount":
                        {
                            context.AddPathSegment("FailedItemsCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.FailedItemsCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImportDataFormat":
                        {
                            context.AddPathSegment("ImportDataFormat");
                            var unmarshaller = ImportDataFormatUnmarshaller.Instance;
                            unmarshalledObject.ImportDataFormat = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImportedItemsCount":
                        {
                            context.AddPathSegment("ImportedItemsCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ImportedItemsCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobId":
                        {
                            context.AddPathSegment("JobId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PreSignedUrl":
                        {
                            context.AddPathSegment("PreSignedUrl");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PreSignedUrl = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTimestamp":
                        {
                            context.AddPathSegment("StartTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context);
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
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static ImportJobUnmarshaller _instance = new ImportJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}