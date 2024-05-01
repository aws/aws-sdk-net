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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An optional structure that configures resource ID overrides for the export job.
    /// </summary>
    public partial class AssetBundleExportJobResourceIdOverrideConfiguration
    {
        private bool? _prefixForAllResources;

        /// <summary>
        /// Gets and sets the property PrefixForAllResources. 
        /// <para>
        /// An option to request a CloudFormation variable for a prefix to be prepended to each
        /// resource's ID before import. The prefix is only added to the asset IDs and does not
        /// change the name of the asset.
        /// </para>
        /// </summary>
        public bool? PrefixForAllResources
        {
            get { return this._prefixForAllResources; }
            set { this._prefixForAllResources = value; }
        }

        // Check to see if PrefixForAllResources property is set
        internal bool IsSetPrefixForAllResources()
        {
            return this._prefixForAllResources.HasValue; 
        }

    }
}