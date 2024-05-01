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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAssociation operation.
    /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
    /// from the specified managed node. If you created the association by using the <c>Targets</c>
    /// parameter, then you must delete the association by using the association ID.
    /// 
    ///  
    /// <para>
    /// When you disassociate a document from a managed node, it doesn't change the configuration
    /// of the node. To change the configuration state of a managed node after you disassociate
    /// a document, you must create a new document with the desired configuration and associate
    /// it with the node.
    /// </para>
    /// </summary>
    public partial class DeleteAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _associationId;
        private string _instanceId;
        private string _name;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteAssociationRequest() { }

        /// <summary>
        /// Instantiates DeleteAssociationRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association, use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>, <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you must use the <c>Targets</c> parameter. </note></param>
        /// <param name="name">The name of the SSM document.</param>
        public DeleteAssociationRequest(string instanceId, string name)
        {
            _instanceId = instanceId;
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID that you want to delete.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association,
        /// use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c>
        /// with Systems Manager documents (SSM documents) that use schema version 2.0 or later
        /// will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use
        /// the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>,
        /// <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you
        /// must use the <c>Targets</c> parameter.
        /// </para>
        ///  </note>
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

    }
}