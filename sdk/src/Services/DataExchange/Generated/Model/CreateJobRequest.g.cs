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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation. This operation creates a
    /// job.
    /// </summary>
    public partial class CreateJobRequest : AmazonDataExchangeRequest
    {
        /// <summary>
        /// Gets and sets the property AssetConfiguration. 
        /// <para>
        /// The configuration for the asset, including tags to be applied to assets created by
        /// the job.
        /// </para>
        /// </summary>
        public AssetConfiguration AssetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AssetConfiguration property is set.
        /// </summary>
        internal bool IsSetAssetConfiguration() => this.AssetConfiguration != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details for the CreateJob request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RequestDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
