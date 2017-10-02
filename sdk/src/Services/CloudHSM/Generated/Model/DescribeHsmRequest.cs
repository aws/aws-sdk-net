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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHsm operation.
    /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
    /// number.
    /// </summary>
    public partial class DescribeHsmRequest : AmazonCloudHSMRequest
    {
        private string _hsmArn;
        private string _hsmSerialNumber;

        /// <summary>
        /// Gets and sets the property HsmArn. 
        /// <para>
        /// The ARN of the HSM. Either the <code>HsmArn</code> or the <code>SerialNumber</code>
        /// parameter must be specified.
        /// </para>
        /// </summary>
        public string HsmArn
        {
            get { return this._hsmArn; }
            set { this._hsmArn = value; }
        }

        // Check to see if HsmArn property is set
        internal bool IsSetHsmArn()
        {
            return this._hsmArn != null;
        }

        /// <summary>
        /// Gets and sets the property HsmSerialNumber. 
        /// <para>
        /// The serial number of the HSM. Either the <code>HsmArn</code> or the <code>HsmSerialNumber</code>
        /// parameter must be specified.
        /// </para>
        /// </summary>
        public string HsmSerialNumber
        {
            get { return this._hsmSerialNumber; }
            set { this._hsmSerialNumber = value; }
        }

        // Check to see if HsmSerialNumber property is set
        internal bool IsSetHsmSerialNumber()
        {
            return this._hsmSerialNumber != null;
        }

    }
}