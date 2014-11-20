/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchConfigurations operation.
    /// Describes one or more launch configurations. If you omit the list of names, then the
    /// call describes all launch configurations.
    /// 
    ///  
    /// <para>
    /// You can specify a maximum number of items to be returned with a single call. If there
    /// are more items to return, the call returns a token. To get the next set of items,
    /// repeat the call with the returned token in the <code>NextToken</code> parameter.
    /// </para>
    /// </summary>
    public partial class DescribeLaunchConfigurationsRequest : AmazonAutoScalingRequest
    {
        private List<string> _launchConfigurationNames = new List<string>();
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationNames. 
        /// <para>
        /// The launch configuration names.
        /// </para>
        /// </summary>
        public List<string> LaunchConfigurationNames
        {
            get { return this._launchConfigurationNames; }
            set { this._launchConfigurationNames = value; }
        }

        // Check to see if LaunchConfigurationNames property is set
        internal bool IsSetLaunchConfigurationNames()
        {
            return this._launchConfigurationNames != null && this._launchConfigurationNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default is 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
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