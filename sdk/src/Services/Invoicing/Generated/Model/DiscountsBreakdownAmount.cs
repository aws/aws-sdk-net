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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The discounted amount.
    /// </summary>
    public partial class DiscountsBreakdownAmount
    {
        private string _amount;
        private string _description;
        private string _rate;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The discounted amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The list of discounts information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Rate. 
        /// <para>
        ///  The details for the discount rate.. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        // Check to see if Rate property is set
        internal bool IsSetRate()
        {
            return this._rate != null;
        }

    }
}