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
    /// A filter that specifies the type of resource associations that should be retrieved
    /// for a custom line item.
    /// </summary>
    public partial class ListResourcesAssociatedToCustomLineItemFilter
    {
        private CustomLineItemRelationship _relationship;

        /// <summary>
        /// Gets and sets the property Relationship. 
        /// <para>
        ///  The type of relationship between the custom line item and the associated resource.
        /// 
        /// </para>
        /// </summary>
        public CustomLineItemRelationship Relationship
        {
            get { return this._relationship; }
            set { this._relationship = value; }
        }

        // Check to see if Relationship property is set
        internal bool IsSetRelationship()
        {
            return this._relationship != null;
        }

    }
}