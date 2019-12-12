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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// For each application, you define one or more environments. An environment is a logical
    /// deployment group of AppConfig targets, such as applications in a <code>Beta</code>
    /// or <code>Production</code> environment. You can also define environments for application
    /// subcomponents such as the <code>Web</code>, <code>Mobile</code> and <code>Back-end</code>
    /// components for your application. You can configure Amazon CloudWatch alarms for each
    /// environment. The system monitors alarms during a configuration deployment. If an alarm
    /// is triggered, the system rolls back the configuration.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private string _description;
        private List<Monitor> _monitors = new List<Monitor>();
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Monitors. 
        /// <para>
        /// Amazon CloudWatch alarms to monitor during the deployment process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Monitor> Monitors
        {
            get { return this._monitors; }
            set { this._monitors = value; }
        }

        // Check to see if Monitors property is set
        internal bool IsSetMonitors()
        {
            return this._monitors != null && this._monitors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata to assign to the environment. Tags help organize and categorize your AppConfig
        /// resources. Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}