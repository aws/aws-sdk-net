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
    /// Container for the parameters to the DeleteInstanceProfile operation.
    /// Deletes the specified instance profile. The instance profile must not have an associated            role.
    /// 
    ///         <important>Make sure you do not have any Amazon EC2 instances running with the instance
    /// profile            you are about to delete. Deleting a role or instance profile that is associated
    /// with a running            instance will break any applications running on the instance.</important>        
    /// <para>
    /// For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
    /// Instance                Profiles</a>.
    /// </para>
    /// </summary>
    public partial class DeleteInstanceProfileRequest : AmazonWebServiceRequest
    {
        private string _instanceProfileName;


        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// Name of the instance profile to delete.
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }


        /// <summary>
        /// Sets the InstanceProfileName property
        /// </summary>
        /// <param name="instanceProfileName">The value to set for the InstanceProfileName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteInstanceProfileRequest WithInstanceProfileName(string instanceProfileName)
        {
            this._instanceProfileName = instanceProfileName;
            return this;
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }

    }
}