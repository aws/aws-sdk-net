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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Endpoint discovery parameters for DeleteBackup operation
    /// </summary>
    public partial class DeleteBackupEndpointDiscoveryMarshaller : IMarshaller<EndpointDiscoveryDataBase, DeleteBackupRequest>, IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to its endpoint discovery data.
        /// </summary>
        public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBackupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to its endpoint discovery data.
        /// </summary>
        public EndpointDiscoveryDataBase Marshall(DeleteBackupRequest publicRequest)
        {
            return new EndpointDiscoveryData(false);
        }

        private static DeleteBackupEndpointDiscoveryMarshaller _instance = new DeleteBackupEndpointDiscoveryMarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteBackupEndpointDiscoveryMarshaller Instance => _instance;
    }
}
