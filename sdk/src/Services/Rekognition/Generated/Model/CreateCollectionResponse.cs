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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the CreateCollection operation.
    /// </summary>
    public partial class CreateCollectionResponse : AmazonWebServiceResponse
    {
        private string _collectionArn;
        private string _faceModelVersion;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property CollectionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the collection. You can use this to manage permissions
        /// on your resources. 
        /// </para>
        /// </summary>
        public string CollectionArn
        {
            get { return this._collectionArn; }
            set { this._collectionArn = value; }
        }

        // Check to see if CollectionArn property is set
        internal bool IsSetCollectionArn()
        {
            return this._collectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the collection you are
        /// creating.
        /// </para>
        /// </summary>
        public string FaceModelVersion
        {
            get { return this._faceModelVersion; }
            set { this._faceModelVersion = value; }
        }

        // Check to see if FaceModelVersion property is set
        internal bool IsSetFaceModelVersion()
        {
            return this._faceModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// HTTP status code indicating the result of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}