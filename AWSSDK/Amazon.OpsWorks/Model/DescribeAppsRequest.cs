/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApps operation.
    /// <para>Requests a description of a specified set of apps.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeApps"/>
    public class DescribeAppsRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private List<string> appIds = new List<string>();

        /// <summary>
        /// The app stack ID. <!-- Could this be more than one stack ID for more than one app? Or is it 'An array of app stack IDs.'? -->
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public DescribeAppsRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// An array of app IDs for the apps to be described.
        ///  
        /// </summary>
        public List<string> AppIds
        {
            get { return this.appIds; }
            set { this.appIds = value; }
        }
        /// <summary>
        /// Adds elements to the AppIds collection
        /// </summary>
        /// <param name="appIds">The values to add to the AppIds collection </param>
        /// <returns>this instance</returns>
        public DescribeAppsRequest WithAppIds(params string[] appIds)
        {
            foreach (string element in appIds)
            {
                this.appIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AppIds collection
        /// </summary>
        /// <param name="appIds">The values to add to the AppIds collection </param>
        /// <returns>this instance</returns>
        public DescribeAppsRequest WithAppIds(IEnumerable<string> appIds)
        {
            foreach (string element in appIds)
            {
                this.appIds.Add(element);
            }

            return this;
        }

        // Check to see if AppIds property is set
        internal bool IsSetAppIds()
        {
            return this.appIds.Count > 0;
        }
    }
}
    
