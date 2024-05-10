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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The function request body.
    /// </summary>
    public partial class FunctionRequest
    {
        private DataConnector _implementedBy;
        private List<string> _requiredProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property ImplementedBy. 
        /// <para>
        /// The data connector.
        /// </para>
        /// </summary>
        public DataConnector ImplementedBy
        {
            get { return this._implementedBy; }
            set { this._implementedBy = value; }
        }

        // Check to see if ImplementedBy property is set
        internal bool IsSetImplementedBy()
        {
            return this._implementedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredProperties. 
        /// <para>
        /// The required properties of the function.
        /// </para>
        /// </summary>
        public List<string> RequiredProperties
        {
            get { return this._requiredProperties; }
            set { this._requiredProperties = value; }
        }

        // Check to see if RequiredProperties property is set
        internal bool IsSetRequiredProperties()
        {
            return this._requiredProperties != null && (this._requiredProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the function.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}