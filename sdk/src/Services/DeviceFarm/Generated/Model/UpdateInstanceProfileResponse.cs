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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the UpdateInstanceProfile operation.
    /// </summary>
    public partial class UpdateInstanceProfileResponse : AmazonWebServiceResponse
    {
        private InstanceProfile _instanceProfile;

        /// <summary>
        /// Gets and sets the property InstanceProfile. 
        /// <para>
        /// An object that contains information about your instance profile.
        /// </para>
        /// </summary>
        public InstanceProfile InstanceProfile
        {
            get { return this._instanceProfile; }
            set { this._instanceProfile = value; }
        }

        // Check to see if InstanceProfile property is set
        internal bool IsSetInstanceProfile()
        {
            return this._instanceProfile != null;
        }

    }
}