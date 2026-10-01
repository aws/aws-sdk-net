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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The standard domain object type.
    /// </summary>
    public partial class DomainObjectTypeField
    {
        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the field.
        /// </para>
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The semantic meaning of the field.
        /// </para>
        /// </summary>
        public FeatureType FeatureType { get; set; }

        /// <summary>
        /// Checks to see if the FeatureType property is set.
        /// </summary>
        internal bool IsSetFeatureType() => this.FeatureType != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The expression that defines how to extract the field value from the source object.>
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The expression that defines where the field value should be placed in the standard
        /// domain object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
