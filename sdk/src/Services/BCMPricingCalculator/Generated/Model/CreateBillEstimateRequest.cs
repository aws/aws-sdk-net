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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBillEstimate operation.
    /// Create a Bill estimate from a Bill scenario. In the Bill scenario you can model usage
    /// addition, usage changes, and usage removal. You can also model commitment addition
    /// and commitment removal. After all changes in a Bill scenario is made satisfactorily,
    /// you can call this API with a Bill scenario ID to generate the Bill estimate. Bill
    /// estimate calculates the pre-tax cost for your consolidated billing family, incorporating
    /// all modeled usage and commitments alongside existing usage and commitments from your
    /// most recent completed anniversary bill, with any applicable discounts applied.
    /// </summary>
    public partial class CreateBillEstimateRequest : AmazonBCMPricingCalculatorRequest
    {
        private string _billScenarioId;
        private string _clientToken;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property BillScenarioId. 
        /// <para>
        ///  The ID of the Bill Scenario for which you want to create a Bill estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BillScenarioId
        {
            get { return this._billScenarioId; }
            set { this._billScenarioId = value; }
        }

        // Check to see if BillScenarioId property is set
        internal bool IsSetBillScenarioId()
        {
            return this._billScenarioId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the Bill estimate that will be created. Names must be unique for an account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  An optional list of tags to associate with the specified BillEstimate. You can use
        /// resource tags to control access to your BillEstimate using IAM policies. Each tag
        /// consists of a key and a value, and each key must be unique for the resource. The following
        /// restrictions apply to resource tags: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although the maximum number of array members is 200, you can assign a maximum of 50
        /// user-tags to one resource. The remaining are reserved for Amazon Web Services. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a key is 128 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a value is 256 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values can only contain alphanumeric characters, spaces, and any of the following:
        /// <c>_.:/=+@-</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are trimmed for any leading or trailing whitespaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don't use <c>aws:</c> as a prefix for your keys. This prefix is reserved for Amazon
        /// Web Services.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}