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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<ConfigurationPolicyAssociationSummary> _configurationPolicyAssociations = AWSConfigs.InitializeCollections ? new List<ConfigurationPolicyAssociationSummary>() : null;
        private List<UnprocessedConfigurationPolicyAssociation> _unprocessedConfigurationPolicyAssociations = AWSConfigs.InitializeCollections ? new List<UnprocessedConfigurationPolicyAssociation>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyAssociations. 
        /// <para>
        ///  Describes associations for the target accounts, OUs, or the root. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationPolicyAssociationSummary> ConfigurationPolicyAssociations
        {
            get { return this._configurationPolicyAssociations; }
            set { this._configurationPolicyAssociations = value; }
        }

        // Check to see if ConfigurationPolicyAssociations property is set
        internal bool IsSetConfigurationPolicyAssociations()
        {
            return this._configurationPolicyAssociations != null && (this._configurationPolicyAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedConfigurationPolicyAssociations. 
        /// <para>
        ///  An array of configuration policy associations, one for each configuration policy
        /// association identifier, that was specified in the request but couldn’t be processed
        /// due to an error. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedConfigurationPolicyAssociation> UnprocessedConfigurationPolicyAssociations
        {
            get { return this._unprocessedConfigurationPolicyAssociations; }
            set { this._unprocessedConfigurationPolicyAssociations = value; }
        }

        // Check to see if UnprocessedConfigurationPolicyAssociations property is set
        internal bool IsSetUnprocessedConfigurationPolicyAssociations()
        {
            return this._unprocessedConfigurationPolicyAssociations != null && (this._unprocessedConfigurationPolicyAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}