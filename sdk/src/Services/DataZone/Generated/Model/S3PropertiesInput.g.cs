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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon S3 properties of a connection.
    /// </summary>
    public partial class S3PropertiesInput
    {
        /// <summary>
        /// Gets and sets the property RegisterS3AccessGrantLocation. 
        /// <para>
        /// Specifies whether to register the Amazon S3 Access Grant location.
        /// </para>
        /// </summary>
        public bool? RegisterS3AccessGrantLocation { get; set; }

        /// <summary>
        /// Checks to see if the RegisterS3AccessGrantLocation property is set.
        /// </summary>
        internal bool IsSetRegisterS3AccessGrantLocation() => this.RegisterS3AccessGrantLocation.HasValue;

        /// <summary>
        /// Gets and sets the property S3AccessGrantLocationId. 
        /// <para>
        /// The Amazon S3 Access Grant location ID that's part of the Amazon S3 properties of
        /// a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string S3AccessGrantLocationId { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessGrantLocationId property is set.
        /// </summary>
        internal bool IsSetS3AccessGrantLocationId() => this.S3AccessGrantLocationId != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI that's part of the Amazon S3 properties of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
