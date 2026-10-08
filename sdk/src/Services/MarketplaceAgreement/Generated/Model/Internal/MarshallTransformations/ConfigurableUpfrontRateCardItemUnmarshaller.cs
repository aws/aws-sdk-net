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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurableUpfrontRateCardItem Object
    /// </summary>  
    public class ConfigurableUpfrontRateCardItemUnmarshaller : ICborUnmarshaller<ConfigurableUpfrontRateCardItem, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConfigurableUpfrontRateCardItem Unmarshall(CborUnmarshallerContext context)
        {
            ConfigurableUpfrontRateCardItem unmarshalledObject = new ConfigurableUpfrontRateCardItem();
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
                    case "constraints":
                        {
                            context.AddPathSegment("Constraints");
                            var unmarshaller = ConstraintsUnmarshaller.Instance;
                            unmarshalledObject.Constraints = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "rateCard":
                        {
                            context.AddPathSegment("RateCard");
                            var unmarshaller = new CborListUnmarshaller<RateCardItem, RateCardItemUnmarshaller>(RateCardItemUnmarshaller.Instance);
                            unmarshalledObject.RateCard = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "selector":
                        {
                            context.AddPathSegment("Selector");
                            var unmarshaller = SelectorUnmarshaller.Instance;
                            unmarshalledObject.Selector = unmarshaller.Unmarshall(context);
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


        private static ConfigurableUpfrontRateCardItemUnmarshaller _instance = new ConfigurableUpfrontRateCardItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurableUpfrontRateCardItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}