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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetPreferences operation.
    /// </summary>
    public partial class GetPreferencesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ManagementAccountRateTypeSelections. 
        /// <para>
        ///  The preferred rate types for the management account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> ManagementAccountRateTypeSelections { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagementAccountRateTypeSelections property is set.
        /// </summary>
        internal bool IsSetManagementAccountRateTypeSelections() => this.ManagementAccountRateTypeSelections != null && (this.ManagementAccountRateTypeSelections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MemberAccountRateTypeSelections. 
        /// <para>
        ///  The preferred rate types for member accounts. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> MemberAccountRateTypeSelections { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemberAccountRateTypeSelections property is set.
        /// </summary>
        internal bool IsSetMemberAccountRateTypeSelections() => this.MemberAccountRateTypeSelections != null && (this.MemberAccountRateTypeSelections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StandaloneAccountRateTypeSelections. 
        /// <para>
        ///  The preferred rate types for a standalone account. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> StandaloneAccountRateTypeSelections { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StandaloneAccountRateTypeSelections property is set.
        /// </summary>
        internal bool IsSetStandaloneAccountRateTypeSelections() => this.StandaloneAccountRateTypeSelections != null && (this.StandaloneAccountRateTypeSelections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
