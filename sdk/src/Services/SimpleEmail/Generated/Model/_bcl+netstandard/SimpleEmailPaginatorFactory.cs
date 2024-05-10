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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Paginators for the SimpleEmail service
    ///</summary>
    public class SimpleEmailPaginatorFactory : ISimpleEmailPaginatorFactory
    {
        private readonly IAmazonSimpleEmailService client;

        internal SimpleEmailPaginatorFactory(IAmazonSimpleEmailService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCustomVerificationEmailTemplates operation
        ///</summary>
        public IListCustomVerificationEmailTemplatesPaginator ListCustomVerificationEmailTemplates(ListCustomVerificationEmailTemplatesRequest request) 
        {
            return new ListCustomVerificationEmailTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdentities operation
        ///</summary>
        public IListIdentitiesPaginator ListIdentities(ListIdentitiesRequest request) 
        {
            return new ListIdentitiesPaginator(this.client, request);
        }
    }
}