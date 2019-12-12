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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Describes a standalone resource or similarly grouped resources that the application
    /// is made up of.
    /// </summary>
    public partial class ApplicationComponent
    {
        private string _componentName;
        private bool? _monitor;
        private string _resourceType;
        private Tier _tier;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property Monitor. 
        /// <para>
        /// Indicates whether the application component is monitored. 
        /// </para>
        /// </summary>
        public bool Monitor
        {
            get { return this._monitor.GetValueOrDefault(); }
            set { this._monitor = value; }
        }

        // Check to see if Monitor property is set
        internal bool IsSetMonitor()
        {
            return this._monitor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. Supported resource types include EC2 instances, Auto Scaling group,
        /// Classic ELB, Application ELB, and SQS Queue.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The stack tier of the application component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Tier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}