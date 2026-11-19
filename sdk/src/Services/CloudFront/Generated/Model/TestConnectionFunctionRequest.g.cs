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
    /// Container for the parameters to the TestConnectionFunction operation. Tests a connection
    /// function.
    /// </summary>
    public partial class TestConnectionFunctionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionObject. 
        /// <para>
        /// The connection object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 40960)]
        public MemoryStream ConnectionObject { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionObject property is set.
        /// </summary>
        internal bool IsSetConnectionObject() => this.ConnectionObject != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The connection function ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the connection function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The connection function stage.
        /// </para>
        /// </summary>
        public FunctionStage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
