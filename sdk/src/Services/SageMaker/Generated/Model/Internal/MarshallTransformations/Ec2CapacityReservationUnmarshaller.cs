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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ec2CapacityReservation Object
    /// </summary>  
    public class Ec2CapacityReservationUnmarshaller : IUnmarshaller<Ec2CapacityReservation, XmlUnmarshallerContext>, IUnmarshaller<Ec2CapacityReservation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Ec2CapacityReservation IUnmarshaller<Ec2CapacityReservation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Ec2CapacityReservation Unmarshall(JsonUnmarshallerContext context)
        {
            Ec2CapacityReservation unmarshalledObject = new Ec2CapacityReservation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AvailableInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2CapacityReservationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2CapacityReservationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsedByCurrentEndpoint", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UsedByCurrentEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Ec2CapacityReservationUnmarshaller _instance = new Ec2CapacityReservationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ec2CapacityReservationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}