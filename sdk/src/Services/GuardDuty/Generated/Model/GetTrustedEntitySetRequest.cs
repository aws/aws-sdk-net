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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrustedEntitySet operation.
    /// Retrieves the trusted entity set associated with the specified <c>trustedEntitySetId</c>.
    /// </summary>
    public partial class GetTrustedEntitySetRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private string _trustedEntitySetId;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with this trusted entity set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedEntitySetId. 
        /// <para>
        /// The unique ID that helps GuardDuty identify the trusted entity set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrustedEntitySetId
        {
            get { return this._trustedEntitySetId; }
            set { this._trustedEntitySetId = value; }
        }

        // Check to see if TrustedEntitySetId property is set
        internal bool IsSetTrustedEntitySetId()
        {
            return this._trustedEntitySetId != null;
        }

    }
}