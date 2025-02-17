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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetPlace operation
    /// </summary>  
    public class GetPlaceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetPlaceResponse response = new GetPlaceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessPoint, AccessPointUnmarshaller>(AccessPointUnmarshaller.Instance);
                    response.AccessPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AccessRestrictions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AccessRestriction, AccessRestrictionUnmarshaller>(AccessRestrictionUnmarshaller.Instance);
                    response.AccessRestrictions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = AddressUnmarshaller.Instance;
                    response.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddressNumberCorrected", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AddressNumberCorrected = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BusinessChains", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BusinessChain, BusinessChainUnmarshaller>(BusinessChainUnmarshaller.Instance);
                    response.BusinessChains = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Categories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Category, CategoryUnmarshaller>(CategoryUnmarshaller.Instance);
                    response.Categories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Contacts", targetDepth))
                {
                    var unmarshaller = ContactsUnmarshaller.Instance;
                    response.Contacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoodTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FoodType, FoodTypeUnmarshaller>(FoodTypeUnmarshaller.Instance);
                    response.FoodTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapView", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    response.MapView = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpeningHours", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OpeningHours, OpeningHoursUnmarshaller>(OpeningHoursUnmarshaller.Instance);
                    response.OpeningHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Phonemes", targetDepth))
                {
                    var unmarshaller = PhonemeDetailsUnmarshaller.Instance;
                    response.Phonemes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoliticalView", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PoliticalView = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Position", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    response.Position = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostalCodeDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PostalCodeDetails, PostalCodeDetailsUnmarshaller>(PostalCodeDetailsUnmarshaller.Instance);
                    response.PostalCodeDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeZone", targetDepth))
                {
                    var unmarshaller = TimeZoneUnmarshaller.Instance;
                    response.TimeZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-geo-pricing-bucket"))
                response.PricingBucket = context.ResponseData.GetHeaderValue("x-amz-geo-pricing-bucket");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonGeoPlacesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetPlaceResponseUnmarshaller _instance = new GetPlaceResponseUnmarshaller();        

        internal static GetPlaceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPlaceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}