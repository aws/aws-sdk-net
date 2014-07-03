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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>CreateInstanceProfile</a>            action.
    /// </summary>
    public partial class CreateInstanceProfileResult
    {
        private InstanceProfile _instanceProfile;


        /// <summary>
        /// Gets and sets the property InstanceProfile. 
        /// <para>
        /// Information about the instance profile.
        /// </para>
        /// </summary>
        public InstanceProfile InstanceProfile
        {
            get { return this._instanceProfile; }
            set { this._instanceProfile = value; }
        }


        /// <summary>
        /// Sets the InstanceProfile property
        /// </summary>
        /// <param name="instanceProfile">The value to set for the InstanceProfile property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceProfileResult WithInstanceProfile(InstanceProfile instanceProfile)
        {
            this._instanceProfile = instanceProfile;
            return this;
        }

        // Check to see if InstanceProfile property is set
        internal bool IsSetInstanceProfile()
        {
            return this._instanceProfile != null;
        }

    }
}