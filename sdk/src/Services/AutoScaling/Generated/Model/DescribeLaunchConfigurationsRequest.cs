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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchConfigurations operation.
    /// Gets information about the launch configurations in the account and Region.
    /// </summary>
    public partial class DescribeLaunchConfigurationsRequest : AmazonAutoScalingRequest
    {
        private List<string> _launchConfigurationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationNames. 
        /// <para>
        /// The launch configuration names. If you omit this property, all launch configurations
        /// are described.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 50 items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LaunchConfigurationNames
        {
            get { return this._launchConfigurationNames; }
            set { this._launchConfigurationNames = value; }
        }

        // Check to see if LaunchConfigurationNames property is set
        internal bool IsSetLaunchConfigurationNames()
        {
            return this._launchConfigurationNames != null && (this._launchConfigurationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <c>50</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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

    }
}