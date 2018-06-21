/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie.Model
{
    /// <summary>
    /// The S3 resources whose classification types you want to update. This data type is
    /// used as a request parameter in the UpdateS3Resources action.
    /// </summary>
    public partial class S3ResourceClassificationUpdate
    {
        private string _bucketName;
        private ClassificationTypeUpdate _classificationTypeUpdate;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket whose classification types you want to update.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ClassificationTypeUpdate. 
        /// <para>
        /// The classification type that you want to update for the resource associated with Amazon
        /// Macie. 
        /// </para>
        /// </summary>
        public ClassificationTypeUpdate ClassificationTypeUpdate
        {
            get { return this._classificationTypeUpdate; }
            set { this._classificationTypeUpdate = value; }
        }

        // Check to see if ClassificationTypeUpdate property is set
        internal bool IsSetClassificationTypeUpdate()
        {
            return this._classificationTypeUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the S3 bucket whose classification types you want to update.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}