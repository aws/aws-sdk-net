﻿/*
 *Copyright Amazon.com, Inc.or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 *You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 *
 *or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SSES3 Unmarshaller
    /// </summary>
    public class SSES3Unmarshaller : IUnmarshaller<SSES3, XmlUnmarshallerContext>, IUnmarshaller<SSES3, JsonUnmarshallerContext>
    {
        public SSES3 Unmarshall(XmlUnmarshallerContext context)
        {
            SSES3 condition = new SSES3();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    // Currently SSES3 is an empty shape and does not have any members inside of it.
                    continue;
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return condition;
                }
            }
            return condition;
        }

        public SSES3 Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static SSES3Unmarshaller _instance;

        public static SSES3Unmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SSES3Unmarshaller();
                }
                return _instance;
            }
        }
    }
}
