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
    /// Container for the parameters to the DescribeAssociation operation. Describes the association
    /// for the specified target or managed node. If you created the association by using
    /// the <c>Targets</c> parameter, then you must retrieve the association by using the
    /// association ID.
    /// </summary>
    public partial class DescribeAssociationRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeAssociationRequest() { }

        /// <summary>
        /// Instantiates DescribeAssociationRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The managed node ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        public DescribeAssociationRequest(string instanceId, string name)
        {
            this.InstanceId = instanceId;
            this.Name = name;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for which you want information.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AssociationVersion. 
        /// <para>
        /// Specify the association version to retrieve. To view the latest version, either specify
        /// <c>$LATEST</c> for this parameter, or omit this parameter. To view a list of all associations
        /// for a managed node, use <a>ListAssociations</a>. To get a list of versions for a specific
        /// association, use <a>ListAssociationVersions</a>. 
        /// </para>
        /// </summary>
        public string AssociationVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssociationVersion property is set.
        /// </summary>
        internal bool IsSetAssociationVersion() => this.AssociationVersion != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The managed node ID.
        /// </para>
        /// </summary>
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
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
