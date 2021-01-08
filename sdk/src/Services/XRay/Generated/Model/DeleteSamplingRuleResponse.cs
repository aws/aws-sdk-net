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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the DeleteSamplingRule operation.
    /// </summary>
    public partial class DeleteSamplingRuleResponse : AmazonWebServiceResponse
    {
        private SamplingRuleRecord _samplingRuleRecord;

        /// <summary>
        /// Gets and sets the property SamplingRuleRecord. 
        /// <para>
        /// The deleted rule definition and metadata.
        /// </para>
        /// </summary>
        public SamplingRuleRecord SamplingRuleRecord
        {
            get { return this._samplingRuleRecord; }
            set { this._samplingRuleRecord = value; }
        }

        // Check to see if SamplingRuleRecord property is set
        internal bool IsSetSamplingRuleRecord()
        {
            return this._samplingRuleRecord != null;
        }

    }
}