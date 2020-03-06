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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyAvailabilityZoneGroup operation.
    /// Enables or disables a Zone Group for your account. To use Local Zones, you must first
    /// enable the Zone Group.
    /// </summary>
    public partial class ModifyAvailabilityZoneGroupRequest : AmazonEC2Request
    {
        private string _groupName;
        private ModifyAvailabilityZoneOptInStatus _optInStatus;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The names of the Zone Group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// Indicates whether to enable or disable Zone Group membership. The valid values are
        /// <code>opted-in</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModifyAvailabilityZoneOptInStatus OptInStatus
        {
            get { return this._optInStatus; }
            set { this._optInStatus = value; }
        }

        // Check to see if OptInStatus property is set
        internal bool IsSetOptInStatus()
        {
            return this._optInStatus != null;
        }

    }
}