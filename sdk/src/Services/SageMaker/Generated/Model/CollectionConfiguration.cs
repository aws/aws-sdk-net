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
    /// Configuration information for the Amazon SageMaker Debugger output tensor collections.
    /// </summary>
    public partial class CollectionConfiguration
    {
        private string _collectionName;
        private Dictionary<string, string> _collectionParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The name of the tensor collection. The name must be unique relative to other rule
        /// configuration names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CollectionName
        {
            get { return this._collectionName; }
            set { this._collectionName = value; }
        }

        // Check to see if CollectionName property is set
        internal bool IsSetCollectionName()
        {
            return this._collectionName != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionParameters. 
        /// <para>
        /// Parameter values for the tensor collection. The allowed parameters are <c>"name"</c>,
        /// <c>"include_regex"</c>, <c>"reduction_config"</c>, <c>"save_config"</c>, <c>"tensor_names"</c>,
        /// and <c>"save_histogram"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> CollectionParameters
        {
            get { return this._collectionParameters; }
            set { this._collectionParameters = value; }
        }

        // Check to see if CollectionParameters property is set
        internal bool IsSetCollectionParameters()
        {
            return this._collectionParameters != null && (this._collectionParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}