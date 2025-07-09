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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
        private string _accountAssociationId;
        private string _arn;
        private AssociationState _associationState;
        private string _connectorDestinationId;
        private string _description;
        private string _errorMessage;
        private string _name;

        /// <summary>
        /// Gets and sets the property AccountAssociationId. 
        /// <para>
        /// The unique identifier of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AccountAssociationId
        {
            get { return this._accountAssociationId; }
            set { this._accountAssociationId = value; }
        }

        // Check to see if AccountAssociationId property is set
        internal bool IsSetAccountAssociationId()
        {
            return this._accountAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=67, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The current state of the account association, indicating its status in the association
        /// lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationState AssociationState
        {
            get { return this._associationState; }
            set { this._associationState = value; }
        }

        // Check to see if AssociationState property is set
        internal bool IsSetAssociationState()
        {
            return this._associationState != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDestinationId. 
        /// <para>
        /// The identifier of the connector destination associated with this account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConnectorDestinationId
        {
            get { return this._connectorDestinationId; }
            set { this._connectorDestinationId = value; }
        }

        // Check to see if ConnectorDestinationId property is set
        internal bool IsSetConnectorDestinationId()
        {
            return this._connectorDestinationId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message explaining any issues with the account association, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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