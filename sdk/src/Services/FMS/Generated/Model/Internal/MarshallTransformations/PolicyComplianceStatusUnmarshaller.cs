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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PolicyComplianceStatus Object
    /// </summary>  
    public class PolicyComplianceStatusUnmarshaller : ICborUnmarshaller<PolicyComplianceStatus, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PolicyComplianceStatus Unmarshall(CborUnmarshallerContext context)
        {
            PolicyComplianceStatus unmarshalledObject = new PolicyComplianceStatus();
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
                    case "EvaluationResults":
                        {
                            context.AddPathSegment("EvaluationResults");
                            var unmarshaller = new CborListUnmarshaller<EvaluationResult, EvaluationResultUnmarshaller>(EvaluationResultUnmarshaller.Instance);
                            unmarshalledObject.EvaluationResults = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IssueInfoMap":
                        {
                            context.AddPathSegment("IssueInfoMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            unmarshalledObject.IssueInfoMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LastUpdated":
                        {
                            context.AddPathSegment("LastUpdated");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdated = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MemberAccount":
                        {
                            context.AddPathSegment("MemberAccount");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MemberAccount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyId":
                        {
                            context.AddPathSegment("PolicyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyName":
                        {
                            context.AddPathSegment("PolicyName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyOwner":
                        {
                            context.AddPathSegment("PolicyOwner");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyOwner = unmarshaller.Unmarshall(context);
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


        private static PolicyComplianceStatusUnmarshaller _instance = new PolicyComplianceStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicyComplianceStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}