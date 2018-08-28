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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetSamplingTargets operation.
    /// Requests a sampling quota for rules that the service is using to sample requests.
    /// </summary>
    public partial class GetSamplingTargetsRequest : AmazonXRayRequest
    {
        private List<SamplingStatisticsDocument> _samplingStatisticsDocuments = new List<SamplingStatisticsDocument>();

        /// <summary>
        /// Gets and sets the property SamplingStatisticsDocuments. 
        /// <para>
        /// Information about rules that the service is using to sample requests.
        /// </para>
        /// </summary>
        public List<SamplingStatisticsDocument> SamplingStatisticsDocuments
        {
            get { return this._samplingStatisticsDocuments; }
            set { this._samplingStatisticsDocuments = value; }
        }

        // Check to see if SamplingStatisticsDocuments property is set
        internal bool IsSetSamplingStatisticsDocuments()
        {
            return this._samplingStatisticsDocuments != null && this._samplingStatisticsDocuments.Count > 0; 
        }

    }
}