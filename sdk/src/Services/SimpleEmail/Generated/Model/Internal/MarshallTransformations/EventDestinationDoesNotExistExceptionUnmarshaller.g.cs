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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for EventDestinationDoesNotExistException
    /// </summary>
    public partial class EventDestinationDoesNotExistExceptionUnmarshaller : IXmlErrorResponseUnmarshaller<EventDestinationDoesNotExistException, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public EventDestinationDoesNotExistException Unmarshall(XmlUnmarshallerContext context)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>
        public EventDestinationDoesNotExistException Unmarshall(XmlUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse)
        {
            EventDestinationDoesNotExistException unmarshalledObject = new EventDestinationDoesNotExistException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ConfigurationSetName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ConfigurationSetName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("EventDestinationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EventDestinationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
            }
            return unmarshalledObject;
        }

        private static EventDestinationDoesNotExistExceptionUnmarshaller _instance = new EventDestinationDoesNotExistExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EventDestinationDoesNotExistExceptionUnmarshaller Instance => _instance;
    }
}
