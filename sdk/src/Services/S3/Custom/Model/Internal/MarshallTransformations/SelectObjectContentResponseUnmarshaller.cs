// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>
    /// SelectObjectContentResponse unmarshaller
    /// </summary>
    public class SelectObjectContentResponseUnmarshaller : S3ReponseUnmarshaller
    {
        private static SelectObjectContentResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton instance of SelectObjectContentResponseUnmarshaller
        /// </summary>
        public static SelectObjectContentResponseUnmarshaller Instance =>
            _instance ?? (_instance = new SelectObjectContentResponseUnmarshaller());

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns true for having a streaming property.
        /// </summary>
        public override bool HasStreamingProperty => true;

        /// <summary>
        /// Return false
        /// </summary>
        /// <param name="response"></param>
        /// <param name="readEntireResponse"></param>
        /// <returns></returns>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
        {
            return false;
        }
    }
}