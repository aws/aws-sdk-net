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
    /// The S3 resources that you want to associate with Amazon Macie for monitoring and data
    /// classification. This data type is used as a request parameter in the AssociateS3Resources
    /// action and a response parameter in the ListS3Resources action.
    /// </summary>
    public partial class S3ResourceClassification
    {
        private string _bucketName;
        private ClassificationType _classificationType;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket that you want to associate with Amazon Macie.
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
        /// Gets and sets the property ClassificationType. 
        /// <para>
        /// The classification type that you want to specify for the resource associated with
        /// Amazon Macie. 
        /// </para>
        /// </summary>
        public ClassificationType ClassificationType
        {
            get { return this._classificationType; }
            set { this._classificationType = value; }
        }

        // Check to see if ClassificationType property is set
        internal bool IsSetClassificationType()
        {
            return this._classificationType != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the S3 bucket that you want to associate with Amazon Macie.
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