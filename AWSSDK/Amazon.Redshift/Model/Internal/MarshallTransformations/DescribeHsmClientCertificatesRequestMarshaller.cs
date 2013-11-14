/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Hsm Client Certificates Request Marshaller
    /// </summary>       
    public class DescribeHsmClientCertificatesRequestMarshaller : IMarshaller<IRequest, DescribeHsmClientCertificatesRequest>
    {
        public IRequest Marshall(DescribeHsmClientCertificatesRequest describeHsmClientCertificatesRequest)
        {
            IRequest request = new DefaultRequest(describeHsmClientCertificatesRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "DescribeHsmClientCertificates");
            request.Parameters.Add("Version", "2012-12-01");
            if (describeHsmClientCertificatesRequest != null && describeHsmClientCertificatesRequest.IsSetHsmClientCertificateIdentifier())
            {
                request.Parameters.Add("HsmClientCertificateIdentifier", StringUtils.FromString(describeHsmClientCertificatesRequest.HsmClientCertificateIdentifier));
            }
            if (describeHsmClientCertificatesRequest != null && describeHsmClientCertificatesRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeHsmClientCertificatesRequest.MaxRecords));
            }
            if (describeHsmClientCertificatesRequest != null && describeHsmClientCertificatesRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(describeHsmClientCertificatesRequest.Marker));
            }

            return request;
        }
    }
}
