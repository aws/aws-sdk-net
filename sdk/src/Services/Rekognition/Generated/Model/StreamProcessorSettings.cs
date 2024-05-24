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
    /// Input parameters used in a streaming video analyzed by a Amazon Rekognition stream
    /// processor. You can use <c>FaceSearch</c> to recognize faces in a streaming video,
    /// or you can use <c>ConnectedHome</c> to detect labels.
    /// </summary>
    public partial class StreamProcessorSettings
    {
        private ConnectedHomeSettings _connectedHome;
        private FaceSearchSettings _faceSearch;

        /// <summary>
        /// Gets and sets the property ConnectedHome.
        /// </summary>
        public ConnectedHomeSettings ConnectedHome
        {
            get { return this._connectedHome; }
            set { this._connectedHome = value; }
        }

        // Check to see if ConnectedHome property is set
        internal bool IsSetConnectedHome()
        {
            return this._connectedHome != null;
        }

        /// <summary>
        /// Gets and sets the property FaceSearch. 
        /// <para>
        /// Face search settings to use on a streaming video. 
        /// </para>
        /// </summary>
        public FaceSearchSettings FaceSearch
        {
            get { return this._faceSearch; }
            set { this._faceSearch = value; }
        }

        // Check to see if FaceSearch property is set
        internal bool IsSetFaceSearch()
        {
            return this._faceSearch != null;
        }

    }
}