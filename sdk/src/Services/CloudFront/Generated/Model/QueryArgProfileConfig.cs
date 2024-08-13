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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Configuration for query argument-profile mapping for field-level encryption.
    /// </summary>
    public partial class QueryArgProfileConfig
    {
        private bool? _forwardWhenQueryArgProfileIsUnknown;
        private QueryArgProfiles _queryArgProfiles;

        /// <summary>
        /// Gets and sets the property ForwardWhenQueryArgProfileIsUnknown. 
        /// <para>
        /// Flag to set if you want a request to be forwarded to the origin even if the profile
        /// specified by the field-level encryption query argument, fle-profile, is unknown.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ForwardWhenQueryArgProfileIsUnknown
        {
            get { return this._forwardWhenQueryArgProfileIsUnknown; }
            set { this._forwardWhenQueryArgProfileIsUnknown = value; }
        }

        // Check to see if ForwardWhenQueryArgProfileIsUnknown property is set
        internal bool IsSetForwardWhenQueryArgProfileIsUnknown()
        {
            return this._forwardWhenQueryArgProfileIsUnknown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryArgProfiles. 
        /// <para>
        /// Profiles specified for query argument-profile mapping for field-level encryption.
        /// </para>
        /// </summary>
        public QueryArgProfiles QueryArgProfiles
        {
            get { return this._queryArgProfiles; }
            set { this._queryArgProfiles = value; }
        }

        // Check to see if QueryArgProfiles property is set
        internal bool IsSetQueryArgProfiles()
        {
            return this._queryArgProfiles != null;
        }

    }
}