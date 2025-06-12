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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSequenceStore operation.
    /// Update one or more parameters for the sequence store.
    /// </summary>
    public partial class UpdateSequenceStoreRequest : AmazonOmicsRequest
    {
        private string _clientToken;
        private string _description;
        private string _fallbackLocation;
        private string _id;
        private string _name;
        private List<string> _propagatedSetLevelTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3AccessConfig _s3AccessConfig;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique token for each
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property FallbackLocation. 
        /// <para>
        /// The S3 URI of a bucket and folder to store Read Sets that fail to upload.
        /// </para>
        /// </summary>
        public string FallbackLocation
        {
            get { return this._fallbackLocation; }
            set { this._fallbackLocation = value; }
        }

        // Check to see if FallbackLocation property is set
        internal bool IsSetFallbackLocation()
        {
            return this._fallbackLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the sequence store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property PropagatedSetLevelTags. 
        /// <para>
        /// The tags keys to propagate to the S3 objects associated with read sets in the sequence
        /// store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> PropagatedSetLevelTags
        {
            get { return this._propagatedSetLevelTags; }
            set { this._propagatedSetLevelTags = value; }
        }

        // Check to see if PropagatedSetLevelTags property is set
        internal bool IsSetPropagatedSetLevelTags()
        {
            return this._propagatedSetLevelTags != null && (this._propagatedSetLevelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3AccessConfig. 
        /// <para>
        /// S3 access configuration parameters.
        /// </para>
        /// </summary>
        public S3AccessConfig S3AccessConfig
        {
            get { return this._s3AccessConfig; }
            set { this._s3AccessConfig = value; }
        }

        // Check to see if S3AccessConfig property is set
        internal bool IsSetS3AccessConfig()
        {
            return this._s3AccessConfig != null;
        }

    }
}