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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Paginators for the TaxSettings service
    ///</summary>
    public class TaxSettingsPaginatorFactory : ITaxSettingsPaginatorFactory
    {
        private readonly IAmazonTaxSettings client;

        internal TaxSettingsPaginatorFactory(IAmazonTaxSettings client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSupplementalTaxRegistrations operation
        ///</summary>
        public IListSupplementalTaxRegistrationsPaginator ListSupplementalTaxRegistrations(ListSupplementalTaxRegistrationsRequest request) 
        {
            return new ListSupplementalTaxRegistrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaxExemptions operation
        ///</summary>
        public IListTaxExemptionsPaginator ListTaxExemptions(ListTaxExemptionsRequest request) 
        {
            return new ListTaxExemptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTaxRegistrations operation
        ///</summary>
        public IListTaxRegistrationsPaginator ListTaxRegistrations(ListTaxRegistrationsRequest request) 
        {
            return new ListTaxRegistrationsPaginator(this.client, request);
        }
    }
}