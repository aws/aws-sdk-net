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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Launch instances with ENA Express settings configured from your launch template.
    /// </summary>
    public partial class EnaSrdSpecificationRequest
    {
        private bool? _enaSrdEnabled;
        private EnaSrdUdpSpecificationRequest _enaSrdUdpSpecification;

        /// <summary>
        /// Gets and sets the property EnaSrdEnabled. 
        /// <para>
        /// Specifies whether ENA Express is enabled for the network interface when you launch
        /// an instance.
        /// </para>
        /// </summary>
        public bool? EnaSrdEnabled
        {
            get { return this._enaSrdEnabled; }
            set { this._enaSrdEnabled = value; }
        }

        // Check to see if EnaSrdEnabled property is set
        internal bool IsSetEnaSrdEnabled()
        {
            return this._enaSrdEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdUdpSpecification. 
        /// <para>
        /// Contains ENA Express settings for UDP network traffic for the network interface attached
        /// to the instance.
        /// </para>
        /// </summary>
        public EnaSrdUdpSpecificationRequest EnaSrdUdpSpecification
        {
            get { return this._enaSrdUdpSpecification; }
            set { this._enaSrdUdpSpecification = value; }
        }

        // Check to see if EnaSrdUdpSpecification property is set
        internal bool IsSetEnaSrdUdpSpecification()
        {
            return this._enaSrdUdpSpecification != null;
        }

    }
}