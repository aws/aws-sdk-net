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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateFleet operation.
    /// </summary>
    public partial class CreateFleetResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateFleetResponse unmarshalledObject = new CreateFleetResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth = 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("errorSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Errors == null)
                        {
                            unmarshalledObject.Errors = new List<CreateFleetError>();
                        }
                        var unmarshaller = CreateFleetErrorUnmarshaller.Instance;
                        unmarshalledObject.Errors.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("fleetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fleetInstanceSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Instances == null)
                        {
                            unmarshalledObject.Instances = new List<CreateFleetInstance>();
                        }
                        var unmarshaller = CreateFleetInstanceUnmarshaller.Instance;
                        unmarshalledObject.Instances.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateFleetResponseUnmarshaller _instance = new CreateFleetResponseUnmarshaller();

        internal static CreateFleetResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFleetResponseUnmarshaller Instance => _instance;
    }
}
