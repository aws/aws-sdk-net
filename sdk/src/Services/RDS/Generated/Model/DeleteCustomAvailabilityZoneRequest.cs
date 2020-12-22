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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCustomAvailabilityZone operation.
    /// Deletes a custom Availability Zone (AZ).
    /// 
    ///  
    /// <para>
    /// A custom AZ is an on-premises AZ that is integrated with a VMware vSphere cluster.
    /// </para>
    ///  
    /// <para>
    /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
    /// RDS on VMware User Guide.</a> 
    /// </para>
    /// </summary>
    public partial class DeleteCustomAvailabilityZoneRequest : AmazonRDSRequest
    {
        private string _customAvailabilityZoneId;

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneId. 
        /// <para>
        /// The custom AZ identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomAvailabilityZoneId
        {
            get { return this._customAvailabilityZoneId; }
            set { this._customAvailabilityZoneId = value; }
        }

        // Check to see if CustomAvailabilityZoneId property is set
        internal bool IsSetCustomAvailabilityZoneId()
        {
            return this._customAvailabilityZoneId != null;
        }

    }
}