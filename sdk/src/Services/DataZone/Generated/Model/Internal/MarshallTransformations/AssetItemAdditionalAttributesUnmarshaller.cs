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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetItemAdditionalAttributes Object
    /// </summary>  
    public class AssetItemAdditionalAttributesUnmarshaller : IUnmarshaller<AssetItemAdditionalAttributes, XmlUnmarshallerContext>, IUnmarshaller<AssetItemAdditionalAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssetItemAdditionalAttributes IUnmarshaller<AssetItemAdditionalAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AssetItemAdditionalAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            AssetItemAdditionalAttributes unmarshalledObject = new AssetItemAdditionalAttributes();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("formsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FormOutput, FormOutputUnmarshaller>(FormOutputUnmarshaller.Instance);
                    unmarshalledObject.FormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("latestTimeSeriesDataPointFormsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TimeSeriesDataPointSummaryFormOutput, TimeSeriesDataPointSummaryFormOutputUnmarshaller>(TimeSeriesDataPointSummaryFormOutputUnmarshaller.Instance);
                    unmarshalledObject.LatestTimeSeriesDataPointFormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("readOnlyFormsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FormOutput, FormOutputUnmarshaller>(FormOutputUnmarshaller.Instance);
                    unmarshalledObject.ReadOnlyFormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssetItemAdditionalAttributesUnmarshaller _instance = new AssetItemAdditionalAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetItemAdditionalAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618