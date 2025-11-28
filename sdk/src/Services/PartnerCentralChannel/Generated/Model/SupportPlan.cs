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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Configuration for different types of support plans.
    /// </summary>
    public partial class SupportPlan
    {
        private PartnerLedSupport _partnerLedSupport;
        private ResoldBusiness _resoldBusiness;
        private ResoldEnterprise _resoldEnterprise;

        /// <summary>
        /// Gets and sets the property PartnerLedSupport. 
        /// <para>
        /// Configuration for partner-led support plans.
        /// </para>
        /// </summary>
        public PartnerLedSupport PartnerLedSupport
        {
            get { return this._partnerLedSupport; }
            set { this._partnerLedSupport = value; }
        }

        // Check to see if PartnerLedSupport property is set
        internal bool IsSetPartnerLedSupport()
        {
            return this._partnerLedSupport != null;
        }

        /// <summary>
        /// Gets and sets the property ResoldBusiness. 
        /// <para>
        /// Configuration for resold business support plans.
        /// </para>
        /// </summary>
        public ResoldBusiness ResoldBusiness
        {
            get { return this._resoldBusiness; }
            set { this._resoldBusiness = value; }
        }

        // Check to see if ResoldBusiness property is set
        internal bool IsSetResoldBusiness()
        {
            return this._resoldBusiness != null;
        }

        /// <summary>
        /// Gets and sets the property ResoldEnterprise. 
        /// <para>
        /// Configuration for resold enterprise support plans.
        /// </para>
        /// </summary>
        public ResoldEnterprise ResoldEnterprise
        {
            get { return this._resoldEnterprise; }
            set { this._resoldEnterprise = value; }
        }

        // Check to see if ResoldEnterprise property is set
        internal bool IsSetResoldEnterprise()
        {
            return this._resoldEnterprise != null;
        }

    }
}