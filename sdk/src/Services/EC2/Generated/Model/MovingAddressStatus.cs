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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
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
    /// Describes the status of a moving Elastic IP address.
    /// </summary>
    public partial class MovingAddressStatus
    {
        private MoveStatus _moveStatus;
        private string _publicIp;

        /// <summary>
        /// Gets and sets the property MoveStatus. 
        /// <para>
        /// The status of the Elastic IP address that's being moved to the EC2-VPC platform, or
        /// restored to the EC2-Classic platform.
        /// </para>
        /// </summary>
        public MoveStatus MoveStatus
        {
            get { return this._moveStatus; }
            set { this._moveStatus = value; }
        }

        // Check to see if MoveStatus property is set
        internal bool IsSetMoveStatus()
        {
            return this._moveStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

    }
}