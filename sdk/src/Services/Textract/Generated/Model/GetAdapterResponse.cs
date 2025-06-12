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
    /// This is the response object from the GetAdapter operation.
    /// </summary>
    public partial class GetAdapterResponse : AmazonWebServiceResponse
    {
        private string _adapterId;
        private string _adapterName;
        private AutoUpdate _autoUpdate;
        private DateTime? _creationTime;
        private string _description;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string identifying the adapter that information has been retrieved for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1011)]
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
        /// The name of the requested adapter.
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
        /// Binary value indicating if the adapter is being automatically updated or not.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the requested adapter was created at.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the requested adapter.
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

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// List of the targeted feature types for the requested adapter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && (this._featureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags (key-value pairs) associated with the adapter that has been retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}