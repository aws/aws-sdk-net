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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is the response object from the GetRasterDataCollection operation.
    /// </summary>
    public partial class GetRasterDataCollectionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private string _descriptionPageUrl;
        private List<string> _imageSourceBands = new List<string>();
        private string _name;
        private List<Filter> _supportedFilters = new List<Filter>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DataCollectionType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the raster data collection.
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
        /// Gets and sets the property DescriptionPageUrl. 
        /// <para>
        /// The URL of the description page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DescriptionPageUrl
        {
            get { return this._descriptionPageUrl; }
            set { this._descriptionPageUrl = value; }
        }

        // Check to see if DescriptionPageUrl property is set
        internal bool IsSetDescriptionPageUrl()
        {
            return this._descriptionPageUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSourceBands.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ImageSourceBands
        {
            get { return this._imageSourceBands; }
            set { this._imageSourceBands = value; }
        }

        // Check to see if ImageSourceBands property is set
        internal bool IsSetImageSourceBands()
        {
            return this._imageSourceBands != null && this._imageSourceBands.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the raster data collection.
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
        /// Gets and sets the property SupportedFilters. 
        /// <para>
        /// The filters supported by the raster data collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Filter> SupportedFilters
        {
            get { return this._supportedFilters; }
            set { this._supportedFilters = value; }
        }

        // Check to see if SupportedFilters property is set
        internal bool IsSetSupportedFilters()
        {
            return this._supportedFilters != null && this._supportedFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and a value.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The raster data collection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataCollectionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}