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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssociationStatus operation. Updates the
    /// status of the Amazon Web Services Systems Manager document (SSM document) associated
    /// with the specified managed node. <para> <c>UpdateAssociationStatus</c> is primarily
    /// used by the Amazon Web Services Systems Manager Agent (SSM Agent) to report status
    /// updates about your associations and is only used for associations created with the
    /// <c>InstanceId</c> legacy parameter. </para>
    /// </summary>
    public partial class UpdateAssociationStatusRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateAssociationStatusRequest() { }

        /// <summary>
        /// Instantiates UpdateAssociationStatusRequest with the parameterized properties
        /// </summary>
        /// <param name="associationStatus">The association status.</param>
        /// <param name="instanceId">The managed node ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        public UpdateAssociationStatusRequest(AssociationStatus associationStatus, string instanceId, string name)
        {
            this.AssociationStatus = associationStatus;
            this.InstanceId = instanceId;
            this.Name = name;
        }

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The association status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
