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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for an EC2 instance resource.
    /// </summary>
    public partial class AwsEc2InstanceViolation
    {
        private List<AwsEc2NetworkInterfaceViolation> _awsEc2NetworkInterfaceViolations = new List<AwsEc2NetworkInterfaceViolation>();
        private string _violationTarget;

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterfaceViolations. 
        /// <para>
        /// Violation detail for network interfaces associated with the EC2 instance.
        /// </para>
        /// </summary>
        public List<AwsEc2NetworkInterfaceViolation> AwsEc2NetworkInterfaceViolations
        {
            get { return this._awsEc2NetworkInterfaceViolations; }
            set { this._awsEc2NetworkInterfaceViolations = value; }
        }

        // Check to see if AwsEc2NetworkInterfaceViolations property is set
        internal bool IsSetAwsEc2NetworkInterfaceViolations()
        {
            return this._awsEc2NetworkInterfaceViolations != null && this._awsEc2NetworkInterfaceViolations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The resource ID of the EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTarget
        {
            get { return this._violationTarget; }
            set { this._violationTarget = value; }
        }

        // Check to see if ViolationTarget property is set
        internal bool IsSetViolationTarget()
        {
            return this._violationTarget != null;
        }

    }
}