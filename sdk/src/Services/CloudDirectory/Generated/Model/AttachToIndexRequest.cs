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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the AttachToIndex operation.
    /// Attaches the specified object to the specified index.
    /// </summary>
    public partial class AttachToIndexRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private ObjectReference _indexReference;
        private ObjectReference _targetReference;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory where the object and index exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexReference. 
        /// <para>
        /// A reference to the index that you are attaching the object to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference IndexReference
        {
            get { return this._indexReference; }
            set { this._indexReference = value; }
        }

        // Check to see if IndexReference property is set
        internal bool IsSetIndexReference()
        {
            return this._indexReference != null;
        }

        /// <summary>
        /// Gets and sets the property TargetReference. 
        /// <para>
        /// A reference to the object that you are attaching to the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference TargetReference
        {
            get { return this._targetReference; }
            set { this._targetReference = value; }
        }

        // Check to see if TargetReference property is set
        internal bool IsSetTargetReference()
        {
            return this._targetReference != null;
        }

    }
}