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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Paginators for the Kinesis service
    ///</summary>
    public class KinesisPaginatorFactory : IKinesisPaginatorFactory
    {
        private readonly IAmazonKinesis client;

        internal KinesisPaginatorFactory(IAmazonKinesis client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListStreamConsumers operation
        ///</summary>
        public IListStreamConsumersPaginator ListStreamConsumers(ListStreamConsumersRequest request) 
        {
            return new ListStreamConsumersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreams operation
        ///</summary>
        public IListStreamsPaginator ListStreams(ListStreamsRequest request) 
        {
            return new ListStreamsPaginator(this.client, request);
        }
    }
}