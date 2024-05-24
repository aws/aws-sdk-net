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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAdapter operation.
    /// Update the configuration for an adapter. FeatureTypes configurations cannot be updated.
    /// At least one new parameter must be specified as an argument.
    /// </summary>
    public partial class UpdateAdapterRequest : AmazonTextractRequest
    {
        private string _adapterId;
        private string _adapterName;
        private AutoUpdate _autoUpdate;
        private string _description;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter that will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1011)]
        public string AdapterId
        {
            get { return this._adapterId; }
            set { this._adapterId = value; }
        }

        // Check to see if AdapterId property is set
        internal bool IsSetAdapterId()
        {
            return this._adapterId != null;
        }

        /// <summary>
        /// Gets and sets the property AdapterName. 
        /// <para>
        /// The new name to be applied to the adapter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AdapterName
        {
            get { return this._adapterName; }
            set { this._adapterName = value; }
        }

        // Check to see if AdapterName property is set
        internal bool IsSetAdapterName()
        {
            return this._adapterName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// The new auto-update status to be applied to the adapter.
        /// </para>
        /// </summary>
        public AutoUpdate AutoUpdate
        {
            get { return this._autoUpdate; }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description to be applied to the adapter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

    }
}