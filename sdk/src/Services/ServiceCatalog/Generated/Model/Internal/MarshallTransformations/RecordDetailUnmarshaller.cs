/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecordDetail Object
    /// </summary>  
    public class RecordDetailUnmarshaller : IUnmarshaller<RecordDetail, XmlUnmarshallerContext>, IUnmarshaller<RecordDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecordDetail IUnmarshaller<RecordDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecordDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecordDetail unmarshalledObject = new RecordDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PathId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PathId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedProductId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedProductId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedProductName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedProductName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedProductType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisionedProductType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisioningArtifactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisioningArtifactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordErrors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecordError, RecordErrorUnmarshaller>(RecordErrorUnmarshaller.Instance);
                    unmarshalledObject.RecordErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecordTag, RecordTagUnmarshaller>(RecordTagUnmarshaller.Instance);
                    unmarshalledObject.RecordTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecordDetailUnmarshaller _instance = new RecordDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecordDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}