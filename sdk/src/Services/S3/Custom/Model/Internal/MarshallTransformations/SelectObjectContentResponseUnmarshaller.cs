// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class SelectObjectContentResponseUnmarshaller : S3ReponseUnmarshaller
    {
        private static SelectObjectContentResponseUnmarshaller _instance;

        public static SelectObjectContentResponseUnmarshaller Instance =>
            _instance ?? (_instance = new SelectObjectContentResponseUnmarshaller());

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            var response = new SelectObjectContentResponse();

            UnmarshallResult(context, response);

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, SelectObjectContentResponse response)
        {
            response.Payload = new SelectObjectContentEventStream(context.Stream);
        }

        public override bool HasStreamingProperty => true;

        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
        {
            return false;
        }
    }
}