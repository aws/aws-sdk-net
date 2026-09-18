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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchGetConfigurationPolicyAssociations operation.
    /// </summary>
    public partial class BatchGetConfigurationPolicyAssociationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationPolicyAssociations. 
        /// <para>
        ///  Describes associations for the target accounts, OUs, or the root. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationPolicyAssociationSummary> ConfigurationPolicyAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationPolicyAssociationSummary>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationPolicyAssociations property is set.
        /// </summary>
        internal bool IsSetConfigurationPolicyAssociations() => this.ConfigurationPolicyAssociations != null && (this.ConfigurationPolicyAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnprocessedConfigurationPolicyAssociations. 
        /// <para>
        ///  An array of configuration policy associations, one for each configuration policy
        /// association identifier, that was specified in the request but couldn’t be processed
        /// due to an error. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedConfigurationPolicyAssociation> UnprocessedConfigurationPolicyAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<UnprocessedConfigurationPolicyAssociation>() : null;

        /// <summary>
        /// Checks to see if the UnprocessedConfigurationPolicyAssociations property is set.
        /// </summary>
        internal bool IsSetUnprocessedConfigurationPolicyAssociations() => this.UnprocessedConfigurationPolicyAssociations != null && (this.UnprocessedConfigurationPolicyAssociations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
