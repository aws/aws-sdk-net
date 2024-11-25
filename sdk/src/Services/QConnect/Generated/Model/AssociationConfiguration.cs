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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private AssociationConfigurationData _associationConfigurationData;
        private string _associationId;
        private AIAgentAssociationConfigurationType _associationType;

        /// <summary>
        /// Gets and sets the property AssociationConfigurationData. 
        /// <para>
        /// The data of the configuration for an Amazon Q in Connect Assistant Association.
        /// </para>
        /// </summary>
        public AssociationConfigurationData AssociationConfigurationData
        {
            get { return this._associationConfigurationData; }
            set { this._associationConfigurationData = value; }
        }

        // Check to see if AssociationConfigurationData property is set
        internal bool IsSetAssociationConfigurationData()
        {
            return this._associationConfigurationData != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The identifier of the association for this Association Configuration.
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
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of the association for this Association Configuration.
        /// </para>
        /// </summary>
        public AIAgentAssociationConfigurationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

    }
}