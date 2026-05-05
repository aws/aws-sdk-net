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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceTagsCriteriaCondition Object
    /// </summary>  
    public class ResourceTagsCriteriaConditionUnmarshaller : ICborUnmarshaller<ResourceTagsCriteriaCondition, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceTagsCriteriaCondition Unmarshall(CborUnmarshallerContext context)
        {
            ResourceTagsCriteriaCondition unmarshalledObject = new ResourceTagsCriteriaCondition();
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
                    case "comparison":
                        {
                            context.AddPathSegment("Comparison");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Comparison = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "key":
                        {
                            context.AddPathSegment("Key");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Key = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "values":
                        {
                            context.AddPathSegment("Values");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.Values = unmarshaller.Unmarshall(context);
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


        private static ResourceTagsCriteriaConditionUnmarshaller _instance = new ResourceTagsCriteriaConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceTagsCriteriaConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}