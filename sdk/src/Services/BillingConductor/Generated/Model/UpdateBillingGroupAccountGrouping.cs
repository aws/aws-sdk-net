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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Specifies if the billing group has the following features enabled.
    /// </summary>
    public partial class UpdateBillingGroupAccountGrouping
    {
        private bool? _autoAssociate;

        /// <summary>
        /// Gets and sets the property AutoAssociate. 
        /// <para>
        /// Specifies if this billing group will automatically associate newly added Amazon Web
        /// Services accounts that join your consolidated billing family.
        /// </para>
        /// </summary>
        public bool? AutoAssociate
        {
            get { return this._autoAssociate; }
            set { this._autoAssociate = value; }
        }

        // Check to see if AutoAssociate property is set
        internal bool IsSetAutoAssociate()
        {
            return this._autoAssociate.HasValue; 
        }

    }
}