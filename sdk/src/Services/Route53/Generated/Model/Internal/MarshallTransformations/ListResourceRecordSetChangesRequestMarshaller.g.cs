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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListResourceRecordSetChanges Request Marshaller
    /// </summary>
    public partial class ListResourceRecordSetChangesRequestMarshaller : IMarshaller<IRequest, ListResourceRecordSetChangesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListResourceRecordSetChangesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListResourceRecordSetChangesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetHostedZoneId())
            {
                throw new AmazonRoute53Exception("Request object does not have required field HostedZoneId set");
            }
            request.AddPathResource("{HostedZoneId}", StringUtils.FromString(publicRequest.HostedZoneId));

            request.ResourcePath = "/2013-04-01/hostedzone/{HostedZoneId}/rrsetchanges";

            if (publicRequest.IsSetRecordName())
            {
                request.Parameters.Add("recordname", StringUtils.FromString(publicRequest.RecordName));
            }

            if (publicRequest.IsSetRecordType())
            {
                request.Parameters.Add("recordtype", StringUtils.FromString(publicRequest.RecordType));
            }

            if (publicRequest.IsSetSubmittedAfter())
            {
                request.Parameters.Add("submittedafter", StringUtils.FromString(publicRequest.SubmittedAfter));
            }

            if (publicRequest.IsSetSubmittedBefore())
            {
                request.Parameters.Add("submittedbefore", StringUtils.FromString(publicRequest.SubmittedBefore));
            }

            if (publicRequest.IsSetSortOrder())
            {
                request.Parameters.Add("sortorder", StringUtils.FromString(publicRequest.SortOrder));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxresults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nexttoken", StringUtils.FromString(publicRequest.NextToken));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly ListResourceRecordSetChangesRequestMarshaller _instance = new();

        internal static ListResourceRecordSetChangesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListResourceRecordSetChangesRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListResourceRecordSetChangesRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, ListResourceRecordSetChangesRequest publicRequest);
    }
}
