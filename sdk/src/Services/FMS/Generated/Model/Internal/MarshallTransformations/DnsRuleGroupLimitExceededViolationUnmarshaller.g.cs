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

using Amazon.FMS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DnsRuleGroupLimitExceededViolation Object
    /// </summary>
    public partial class DnsRuleGroupLimitExceededViolationUnmarshaller : ICborUnmarshaller<DnsRuleGroupLimitExceededViolation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DnsRuleGroupLimitExceededViolation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DnsRuleGroupLimitExceededViolation();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "NumberOfRuleGroupsAlreadyAssociated":
                        context.AddPathSegment("NumberOfRuleGroupsAlreadyAssociated");
                        unmarshalledObject.NumberOfRuleGroupsAlreadyAssociated = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ViolationTarget":
                        context.AddPathSegment("ViolationTarget");
                        unmarshalledObject.ViolationTarget = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ViolationTargetDescription":
                        context.AddPathSegment("ViolationTargetDescription");
                        unmarshalledObject.ViolationTargetDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static DnsRuleGroupLimitExceededViolationUnmarshaller _instance = new DnsRuleGroupLimitExceededViolationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DnsRuleGroupLimitExceededViolationUnmarshaller Instance => _instance;
    }
}
