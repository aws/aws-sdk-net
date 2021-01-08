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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetLayerVersionByArn operation.
    /// </summary>
    public partial class GetLayerVersionByArnResponse : AmazonWebServiceResponse
    {
        private List<string> _compatibleRuntimes = new List<string>();
        private LayerVersionContentOutput _content;
        private string _createdDate;
        private string _description;
        private string _layerArn;
        private string _layerVersionArn;
        private string _licenseInfo;
        private long? _version;

        /// <summary>
        /// Gets and sets the property CompatibleRuntimes. 
        /// <para>
        /// The layer's compatible runtimes.
        /// </para>
        /// </summary>
        [AWSProperty(Max=15)]
        public List<string> CompatibleRuntimes
        {
            get { return this._compatibleRuntimes; }
            set { this._compatibleRuntimes = value; }
        }

        // Check to see if CompatibleRuntimes property is set
        internal bool IsSetCompatibleRuntimes()
        {
            return this._compatibleRuntimes != null && this._compatibleRuntimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Details about the layer version.
        /// </para>
        /// </summary>
        public LayerVersionContentOutput Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the layer version was created, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property LayerArn. 
        /// <para>
        /// The ARN of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string LayerArn
        {
            get { return this._layerArn; }
            set { this._layerArn = value; }
        }

        // Check to see if LayerArn property is set
        internal bool IsSetLayerArn()
        {
            return this._layerArn != null;
        }

        /// <summary>
        /// Gets and sets the property LayerVersionArn. 
        /// <para>
        /// The ARN of the layer version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string LayerVersionArn
        {
            get { return this._layerVersionArn; }
            set { this._layerVersionArn = value; }
        }

        // Check to see if LayerVersionArn property is set
        internal bool IsSetLayerVersionArn()
        {
            return this._layerVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseInfo. 
        /// <para>
        /// The layer's software license.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string LicenseInfo
        {
            get { return this._licenseInfo; }
            set { this._licenseInfo = value; }
        }

        // Check to see if LicenseInfo property is set
        internal bool IsSetLicenseInfo()
        {
            return this._licenseInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}