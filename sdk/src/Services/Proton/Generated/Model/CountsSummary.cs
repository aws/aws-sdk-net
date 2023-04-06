/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary counts of each Proton resource type.
    /// </summary>
    public partial class CountsSummary
    {
        private ResourceCountsSummary _components;
        private ResourceCountsSummary _environments;
        private ResourceCountsSummary _environmentTemplates;
        private ResourceCountsSummary _pipelines;
        private ResourceCountsSummary _serviceInstances;
        private ResourceCountsSummary _services;
        private ResourceCountsSummary _serviceTemplates;

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The total number of components in the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// The semantics of the <code>components</code> field are different from the semantics
        /// of results for other infrastructure-provisioning resources. That's because at this
        /// time components don't have associated templates, therefore they don't have the concept
        /// of staleness. The <code>components</code> object will only contain <code>total</code>
        /// and <code>failed</code> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null;
        }

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        /// The staleness counts for Proton environments in the Amazon Web Services account. The
        /// <code>environments</code> object will only contain <code>total</code> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Environments
        {
            get { return this._environments; }
            set { this._environments = value; }
        }

        // Check to see if Environments property is set
        internal bool IsSetEnvironments()
        {
            return this._environments != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentTemplates. 
        /// <para>
        /// The total number of environment templates in the Amazon Web Services account. The
        /// <code>environmentTemplates</code> object will only contain <code>total</code> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary EnvironmentTemplates
        {
            get { return this._environmentTemplates; }
            set { this._environmentTemplates = value; }
        }

        // Check to see if EnvironmentTemplates property is set
        internal bool IsSetEnvironmentTemplates()
        {
            return this._environmentTemplates != null;
        }

        /// <summary>
        /// Gets and sets the property Pipelines. 
        /// <para>
        /// The staleness counts for Proton pipelines in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Pipelines
        {
            get { return this._pipelines; }
            set { this._pipelines = value; }
        }

        // Check to see if Pipelines property is set
        internal bool IsSetPipelines()
        {
            return this._pipelines != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInstances. 
        /// <para>
        /// The staleness counts for Proton service instances in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary ServiceInstances
        {
            get { return this._serviceInstances; }
            set { this._serviceInstances = value; }
        }

        // Check to see if ServiceInstances property is set
        internal bool IsSetServiceInstances()
        {
            return this._serviceInstances != null;
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The staleness counts for Proton services in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceTemplates. 
        /// <para>
        /// The total number of service templates in the Amazon Web Services account. The <code>serviceTemplates</code>
        /// object will only contain <code>total</code> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary ServiceTemplates
        {
            get { return this._serviceTemplates; }
            set { this._serviceTemplates = value; }
        }

        // Check to see if ServiceTemplates property is set
        internal bool IsSetServiceTemplates()
        {
            return this._serviceTemplates != null;
        }

    }
}