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
    /// Container for the parameters to the UpdateService operation.
    /// Edit a service description or use a spec to add and delete service instances.
    /// 
    ///  <note> 
    /// <para>
    /// Existing service instances and the service pipeline <i>can't</i> be edited using this
    /// API. They can only be deleted.
    /// </para>
    ///  </note> 
    /// <para>
    /// Use the <code>description</code> parameter to modify the description.
    /// </para>
    ///  
    /// <para>
    /// Edit the <code>spec</code> parameter to add or delete instances.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't delete a service instance (remove it from the spec) if it has an attached
    /// component.
    /// </para>
    ///  
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateServiceRequest : AmazonProtonRequest
    {
        private string _description;
        private string _name;
        private string _spec;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The edited service description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service to edit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Spec. 
        /// <para>
        /// Lists the service instances to add and the existing service instances to remain. Omit
        /// the existing service instances to delete from the list. <i>Don't</i> include edits
        /// to the existing service instances or pipeline. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-svc-update.html">Edit
        /// a service</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

    }
}