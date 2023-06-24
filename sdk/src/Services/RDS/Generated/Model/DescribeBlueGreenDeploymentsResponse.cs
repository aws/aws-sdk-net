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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the DescribeBlueGreenDeployments operation.
    /// </summary>
    public partial class DescribeBlueGreenDeploymentsResponse : AmazonWebServiceResponse
    {
        private List<BlueGreenDeployment> _blueGreenDeployments = new List<BlueGreenDeployment>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property BlueGreenDeployments. 
        /// <para>
        /// Contains a list of blue/green deployments for the user.
        /// </para>
        /// </summary>
        public List<BlueGreenDeployment> BlueGreenDeployments
        {
            get { return this._blueGreenDeployments; }
            set { this._blueGreenDeployments = value; }
        }

        // Check to see if BlueGreenDeployments property is set
        internal bool IsSetBlueGreenDeployments()
        {
            return this._blueGreenDeployments != null && this._blueGreenDeployments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token that can be used in a later DescribeBlueGreenDeployments request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}