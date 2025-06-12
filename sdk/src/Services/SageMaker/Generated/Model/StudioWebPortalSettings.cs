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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Studio settings. If these settings are applied on a user level, they take priority
    /// over the settings applied on a domain level.
    /// </summary>
    public partial class StudioWebPortalSettings
    {
        private List<string> _hiddenAppTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _hiddenInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _hiddenMlTools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<HiddenSageMakerImage> _hiddenSageMakerImageVersionAliases = AWSConfigs.InitializeCollections ? new List<HiddenSageMakerImage>() : null;

        /// <summary>
        /// Gets and sets the property HiddenAppTypes. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-updated-apps.html">Applications
        /// supported in Studio</a> that are hidden from the Studio left navigation pane.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenAppTypes
        {
            get { return this._hiddenAppTypes; }
            set { this._hiddenAppTypes = value; }
        }

        // Check to see if HiddenAppTypes property is set
        internal bool IsSetHiddenAppTypes()
        {
            return this._hiddenAppTypes != null && (this._hiddenAppTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HiddenInstanceTypes. 
        /// <para>
        ///  The instance types you are hiding from the Studio user interface. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenInstanceTypes
        {
            get { return this._hiddenInstanceTypes; }
            set { this._hiddenInstanceTypes = value; }
        }

        // Check to see if HiddenInstanceTypes property is set
        internal bool IsSetHiddenInstanceTypes()
        {
            return this._hiddenInstanceTypes != null && (this._hiddenInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HiddenMlTools. 
        /// <para>
        /// The machine learning tools that are hidden from the Studio left navigation pane.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HiddenMlTools
        {
            get { return this._hiddenMlTools; }
            set { this._hiddenMlTools = value; }
        }

        // Check to see if HiddenMlTools property is set
        internal bool IsSetHiddenMlTools()
        {
            return this._hiddenMlTools != null && (this._hiddenMlTools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HiddenSageMakerImageVersionAliases. 
        /// <para>
        ///  The version aliases you are hiding from the Studio user interface. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<HiddenSageMakerImage> HiddenSageMakerImageVersionAliases
        {
            get { return this._hiddenSageMakerImageVersionAliases; }
            set { this._hiddenSageMakerImageVersionAliases = value; }
        }

        // Check to see if HiddenSageMakerImageVersionAliases property is set
        internal bool IsSetHiddenSageMakerImageVersionAliases()
        {
            return this._hiddenSageMakerImageVersionAliases != null && (this._hiddenSageMakerImageVersionAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}