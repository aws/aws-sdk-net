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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Used to provide Reserved Instance preferences for the recommendation.
    /// </summary>
    public partial class ReservedInstanceOptions
    {
        private OfferingClass _offeringClass;
        private PurchasingOption _purchasingOption;
        private TermLength _termLength;

        /// <summary>
        /// Gets and sets the property OfferingClass. 
        /// <para>
        ///  The flexibility to change the instance types needed for your Reserved Instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OfferingClass OfferingClass
        {
            get { return this._offeringClass; }
            set { this._offeringClass = value; }
        }

        // Check to see if OfferingClass property is set
        internal bool IsSetOfferingClass()
        {
            return this._offeringClass != null;
        }

        /// <summary>
        /// Gets and sets the property PurchasingOption. 
        /// <para>
        ///  The payment plan to use for your Reserved Instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PurchasingOption PurchasingOption
        {
            get { return this._purchasingOption; }
            set { this._purchasingOption = value; }
        }

        // Check to see if PurchasingOption property is set
        internal bool IsSetPurchasingOption()
        {
            return this._purchasingOption != null;
        }

        /// <summary>
        /// Gets and sets the property TermLength. 
        /// <para>
        ///  The preferred duration of the Reserved Instance term. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TermLength TermLength
        {
            get { return this._termLength; }
            set { this._termLength = value; }
        }

        // Check to see if TermLength property is set
        internal bool IsSetTermLength()
        {
            return this._termLength != null;
        }

    }
}