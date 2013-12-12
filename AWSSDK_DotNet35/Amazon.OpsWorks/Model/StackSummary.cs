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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Summarizes the number of layers, instances, and apps in a stack.</para>
    /// </summary>
    public class StackSummary
    {
        
        private string stackId;
        private string name;
        private int? layersCount;
        private int? appsCount;
        private InstancesCount instancesCount;


        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The stack name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The number of layers.
        ///  
        /// </summary>
        public int LayersCount
        {
            get { return this.layersCount ?? default(int); }
            set { this.layersCount = value; }
        }

        // Check to see if LayersCount property is set
        internal bool IsSetLayersCount()
        {
            return this.layersCount.HasValue;
        }

        /// <summary>
        /// The number of apps.
        ///  
        /// </summary>
        public int AppsCount
        {
            get { return this.appsCount ?? default(int); }
            set { this.appsCount = value; }
        }

        // Check to see if AppsCount property is set
        internal bool IsSetAppsCount()
        {
            return this.appsCount.HasValue;
        }

        /// <summary>
        /// An <c>InstancesCount</c> object with the number of instances in each status.
        ///  
        /// </summary>
        public InstancesCount InstancesCount
        {
            get { return this.instancesCount; }
            set { this.instancesCount = value; }
        }

        // Check to see if InstancesCount property is set
        internal bool IsSetInstancesCount()
        {
            return this.instancesCount != null;
        }
    }
}
