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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure containing information about an account association, including its identifier,
    /// state, and related metadata.
    /// </summary>
    public partial class AccountAssociationItem
    {
        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The unique identifier of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AccountAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AccountAssociationId property is set.
        /// </summary>
        internal bool IsSetAccountAssociationId() => this.AccountAssociationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 67, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The current state of the account association, indicating its status in the association
        /// lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationState AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property ConnectorDestinationId. 
        /// <para>
        /// The identifier of the connector destination associated with this account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConnectorDestinationId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDestinationId property is set.
        /// </summary>
        internal bool IsSetConnectorDestinationId() => this.ConnectorDestinationId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message explaining any issues with the account association, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
