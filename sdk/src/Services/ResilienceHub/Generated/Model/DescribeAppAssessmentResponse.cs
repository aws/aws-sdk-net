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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeAppAssessment operation.
    /// </summary>
    public partial class DescribeAppAssessmentResponse : AmazonWebServiceResponse
    {
        private AppAssessment _assessment;

        /// <summary>
        /// Gets and sets the property Assessment. 
        /// <para>
        /// The assessment for an Resilience Hub application, returned as an object. This object
        /// includes Amazon Resource Names (ARNs), compliance information, compliance status,
        /// cost, messages, resiliency scores, and more.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppAssessment Assessment
        {
            get { return this._assessment; }
            set { this._assessment = value; }
        }

        // Check to see if Assessment property is set
        internal bool IsSetAssessment()
        {
            return this._assessment != null;
        }

    }
}