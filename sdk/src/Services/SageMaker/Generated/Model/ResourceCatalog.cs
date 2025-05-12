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
    /// A resource catalog containing all of the resources of a specific resource type within
    /// a resource owner account. For an example on sharing the Amazon SageMaker Feature Store
    /// <c>DefaultFeatureGroupCatalog</c>, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/feature-store-cross-account-discoverability-share-sagemaker-catalog.html">Share
    /// Amazon SageMaker Catalog resource type</a> in the Amazon SageMaker Developer Guide.
    /// </summary>
    public partial class ResourceCatalog
    {
        private DateTime? _creationTime;
        private string _description;
        private string _resourceCatalogArn;
        private string _resourceCatalogName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time the <c>ResourceCatalog</c> was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  A free form description of the <c>ResourceCatalog</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property ResourceCatalogArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the <c>ResourceCatalog</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ResourceCatalogArn
        {
            get { return this._resourceCatalogArn; }
            set { this._resourceCatalogArn = value; }
        }

        // Check to see if ResourceCatalogArn property is set
        internal bool IsSetResourceCatalogArn()
        {
            return this._resourceCatalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCatalogName. 
        /// <para>
        ///  The name of the <c>ResourceCatalog</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResourceCatalogName
        {
            get { return this._resourceCatalogName; }
            set { this._resourceCatalogName = value; }
        }

        // Check to see if ResourceCatalogName property is set
        internal bool IsSetResourceCatalogName()
        {
            return this._resourceCatalogName != null;
        }

    }
}