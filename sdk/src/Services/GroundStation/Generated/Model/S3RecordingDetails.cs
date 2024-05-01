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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Details about an S3 recording <c>Config</c> used in a contact.
    /// </summary>
    public partial class S3RecordingDetails
    {
        private string _bucketArn;
        private string _keyTemplate;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// ARN of the bucket used.
        /// </para>
        /// </summary>
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyTemplate. 
        /// <para>
        /// Key template used for the S3 Recording Configuration
        /// </para>
        /// </summary>
        public string KeyTemplate
        {
            get { return this._keyTemplate; }
            set { this._keyTemplate = value; }
        }

        // Check to see if KeyTemplate property is set
        internal bool IsSetKeyTemplate()
        {
            return this._keyTemplate != null;
        }

    }
}