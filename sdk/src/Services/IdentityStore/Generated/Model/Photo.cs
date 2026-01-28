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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
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
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Contains information about a user's photo. Users can have up to 3 photos, with one
    /// designated as primary. Supports common image formats, including jpg, jpeg, png, and
    /// gif.
    /// </summary>
    public partial class Photo
    {
        private string _display;
        private bool? _primary;
        private string _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        /// A human-readable description of the photo for display purposes. This optional field
        /// provides context about the photo.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Display
        {
            get { return this._display; }
            set { this._display = value; }
        }

        // Check to see if Display property is set
        internal bool IsSetDisplay()
        {
            return this._display != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// Specifies whether this is the user's primary photo. Default value is <c>false</c>.
        /// Only one photo can be designated as primary per user.
        /// </para>
        /// </summary>
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of photo. This field is optional and can be used to categorize different
        /// types of photos.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The photo data or URL. Supported formats include jpg, jpeg, png, and gif. This field
        /// is required for all photo entries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}