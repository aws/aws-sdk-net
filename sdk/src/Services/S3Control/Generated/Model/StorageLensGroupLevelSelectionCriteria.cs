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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Indicates which Storage Lens group ARNs to include or exclude in the Storage Lens
    /// group aggregation. You can only attach Storage Lens groups to your Storage Lens dashboard
    /// if they're included in your Storage Lens group aggregation. If this value is left
    /// null, then all Storage Lens groups are selected.
    /// </summary>
    public partial class StorageLensGroupLevelSelectionCriteria
    {
        private List<string> _exclude = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        ///  Indicates which Storage Lens group ARNs to exclude from the Storage Lens group aggregation.
        /// 
        /// </para>
        /// </summary>
        public List<string> Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null && (this._exclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        ///  Indicates which Storage Lens group ARNs to include in the Storage Lens group aggregation.
        /// 
        /// </para>
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}