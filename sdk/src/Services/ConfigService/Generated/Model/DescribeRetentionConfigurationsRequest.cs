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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRetentionConfigurations operation.
    /// Returns the details of one or more retention configurations. If the retention configuration
    /// name is not specified, this operation returns the details for all the retention configurations
    /// for that account.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, Config supports only one retention configuration per region in your account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeRetentionConfigurationsRequest : AmazonConfigServiceRequest
    {
        private string _nextToken;
        private List<string> _retentionConfigurationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionConfigurationNames. 
        /// <para>
        /// A list of names of retention configurations for which you want details. If you do
        /// not specify a name, Config returns details for all the retention configurations for
        /// that account.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, Config supports only one retention configuration per region in your account.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> RetentionConfigurationNames
        {
            get { return this._retentionConfigurationNames; }
            set { this._retentionConfigurationNames = value; }
        }

        // Check to see if RetentionConfigurationNames property is set
        internal bool IsSetRetentionConfigurationNames()
        {
            return this._retentionConfigurationNames != null && (this._retentionConfigurationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}