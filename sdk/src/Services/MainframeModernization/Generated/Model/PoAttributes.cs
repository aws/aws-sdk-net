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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// The supported properties for a PO type data set.
    /// </summary>
    public partial class PoAttributes
    {
        private string _encoding;
        private string _format;
        private List<string> _memberFileExtensions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The character set encoding of the data set.
        /// </para>
        /// </summary>
        public string Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the data set records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property MemberFileExtensions. 
        /// <para>
        /// An array containing one or more filename extensions, allowing you to specify which
        /// files to be included as PDS member.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> MemberFileExtensions
        {
            get { return this._memberFileExtensions; }
            set { this._memberFileExtensions = value; }
        }

        // Check to see if MemberFileExtensions property is set
        internal bool IsSetMemberFileExtensions()
        {
            return this._memberFileExtensions != null && (this._memberFileExtensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}