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
    /// Response Unmarshaller for Policy Object
    /// </summary>
    public partial class PolicyUnmarshaller : ICborUnmarshaller<Policy, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Policy Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Policy();
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
                    case "DeleteUnusedFMManagedResources":
                        context.AddPathSegment("DeleteUnusedFMManagedResources");
                        unmarshalledObject.DeleteUnusedFMManagedResources = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExcludeMap":
                        context.AddPathSegment("ExcludeMap");
                        unmarshalledObject.ExcludeMap = new CborDictionaryUnmarshaller<string, List<string>, CborStringUnmarshaller, CborListUnmarshaller<string, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance)).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExcludeResourceTags":
                        context.AddPathSegment("ExcludeResourceTags");
                        unmarshalledObject.ExcludeResourceTags = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "IncludeMap":
                        context.AddPathSegment("IncludeMap");
                        unmarshalledObject.IncludeMap = new CborDictionaryUnmarshaller<string, List<string>, CborStringUnmarshaller, CborListUnmarshaller<string, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance)).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyDescription":
                        context.AddPathSegment("PolicyDescription");
                        unmarshalledObject.PolicyDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyId":
                        context.AddPathSegment("PolicyId");
                        unmarshalledObject.PolicyId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyName":
                        context.AddPathSegment("PolicyName");
                        unmarshalledObject.PolicyName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyStatus":
                        context.AddPathSegment("PolicyStatus");
                        unmarshalledObject.PolicyStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PolicyUpdateToken":
                        context.AddPathSegment("PolicyUpdateToken");
                        unmarshalledObject.PolicyUpdateToken = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RemediationEnabled":
                        context.AddPathSegment("RemediationEnabled");
                        unmarshalledObject.RemediationEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceSetIds":
                        context.AddPathSegment("ResourceSetIds");
                        unmarshalledObject.ResourceSetIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceTagLogicalOperator":
                        context.AddPathSegment("ResourceTagLogicalOperator");
                        unmarshalledObject.ResourceTagLogicalOperator = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceTags":
                        context.AddPathSegment("ResourceTags");
                        unmarshalledObject.ResourceTags = new CborListUnmarshaller<ResourceTag, ResourceTagUnmarshaller>(ResourceTagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceType":
                        context.AddPathSegment("ResourceType");
                        unmarshalledObject.ResourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceTypeList":
                        context.AddPathSegment("ResourceTypeList");
                        unmarshalledObject.ResourceTypeList = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SecurityServicePolicyData":
                        context.AddPathSegment("SecurityServicePolicyData");
                        unmarshalledObject.SecurityServicePolicyData = SecurityServicePolicyDataUnmarshaller.Instance.Unmarshall(context);
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

        private static PolicyUnmarshaller _instance = new PolicyUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PolicyUnmarshaller Instance => _instance;
    }
}
