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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssociation operation.
    /// Associates the specified SSM document with the specified instance.
    /// 
    ///  
    /// <para>
    /// When you associate an SSM document with an instance, the configuration agent on the
    /// instance processes the document and configures the instance as specified.
    /// </para>
    ///  
    /// <para>
    /// If you associate a document with an instance that already has an associated document,
    /// the system throws the AssociationAlreadyExists exception.
    /// </para>
    /// </summary>
    public partial class CreateAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _instanceId;
        private string _name;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAssociationRequest() { }

        /// <summary>
        /// Instantiates CreateAssociationRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The Windows Server instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        public CreateAssociationRequest(string instanceId, string name)
        {
            _instanceId = instanceId;
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Windows Server instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
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
        /// Gets and sets the property Parameters. The parameters for the documents runtime configuration.
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}