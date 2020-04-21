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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the AWS resource associated with the activity that prompted
    /// GuardDuty to generate a finding.
    /// </summary>
    public partial class Resource
    {
        private AccessKeyDetails _accessKeyDetails;
        private InstanceDetails _instanceDetails;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property AccessKeyDetails. 
        /// <para>
        /// The IAM access key details (IAM user information) of a user that engaged in the activity
        /// that prompted GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public AccessKeyDetails AccessKeyDetails
        {
            get { return this._accessKeyDetails; }
            set { this._accessKeyDetails = value; }
        }

        // Check to see if AccessKeyDetails property is set
        internal bool IsSetAccessKeyDetails()
        {
            return this._accessKeyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// The information about the EC2 instance associated with the activity that prompted
        /// GuardDuty to generate a finding.
        /// </para>
        /// </summary>
        public InstanceDetails InstanceDetails
        {
            get { return this._instanceDetails; }
            set { this._instanceDetails = value; }
        }

        // Check to see if InstanceDetails property is set
        internal bool IsSetInstanceDetails()
        {
            return this._instanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of AWS resource.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}