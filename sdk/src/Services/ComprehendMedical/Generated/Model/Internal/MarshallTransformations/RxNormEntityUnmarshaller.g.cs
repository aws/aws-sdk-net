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

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RxNormEntity Object
    /// </summary>
    public partial class RxNormEntityUnmarshaller : ICborUnmarshaller<RxNormEntity, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RxNormEntity Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RxNormEntity();
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
                    case "Attributes":
                        context.AddPathSegment("Attributes");
                        unmarshalledObject.Attributes = new CborListUnmarshaller<RxNormAttribute, RxNormAttributeUnmarshaller>(RxNormAttributeUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BeginOffset":
                        context.AddPathSegment("BeginOffset");
                        unmarshalledObject.BeginOffset = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Category":
                        context.AddPathSegment("Category");
                        unmarshalledObject.Category = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndOffset":
                        context.AddPathSegment("EndOffset");
                        unmarshalledObject.EndOffset = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RxNormConcepts":
                        context.AddPathSegment("RxNormConcepts");
                        unmarshalledObject.RxNormConcepts = new CborListUnmarshaller<RxNormConcept, RxNormConceptUnmarshaller>(RxNormConceptUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Score":
                        context.AddPathSegment("Score");
                        unmarshalledObject.Score = CborNullableFloatUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Text":
                        context.AddPathSegment("Text");
                        unmarshalledObject.Text = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Traits":
                        context.AddPathSegment("Traits");
                        unmarshalledObject.Traits = new CborListUnmarshaller<RxNormTrait, RxNormTraitUnmarshaller>(RxNormTraitUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static RxNormEntityUnmarshaller _instance = new RxNormEntityUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RxNormEntityUnmarshaller Instance => _instance;
    }
}
