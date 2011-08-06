/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DescribeAutoScalingNotificationTypesResult  
    {
        
        private List<string> autoScalingNotificationTypes = new List<string>();

        /// <summary>
        /// <i>Eric's doc mentions the following: autoscaling:EC2_Instance_Launch, autoscaling:EC2_Instance_Terminate, autoscaling:Error. Should we list
        /// them? Where can I get a complete list to add here or refer users to?</i>>
        ///  
        /// </summary>
        public List<string> AutoScalingNotificationTypes
        {
            get { return this.autoScalingNotificationTypes; }
            set { this.autoScalingNotificationTypes = value; }
        }
        /// <summary>
        /// Adds elements to the AutoScalingNotificationTypes collection
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(params string[] autoScalingNotificationTypes)
        {
            foreach (string element in autoScalingNotificationTypes)
            {
                this.autoScalingNotificationTypes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AutoScalingNotificationTypes collection
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(IEnumerable<string> autoScalingNotificationTypes)
        {
            foreach (string element in autoScalingNotificationTypes)
            {
                this.autoScalingNotificationTypes.Add(element);
            }

            return this;
        }

        // Check to see if AutoScalingNotificationTypes property is set
        internal bool IsSetAutoScalingNotificationTypes()
        {
            return this.autoScalingNotificationTypes.Count > 0;       
        }
    }
}
