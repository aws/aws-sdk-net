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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Summarizes the number of layers, instances, and apps in a stack.</para>
    /// </summary>
    public partial class StackSummary
    {
        
        private string stackId;
        private string name;
        private string arn;
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

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithStackId(string stackId)
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
        /// The stack name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The stack's ARN.
        ///  
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
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

        /// <summary>
        /// Sets the LayersCount property
        /// </summary>
        /// <param name="layersCount">The value to set for the LayersCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithLayersCount(int layersCount)
        {
            this.layersCount = layersCount;
            return this;
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

        /// <summary>
        /// Sets the AppsCount property
        /// </summary>
        /// <param name="appsCount">The value to set for the AppsCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithAppsCount(int appsCount)
        {
            this.appsCount = appsCount;
            return this;
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

        /// <summary>
        /// Sets the InstancesCount property
        /// </summary>
        /// <param name="instancesCount">The value to set for the InstancesCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithInstancesCount(InstancesCount instancesCount)
        {
            this.instancesCount = instancesCount;
            return this;
        }
            

        // Check to see if InstancesCount property is set
        internal bool IsSetInstancesCount()
        {
            return this.instancesCount != null;
        }
    }
}
