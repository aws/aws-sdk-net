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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary counts of each Proton resource type.
    /// </summary>
    public partial class CountsSummary
    {
        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// The total number of components in the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// The semantics of the <c>components</c> field are different from the semantics of results
        /// for other infrastructure-provisioning resources. That's because at this time components
        /// don't have associated templates, therefore they don't have the concept of staleness.
        /// The <c>components</c> object will only contain <c>total</c> and <c>failed</c> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Components { get; set; }

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null;

        /// <summary>
        /// Gets and sets the property EnvironmentTemplates. 
        /// <para>
        /// The total number of environment templates in the Amazon Web Services account. The
        /// <c>environmentTemplates</c> object will only contain <c>total</c> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary EnvironmentTemplates { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentTemplates property is set.
        /// </summary>
        internal bool IsSetEnvironmentTemplates() => this.EnvironmentTemplates != null;

        /// <summary>
        /// Gets and sets the property Environments. 
        /// <para>
        /// The staleness counts for Proton environments in the Amazon Web Services account. The
        /// <c>environments</c> object will only contain <c>total</c> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Environments { get; set; }

        /// <summary>
        /// Checks to see if the Environments property is set.
        /// </summary>
        internal bool IsSetEnvironments() => this.Environments != null;

        /// <summary>
        /// Gets and sets the property Pipelines. 
        /// <para>
        /// The staleness counts for Proton pipelines in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Pipelines { get; set; }

        /// <summary>
        /// Checks to see if the Pipelines property is set.
        /// </summary>
        internal bool IsSetPipelines() => this.Pipelines != null;

        /// <summary>
        /// Gets and sets the property ServiceInstances. 
        /// <para>
        /// The staleness counts for Proton service instances in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary ServiceInstances { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstances property is set.
        /// </summary>
        internal bool IsSetServiceInstances() => this.ServiceInstances != null;

        /// <summary>
        /// Gets and sets the property ServiceTemplates. 
        /// <para>
        /// The total number of service templates in the Amazon Web Services account. The <c>serviceTemplates</c>
        /// object will only contain <c>total</c> members.
        /// </para>
        /// </summary>
        public ResourceCountsSummary ServiceTemplates { get; set; }

        /// <summary>
        /// Checks to see if the ServiceTemplates property is set.
        /// </summary>
        internal bool IsSetServiceTemplates() => this.ServiceTemplates != null;

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The staleness counts for Proton services in the Amazon Web Services account.
        /// </para>
        /// </summary>
        public ResourceCountsSummary Services { get; set; }

        /// <summary>
        /// Checks to see if the Services property is set.
        /// </summary>
        internal bool IsSetServices() => this.Services != null;
    }
}
