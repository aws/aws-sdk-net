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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;


#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public partial class PutBucketMetricsConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketMetricsConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Custom marshaller for Metrics Filter
        /// </summary>
        /// <param name="publicRequest"></param>
        /// <param name="xmlWriter"></param>
        public void MetricsFilterCustomMarshall(PutBucketMetricsConfigurationRequest publicRequest, XmlWriter xmlWriter)
        {
            if (publicRequest.MetricsConfiguration.MetricsFilter != null)
            {
                xmlWriter.WriteStartElement("Filter");
                if (publicRequest.MetricsConfiguration.MetricsFilter.MetricsFilterPredicate != null)
                {
                    publicRequest.MetricsConfiguration.MetricsFilter.MetricsFilterPredicate.Accept(new MetricsPredicateVisitor(xmlWriter));
                }
                xmlWriter.WriteEndElement();
            }
        }

        // preserving this logic https://github.com/aws/aws-sdk-net-staging/blob/aaa45084f08d8a778582048974d0246f5707f213/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/PutBucketMetricsConfigurationRequestMarshaller.cs#L91
        // even though model doesn't specify any checksum being required, this has been here for a while.
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketMetricsConfigurationRequest publicRequest)
        {
            ChecksumUtils.SetChecksumData(defaultRequest);
        }
    }
}
