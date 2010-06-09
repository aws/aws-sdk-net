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
    /// Describe Bundle Tasks Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeBundleTasksResult
    {
        private List<BundleTask> bundleTaskField;
        /// <summary>
        /// Gets and sets the BundleTask property.
        /// Bundle Task
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleTask")]
        public List<BundleTask> BundleTask
        {
            get
            {
                if (this.bundleTaskField == null)
                {
                    this.bundleTaskField = new List<BundleTask>();
                }
                return this.bundleTaskField;
            }
            set { this.bundleTaskField = value; }
        }

        /// <summary>
        /// Sets the BundleTask property
        /// </summary>
        /// <param name="list">Bundle Task</param>
        /// <returns>this instance</returns>
        public DescribeBundleTasksResult WithBundleTask(params BundleTask[] list)
        {
            foreach (BundleTask item in list)
            {
                BundleTask.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BundleTask property is set
        /// </summary>
        /// <returns>true if BundleTask property is set</returns>
        public bool IsSetBundleTask()
        {
            return (BundleTask.Count > 0);
        }

    }
}
