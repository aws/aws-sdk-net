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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an enabled security standard in which a security control is enabled.
    /// </summary>
    public partial class AssociatedStandard
    {
        private string _standardsId;

        /// <summary>
        /// Gets and sets the property StandardsId. 
        /// <para>
        /// The unique identifier of a standard in which a control is enabled. This field consists
        /// of the resource portion of the Amazon Resource Name (ARN) returned for a standard
        /// in the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_DescribeStandards.html">DescribeStandards</a>
        /// API response. 
        /// </para>
        /// </summary>
        public string StandardsId
        {
            get { return this._standardsId; }
            set { this._standardsId = value; }
        }

        // Check to see if StandardsId property is set
        internal bool IsSetStandardsId()
        {
            return this._standardsId != null;
        }

    }
}