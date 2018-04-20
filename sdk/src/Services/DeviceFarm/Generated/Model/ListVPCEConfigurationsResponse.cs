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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the ListVPCEConfigurations operation.
    /// </summary>
    public partial class ListVPCEConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VPCEConfiguration> _vpceConfigurations = new List<VPCEConfiguration>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
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
        /// Gets and sets the property VpceConfigurations. 
        /// <para>
        /// An array of <code>VPCEConfiguration</code> objects containing information about your
        /// VPC endpoint configuration.
        /// </para>
        /// </summary>
        public List<VPCEConfiguration> VpceConfigurations
        {
            get { return this._vpceConfigurations; }
            set { this._vpceConfigurations = value; }
        }

        // Check to see if VpceConfigurations property is set
        internal bool IsSetVpceConfigurations()
        {
            return this._vpceConfigurations != null && this._vpceConfigurations.Count > 0; 
        }

    }
}