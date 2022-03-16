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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A filter that specifies the custom line items and billing groups to retrieve FFLI
    /// information.
    /// </summary>
    public partial class ListCustomLineItemsFilter
    {
        private List<string> _arns = new List<string>();
        private List<string> _billingGroups = new List<string>();
        private List<string> _names = new List<string>();

        /// <summary>
        /// Gets and sets the property Arns. 
        /// <para>
        ///  A list of custom line item ARNs to retrieve information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Arns
        {
            get { return this._arns; }
            set { this._arns = value; }
        }

        // Check to see if Arns property is set
        internal bool IsSetArns()
        {
            return this._arns != null && this._arns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BillingGroups. 
        /// <para>
        ///  The billing group Amazon Resource Names (ARNs) to retrieve information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> BillingGroups
        {
            get { return this._billingGroups; }
            set { this._billingGroups = value; }
        }

        // Check to see if BillingGroups property is set
        internal bool IsSetBillingGroups()
        {
            return this._billingGroups != null && this._billingGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        ///  A list of custom line items to retrieve information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

    }
}