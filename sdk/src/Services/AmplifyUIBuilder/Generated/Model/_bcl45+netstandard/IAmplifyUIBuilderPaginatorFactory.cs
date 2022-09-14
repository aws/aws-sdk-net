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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Paginators for the AmplifyUIBuilder service
    ///</summary>
    public interface IAmplifyUIBuilderPaginatorFactory
    {

        /// <summary>
        /// Paginator for ExportComponents operation
        ///</summary>
        IExportComponentsPaginator ExportComponents(ExportComponentsRequest request);

        /// <summary>
        /// Paginator for ExportForms operation
        ///</summary>
        IExportFormsPaginator ExportForms(ExportFormsRequest request);

        /// <summary>
        /// Paginator for ExportThemes operation
        ///</summary>
        IExportThemesPaginator ExportThemes(ExportThemesRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListForms operation
        ///</summary>
        IListFormsPaginator ListForms(ListFormsRequest request);

        /// <summary>
        /// Paginator for ListThemes operation
        ///</summary>
        IListThemesPaginator ListThemes(ListThemesRequest request);
    }
}