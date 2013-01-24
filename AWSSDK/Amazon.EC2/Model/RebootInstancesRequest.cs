/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Requests a reboot of one or more instances.
    /// </summary>
    /// <remarks>
    /// This operation is asynchronous; it only queues a request to
    /// reboot the specified instance(s). The operation will succeed if the instances
    /// are valid and belong to you. Requests to reboot terminated instances
    /// are ignored.
    ///
    /// Note - if a Linux/UNIX instance does not cleanly shut
    /// down within four minutes, Amazon EC2 will perform a hard reboot.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class RebootInstancesRequest
    {    
        private List<string> instanceIdField;

        /// <summary>
        /// One or more instance IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public List<string> InstanceId
        {
            get
            {
                if (this.instanceIdField == null)
                {
                    this.instanceIdField = new List<string>();
                }
                return this.instanceIdField;
            }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets instance IDs.
        /// </summary>
        /// <param name="list">One or more instance IDs.</param>
        /// <returns>this instance</returns>
        public RebootInstancesRequest WithInstanceId(params string[] list)
        {
            foreach (string item in list)
            {
                InstanceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return (InstanceId.Count > 0);
        }

    }
}
