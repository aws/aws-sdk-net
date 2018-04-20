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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the instances that AWS recommends that you purchase.
    /// </summary>
    public partial class InstanceDetails
    {
        private EC2InstanceDetails _ec2InstanceDetails;
        private RDSInstanceDetails _rdsInstanceDetails;

        /// <summary>
        /// Gets and sets the property EC2InstanceDetails. 
        /// <para>
        /// The EC2 instances that AWS recommends that you purchase.
        /// </para>
        /// </summary>
        public EC2InstanceDetails EC2InstanceDetails
        {
            get { return this._ec2InstanceDetails; }
            set { this._ec2InstanceDetails = value; }
        }

        // Check to see if EC2InstanceDetails property is set
        internal bool IsSetEC2InstanceDetails()
        {
            return this._ec2InstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RDSInstanceDetails. 
        /// <para>
        /// The RDS instances that AWS recommends that you purchase.
        /// </para>
        /// </summary>
        public RDSInstanceDetails RDSInstanceDetails
        {
            get { return this._rdsInstanceDetails; }
            set { this._rdsInstanceDetails = value; }
        }

        // Check to see if RDSInstanceDetails property is set
        internal bool IsSetRDSInstanceDetails()
        {
            return this._rdsInstanceDetails != null;
        }

    }
}