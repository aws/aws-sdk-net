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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Resource configuration for an input source. Provide exactly one field.
    /// </summary>
    public partial class ResourceConfiguration
    {
        private string _cfnStackArn;
        private string _designFileS3Url;
        private EksSource _eks;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;
        private string _tfStateFileUrl;

        /// <summary>
        /// Gets and sets the property CfnStackArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string CfnStackArn
        {
            get { return this._cfnStackArn; }
            set { this._cfnStackArn = value; }
        }

        // Check to see if CfnStackArn property is set
        internal bool IsSetCfnStackArn()
        {
            return this._cfnStackArn != null;
        }

        /// <summary>
        /// Gets and sets the property DesignFileS3Url.
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string DesignFileS3Url
        {
            get { return this._designFileS3Url; }
            set { this._designFileS3Url = value; }
        }

        // Check to see if DesignFileS3Url property is set
        internal bool IsSetDesignFileS3Url()
        {
            return this._designFileS3Url != null;
        }

        /// <summary>
        /// Gets and sets the property Eks. 
        /// <para>
        /// The Amazon EKS configuration for resource discovery.
        /// </para>
        /// </summary>
        public EksSource Eks
        {
            get { return this._eks; }
            set { this._eks = value; }
        }

        // Check to see if Eks property is set
        internal bool IsSetEks()
        {
            return this._eks != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The resource tags for tag-based resource discovery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TfStateFileUrl.
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TfStateFileUrl
        {
            get { return this._tfStateFileUrl; }
            set { this._tfStateFileUrl = value; }
        }

        // Check to see if TfStateFileUrl property is set
        internal bool IsSetTfStateFileUrl()
        {
            return this._tfStateFileUrl != null;
        }

    }
}