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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when Amazon Redshift is being used as a destination.
    /// </summary>
    public partial class RedshiftDestinationProperties
    {
        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The object key for the bucket in which Amazon AppFlow places the destination files.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the BucketPrefix property is set.
        /// </summary>
        internal bool IsSetBucketPrefix() => this.BucketPrefix != null;

        /// <summary>
        /// Gets and sets the property ErrorHandlingConfig. 
        /// <para>
        ///  The settings that determine how Amazon AppFlow handles an error when placing data
        /// in the Amazon Redshift destination. For example, this setting would determine if the
        /// flow should fail after one insertion error, or continue and attempt to insert every
        /// record regardless of the initial failure. <c>ErrorHandlingConfig</c> is a part of
        /// the destination connector details. 
        /// </para>
        /// </summary>
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ErrorHandlingConfig property is set.
        /// </summary>
        internal bool IsSetErrorHandlingConfig() => this.ErrorHandlingConfig != null;

        /// <summary>
        /// Gets and sets the property IntermediateBucketName. 
        /// <para>
        ///  The intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string IntermediateBucketName { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateBucketName property is set.
        /// </summary>
        internal bool IsSetIntermediateBucketName() => this.IntermediateBucketName != null;

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Amazon Redshift flow destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string Object { get; set; }

        /// <summary>
        /// Checks to see if the Object property is set.
        /// </summary>
        internal bool IsSetObject() => this.Object != null;
    }
}
