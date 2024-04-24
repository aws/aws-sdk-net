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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
        private string _bucketPrefix;
        private ErrorHandlingConfig _errorHandlingConfig;
        private string _intermediateBucketName;
        private string _object;

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The object key for the bucket in which Amazon AppFlow places the destination files.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

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
        public ErrorHandlingConfig ErrorHandlingConfig
        {
            get { return this._errorHandlingConfig; }
            set { this._errorHandlingConfig = value; }
        }

        // Check to see if ErrorHandlingConfig property is set
        internal bool IsSetErrorHandlingConfig()
        {
            return this._errorHandlingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IntermediateBucketName. 
        /// <para>
        ///  The intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string IntermediateBucketName
        {
            get { return this._intermediateBucketName; }
            set { this._intermediateBucketName = value; }
        }

        // Check to see if IntermediateBucketName property is set
        internal bool IsSetIntermediateBucketName()
        {
            return this._intermediateBucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Amazon Redshift flow destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

    }
}