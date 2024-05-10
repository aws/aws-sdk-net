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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The provider configuration required for different ID namespace types.
    /// </summary>
    public partial class ProviderIdNameSpaceConfiguration
    {
        private string _description;
        private Amazon.Runtime.Documents.Document _providerSourceConfigurationDefinition;
        private Amazon.Runtime.Documents.Document _providerTargetConfigurationDefinition;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ID namespace.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProviderSourceConfigurationDefinition. 
        /// <para>
        /// Configurations required for the source ID namespace.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderSourceConfigurationDefinition
        {
            get { return this._providerSourceConfigurationDefinition; }
            set { this._providerSourceConfigurationDefinition = value; }
        }

        // Check to see if ProviderSourceConfigurationDefinition property is set
        internal bool IsSetProviderSourceConfigurationDefinition()
        {
            return !this._providerSourceConfigurationDefinition.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ProviderTargetConfigurationDefinition. 
        /// <para>
        /// Configurations required for the target ID namespace.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderTargetConfigurationDefinition
        {
            get { return this._providerTargetConfigurationDefinition; }
            set { this._providerTargetConfigurationDefinition = value; }
        }

        // Check to see if ProviderTargetConfigurationDefinition property is set
        internal bool IsSetProviderTargetConfigurationDefinition()
        {
            return !this._providerTargetConfigurationDefinition.IsNull();
        }

    }
}