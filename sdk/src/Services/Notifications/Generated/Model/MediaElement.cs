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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Describes a media element.
    /// </summary>
    public partial class MediaElement
    {
        private string _caption;
        private string _mediaId;
        private MediaElementType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property Caption. 
        /// <para>
        /// The caption of the media.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Caption
        {
            get { return this._caption; }
            set { this._caption = value; }
        }

        // Check to see if Caption property is set
        internal bool IsSetCaption()
        {
            return this._caption != null;
        }

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The unique ID for the media.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MediaId
        {
            get { return this._mediaId; }
            set { this._mediaId = value; }
        }

        // Check to see if MediaId property is set
        internal bool IsSetMediaId()
        {
            return this._mediaId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of media.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaElementType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the media.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}