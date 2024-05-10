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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Paginators for the IAMRolesAnywhere service
    ///</summary>
    public interface IIAMRolesAnywherePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListCrls operation
        ///</summary>
        IListCrlsPaginator ListCrls(ListCrlsRequest request);

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        IListProfilesPaginator ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Paginator for ListSubjects operation
        ///</summary>
        IListSubjectsPaginator ListSubjects(ListSubjectsRequest request);

        /// <summary>
        /// Paginator for ListTrustAnchors operation
        ///</summary>
        IListTrustAnchorsPaginator ListTrustAnchors(ListTrustAnchorsRequest request);
    }
}