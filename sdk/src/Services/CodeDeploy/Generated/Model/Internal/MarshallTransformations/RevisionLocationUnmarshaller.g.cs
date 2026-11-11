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

using Amazon.CodeDeploy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RevisionLocation Object
    /// </summary>
    public partial class RevisionLocationUnmarshaller : ICborUnmarshaller<RevisionLocation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RevisionLocation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RevisionLocation();
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
                    case "appSpecContent":
                        context.AddPathSegment("AppSpecContent");
                        unmarshalledObject.AppSpecContent = AppSpecContentUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "gitHubLocation":
                        context.AddPathSegment("GitHubLocation");
                        unmarshalledObject.GitHubLocation = GitHubLocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "revisionType":
                        context.AddPathSegment("RevisionType");
                        unmarshalledObject.RevisionType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "s3Location":
                        context.AddPathSegment("S3Location");
                        unmarshalledObject.S3Location = S3LocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "string":
                        context.AddPathSegment("String");
                        unmarshalledObject.String = RawStringUnmarshaller.Instance.Unmarshall(context);
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

        private static RevisionLocationUnmarshaller _instance = new RevisionLocationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RevisionLocationUnmarshaller Instance => _instance;
    }
}
