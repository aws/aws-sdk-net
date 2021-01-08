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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>UpdateScalingParameters</code> request. Contains the status
    /// of the newly-configured scaling parameters.
    /// </summary>
    public partial class UpdateScalingParametersResponse : AmazonWebServiceResponse
    {
        private ScalingParametersStatus _scalingParameters;

        /// <summary>
        /// Gets and sets the property ScalingParameters.
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingParametersStatus ScalingParameters
        {
            get { return this._scalingParameters; }
            set { this._scalingParameters = value; }
        }

        // Check to see if ScalingParameters property is set
        internal bool IsSetScalingParameters()
        {
            return this._scalingParameters != null;
        }

    }
}