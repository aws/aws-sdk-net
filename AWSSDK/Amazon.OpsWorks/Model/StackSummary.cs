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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Summarizes the number of layers, instances, and apps in a stack.
    /// </summary>
    public partial class StackSummary
    {
        private int? _appsCount;
        private string _arn;
        private InstancesCount _instancesCount;
        private int? _layersCount;
        private string _name;
        private string _stackId;


        /// <summary>
        /// Gets and sets the property AppsCount. 
        /// <para>
        /// The number of apps.
        /// </para>
        /// </summary>
        public int AppsCount
        {
            get { return this._appsCount.GetValueOrDefault(); }
            set { this._appsCount = value; }
        }


        /// <summary>
        /// Sets the AppsCount property
        /// </summary>
        /// <param name="appsCount">The value to set for the AppsCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithAppsCount(int appsCount)
        {
            this._appsCount = appsCount;
            return this;
        }

        // Check to see if AppsCount property is set
        internal bool IsSetAppsCount()
        {
            return this._appsCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The stack's ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property InstancesCount. 
        /// <para>
        /// An <code>InstancesCount</code> object with the number of instances in each status.
        /// </para>
        /// </summary>
        public InstancesCount InstancesCount
        {
            get { return this._instancesCount; }
            set { this._instancesCount = value; }
        }


        /// <summary>
        /// Sets the InstancesCount property
        /// </summary>
        /// <param name="instancesCount">The value to set for the InstancesCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithInstancesCount(InstancesCount instancesCount)
        {
            this._instancesCount = instancesCount;
            return this;
        }

        // Check to see if InstancesCount property is set
        internal bool IsSetInstancesCount()
        {
            return this._instancesCount != null;
        }


        /// <summary>
        /// Gets and sets the property LayersCount. 
        /// <para>
        /// The number of layers.
        /// </para>
        /// </summary>
        public int LayersCount
        {
            get { return this._layersCount.GetValueOrDefault(); }
            set { this._layersCount = value; }
        }


        /// <summary>
        /// Sets the LayersCount property
        /// </summary>
        /// <param name="layersCount">The value to set for the LayersCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithLayersCount(int layersCount)
        {
            this._layersCount = layersCount;
            return this;
        }

        // Check to see if LayersCount property is set
        internal bool IsSetLayersCount()
        {
            return this._layersCount.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The stack name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StackSummary WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}