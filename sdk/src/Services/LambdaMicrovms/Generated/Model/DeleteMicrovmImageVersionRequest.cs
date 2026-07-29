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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMicrovmImageVersion operation.
    /// Deletes a specific version of a MicroVM image. This operation is idempotent; deleting
    /// a version that has already been deleted succeeds without error.
    /// </summary>
    public partial class DeleteMicrovmImageVersionRequest : AmazonLambdaMicrovmsRequest
    {
        private string _imageIdentifier;
        private string _imageVersion;

        /// <summary>
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The unique identifier (ARN or ID) of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ImageIdentifier
        {
            get { return this._imageIdentifier; }
            set { this._imageIdentifier = value; }
        }

        // Check to see if ImageIdentifier property is set
        internal bool IsSetImageIdentifier()
        {
            return this._imageIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

    }
}