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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Data sources that are available to your model in addition to the one that you specify
    /// for <c>ModelDataSource</c> when you use the <c>CreateModel</c> action.
    /// </summary>
    public partial class AdditionalModelDataSource
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// A custom name for this <c>AdditionalModelDataSource</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property S3DataSource.
        /// </summary>
        [AWSProperty(Required = true)]
        public S3ModelDataSource S3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the S3DataSource property is set.
        /// </summary>
        internal bool IsSetS3DataSource() => this.S3DataSource != null;
    }
}
