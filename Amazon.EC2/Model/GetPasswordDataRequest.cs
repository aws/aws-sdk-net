/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Retrieves the encrypted administrator password
    /// for the instances running
    /// Windows.
    ///
    /// Note - the Windows password is
    /// only generated the first time an AMI is launched.
    /// It is not generated for rebundled AMIs or after the password is
    /// changed on an instance.
    ///
    /// The password is encrypted using the key pair that you
    /// provided.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class GetPasswordDataRequest
    {    
        private string instanceIdField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The ID of the instance for which to get the
        /// password.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The ID of the instance for which to get the
        /// password.</param>
        /// <returns>this instance</returns>
        public GetPasswordDataRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

    }
}
