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
    /// Contains summary information about a MicroVM image.
    /// </summary>
    public partial class MicrovmImageSummary
    {
        private DateTime? _createdAt;
        private string _imageArn;
        private string _latestActiveImageVersion;
        private string _latestFailedImageVersion;
        private string _name;
        private MicrovmImageState _state;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the MicroVM image was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property LatestActiveImageVersion. 
        /// <para>
        /// The latest active version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LatestActiveImageVersion
        {
            get { return this._latestActiveImageVersion; }
            set { this._latestActiveImageVersion = value; }
        }

        // Check to see if LatestActiveImageVersion property is set
        internal bool IsSetLatestActiveImageVersion()
        {
            return this._latestActiveImageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LatestFailedImageVersion. 
        /// <para>
        /// The latest failed version of the MicroVM image, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string LatestFailedImageVersion
        {
            get { return this._latestFailedImageVersion; }
            set { this._latestFailedImageVersion = value; }
        }

        // Check to see if LatestFailedImageVersion property is set
        internal bool IsSetLatestFailedImageVersion()
        {
            return this._latestFailedImageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MicrovmImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}