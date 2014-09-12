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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}