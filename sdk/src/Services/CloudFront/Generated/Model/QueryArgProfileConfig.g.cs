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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ForwardWhenQueryArgProfileIsUnknown. 
        /// <para>
        /// Flag to set if you want a request to be forwarded to the origin even if the profile
        /// specified by the field-level encryption query argument, fle-profile, is unknown.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

        /// <summary>
        /// Checks to see if the ForwardWhenQueryArgProfileIsUnknown property is set.
        /// </summary>
        internal bool IsSetForwardWhenQueryArgProfileIsUnknown() => this.ForwardWhenQueryArgProfileIsUnknown.HasValue;

        /// <summary>
        /// Gets and sets the property QueryArgProfiles. 
        /// <para>
        /// Profiles specified for query argument-profile mapping for field-level encryption.
        /// </para>
        /// </summary>
        public QueryArgProfiles QueryArgProfiles { get; set; }

        /// <summary>
        /// Checks to see if the QueryArgProfiles property is set.
        /// </summary>
        internal bool IsSetQueryArgProfiles() => this.QueryArgProfiles != null;
    }
}
