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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The location of resources.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Gets and sets the property DynamoDB. 
        /// <para>
        /// An Amazon DynamoDB table location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CodeGenNodeArg> DynamoDB { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeGenNodeArg>() : null;

        /// <summary>
        /// Checks to see if the DynamoDB property is set.
        /// </summary>
        internal bool IsSetDynamoDB() => this.DynamoDB != null && (this.DynamoDB.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Jdbc. 
        /// <para>
        /// A JDBC location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CodeGenNodeArg> Jdbc { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeGenNodeArg>() : null;

        /// <summary>
        /// Checks to see if the Jdbc property is set.
        /// </summary>
        internal bool IsSetJdbc() => this.Jdbc != null && (this.Jdbc.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// An Amazon Simple Storage Service (Amazon S3) location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CodeGenNodeArg> S3 { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeGenNodeArg>() : null;

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null && (this.S3.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
