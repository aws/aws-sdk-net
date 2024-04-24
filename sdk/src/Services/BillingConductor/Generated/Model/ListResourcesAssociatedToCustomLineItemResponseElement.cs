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
    /// A representation of a resource association for a custom line item.
    /// </summary>
    public partial class ListResourcesAssociatedToCustomLineItemResponseElement
    {
        private string _arn;
        private string _endBillingPeriod;
        private CustomLineItemRelationship _relationship;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the associated resource. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EndBillingPeriod. 
        /// <para>
        /// The end billing period of the associated resource.
        /// </para>
        /// </summary>
        public string EndBillingPeriod
        {
            get { return this._endBillingPeriod; }
            set { this._endBillingPeriod = value; }
        }

        // Check to see if EndBillingPeriod property is set
        internal bool IsSetEndBillingPeriod()
        {
            return this._endBillingPeriod != null;
        }

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