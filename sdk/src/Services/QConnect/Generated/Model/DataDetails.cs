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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about the data.
    /// </summary>
    public partial class DataDetails
    {
        private ContentDataDetails _contentData;
        private GenerativeChunkDataDetails _generativeChunkData;
        private GenerativeDataDetails _generativeData;
        private IntentDetectedDataDetails _intentDetectedData;
        private SourceContentDataDetails _sourceContentData;

        /// <summary>
        /// Gets and sets the property ContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public ContentDataDetails ContentData
        {
            get { return this._contentData; }
            set { this._contentData = value; }
        }

        // Check to see if ContentData property is set
        internal bool IsSetContentData()
        {
            return this._contentData != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeChunkData. 
        /// <para>
        /// Details about the generative chunk data.
        /// </para>
        /// </summary>
        public GenerativeChunkDataDetails GenerativeChunkData
        {
            get { return this._generativeChunkData; }
            set { this._generativeChunkData = value; }
        }

        // Check to see if GenerativeChunkData property is set
        internal bool IsSetGenerativeChunkData()
        {
            return this._generativeChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeData. 
        /// <para>
        ///  Details about the generative data.
        /// </para>
        /// </summary>
        public GenerativeDataDetails GenerativeData
        {
            get { return this._generativeData; }
            set { this._generativeData = value; }
        }

        // Check to see if GenerativeData property is set
        internal bool IsSetGenerativeData()
        {
            return this._generativeData != null;
        }

        /// <summary>
        /// Gets and sets the property IntentDetectedData. 
        /// <para>
        /// Details about the intent data.
        /// </para>
        /// </summary>
        public IntentDetectedDataDetails IntentDetectedData
        {
            get { return this._intentDetectedData; }
            set { this._intentDetectedData = value; }
        }

        // Check to see if IntentDetectedData property is set
        internal bool IsSetIntentDetectedData()
        {
            return this._intentDetectedData != null;
        }

        /// <summary>
        /// Gets and sets the property SourceContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public SourceContentDataDetails SourceContentData
        {
            get { return this._sourceContentData; }
            set { this._sourceContentData = value; }
        }

        // Check to see if SourceContentData property is set
        internal bool IsSetSourceContentData()
        {
            return this._sourceContentData != null;
        }

    }
}