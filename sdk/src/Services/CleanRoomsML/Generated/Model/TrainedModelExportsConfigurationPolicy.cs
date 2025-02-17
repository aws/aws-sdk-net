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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Information about how the trained model exports are configured.
    /// </summary>
    public partial class TrainedModelExportsConfigurationPolicy
    {
        private List<string> _filesToExport = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TrainedModelExportsMaxSize _maxSize;

        /// <summary>
        /// Gets and sets the property FilesToExport. 
        /// <para>
        /// The files that are exported during the trained model export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> FilesToExport
        {
            get { return this._filesToExport; }
            set { this._filesToExport = value; }
        }

        // Check to see if FilesToExport property is set
        internal bool IsSetFilesToExport()
        {
            return this._filesToExport != null && (this._filesToExport.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the data that can be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainedModelExportsMaxSize MaxSize
        {
            get { return this._maxSize; }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize != null;
        }

    }
}