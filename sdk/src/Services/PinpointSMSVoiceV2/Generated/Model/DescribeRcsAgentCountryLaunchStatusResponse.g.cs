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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeRcsAgentCountryLaunchStatus operation.
    /// </summary>
    public partial class DescribeRcsAgentCountryLaunchStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CountryLaunchStatus. 
        /// <para>
        /// An array of CountryLaunchStatusInformation objects that contain the per-country launch
        /// status details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CountryLaunchStatusInformation> CountryLaunchStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<CountryLaunchStatusInformation>() : null;

        /// <summary>
        /// Checks to see if the CountryLaunchStatus property is set.
        /// </summary>
        internal bool IsSetCountryLaunchStatus() => this.CountryLaunchStatus != null && (this.CountryLaunchStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. If this field is empty
        /// then there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RcsAgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RcsAgentArn { get; set; }

        /// <summary>
        /// Checks to see if the RcsAgentArn property is set.
        /// </summary>
        internal bool IsSetRcsAgentArn() => this.RcsAgentArn != null;

        /// <summary>
        /// Gets and sets the property RcsAgentId. 
        /// <para>
        /// The unique identifier for the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RcsAgentId { get; set; }

        /// <summary>
        /// Checks to see if the RcsAgentId property is set.
        /// </summary>
        internal bool IsSetRcsAgentId() => this.RcsAgentId != null;
    }
}
