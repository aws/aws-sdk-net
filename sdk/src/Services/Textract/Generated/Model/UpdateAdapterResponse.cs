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
    /// This is the response object from the UpdateAdapter operation.
    /// </summary>
    public partial class UpdateAdapterResponse : AmazonWebServiceResponse
    {
        private string _adapterId;
        private string _adapterName;
        private AutoUpdate _autoUpdate;
        private DateTime? _creationTime;
        private string _description;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdapterId. 
        /// <para>
        /// A string containing a unique ID for the adapter that has been updated.
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
        /// A string containing the name of the adapter that has been updated.
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
        /// The auto-update status of the adapter that has been updated.
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
        /// An object specifying the creation time of the the adapter that has been updated.
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
        /// A string containing the description of the adapter that has been updated.
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
        /// List of the targeted feature types for the updated adapter.
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

    }
}