/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSet operation.
    /// This operation creates a data set.
    /// </summary>
    public partial class CreateDataSetRequest : AmazonDataExchangeRequest
    {
        private AssetType _assetType;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of file your data is stored in. Currently, the supported asset type is S3_SNAPSHOT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetType AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the data set. This value can be up to 16,348 characters long.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A data set tag is an optional label that you can assign to a data set when you create
        /// it. Each tag consists of a key and an optional value, both of which you define. When
        /// you use tagging, you can also use tag-based access control in IAM policies to control
        /// access to these data sets and revisions.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}