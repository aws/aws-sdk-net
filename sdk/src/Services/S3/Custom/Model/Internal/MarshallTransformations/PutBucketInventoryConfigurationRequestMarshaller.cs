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
using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System.Globalization;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Request Marshaller for PutInventoryConfiguration operation
    /// </summary> 
    public partial class PutBucketInventoryConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketInventoryConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketInventoryConfigurationRequest publicRequest)
        {
            ChecksumUtils.SetChecksumData(defaultRequest);
        }

        void InventoryFilterCustomMarshall(PutBucketInventoryConfigurationRequest publicRequest, XmlWriter xmlWriter)
        {
            var inventoryConfiguration = publicRequest.InventoryConfiguration;
            if (inventoryConfiguration.IsSetInventoryFilter())
            {
                xmlWriter.WriteStartElement("Filter");
                var predicate = inventoryConfiguration.InventoryFilter.InventoryFilterPredicate;
                predicate.Accept(new InventoryPredicateVisitor(xmlWriter));
                xmlWriter.WriteEndElement();
            }
        }
    }
}
