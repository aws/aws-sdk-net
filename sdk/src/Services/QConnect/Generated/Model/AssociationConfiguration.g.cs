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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for an Amazon Q in Connect Assistant Association.
    /// </summary>
    public partial class AssociationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AssociationConfigurationData. 
        /// <para>
        /// The data of the configuration for an Amazon Q in Connect Assistant Association.
        /// </para>
        /// </summary>
        public AssociationConfigurationData AssociationConfigurationData { get; set; }

        /// <summary>
        /// Checks to see if the AssociationConfigurationData property is set.
        /// </summary>
        internal bool IsSetAssociationConfigurationData() => this.AssociationConfigurationData != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The identifier of the association for this Association Configuration.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of the association for this Association Configuration.
        /// </para>
        /// </summary>
        public AIAgentAssociationConfigurationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;
    }
}
