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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the GetDistributionConfiguration operation.
    /// </summary>
    public partial class GetDistributionConfigurationResponse : AmazonWebServiceResponse
    {
        private DistributionConfiguration _distributionConfiguration;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property DistributionConfiguration. 
        /// <para>
        /// The distribution configuration object. 
        /// </para>
        /// </summary>
        public DistributionConfiguration DistributionConfiguration
        {
            get { return this._distributionConfiguration; }
            set { this._distributionConfiguration = value; }
        }

        // Check to see if DistributionConfiguration property is set
        internal bool IsSetDistributionConfiguration()
        {
            return this._distributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}