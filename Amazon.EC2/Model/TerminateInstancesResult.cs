/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Terminate Instances Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class TerminateInstancesResult
    {
        private List<InstanceStateChange> terminatingInstanceField;
        /// <summary>
        /// Gets and sets the TerminatingInstance property.
        /// List of terminating instances
        /// </summary>
        [XmlElementAttribute(ElementName = "TerminatingInstance")]
        public List<InstanceStateChange> TerminatingInstance
        {
            get
            {
                if (this.terminatingInstanceField == null)
                {
                    this.terminatingInstanceField = new List<InstanceStateChange>();
                }
                return this.terminatingInstanceField;
            }
            set { this.terminatingInstanceField = value; }
        }

        /// <summary>
        /// Sets the TerminatingInstance property
        /// </summary>
        /// <param name="list">List of terminating instances</param>
        /// <returns>this instance</returns>
        public TerminateInstancesResult WithTerminatingInstance(params InstanceStateChange[] list)
        {
            foreach (InstanceStateChange item in list)
            {
                TerminatingInstance.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if TerminatingInstance property is set
        /// </summary>
        /// <returns>true if TerminatingInstance property is set</returns>
        public bool IsSetTerminatingInstance()
        {
            return (TerminatingInstance.Count > 0);
        }

    }
}
