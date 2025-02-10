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
    /// This is the response object from the UpdatePreferences operation.
    /// </summary>
    public partial class UpdatePreferencesResponse : AmazonWebServiceResponse
    {
        private List<string> _managementAccountRateTypeSelections = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _memberAccountRateTypeSelections = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ManagementAccountRateTypeSelections. 
        /// <para>
        ///  The updated preferred rate types for the management account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> ManagementAccountRateTypeSelections
        {
            get { return this._managementAccountRateTypeSelections; }
            set { this._managementAccountRateTypeSelections = value; }
        }

        // Check to see if ManagementAccountRateTypeSelections property is set
        internal bool IsSetManagementAccountRateTypeSelections()
        {
            return this._managementAccountRateTypeSelections != null && (this._managementAccountRateTypeSelections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberAccountRateTypeSelections. 
        /// <para>
        ///  The updated preferred rate types for member accounts. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> MemberAccountRateTypeSelections
        {
            get { return this._memberAccountRateTypeSelections; }
            set { this._memberAccountRateTypeSelections = value; }
        }

        // Check to see if MemberAccountRateTypeSelections property is set
        internal bool IsSetMemberAccountRateTypeSelections()
        {
            return this._memberAccountRateTypeSelections != null && (this._memberAccountRateTypeSelections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}