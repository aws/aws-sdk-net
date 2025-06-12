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
    /// The SageMaker images that are hidden from the Studio user interface. You must specify
    /// the SageMaker image name and version aliases.
    /// </summary>
    public partial class HiddenSageMakerImage
    {
        private SageMakerImageName _sageMakerImageName;
        private List<string> _versionAliases = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SageMakerImageName. 
        /// <para>
        ///  The SageMaker image name that you are hiding from the Studio user interface. 
        /// </para>
        /// </summary>
        public SageMakerImageName SageMakerImageName
        {
            get { return this._sageMakerImageName; }
            set { this._sageMakerImageName = value; }
        }

        // Check to see if SageMakerImageName property is set
        internal bool IsSetSageMakerImageName()
        {
            return this._sageMakerImageName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionAliases. 
        /// <para>
        ///  The version aliases you are hiding from the Studio user interface. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> VersionAliases
        {
            get { return this._versionAliases; }
            set { this._versionAliases = value; }
        }

        // Check to see if VersionAliases property is set
        internal bool IsSetVersionAliases()
        {
            return this._versionAliases != null && (this._versionAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}