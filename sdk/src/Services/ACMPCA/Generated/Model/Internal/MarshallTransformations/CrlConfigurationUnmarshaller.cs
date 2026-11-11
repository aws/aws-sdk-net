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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CrlConfiguration Object
    /// </summary>  
    public class CrlConfigurationUnmarshaller : ICborUnmarshaller<CrlConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CrlConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            CrlConfiguration unmarshalledObject = new CrlConfiguration();
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
                    case "CrlDistributionPointExtensionConfiguration":
                        {
                            context.AddPathSegment("CrlDistributionPointExtensionConfiguration");
                            var unmarshaller = CrlDistributionPointExtensionConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CrlDistributionPointExtensionConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CrlType":
                        {
                            context.AddPathSegment("CrlType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CrlType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CustomCname":
                        {
                            context.AddPathSegment("CustomCname");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CustomCname = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CustomPath":
                        {
                            context.AddPathSegment("CustomPath");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CustomPath = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Enabled":
                        {
                            context.AddPathSegment("Enabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ExpirationInDays":
                        {
                            context.AddPathSegment("ExpirationInDays");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ExpirationInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "S3BucketName":
                        {
                            context.AddPathSegment("S3BucketName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.S3BucketName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "S3ObjectAcl":
                        {
                            context.AddPathSegment("S3ObjectAcl");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.S3ObjectAcl = unmarshaller.Unmarshall(context);
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


        private static CrlConfigurationUnmarshaller _instance = new CrlConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CrlConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}