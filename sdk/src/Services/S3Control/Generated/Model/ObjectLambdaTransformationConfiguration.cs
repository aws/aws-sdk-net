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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A configuration used when creating an Object Lambda Access Point transformation.
    /// </summary>
    public partial class ObjectLambdaTransformationConfiguration
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ObjectLambdaContentTransformation _contentTransformation;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A container for the action of an Object Lambda Access Point configuration. Valid inputs
        /// are <c>GetObject</c>, <c>ListObjects</c>, <c>HeadObject</c>, and <c>ListObjectsV2</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContentTransformation. 
        /// <para>
        /// A container for the content transformation of an Object Lambda Access Point configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectLambdaContentTransformation ContentTransformation
        {
            get { return this._contentTransformation; }
            set { this._contentTransformation = value; }
        }

        // Check to see if ContentTransformation property is set
        internal bool IsSetContentTransformation()
        {
            return this._contentTransformation != null;
        }

    }
}