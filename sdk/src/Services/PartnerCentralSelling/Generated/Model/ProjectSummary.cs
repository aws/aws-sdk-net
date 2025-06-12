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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains a <c>Project</c> object's subset of fields.
    /// </summary>
    public partial class ProjectSummary
    {
        private List<string> _deliveryModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ExpectedCustomerSpend> _expectedCustomerSpend = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryModels. 
        /// <para>
        /// Specifies your solution or service's deployment or consumption model in the <c>Opportunity</c>'s
        /// context. You can select multiple options.
        /// </para>
        ///  
        /// <para>
        /// Options' descriptions from the <c>Delivery Model</c> field are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SaaS or PaaS: Your Amazon Web Services based solution deployed as SaaS or PaaS in
        /// your Amazon Web Services environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BYOL or AMI: Your Amazon Web Services based solution deployed as BYOL or AMI in the
        /// end customer's Amazon Web Services environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Managed Services: The end customer's Amazon Web Services business management (For
        /// example: Consulting, design, implementation, billing support, cost optimization, technical
        /// support).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Professional Services: Offerings to help enterprise end customers achieve specific
        /// business outcomes for enterprise cloud adoption (For example: Advisory or transformation
        /// planning).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resell: Amazon Web Services accounts and billing management for your customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other: Delivery model not described above.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeliveryModels
        {
            get { return this._deliveryModels; }
            set { this._deliveryModels = value; }
        }

        // Check to see if DeliveryModels property is set
        internal bool IsSetDeliveryModels()
        {
            return this._deliveryModels != null && (this._deliveryModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        /// Provides a summary of the expected customer spend for the project, offering a high-level
        /// view of the potential financial impact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ExpectedCustomerSpend> ExpectedCustomerSpend
        {
            get { return this._expectedCustomerSpend; }
            set { this._expectedCustomerSpend = value; }
        }

        // Check to see if ExpectedCustomerSpend property is set
        internal bool IsSetExpectedCustomerSpend()
        {
            return this._expectedCustomerSpend != null && (this._expectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}