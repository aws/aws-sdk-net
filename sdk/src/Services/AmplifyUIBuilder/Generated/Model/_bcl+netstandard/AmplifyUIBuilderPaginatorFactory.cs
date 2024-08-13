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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Paginators for the AmplifyUIBuilder service
    ///</summary>
    public class AmplifyUIBuilderPaginatorFactory : IAmplifyUIBuilderPaginatorFactory
    {
        private readonly IAmazonAmplifyUIBuilder client;

        internal AmplifyUIBuilderPaginatorFactory(IAmazonAmplifyUIBuilder client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ExportComponents operation
        ///</summary>
        public IExportComponentsPaginator ExportComponents(ExportComponentsRequest request) 
        {
            return new ExportComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ExportForms operation
        ///</summary>
        public IExportFormsPaginator ExportForms(ExportFormsRequest request) 
        {
            return new ExportFormsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ExportThemes operation
        ///</summary>
        public IExportThemesPaginator ExportThemes(ExportThemesRequest request) 
        {
            return new ExportThemesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCodegenJobs operation
        ///</summary>
        public IListCodegenJobsPaginator ListCodegenJobs(ListCodegenJobsRequest request) 
        {
            return new ListCodegenJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListForms operation
        ///</summary>
        public IListFormsPaginator ListForms(ListFormsRequest request) 
        {
            return new ListFormsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThemes operation
        ///</summary>
        public IListThemesPaginator ListThemes(ListThemesRequest request) 
        {
            return new ListThemesPaginator(this.client, request);
        }
    }
}