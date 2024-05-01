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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Definition
    {
        private Checksum _checksum;
        private string _modelHandle;
        private string _s3Url;
        private ModelState _state;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum information of the model.
        /// </para>
        /// </summary>
        public Checksum Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ModelHandle. 
        /// <para>
        /// The unique model handle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelHandle
        {
            get { return this._modelHandle; }
            set { this._modelHandle = value; }
        }

        // Check to see if ModelHandle property is set
        internal bool IsSetModelHandle()
        {
            return this._modelHandle != null;
        }

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The absolute S3 location of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The desired state of the model.
        /// </para>
        /// </summary>
        public ModelState State
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