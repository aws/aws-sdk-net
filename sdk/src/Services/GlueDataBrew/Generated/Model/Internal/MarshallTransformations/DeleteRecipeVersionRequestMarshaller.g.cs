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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.GlueDataBrew.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteRecipeVersion Request Marshaller
    /// </summary>
    public partial class DeleteRecipeVersionRequestMarshaller : IMarshaller<IRequest, DeleteRecipeVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteRecipeVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteRecipeVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlueDataBrew");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetName())
            {
                throw new AmazonGlueDataBrewException("Request object does not have required field Name set");
            }
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));

            if (!publicRequest.IsSetRecipeVersion())
            {
                throw new AmazonGlueDataBrewException("Request object does not have required field RecipeVersion set");
            }
            request.AddPathResource("{RecipeVersion}", StringUtils.FromString(publicRequest.RecipeVersion));

            request.ResourcePath = "/recipes/{Name}/recipeVersion/{RecipeVersion}";

            return request;
        }

        private static readonly DeleteRecipeVersionRequestMarshaller _instance = new();

        internal static DeleteRecipeVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteRecipeVersionRequestMarshaller Instance => _instance;
    }
}
