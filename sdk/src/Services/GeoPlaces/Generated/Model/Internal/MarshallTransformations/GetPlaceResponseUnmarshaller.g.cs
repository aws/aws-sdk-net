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

using Amazon.GeoPlaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetPlace operation.
    /// </summary>
    public partial class GetPlaceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetPlaceResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccessPoints", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AccessPoint, AccessPointUnmarshaller>(AccessPointUnmarshaller.Instance);
                    unmarshalledObject.AccessPoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AccessRestrictions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AccessRestriction, AccessRestrictionUnmarshaller>(AccessRestrictionUnmarshaller.Instance);
                    unmarshalledObject.AccessRestrictions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Address", targetDepth, ref reader))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AddressNumberCorrected", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AddressNumberCorrected = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BusinessChains", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<BusinessChain, BusinessChainUnmarshaller>(BusinessChainUnmarshaller.Instance);
                    unmarshalledObject.BusinessChains = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Categories", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Contacts", targetDepth, ref reader))
                {
                    var unmarshaller = ContactsUnmarshaller.Instance;
                    unmarshalledObject.Contacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CrossReferences", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<CrossReference, CrossReferenceUnmarshaller>(CrossReferenceUnmarshaller.Instance);
                    unmarshalledObject.CrossReferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedPointAddress", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EstimatedPointAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoodTypes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FoodType, FoodTypeUnmarshaller>(FoodTypeUnmarshaller.Instance);
                    unmarshalledObject.FoodTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("MainAddress", targetDepth, ref reader))
                {
                    var unmarshaller = RelatedPlaceUnmarshaller.Instance;
                    unmarshalledObject.MainAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("MapView", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.MapView = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OpeningHours", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<OpeningHours, OpeningHoursUnmarshaller>(OpeningHoursUnmarshaller.Instance);
                    unmarshalledObject.OpeningHours = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Phonemes", targetDepth, ref reader))
                {
                    var unmarshaller = PhonemeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Phonemes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PlaceAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PlaceAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PlaceId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PlaceType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PoliticalView", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoliticalView = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Position", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PostalCodeDetails", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PostalCodeDetails, PostalCodeDetailsUnmarshaller>(PostalCodeDetailsUnmarshaller.Instance);
                    unmarshalledObject.PostalCodeDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SecondaryAddresses", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RelatedPlace, RelatedPlaceUnmarshaller>(RelatedPlaceUnmarshaller.Instance);
                    unmarshalledObject.SecondaryAddresses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TimeZone", targetDepth, ref reader))
                {
                    var unmarshaller = TimeZoneUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Title", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-geo-pricing-bucket"))
            {
                unmarshalledObject.PricingBucket = context.ResponseData.GetHeaderValue("x-amz-geo-pricing-bucket");
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonGeoPlacesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetPlaceResponseUnmarshaller _instance = new GetPlaceResponseUnmarshaller();

        internal static GetPlaceResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetPlaceResponseUnmarshaller Instance => _instance;
    }
}
