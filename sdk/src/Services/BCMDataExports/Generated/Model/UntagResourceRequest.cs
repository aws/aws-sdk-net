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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Deletes tags associated with an existing data export definition.
    /// </summary>
    public partial class UntagResourceRequest : AmazonBCMDataExportsRequest
    {
        private string _resourceArn;
        private List<string> _resourceTagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The unique identifier for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTagKeys. 
        /// <para>
        /// The tag keys that are associated with the resource ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<string> ResourceTagKeys
        {
            get { return this._resourceTagKeys; }
            set { this._resourceTagKeys = value; }
        }

        // Check to see if ResourceTagKeys property is set
        internal bool IsSetResourceTagKeys()
        {
            return this._resourceTagKeys != null && (this._resourceTagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}