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
    /// Result of a StartInstances request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class StartInstancesResult
    {
        private List<InstanceStateChange> startingInstancesField;
        /// <summary>
        /// Gets and sets the StartingInstances property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartingInstances")]
        public List<InstanceStateChange> StartingInstances
        {
            get
            {
                if (this.startingInstancesField == null)
                {
                    this.startingInstancesField = new List<InstanceStateChange>();
                }
                return this.startingInstancesField;
            }
            set { this.startingInstancesField = value; }
        }

        /// <summary>
        /// Sets the StartingInstances property
        /// </summary>
        /// <param name="list">StartingInstances property</param>
        /// <returns>this instance</returns>
        public StartInstancesResult WithStartingInstances(params InstanceStateChange[] list)
        {
            foreach (InstanceStateChange item in list)
            {
                StartingInstances.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if StartingInstances property is set
        /// </summary>
        /// <returns>true if StartingInstances property is set</returns>
        public bool IsSetStartingInstances()
        {
            return (StartingInstances.Count > 0);
        }

    }
}
